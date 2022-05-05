using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using sistema.Models;
using Database.Shared.IRepository;
using Database.Shared.Models;
using Microsoft.AspNetCore.Http;
using sistema.Json;
using Wkhtmltopdf.NetCore;
using ClosedXML.Excel;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Rotativa.AspNetCore;


namespace sistema.Controllers
{
    public class VentaController : Controller
    {

        private readonly IVenta _ventaRepository = null;
        private readonly ICliente _clienteRepository = null;
        private readonly IPacientes _pacienteRepository = null;
        private readonly IProducto _productoRepository = null;
        private readonly IRuta _rutaRepository = null;
        private readonly IEnvio _envioRepository = null;
        private readonly ICaja _cajaRepository = null;
        private readonly ICajaClinica _cajaClinicaRepository = null;
        private readonly IEmpleado _empleadoRepository = null;
        private readonly IUser _userRepository = null;
        private readonly IGeneratePdf _generatePdf;
        private readonly UserManager<User> _userManager = null;



        public VentaController(IVenta ventaRepository, ICliente clienteRepository, IProducto productoRepository, IRuta rutaRepository,
        IEnvio envioRepository, ICaja cajaRepository, IEmpleado empleadoRepository, IGeneratePdf generatePdf, IUser userRepository, 
        ICajaClinica cajaClinicaRepository,  UserManager<User> userManager, IPacientes pacienteRepository)
        {
            _ventaRepository = ventaRepository;
            _clienteRepository = clienteRepository;
            _productoRepository = productoRepository;
            _rutaRepository = rutaRepository;
            _envioRepository = envioRepository;
            _cajaRepository = cajaRepository;
            _generatePdf = generatePdf;
            _empleadoRepository = empleadoRepository;
            _userRepository = userRepository;
            _cajaClinicaRepository = cajaClinicaRepository;
            _userManager = userManager;
            _pacienteRepository = pacienteRepository;
        }

        public async Task<IActionResult> prueba()
        {
            return await _generatePdf.GetPdf("Views/Venta/prueba.cshtml", "Hello World");
        }


