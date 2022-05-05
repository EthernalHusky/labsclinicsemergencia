using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Database.Shared;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using sistema.Models;
using Database.Shared.IRepository;
using Database.Shared.Data;
using Database.Shared.Models;
using System.Web;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using sistema.Json;
//using System.Web.Http;
using Microsoft.AspNetCore.Authorization;

namespace sistema.Controllers
{
    [Authorize(Roles = "Administrador, Vendedor, Supervisor")]
    public class VentaServicioController : Controller
    {


        private readonly IVentaServicio _ventaServicioRepository = null;
        private readonly ICliente _clienteRepository = null;
        private readonly IServicio _servicioRepository = null;
        private readonly ICaja _cajaRepository = null;
        private readonly IEmpleado _empleadoRepository = null;
        private readonly ICajaClinica _cajaClinicaRepository = null;

        public VentaServicioController(IVentaServicio ventaServicioRepository, ICliente clienteRepository, IServicio servicioRepository, 
            ICaja cajaRepository, IEmpleado empleadoRepository, ICajaClinica cajaClinicaRepository)
        {
            _ventaServicioRepository=ventaServicioRepository;
            _clienteRepository=clienteRepository;
            _servicioRepository=servicioRepository;
            _cajaRepository = cajaRepository;
            _empleadoRepository = empleadoRepository;
            _cajaClinicaRepository = cajaClinicaRepository;
        }

        public IActionResult Lista(string sortOrder, string buscar, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["ApellidoSortParam"] = string.IsNullOrEmpty(sortOrder) ? "Apellido_desc" : "";
            ViewData["NombreSortParam"] = string.IsNullOrEmpty(sortOrder) ? "Nombre_desc" : "";
            
            if(buscar != null)
            {
                pageNumber = 1;
            }
            else 
            {
                buscar = currentFilter;
            }
            
            ViewData["CurrentFilter"] = buscar;

            var lista = _ventaServicioRepository.PaginacionVentaServicios(sortOrder, buscar, pageNumber, 10);

            return View(lista);
        }

        public IActionResult ReporteVentasServiciosFechas()
        {

            var modelo = new VentaServicioBaseViewModel();

            modelo.Init(_empleadoRepository);

            return View(modelo);
        }

        public IActionResult Nuevo()
        {
            var modelo = new VentaServicioBaseViewModel();

            modelo.Init(_clienteRepository);

            modelo.Init(_servicioRepository);

            return View(modelo);
        }

        public JsonResult ObtenerListadoServicios()
        {
            var listado = _servicioRepository.GetList();
            return Json(listado);
        }

        public JsonResult BusquedaServicios(string nombre)
        {
            

            var buscado = _servicioRepository.BuscarPorNombreBusquedaAjax(nombre);

            // mi pregunta es ya lo viste con F12, si te retorna toda la lista? si ya vi y me retorna algo raro
            //un objeto creo 
            if(buscado.Count < 1)
            {
                var lista = _servicioRepository.GetList();
                return Json(lista);
            }

            return Json(buscado);
        }

        public JsonResult GuardarVentaServicio([FromBody] ServiciosAddViewModel det)
        {
            var fecha = DateTime.Now;

            if (ModelState.IsValid)
            {

                var cajita = _cajaClinicaRepository.ListarCajas();

                if(!cajita.Any(a => a.EstadoCaja == true))
                {
                    return new JsonErrorResult(new { message = "¡Error. No hay cajas abiertas. Por favor debe abrir una caja.!" });
                } 

                var cliente = _clienteRepository.GetClientePorNombre(det.ventaServicio.Nombres);
                var cajaAbierta = _cajaClinicaRepository.GetCajaAbierta();
                var empleado = _empleadoRepository.Get(Convert.ToInt32(det.ventaServicio.EmpleadoId));


                if (empleado == null)
                {
                   return new JsonErrorResult(new { message = "¡Codigo de empleado incorrecto.!" });
                }

                if(cliente == null)
                {
                    var nuevoCliente = new Paciente()
                    {
                        Nombre = det.ventaServicio.Nombres,
                        Direccion = det.ventaServicio.Direccion,
                        Nit = det.ventaServicio.Nit
                    };

                    var nuevaVentaServicio = new VentaServicio()
                    {
                        NoComprobante = det.ventaServicio.NoComprobante,
                        Nombres = nuevoCliente.Nombre,
                        Nit = nuevoCliente.Nit,
                        Direccion = nuevoCliente.Direccion,
                        Paciente = nuevoCliente,
                        FormaPago = det.ventaServicio.FormaPago,
                        EmpleadoId = det.ventaServicio.EmpleadoId,
                        FechaVenta = fecha,
                    };

                    var nuevoDetalleCaja = new DetalleCajaClinica()
                    {
                        VentaServicio = nuevaVentaServicio,
                        Descripcion = "Venta de servicio a cliente: " + nuevoCliente.Nombre,
                        Ingreso = det.DetalleServicios.Sum(a => Convert.ToDecimal(a.Total)),
                        CajaClinica = cajaAbierta
                    };

                    _cajaClinicaRepository.Add(nuevoDetalleCaja, false);

                    foreach (var item in det.DetalleServicios)
                    {

                        var detalle = new DetalleServicio()
                        {
                            VentaServicio = nuevaVentaServicio,
                            Cantidad = Convert.ToInt32(item.Cantidad),
                            Precio = Convert.ToDecimal(item.Precio),
                            Total = Convert.ToDecimal(item.Total),
                            ServicioId = Convert.ToInt32(item.ServicioId),

                        };

                        _ventaServicioRepository.Add(detalle, false);

                    }

                   _ventaServicioRepository.saveChanges();

                    TempData["Message"] = "¡La venta se ha guardado con exito.!";

                    return Json(nuevaVentaServicio.Id);

                } 
                else 
                {

                    var nuevaVentaServicio = new VentaServicio()
                    {

                        NoComprobante = det.ventaServicio.NoComprobante,
                        Nombres = cliente.Nombre,
                        Nit = cliente.Nit,
                        Direccion = cliente.Direccion,
                        // Paciente = cliente,
                        FormaPago = det.ventaServicio.FormaPago,
                        EmpleadoId = det.ventaServicio.EmpleadoId,
                        FechaVenta = fecha,

                    };

                    var nuevoDetalleCaja = new DetalleCajaClinica()
                    {
                        VentaServicio = nuevaVentaServicio,
                        Descripcion = "Venta de servicio a cliente: " + cliente.Nombre,
                        Ingreso = det.DetalleServicios.Sum(a => Convert.ToDecimal(a.Total)),
                        CajaClinica = cajaAbierta
                    };

                    _cajaClinicaRepository.Add(nuevoDetalleCaja, false);

                    foreach (var item in det.DetalleServicios)
                    {

                        var detalle = new DetalleServicio()
                        {
                            VentaServicio = nuevaVentaServicio,
                            Cantidad = Convert.ToInt32(item.Cantidad),
                            Precio = Convert.ToDecimal(item.Precio),
                            Descuento = Convert.ToDecimal(item.Descuento),
                            Subtotal = Convert.ToDecimal(item.Subtotal),
                            Total = Convert.ToDecimal(item.Total),
                            ServicioId = Convert.ToInt32(item.ServicioId),

                        };

                        _ventaServicioRepository.Add(detalle, false);

                    }

                    _ventaServicioRepository.saveChanges();

                    TempData["Message"] = "¡La venta se ha guardado con exito.!";

                    return Json(nuevaVentaServicio.Id);
                }

            }
             return new JsonErrorResult(new { message = "Hubo un error interno. Intente mas tarde." });

        }