        [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
        public IActionResult ListaVentasFarmacia(string sortOrder, string buscar, string currentFilter, int? pageNumber)
        {
            if (buscar != null)
            {
                pageNumber = 1;
            }
            else
            {
                buscar = currentFilter;
            }

            ViewData["CurrentFilter"] = buscar;

            var lista = _ventaRepository.PaginacionVentasFarmacia(sortOrder, buscar, pageNumber, 25);

            return View(lista);
        }



        [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
        public IActionResult ListaVentasClinica(string sortOrder, string buscar, string currentFilter, int? pageNumber)
        {

            if (buscar != null)
            {
                pageNumber = 1;
            }
            else
            {
                buscar = currentFilter;
            }

            ViewData["CurrentFilter"] = buscar;

            var lista = _ventaRepository.PaginacionVentasClinica(sortOrder, buscar, pageNumber, 25);

            return View(lista);
        }

        [Authorize(Roles = "Administrador")]
        // vista para reportar la utilidad por fechas
        public IActionResult ReporteFechas()
        {
            var modelo = new VentaBaseViewModel(0);
            return View(modelo);
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        // vista para reportar las ventas por fechas, pdf y excel
        public IActionResult ReporteVentasFechas()
        {
            var modelo = new VentaBaseViewModel(0);
            modelo.Init(_empleadoRepository);
            return View(modelo);

        }

        [Authorize(Roles = "Administrador, Vendedor, Supervisor")]
        public IActionResult Nuevo()
        {
            var user = _userManager.GetUserAsync(HttpContext.User);
            var empleadoId = user.Result.EmpleadoId == null ? (int)0 : (int)user.Result.EmpleadoId;
            var modelo = new VentaBaseViewModel(empleadoId);

            modelo.Init(_clienteRepository);
            modelo.Init(_rutaRepository);
            modelo.Init(_productoRepository);
            var listausers = _ventaRepository.GetUsersRole("Mensajero");
            modelo.ListaUsuarios = listausers;
            modelo.Init(_envioRepository);

            return View(modelo);
        }

        [Authorize(Roles = "Administrador, Vendedor, Supervisor")]
        public IActionResult NuevaVentaClinica()
        {
            var user = _userManager.GetUserAsync(HttpContext.User);
            var empleadoId = user.Result.EmpleadoId == null ? (int)0 : (int)user.Result.EmpleadoId;
            var modelo = new VentaClinicaBaseViewModel(empleadoId);

            modelo.Init(_productoRepository, _ventaRepository, _clienteRepository, _envioRepository);
            var listausers = _ventaRepository.GetUsersRole("Mensajero");
            modelo.ListaUsuarios = listausers;

            return View(modelo);
        }

        [Authorize(Roles = "Administrador, Vendedor, Supervisor")]
        public JsonResult BusquedaProductos(string codigo)
        {
            var len = codigo.Length;

            if(codigo.Length < 3)
            {
                return new JsonErrorResult(new { message = "Solo se acepta un mínimo 3 letras en delante." });
            }
            var buscado = _productoRepository.BuscarPorNombreYReferenciaBusquedaAjax(codigo);
            return Json(buscado);
        }

        [Authorize(Roles = "Administrador, Vendedor, Supervisor")]
        public JsonResult BusquedaProductosClinica(string codigo)
        {
            if(ModelState.IsValid)
            {
                var len = codigo.Length;

                if(len < 3)
                {
                    return new JsonErrorResult(new { message = "Solo se acepta un mínimo 3 letras en delante." });
                }

                var buscado = _productoRepository.BuscarPorNombreYReferenciaBusquedaAjaxClinica(codigo);
                return Json(buscado);
            }
            
            return new JsonErrorResult(new { message = "Ha ocurrido un error de servidor." });

        }

        [Authorize(Roles = "Administrador, Vendedor, Supervisor")]
        public JsonResult GuardarEnvio([FromBody] ViewModelVenta2 det)
        {

            if (ModelState.IsValid)
            {
                if (det.datosenvio.EmpleadoId == "")
                {

                    TempData["Message"] = "¡Codigo de empleado incorrecto.!";
                    return Json("");
                }

                var empleado = _empleadoRepository.Get(Convert.ToInt32(det.datosenvio.EmpleadoId));

                if (empleado == null)
                {

                    TempData["Message"] = "¡Codigo de empleado incorrecto.!";
                    return Json("");
                }

                // string[] fecha = det.datosenvio.Fecha.Split('-');

                // var piloto = _ventaRepository.GetEmpleadoUser(det.datosenvio.UserId);
                var user = _userRepository.GetbyId(det.datosenvio.UserId);

                var nuevoEnvio = new Envio()
                {
                    // NombrePiloto = piloto.Nombre,
                    RutaId = Convert.ToInt32(det.datosenvio.Ruta),
                    FechaEntrega = Convert.ToDateTime(det.datosenvio.Fecha),
                    DireccionExacta = det.datosenvio.DireccionExacta,
                    Nombres = det.datosenvio.Nombre,
                    NoComprobante = det.datosenvio.NoComprobante,
                    Nit = det.datosenvio.Nit,
                    EmpleadoId = Convert.ToInt32(det.datosenvio.EmpleadoId),
                    User = user,
                    FechaEnvio = DateTime.Now,
                    EstadosEnvioId = 1,

                };


                foreach (var item in det.detalle)
                {

                    var detalle = new DetalleEnvio()
                    {
                        Envio = nuevoEnvio,
                        Cantidad = Convert.ToInt32(item.Cantidad),
                        Precio = Convert.ToDecimal(item.Precio),
                        Descuento = Convert.ToDecimal(item.Descuento),
                        Subtotal = Convert.ToDecimal(item.Subtotal),
                        Total = Convert.ToDecimal(item.Total),
                        ProductoId = Convert.ToInt32(item.ProductoId),

                    };

                    _envioRepository.Add(detalle, false);


                }

                _envioRepository.saveChanges();

                TempData["Message"] = "¡El pedido se ha guardado con exito.!";

                return Json("Ok");



            }

            return Json("Hubo un error interno.");
        }


        [Authorize(Roles = "Administrador, Vendedor, Supervisor")]
        public JsonResult GuardarVentaFarmacia([FromBody]VentaClinicaAddViewModel model)
        {
            // registrar un identificador si es de farm o de clinica

            if (ModelState.IsValid)
            {
                // cargar lista de todas las cajas
                var cajita = _cajaRepository.ListarCajas();

                // verificar si hay cajas abiertas, una por una, si te acordas del Any()
                // otra manera seria hacerlo con una bandera, pero el any te hace el trabajo.
                if (!cajita.Any(a => a.EstadoCaja == true))
                {
                    return new JsonErrorResult(new { message = "¡Error. No hay cajas abiertas. Por favor debe abrir una caja.!" });
                }

                var cliente = _clienteRepository.GetClientePorNombre(model.encabezado.Nombres);
                var cajaAbierta = _cajaRepository.GetCajaAbierta();
                var empleado = _empleadoRepository.Get(model.encabezado.EmpleadoId);

                if (empleado == null)
                {
                    return new JsonErrorResult(new { message = "¡Codigo de empleado incorrecto.!" });
                }

                if (cliente == null)
                {

                    var nuevoCliente = new Clientes()
                    {
                        Nombre = model.encabezado.Nombres,
                        Direccion = model.encabezado.Direccion,
                        Nit = model.encabezado.Nit

                    };

                    var nuevaVenta = new Venta()
                    {
                        NoComprobante = model.encabezado.NoComprobante,
                        Nombres = nuevoCliente.Nombre,
                        Nit = nuevoCliente.Nit,
                        Direccion = nuevoCliente.Direccion,
                        Clientes = nuevoCliente,
                        // FormaPago = det.encabezado.FormaPago,
                        FechaVenta = DateTime.Now,
                        EmpleadoId = model.encabezado.EmpleadoId,
                        TipoVenta = "farmacia",
                        MontoPago = model.encabezado.Monto,
                        Vuelto = model.encabezado.Vuelto

                    };

                    var pago = new Pagos()
                    {
                        Venta = nuevaVenta,
                        FormaPagoId = Convert.ToInt32(model.encabezado.FormaPago),
                        Monto = Convert.ToDecimal(model.encabezado.Monto),
                    };

                    _envioRepository.AddPago(pago, false);

                    var nuevoDetalleCaja = new DetalleCaja()
                    {
                        Venta = nuevaVenta,
                        Descripcion = "Venta a cliente: " + nuevoCliente.Nombre,
                        Ingreso = model.encabezado.Monto,
                        Caja = cajaAbierta
                    };

                    _cajaRepository.Add(nuevoDetalleCaja, false);


                    foreach (var item in model.detalle)
                    {

                        var nuevodetalle = new DetalleVenta()
                        {
                            Venta = nuevaVenta,
                            Cantidad = item.Cantidad,
                            Precio = item.Precio,
                            Descuento = item.Descuento,
                            Subtotal = item.Subtotal,
                            Total = item.Total,
                            ProductoId = item.ProductoId,
                        };

                        _ventaRepository.Add(nuevodetalle, false);

                        //restar al inventario
                        var producto = _productoRepository.Get((int)nuevodetalle.ProductoId);
                        producto.Stock -= nuevodetalle.Cantidad;
                        _productoRepository.Update(producto, false);
                    }

                    _ventaRepository.saveChanges();

                    TempData["Message"] = "¡La venta se ha guardado con éxito.!";
                    return Json(nuevaVenta.Id);

                }
                else
                {
                    var nuevaVenta = new Venta()
                    {
                        NoComprobante = model.encabezado.NoComprobante,
                        Nombres = model.encabezado.Nombres,
                        Nit = model.encabezado.Nit,
                        Direccion = model.encabezado.Direccion,
                        Clientes = cliente,
                        // FormaPago = det.encabezado.FormaPago,
                        FechaVenta = DateTime.Now,
                        EmpleadoId = model.encabezado.EmpleadoId,
                        TipoVenta = "farmacia",
                        MontoPago = model.encabezado.Monto,
                        Vuelto = model.encabezado.Vuelto
                    };

                    var pago = new Pagos()
                        {
                            Venta = nuevaVenta,
                            FormaPagoId = Convert.ToInt32(model.encabezado.FormaPago),
                            Monto = Convert.ToDecimal(model.encabezado.Monto),
                        };

                    _envioRepository.AddPago(pago, false);

                    var nuevoDetalleCaja = new DetalleCaja()
                    {
                        Venta = nuevaVenta,
                        Descripcion = "Venta a cliente: " + cliente.Nombre,
                        Ingreso = model.encabezado.Monto,
                        Caja = cajaAbierta
                    };
                    
                    _cajaRepository.Add(nuevoDetalleCaja, false);

                    foreach (var item in model.detalle)
                    {

                        var nuevodetalle = new DetalleVenta()
                        {
                            Venta = nuevaVenta,
                            Cantidad = item.Cantidad,
                            Precio = item.Precio,
                            Descuento = item.Descuento,
                            Subtotal = item.Subtotal,
                            Total = item.Total,
                            ProductoId = item.ProductoId,

                        };

                        _ventaRepository.Add(nuevodetalle, false);

                        //restar a inventario
                        var producto = _productoRepository.Get((Int16)nuevodetalle.ProductoId);

                        producto.Stock -= nuevodetalle.Cantidad;
                        _productoRepository.Update(producto, false);


                    }

                    _ventaRepository.saveChanges();

                    TempData["Message"] = "¡La venta se ha guardado con éxito.!";

                    return Json(nuevaVenta.Id);

                }
            }

            return Json("Hubo un error interno.");        
        }

        
        [Authorize(Roles = "Administrador, Vendedor, Supervisor")]
        public JsonResult GuardarVentaClinica([FromBody]VentaClinicaAddViewModel model)
        {
            // registrar un identificador si es de farm o de clinica

            if (ModelState.IsValid)
            {
                // cargar lista de todas las cajas
                var cajita = _cajaClinicaRepository.ListarCajas();

                // verificar si hay cajas abiertas, una por una, si te acordas del Any()
                // otra manera seria hacerlo con una bandera, pero el any te hace el trabajo.
                if (!cajita.Any(a => a.EstadoCaja == true))
                {
                    return new JsonErrorResult(new { message = "¡Error. No hay cajas abiertas. Por favor debe abrir una caja.!" });
                }

                var paciente = _pacienteRepository.GetPacientePorNombre(model.encabezado.Nombres);
                var cajaAbierta = _cajaClinicaRepository.GetCajaAbierta();
                var empleado = _empleadoRepository.Get(model.encabezado.EmpleadoId);

                if (empleado == null)
                {
                    return new JsonErrorResult(new { message = "¡Codigo de empleado incorrecto.!" });
                }

                if (paciente == null)
                {

                    var nuevoPaciente = new Paciente()
                    {
                        Nombre = model.encabezado.Nombres,
                        Direccion = model.encabezado.Direccion,
                        Nit = model.encabezado.Nit
                    };

                    var nuevaVenta = new Venta()
                    {
                        NoComprobante = model.encabezado.NoComprobante,
                        Nombres = nuevoPaciente.Nombre,
                        Nit = nuevoPaciente.Nit,
                        Direccion = nuevoPaciente.Direccion,
                        Paciente = nuevoPaciente,
                        // FormaPago = det.encabezado.FormaPago,
                        FechaVenta = DateTime.Now,
                        EmpleadoId = model.encabezado.EmpleadoId,
                        TipoVenta = "clinica",
                        MontoPago = model.encabezado.Monto,
                        Vuelto = model.encabezado.Vuelto

                    };

                    var pago = new Pagos()
                    {
                        Venta = nuevaVenta,
                        FormaPagoId = Convert.ToInt32(model.encabezado.FormaPago),
                        Monto = Convert.ToDecimal(model.encabezado.Monto),
                    };

                    _envioRepository.AddPago(pago, false);

                    var nuevoDetalleCaja = new DetalleCajaClinica()
                    {
                        Venta = nuevaVenta,
                        Descripcion = "Venta a cliente: " + nuevoPaciente.Nombre,
                        Ingreso = model.encabezado.Monto,
                        CajaClinica = cajaAbierta
                    };

                    _cajaClinicaRepository.Add(nuevoDetalleCaja, false);


                    foreach (var item in model.detalle)
                    {
                        // diferenciar entre Servicios y productos
                        if(item.BienOServicio == "B")
                        {

                            var nuevodetalle = new DetalleVenta()
                            {
                                Venta = nuevaVenta,
                                Cantidad = item.Cantidad,
                                Precio = item.Precio,
                                Descuento = item.Descuento,
                                Subtotal = item.Subtotal,
                                Total = item.Total,
                                ProductoId = item.ProductoId,
                                BienOServicio = "B"
                            };

                            _ventaRepository.Add(nuevodetalle, false);

                            //restar al inventario
                            var producto = _productoRepository.Get((int)nuevodetalle.ProductoId);
                            producto.Stock -= nuevodetalle.Cantidad;
                            _productoRepository.Update(producto, false);
                        }
                        else if(item.BienOServicio == "S")
                        {
                            var nuevodetalle = new DetalleVenta()
                            {
                                Venta = nuevaVenta,
                                Cantidad = item.Cantidad,
                                Precio = item.Precio,
                                Descuento = item.Descuento,
                                Subtotal = item.Subtotal,
                                Total = item.Total,
                                ServicioId = item.ProductoId,
                                BienOServicio = "S"
                            };

                            _ventaRepository.Add(nuevodetalle, false);
                        }

                        
                    }

                    _ventaRepository.saveChanges();

                    TempData["Message"] = "¡La venta se ha guardado con éxito.!";
                    return Json(nuevaVenta.Id);

                }
                else
                {
                    var nuevaVenta = new Venta()
                    {
                        NoComprobante = model.encabezado.NoComprobante,
                        Nombres = model.encabezado.Nombres,
                        Nit = model.encabezado.Nit,
                        Direccion = model.encabezado.Direccion,
                        Paciente = paciente,
                        // FormaPago = det.encabezado.FormaPago,
                        FechaVenta = DateTime.Now,
                        EmpleadoId = model.encabezado.EmpleadoId,
                        TipoVenta = "clinica",
                        MontoPago = model.encabezado.Monto,
                        Vuelto = model.encabezado.Vuelto
                    };

                    var pago = new Pagos()
                        {
                            Venta = nuevaVenta,
                            FormaPagoId = Convert.ToInt32(model.encabezado.FormaPago),
                            Monto = Convert.ToDecimal(model.encabezado.Monto),
                        };

                    _envioRepository.AddPago(pago, false);

                    var nuevoDetalleCaja = new DetalleCajaClinica()
                    {
                        Venta = nuevaVenta,
                        Descripcion = "Venta a cliente: " + paciente.Nombre,
                        Ingreso = model.encabezado.Monto,
                        CajaClinica = cajaAbierta
                    };
                    
                    _cajaClinicaRepository.Add(nuevoDetalleCaja, false);

                    foreach (var item in model.detalle)
                    {
                        // diferenciar entre Servicios y productos
                        if(item.BienOServicio == "B")
                        {

                            var nuevodetalle = new DetalleVenta()
                            {
                                Venta = nuevaVenta,
                                Cantidad = item.Cantidad,
                                Precio = item.Precio,
                                Descuento = item.Descuento,
                                Subtotal = item.Subtotal,
                                Total = item.Total,
                                ProductoId = item.ProductoId,
                                BienOServicio = "B"
                            };

                            _ventaRepository.Add(nuevodetalle, false);

                            //restar al inventario
                            var producto = _productoRepository.Get((int)nuevodetalle.ProductoId);
                            producto.Stock -= nuevodetalle.Cantidad;
                            _productoRepository.Update(producto, false);
                        }
                        else if(item.BienOServicio == "S")
                        {
                            var nuevodetalle = new DetalleVenta()
                            {
                                Venta = nuevaVenta,
                                Cantidad = item.Cantidad,
                                Precio = item.Precio,
                                Descuento = item.Descuento,
                                Subtotal = item.Subtotal,
                                Total = item.Total,
                                ServicioId = item.ProductoId,
                                BienOServicio = "S"
                            };

                            _ventaRepository.Add(nuevodetalle, false);
                        }
                    }

                    _ventaRepository.saveChanges();

                    TempData["Message"] = "¡La venta se ha guardado con éxito.!";

                    return Json(nuevaVenta.Id);

                }
            }

            return Json("Hubo un error interno.");
        }






         [Authorize(Roles = "Administrador, Vendedor, Supervisor")]
        
        public IActionResult Modificar(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var Venta = _ventaRepository.Get((int)id);

            if (Venta == null)
            {
                return StatusCode(404);
            }

            var model = new VentaBaseViewModel(0)
            {
                Venta = Venta,
            };

            model.Init(_clienteRepository);

            return View(model);
        }

         [Authorize(Roles = "Administrador, Vendedor, Supervisor")]

        public JsonResult ModificarVenta([FromBody] ViewModelVenta2 det)
        {
            var listadoEnBd = _ventaRepository.GetDetalle(det.encabezado.Id);

            if (ModelState.IsValid)
            {
                foreach (var item in listadoEnBd)
                {
                    bool flag = false;

                    foreach (var ins in det.nuevos)
                    {
                        if (item.Id == Convert.ToInt32(ins.Ids))
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (!flag)
                    {
                        _ventaRepository.Delete(item.Id, false);
                    }



                }

                var venta = new Venta()
                {
                    Id = det.encabezado.Id,
                    NoComprobante = det.encabezado.NoComprobante,
                    PacienteId = Convert.ToInt32(det.encabezado.ClienteId),
                    Nit = det.encabezado.Nit,
                    Nombres = det.encabezado.Nombre,
                    Direccion = det.encabezado.Direccion,
                    EmpleadoId = det.encabezado.EmpleadoId,

                };

                _ventaRepository.Update(venta);


                foreach (var item in det.detalle)
                {

                    var nuevodetalle = new DetalleVenta()

                    {
                        VentaId = Convert.ToInt32(det.encabezado.Id),
                        ProductoId = Convert.ToInt32(item.ProductoId),
                        Cantidad = Convert.ToInt32(item.Cantidad),
                        Precio = Convert.ToDecimal(item.Precio),
                        Descuento = Convert.ToDecimal(item.Descuento),
                        Subtotal = Convert.ToDecimal(item.Subtotal),
                        Total = Convert.ToDecimal(item.Total),
                    };

                    _ventaRepository.Add(nuevodetalle, false);

                }

                _ventaRepository.saveChanges();

                return Json("OK");

            }


            return new JsonErrorResult(new { message = "Ha ocurrido un error de servidor." });
        }

         [Authorize(Roles = "Administrador, Vendedor, Supervisor")]

        public IActionResult ExportarVentas()
        {
            var ventas = _ventaRepository.GetListado().OrderByDescending(a => a.FechaVenta);

            using (var workboook = new XLWorkbook())
            {
                var worksheet = workboook.Worksheets.Add("Ventas");
                var row = 1;
                worksheet.Cell(row, 1).Value = "Venta #";
                worksheet.Cell(row, 2).Value = "Cliente";
                worksheet.Cell(row, 3).Value = "NoComprobante";
                worksheet.Cell(row, 4).Value = "Nit";
                worksheet.Cell(row, 5).Value = "Nombres";
                worksheet.Cell(row, 6).Value = "Direccion";
                worksheet.Cell(row, 7).Value = "FechaVenta";
                worksheet.Cell(row, 8).Value = "Subtotal";
                worksheet.Cell(row, 9).Value = "Descuento";
                worksheet.Cell(row, 10).Value = "Total";



                foreach (var ven in ventas)
                {
                    row++;
                    worksheet.Cell(row, 1).Value = ven.Id; ;
                    worksheet.Cell(row, 2).Value = ven.Paciente.Nombre;
                    worksheet.Cell(row, 3).Value = ven.NoComprobante;
                    worksheet.Cell(row, 4).Value = ven.Nit;
                    worksheet.Cell(row, 5).Value = ven.Nombres;
                    worksheet.Cell(row, 6).Value = ven.Direccion;
                    worksheet.Cell(row, 7).Value = ven.FechaVenta;
                    worksheet.Cell(row, 8).Value = ven.DetalleVenta.Sum(a => a.Subtotal);
                    worksheet.Cell(row, 9).Value = ven.DetalleVenta.Sum(a => a.Descuento);
                    worksheet.Cell(row, 10).Value = ven.DetalleVenta.Sum(a => a.Total);


                }

                using (var stream = new MemoryStream())
                {
                    workboook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officefocument.spreadsheet",
                    "Ventas.xlsx"
                    );

                }



            }

        }

         [Authorize(Roles = "Administrador, Vendedor, Supervisor")]
        public IActionResult ExportarDetalleVentas()
        {
            var detalles = _ventaRepository.GetListadoDetalles();

            using (var workboook = new XLWorkbook())
            {
                var worksheet = workboook.Worksheets.Add("Ventas");
                var row = 1;
                worksheet.Cell(row, 1).Value = "CodigoProducto";
                worksheet.Cell(row, 2).Value = "NombreProducto";
                worksheet.Cell(row, 3).Value = "Cantidad";
                worksheet.Cell(row, 4).Value = "Precio";
                worksheet.Cell(row, 5).Value = "Descuento";
                worksheet.Cell(row, 6).Value = "Subtotal";
                worksheet.Cell(row, 7).Value = "Total";
                worksheet.Cell(row, 8).Value = "VentaId";


                foreach (var det in detalles)
                {
                    row++;
                    worksheet.Cell(row, 1).Value = det.Producto.CodigoReferencia;
                    worksheet.Cell(row, 2).Value = det.Producto.NombreProducto;
                    worksheet.Cell(row, 3).Value = det.Cantidad;
                    worksheet.Cell(row, 4).Value = det.Precio;
                    worksheet.Cell(row, 5).Value = det.Descuento;
                    worksheet.Cell(row, 6).Value = det.Subtotal;
                    worksheet.Cell(row, 7).Value = det.Total;
                    worksheet.Cell(row, 8).Value = det.VentaId;


                }

                using (var stream = new MemoryStream())
                {
                    workboook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officefocument.spreadsheet",
                    "DetalleVentas.xlsx"
                    );

                }



            }

        }

        // public IActionResult VerGraficaFecha()
        //  {

    
            
        //     return View();
        // }

        // public IActionResult GraficaVentas(string mesdesde, string meshasta)
        //  {

        //     if(mesdesde == null || meshasta == null)
        //     {

        //         return View();
        //     }

        //     var fechahoy= DateTime.Now;
        //     var anio = fechahoy.Year;

        //    var desde = mesdesde+"/"+"01/"+anio;
        //     var hasta = meshasta+"/"+"01/"+anio;

        //       //var fechas = fecha.Split('-');
        //       var ventas = new List<Venta>();

        //     // ventas = _ventaRepository.GetVentasFechas(Convert.ToDateTime(desde), Convert.ToDateTime(hasta).AddDays(1));
                
        //      ventas = _ventaRepository.GetListadoFecha(Convert.ToDateTime(desde), Convert.ToDateTime(hasta).AddDays(1));
        //         //return Json (ventas);
           
            
        //     return View(ventas);
        //     //return Json(ventas);

        // }

        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult AnularVenta(int? Id)
        {
            if(Id == null) return BadRequest("request is incorrect");

            var venta = _ventaRepository.Get((int)Id);

            if(venta == null) return StatusCode(404); 

            
            venta.Eliminado = true; // cambiamos el estado a falso, practicamente es anulado.
            _ventaRepository.Update(venta, false); 

            // regresar los productos a inventario y sumarlos
            foreach(var item in venta.DetalleVenta)
            {
                var producto = _productoRepository.Get(item.Producto.Id);
                producto.Stock += item.Cantidad;
                _productoRepository.Update(producto, false);
            }

            // tambien debemos de eliminar el registro en caja.
            var detallecaja = _cajaRepository.GetDetalleCaja((int)Id);
            _cajaRepository.GetDetalleCajaPorVentaId(detallecaja.Id, false);

            return RedirectToAction("ListaVentasFarmacia");
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult AnularVentaClinica(int? Id)
        {
            if(Id == null) return BadRequest("request is incorrect");

            var venta = _ventaRepository.Get((int)Id);

            if(venta == null) return StatusCode(404); 

            
            venta.Eliminado = true; // cambiamos el estado a falso, practicamente es anulado.
            _ventaRepository.Update(venta, false); 

            // regresar los productos a inventario y sumarlos
            foreach(var item in venta.DetalleVenta)
            {
                if(item.Producto != null)
                {
                    var producto = _productoRepository.Get(item.Producto.Id);
                    producto.Stock += item.Cantidad;
                    _productoRepository.Update(producto, false);
                }
               
            }

            // tambien debemos de eliminar el registro en caja.
            var detallecajaclinica = _cajaClinicaRepository.GetDetalleCaja((int)Id);
            _cajaClinicaRepository.GetDetalleCajaPorVentaIdC(detallecajaclinica.Id, false);

            return RedirectToAction("ListaVentasClinica");
        }


         public async Task<IActionResult> Reporte(string fecha, int? empleadoid)
         {
            var fechas = fecha.Split('-');
            var ventas = new List<Venta>();

            if(empleadoid == null)
            {
                
                ventas = _ventaRepository.GetListadoFecha(Convert.ToDateTime(fechas[0]), Convert.ToDateTime(fechas[1]).AddDays(1));
            }
            else
            {
                ventas = _ventaRepository.GetListadoFechaEmpleado(Convert.ToDateTime(fechas[0]), Convert.ToDateTime(fechas[1]).AddDays(1),empleadoid); 
            }

            var model = new ReportesVentasViewModel()
            {
                Ventas = ventas,
                Desde = fechas[0],
                Hasta = fechas[1],
            };
            
            ViewBag.Desde = "2";
            return await _generatePdf.GetPdf("Views/Venta/Reporte.cshtml", model);
        }

    }


    public class DetalleVentaBinding
    {
        public string ProductoId { get; set; }
        public string Cantidad { get; set; }
        public string Precio { get; set; }
        public string Descuento { get; set; }

        public string Subtotal { get; set; }

        public string Total { get; set; }
    }
    public class DatosEnvioBinding
    {
        //public string NombrePiloto { get; set; }

        public string Ruta { get; set; }

        public string Fecha { get; set; }

        public string DireccionExacta { get; set; }

        public string NoComprobante { get; set; }

        public string Nit { get; set; }

        public string Nombre { get; set; }

        public string EmpleadoId { get; set; }

        public string UserId { get; set; }

        public int Id { get; set; }

    }


    public class DatosBinding
    {
        public string NoComprobante { get; set; }

        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }

        public string ClienteId { get; set; }

        public string Nit { get; set; }

        public string Direccion { get; set; }

        public string FormaPago { get; set; }

        public int Id { get; set; }

    }

    public class ViewModelVenta2
    {
        public List<DetalleVentaBinding> detalle { get; set; }
        public List<IdsBinding> nuevos { get; set; }
        public DatosBinding encabezado { get; set; }
        public DatosEnvioBinding datosenvio { get; set; }

    }

}