         public IActionResult Modificar(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var ventaServicio = _ventaServicioRepository.Get((int)id);

            if (ventaServicio == null)
            {
                return StatusCode(404);
            }

            var model = new VentaServicioBaseViewModel(){
                VentaServicio = ventaServicio,

            };

            model.Init(_clienteRepository);

            model.Init(_servicioRepository);

            return View(model);
        }

         public JsonResult ModificarVentaServicio([FromBody]ViewModelVentaServicio det)
        {
            var listadoEnBd = _ventaServicioRepository.GetDetalle(det.encabezado.Id);
            
            if(ModelState.IsValid)
            {
                foreach (var item in listadoEnBd)
                {   
                    bool flag = false;
                    
                    foreach(var ins in det.nuevos)
                    {
                        if(item.Id == Convert.ToInt32(ins.Ids))
                        {
                            flag = true;
                            break;
                        }
                    }
                    
                    if(!flag)
                    {
                        _ventaServicioRepository.Delete(item.Id, false);
                    }

                    
                    
                }

                var ventaServicio = new VentaServicio(){
                   Id=det.encabezado.Id,
                   NoComprobante= det.encabezado.NoComprobante,
                   ClienteId =Convert.ToInt32(det.encabezado.ClienteId),
                   Nit =det.encabezado.Nit,
                   Nombres = det.encabezado.Nombre,
                   Direccion = det.encabezado.Direccion,
                   EmpleadoId = det.encabezado.EmpleadoId,

                };

                 _ventaServicioRepository.Update(ventaServicio);


                foreach(var item in det.detalle)
                {

                    var nuevodetalle = new DetalleServicio()

                    {
                        VentaServicioId = Convert.ToInt32(det.encabezado.Id),
                        ServicioId =Convert.ToInt32(item.ServicioId),
                        Cantidad = Convert.ToInt32(item.Cantidad),
                        Precio = Convert.ToDecimal(item.Precio),
                        Descuento = Convert.ToDecimal(item.Descuento),
                        Subtotal = Convert.ToDecimal(item.Subtotal),
                        Total = Convert.ToDecimal(item.Total),
                    };

                    _ventaServicioRepository.Add(nuevodetalle , false);

                }

            _ventaServicioRepository.saveChanges();

            return Json("OK");

            }
            

            return new JsonErrorResult(new { message = "Ha ocurrido un error de servidor."});
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult AnularVenta(int? Id)
        {
            if(Id == null) return BadRequest("request is incorrect");

            var servicio = _ventaServicioRepository.Get((int)Id);

            if(servicio == null) return StatusCode(404); 

            servicio.Eliminado = true; // cambiamos el estado a falso, practicamente es anulado.
            _ventaServicioRepository.Update(servicio, false); 

            // tambien debemos de eliminar el registro en caja.
            var detallecaja = _cajaRepository.GetDetalleCajaVentaServicio((int)Id);
            _cajaRepository.GetDetalleCajaPorVentaId(detallecaja.Id, false);

            return RedirectToAction("Lista");
        }
    }
    

    public class DetalleServicioBinding
    {
        public string ServicioId { get; set; }
        public string Cantidad { get; set; }
        public string Precio { get; set; }
        public string Descuento { get; set; }
        public string Subtotal { get; set; }
        public string Total { get; set; }
    }

    

    public class ViewModelVentaServicio
    {
        public List<DetalleServicioBinding> detalle { get; set; }
        public List<IdsBinding> nuevos { get; set; }
        public DatosBinding encabezado { get; set; }

    }

}
