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
using sistema.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Wkhtmltopdf.NetCore;

namespace sistema.Controllers
{
   [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
    public class LaboratorioClinicoController : Controller
    {
        private readonly ILaboratorioClinico _laboratorioClinico = null;
        private readonly IEmpleado _empleadosDoctoresRepository = null;
        private readonly IPacientes _pacientesRepository = null;
        private readonly UserManager<User> _userManager = null;
        private readonly IEnvio _envioRepository = null;

        private readonly IPacientes _pacienteRepository = null;
        private readonly IEmpleado _empleadoRepository = null;

        
        public LaboratorioClinicoController(ILaboratorioClinico laboratorioClinico, 
        UserManager<User> userManager,
        IPacientes pacientesRepository,
        IEmpleado empleadoDoctoresRepository,
        IEnvio envioRepository,
        IEmpleado empleadoRepository,
        IPacientes pacienteRepository)
        {
            _laboratorioClinico = laboratorioClinico;
            _userManager = userManager;
            _pacientesRepository  = pacientesRepository;
            _empleadosDoctoresRepository = empleadoDoctoresRepository;
            _envioRepository = envioRepository;
            _empleadoRepository = empleadoRepository;
            _pacienteRepository = pacienteRepository;
        }

        public IActionResult ListaCategorias(string sortOrder, string buscar, string currentFilter, int? pageNumber)
        {
            
            if(buscar != null)
            {
                pageNumber = 1;
            }
            else 
            {
                buscar = currentFilter;
            }
            
            ViewData["CurrentFilter"] = buscar;

            var lista = _laboratorioClinico.PaginacionCategoriasLab(sortOrder, buscar, pageNumber, 30);

            return View(lista);
        }

        public IActionResult VentasLabLista(string sortOrder, string buscar, string currentFilter, int? pageNumber)
        {
            if(buscar != null)
            {
                pageNumber = 1;
            }
            else 
            {
                buscar = currentFilter;
            }
            
            ViewData["CurrentFilter"] = buscar;

            var lista = _laboratorioClinico.PaginacionVentasLab(sortOrder, buscar, pageNumber, 30);

            return View(lista);
        }
        
        public IActionResult ListaExamenes(ExamenesLabClinicoViewModel viewModel)
        {
            if(viewModel.buscar != null)
            {
                viewModel.pageNumber = 1;
            }
            else 
            {
                viewModel.buscar = viewModel.currentFilter;
            }
            
            ViewData["CurrentFilter"] = viewModel.buscar;
             viewModel.Init(_laboratorioClinico);

            viewModel.nombreExamenes = _laboratorioClinico.PaginacionExamenClinicoLab(null,viewModel.buscar, viewModel.pageNumber, 30, viewModel.catexamenId);

            return View(viewModel);
        }

        public IActionResult NuevaCategoria()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NuevaCategoria(ModCategoriaListados model)
        {
            if(ModelState.IsValid)
            {
                model.CategoriaLabClinico.FechaCreacion = DateTime.Now;
                model.CategoriaLabClinico.Activo = true;
                _laboratorioClinico.Add(model.CategoriaLabClinico);
                TempData["Message"] = "¡El registro se ha guardado con éxito.!";
                return RedirectToAction("ListaCategorias");
            }
            
            return View(model);
        }

        public IActionResult ModificarCategoriaLab (int? id)
        {
            var categoriaLab = _laboratorioClinico.GetCategoriaLab((int)id);
            var nombreExamenes = _laboratorioClinico.ExamenesLabList((int)id);

            var model = new ModCategoriaListados()
            {
                CategoriaLabClinico = categoriaLab,
                NombresExamenes = nombreExamenes

            };

            return View(model);
        }

        public IActionResult DesactivarOActivarCategoriaLab(int? id)
        {
            var categoriaLab = _laboratorioClinico.GetCategoriaLab((int)id);

            if(categoriaLab.Activo == true)
            {
                categoriaLab.Activo = false;
            }
            else {
                categoriaLab.Activo = true;
            }

            _laboratorioClinico.Update(categoriaLab);

            return RedirectToAction("ListaCategorias");
        }

        public IActionResult ActivarODesactivarDatosLab(int? id, int? cat2)
        {
            var datos = _laboratorioClinico.GetDatosExamenLab((int)id);

            if(datos.Activo == true)
            {
                datos.Activo = false;
            }
            else {
                datos.Activo = true;
            }

            _laboratorioClinico.Update(datos);

            return RedirectToAction("ModificarExamenLab", new {id = cat2});


        }


        

        public IActionResult ActivarODesactivarNombreExamenLab(int? id, int cat2)
        {
            var categoriaLab = _laboratorioClinico.GetExamenLab((int)id);

            if(categoriaLab.Activo == true)
            {
                categoriaLab.Activo = false;
            }
            else {
                categoriaLab.Activo = true;
            }

            _laboratorioClinico.Update(categoriaLab);

            return RedirectToAction("ModificarCategoriaLab", new {id = cat2});
            
            // return RedirectToAction("ListaCategorias");
        }

        

        public IActionResult EliminarCategoria (int? id)
        {
            var categoriaLab = _laboratorioClinico.GetCategoriaLab((int)id);
            categoriaLab.Eliminado = true;

            _laboratorioClinico.Update(categoriaLab);

            TempData["Message"] = "¡El registro se ha archivado con éxito.!";

            return RedirectToAction("ListaCategorias");
        }
        
        public IActionResult EliminarDatosLab (int? id, int? cat2)
        {
            var categoriaLab = _laboratorioClinico.GetDatosExamenLab((int)id);
            categoriaLab.Eliminado = true;

            _laboratorioClinico.Update(categoriaLab);

            TempData["Message"] = "¡El registro se ha archivado con éxito.!";

            return RedirectToAction("ModificarExamenLab", new {id = cat2});
        }

        public IActionResult EliminarExamen (int? id)
        {
            var examen = _laboratorioClinico.GetExamenLab((int)id);
            examen.Eliminado = true;

            _laboratorioClinico.Update(examen);

            TempData["Message"] = "¡El registro se ha archivado con éxito.!";

            return RedirectToAction("ListaExamenes");
        }

        public IActionResult EliminarExamen2 (int? id, int cat2)
        {
            var examen = _laboratorioClinico.GetExamenLab((int)id);
            examen.Eliminado = true;

            _laboratorioClinico.Update(examen);

            TempData["Message"] = "¡El registro se ha archivado con éxito.!";

                // return RedirectToAction("ListaCategorias");
            return RedirectToAction("ModificarCategoriaLab", new {id = cat2});
        }

        public IActionResult EliminarExamenRealizado (int? id)
        {
            var examen = _laboratorioClinico.GetExamenRealizado((int)id);
            examen.Eliminado = true;

            _laboratorioClinico.Update(examen);

            TempData["Message"] = "¡El registro se ha archivado con éxito.!";

            return RedirectToAction("ListaExamenesRealizados");
        }

        public IActionResult EliminarVentaLab(int? id)
        {
            var venta = _laboratorioClinico.GetVentaLab((int)id);
            var examen = _laboratorioClinico.GetExamenRealizado((int)venta.ExamenId);

            examen.Eliminado = true;
            venta.Eliminado = true;

            _laboratorioClinico.Update(examen,false);
            _laboratorioClinico.Update(venta,false);

            _laboratorioClinico.saveChanges();


            TempData["Message"] = "¡El registro se ha archivado con éxito.!";

            return RedirectToAction("VentasLabLista");
        }

        public IActionResult ModificarExamenLab (int? id)
        {
           var lab = _laboratorioClinico.GetExamenLab((int)id);
           var datosLista = _laboratorioClinico.DatosLabList((int)id);

            var model = new ExamenLabClinicoViewModel()
            {
                ExamenLabClinico = lab,
                DatosExamenes = datosLista
            };

            model.Init(_laboratorioClinico);
            return View(model);
        }

        public IActionResult ModificarDatosLab (int? id)
        {
            var dato = _laboratorioClinico.GetDatosExamenLab((int)id);
            return View(dato);
        }


        public IActionResult EditarDetalleExamen (int? id)
        {
           var examen = _laboratorioClinico.GetExamenRealizado((int)id);

            var model = new RealizarExamenLabClinicoViewModel()
            {
                Examen = examen
            };

            model.Init(_laboratorioClinico, _empleadosDoctoresRepository,_pacientesRepository, _envioRepository);
            ViewBag.MostrarEstado = true;
            
            return View(model);
        }

        [HttpPost]
        public IActionResult EditarDetalleExamen (RealizarExamenLabClinicoViewModel viewModel)
        {

            if(ModelState.IsValid)
            {
                //  var user = await _userManager.GetUserAsync(HttpContext.User);
                
                _laboratorioClinico.Update(viewModel.Examen);

                TempData["Message"] = "¡El registro se ha modificado con éxito.!";
                // return RedirectToAction("ListaCategorias");

                viewModel.Init(_laboratorioClinico, _empleadosDoctoresRepository,_pacientesRepository, _envioRepository);
                ViewBag.MostrarEstado = true;
                
                return View(viewModel);

            }

        //    var examen = _laboratorioClinico.GetExamenRealizado((int)viewModel);

            var model = new RealizarExamenLabClinicoViewModel()
            {
                Examen = viewModel.Examen
            };

            model.Init(_laboratorioClinico, _empleadosDoctoresRepository,_pacientesRepository, _envioRepository);

            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ModificarCategoriaLab (ModCategoriaListados model)
        {
            if(ModelState.IsValid)
            {
                 var user = await _userManager.GetUserAsync(HttpContext.User);
                
                model.CategoriaLabClinico.UltimoUsuarioModificado = user.UserName;
                _laboratorioClinico.Update(model.CategoriaLabClinico);

                TempData["Message"] = "¡El registro se ha modificado con éxito.!";
                // return RedirectToAction("ListaCategorias");
                return View(model);

            }
            
            return View(model);
        }

        

         [HttpPost]
        public async Task<IActionResult> ModificarExamenLab (ExamenLabClinicoViewModel model)
        {
            if(ModelState.IsValid)
            {
                 var user = await _userManager.GetUserAsync(HttpContext.User);
                
                model.ExamenLabClinico.UltimaModificacion = user.UserName;
                _laboratorioClinico.Update(model.ExamenLabClinico);

                TempData["Message"] = "¡El registro se ha modificado con éxito.!";
                // return RedirectToAction("ListaCategorias");
                return View(model);

            }
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ModificarDatosLab (DatosExamenesLabClinico model)
        {
            if(ModelState.IsValid)
            {
                //  var user = await _userManager.GetUserAsync(HttpContext.User);
                
                // model.ExamenLabClinico.UltimaModificacion = user.UserName;
                _laboratorioClinico.Update(model);

                TempData["Message"] = "¡El registro se ha modificado con éxito.!";
                // return RedirectToAction("ListaCategorias");
                return View(model);

            }
            
            return View(model);
        }

        

        
        
        public IActionResult CrearExamen()
        {
            var model = new ExamenLabClinicoViewModel();
            model.Init(_laboratorioClinico);
            
            return View(model); 
        }
        
        [HttpPost]
        public IActionResult CrearExamen(ExamenLabClinicoViewModel model)
        {
            if(ModelState.IsValid)
            {
                _laboratorioClinico.Add(model.ExamenLabClinico);

                TempData["Message"] = "¡El registro se ha insertado con éxito.!";
                // return RedirectToAction("ListaCategorias");
                return RedirectToAction("ListaExamenes");

            }

            var viewModel = new ExamenLabClinicoViewModel();
            model.Init(_laboratorioClinico);
            
            return View(model); 
        }

        [HttpPost]
        public IActionResult CrearExamen2(ExamenLabClinico model, int catid)
        {
            if(ModelState.IsValid)
            {
                model.CategoriaLabClinicoId = catid;
                _laboratorioClinico.Add(model);

                TempData["Message"] = "¡El registro se ha insertado con éxito.!";
                // return RedirectToAction("ListaCategorias");
                return RedirectToAction("ModificarCategoriaLab", new {id = catid});
            }

            // var viewModel = new ExamenLabClinicoViewModel();
            // model.Init(_laboratorioClinico);
            
            return RedirectToAction("ModificarCategoriaLab", new {id = catid});
        }

        [HttpPost]
        public IActionResult CrearDatosExamenLab(DatosExamenesLabClinico model, int datoid)
        {
            if(ModelState.IsValid)
            {
                model.ExamenLabClinicoId = datoid;
                _laboratorioClinico.Add(model);

                TempData["Message"] = "¡El registro se ha insertado con éxito.!";
                // return RedirectToAction("ListaCategorias");
                return RedirectToAction("ModificarExamenLab", new {id = datoid});
            }

            // var viewModel = new ExamenLabClinicoViewModel();
            // model.Init(_laboratorioClinico);
            
            return RedirectToAction("ModificarExamenLab", new {id = datoid});
        }

        public IActionResult RealizarExamenClinico()
        {
            var model = new RealizarExamenLabClinicoViewModel();
            ViewBag.MostrarEstado = false;
            
            model.Init(_laboratorioClinico, _empleadosDoctoresRepository,_pacientesRepository, _envioRepository);
            return View(model);
        }

        [HttpPost]
        public IActionResult RealizarExamenClinico(RealizarExamenLabClinicoViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                viewModel.Examen.FechaRealizacion = DateTime.Now;
                viewModel.Examen.EstadoExamenId = 2; // 2 es en proceso
                _laboratorioClinico.Add(viewModel.Examen);

                TempData["Message"] = "¡El registro se ha insertado con éxito.!";
                // return RedirectToAction("ListaCategorias");
                return RedirectToAction("GenerarReporteExamen","CrearPDF", new {viewModel.Examen.Id});

            }

            var model = new RealizarExamenLabClinicoViewModel();

            model.Init(_laboratorioClinico, _empleadosDoctoresRepository,_pacientesRepository, _envioRepository);
            return View(model);
        }

        


        public IActionResult ListaExamenesRealizados(string sortOrder, string buscar, string currentFilter, int? pageNumber)
        {
            if(buscar != null)
            {
                pageNumber = 1;
            }
            else 
            {
                buscar = currentFilter;
            }
            
            ViewData["CurrentFilter"] = buscar;

            var lista = _laboratorioClinico.PaginacionExamenesRealizados(sortOrder, buscar, pageNumber, 30, null);

            return View(lista);
        }

        public IActionResult ExamenesEnProceso(string sortOrder, string buscar, string currentFilter, int? pageNumber)
        {
            if(buscar != null)
            {
                pageNumber = 1;
            }
            else 
            {
                buscar = currentFilter;
            }
            
            ViewData["CurrentFilter"] = buscar;

            var lista = _laboratorioClinico.PaginacionExamenesRealizados(sortOrder, buscar, pageNumber, 30,2);

            return View(lista);
        }

        public IActionResult ExamenesSolicitados(string sortOrder, string buscar, string currentFilter, int? pageNumber)
        {
            if(buscar != null)
            {
                pageNumber = 1;
            }
            else 
            {
                buscar = currentFilter;
            }
            
            ViewData["CurrentFilter"] = buscar;

            var lista = _laboratorioClinico.PaginacionExamenesRealizados(sortOrder, buscar, pageNumber, 30,1);

            return View(lista);
        }

         public IActionResult ExamenesCancelados(string sortOrder, string buscar, string currentFilter, int? pageNumber)
        {
            if(buscar != null)
            {
                pageNumber = 1;
            }
            else 
            {
                buscar = currentFilter;
            }
            
            ViewData["CurrentFilter"] = buscar;

            var lista = _laboratorioClinico.PaginacionExamenesRealizados(sortOrder, buscar, pageNumber, 30,3);

            return View(lista);
        }

         public IActionResult ExamenesEnRevision(string sortOrder, string buscar, string currentFilter, int? pageNumber)
        {
            if(buscar != null)
            {
                pageNumber = 1;
            }
            else 
            {
                buscar = currentFilter;
            }
            
            ViewData["CurrentFilter"] = buscar;

            var lista = _laboratorioClinico.PaginacionExamenesRealizados(sortOrder, buscar, pageNumber, 30,4);

            return View(lista);
        }

        public IActionResult ExamenesFinalizados(string sortOrder, string buscar, string currentFilter, int? pageNumber)
        {
            if(buscar != null)
            {
                pageNumber = 1;
            }
            else 
            {
                buscar = currentFilter;
            }
            
            ViewData["CurrentFilter"] = buscar;

            var lista = _laboratorioClinico.PaginacionExamenesRealizados(sortOrder, buscar, pageNumber, 30,4);

            return View(lista);
        }

        public JsonResult RetornarExamenes(string id)
        {
            var examenBuscado = _laboratorioClinico.GetExamenLab(Convert.ToInt16(id));

            if(examenBuscado == null)
            {
                return new JsonErrorResult(new { message = ""});
            }

            var objetos = new {id = examenBuscado.Id, 
                nombreServicio = examenBuscado.NombreExamen, 
                    precio = examenBuscado.Precio,
                    precioB = examenBuscado.PrecioB,
                    precioC = examenBuscado.PrecioC};

            return Json(objetos);
        }

        public JsonResult ObtenerListadoExamenesLab()
        {
            var listado = _laboratorioClinico.ExamenesLabListTodos();

            var list = new List<object>();

            foreach(var item in listado)
            {
                var model = new{
                    id = item.Id,
                    nombreServicio = item.NombreExamen,
                    categoria = item.CategoriaLabClinico.Nombre
                };

                list.Add(model);
            };
            
            return Json(list);
        }


                [Authorize(Roles = "Administrador, Vendedor, Supervisor")]
        public JsonResult GuardarVentaLab([FromBody]VentaClinicaAddViewModel model)
        {
            // registrar un identificador si es de farm o de clinica

            if (ModelState.IsValid)
            {
                if(  string.IsNullOrEmpty(model.encabezado.Nombres) ) 
                {
                    model.encabezado.Nombres = "CF";
                }

                if( string.IsNullOrEmpty(model.encabezado.Nit))
                {
                    model.encabezado.Nit = "CF";
                }

                if(string.IsNullOrEmpty(model.encabezado.Direccion))
                {
                    model.encabezado.Direccion = "CF";
                }

                // cargar lista de todas las cajas
                var cajita = _laboratorioClinico.ListarCajas();

                // verificar si hay cajas abiertas, una por una, si te acordas del Any()
                // otra manera seria hacerlo con una bandera, pero el any te hace el trabajo.
                if (!cajita.Any(a => a.EstadoCaja == true))
                {
                    return new JsonErrorResult(new { message = "¡Error. No hay cajas abiertas. Por favor debe abrir una caja.!" });
                }

                var paciente = _pacienteRepository.Get(model.encabezado.ClienteId);
                var cajaAbierta = _laboratorioClinico.GetCajaAbierta();
                var empleado = _empleadoRepository.Get(model.encabezado.EmpleadoId);

                if (empleado == null)
                {
                    return new JsonErrorResult(new { message = "¡Codigo de empleado incorrecto.!" });
                }

                var examen = new Examen()
                {
                    Paciente = paciente,
                    EstadoExamenId = 1,
                    FechaRealizacion = DateTime.Now,
                    DoctorReferido = model.encabezado.MedicoReferido,
                    ClinicaReferida = model.encabezado.ClinicaReferida

                };
               
                var nuevaVenta = new VentasLab()
                {
                    // NoComprobante = model.encabezado.NoComprobante,
                    Nombres = model.encabezado.Nombres,
                    Nit = model.encabezado.Nit,
                    Direccion = model.encabezado.Direccion,
                    // Paciente = paciente,
                    // FormaPago = model.detalle.encabezado.FormaPago,
                    FechaVenta = DateTime.Now,
                    EmpleadoResponsable = empleado.Nombre,
                    // TipoVenta = "clinica",
                    MontoPagado = model.encabezado.Monto,
                    Vuelto = model.encabezado.Vuelto,
                    Examen = examen
                };

                var pago = new Pagos()
                {
                    VentaLab = nuevaVenta,
                    FormaPagoId = Convert.ToInt32(model.encabezado.FormaPago),
                    Monto = Convert.ToDecimal(model.encabezado.Monto),
                };

                _envioRepository.AddPago(pago, false);

               

                var nuevoDetalleCaja = new DetalleCajaLab()
                {
                    VentasLab = nuevaVenta,
                    Descripcion = "Venta de examen: " + paciente.Nombre,
                    Ingreso = model.encabezado.Monto,
                    CajaLab = cajaAbierta
                };
                
                _laboratorioClinico.Add(nuevoDetalleCaja, false);

                foreach (var item in model.detalle)
                {
                    
                    var nuevodetalle = new DetalleExamen()
                    {
                        Examen = examen,
                        Cantidad = item.Cantidad,
                        Precio = item.Precio,
                        Descuento = item.Descuento,
                        Subtotal = item.Subtotal,
                        Total = item.Total,
                        ExamenLabClinicoId = item.ProductoId,
                    };

                    _laboratorioClinico.Add(nuevodetalle, false);

                    //restar al inventario
                    // var producto = _productoRepository.Get((int)nuevodetalle.ProductoId);
                    // producto.Stock -= nuevodetalle.Cantidad;
                    // _productoRepository.Update(producto, false);
                }

                _laboratorioClinico.saveChanges();

                TempData["Message"] = "¡La venta se ha guardado con éxito.!";

                return Json(nuevaVenta.Id);

            }

            return Json("Hubo un error interno.");
        }


        public IActionResult Aperturar()
        {
            var model = new CajaLaboratorioBaseViewModel()
            {
            };
            
            model.Init(_laboratorioClinico);


            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Aperturar(CajaLaboratorioBaseViewModel model)
        {

            if (ModelState.IsValid)
            {
                // var cajaAbierta = _cajaRepository.GetCajaAbierta();
                var cajita = _laboratorioClinico.ListarCajas();

                //verificar si no hay cajas abiertas

                if (cajita.Any(a => a.EstadoCaja == true))
                {
                    TempData["Message"] = "¡Error. Ya hay una caja abierta.!";
                    model.Init(_laboratorioClinico);
                    return RedirectToAction("Aperturar");
                }
                else
                {
                    var user = await _userManager.GetUserAsync(HttpContext.User);

                    var nuevaCaja = new CajaLab()
                    {
                        MontoApertura = model.CajaLab.MontoApertura,
                        FechaApertura = DateTime.Now,
                        EstadoCaja = true,
                        ResponsableAperturaLab = user,
                    };

                    _laboratorioClinico.Add(nuevaCaja);

                    model.Init(_laboratorioClinico);
                    return RedirectToAction("Aperturar");
                }
            }

            model.Init(_laboratorioClinico);
            return View(model);
        }


        public JsonResult GuardarEgreso(string monto, string descripcion)
        {
            if (monto != null && descripcion != null)
            {
                var cajaAbierta = _laboratorioClinico.GetCajaAbierta();

                var nuevoDetalleCaja = new DetalleCajaLab()
                {
                    Fecha = DateTime.Now,
                    Descripcion = descripcion,
                    Gasto = Convert.ToInt32(monto),
                    CajaLab = cajaAbierta,
                };

                _laboratorioClinico.Add(nuevoDetalleCaja);

                TempData["Message"] = "¡El gasto se ha guardado con exito.!";

                return Json(nuevoDetalleCaja.CajaLab.Id);
            }

            return Json("Ha ocurrido un error");
        }

        public JsonResult GuardarIngreso(string monto, string descripcion)
        {

            if (monto != null && descripcion != null)
            {

                var cajaAbierta = _laboratorioClinico.GetCajaAbierta();

                var nuevoDetalleCaja = new DetalleCajaLab()
                {
                    Fecha = DateTime.Now,
                    Descripcion = descripcion,
                    Ingreso = Convert.ToInt32(monto),
                    CajaLab = cajaAbierta,
                };

                _laboratorioClinico.Add(nuevoDetalleCaja);

                TempData["Message"] = "¡El ingreso se ha guardado con exito.!";

                return Json(nuevoDetalleCaja.CajaLab.Id);


            }

            return Json("Ha ocurrido un error");

        }

        public async Task<IActionResult> Cerrar(CajaLaboratorioBaseViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);

                var caja = _laboratorioClinico.GetCaja(model.CajaLab.Id);
                caja.EstadoCaja = false;
                caja.FechaCierre = DateTime.Now;
                caja.ResponsableCierreLab = user;

                _laboratorioClinico.Update(caja);

                model.Init(_laboratorioClinico);
                return RedirectToAction("Aperturar");
            }

            model.Init(_laboratorioClinico);
            return View(model);
        }


        public IActionResult VerDetalle(int? id)
        {

            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var caja = _laboratorioClinico.GetCaja((int)id);

            if (caja == null)
            {
                return StatusCode(404);
            }

            var model = new CajaLaboratorioBaseViewModel()
            {
                CajaLab = caja
            };

            return View(model);
        }

        public IActionResult ModificarResultadosExamen(int detalleExamenId)
        {
            var detalle = _laboratorioClinico.GetDetalleExamenLab((int)detalleExamenId);

            var model = new ModificarResultadosExamen()
            {
                DetalleExamen = detalle,
                ExamenId = detalle.ExamenId
            };

            return View(model);
        }


        [HttpPost]
        public IActionResult ModificarResultadosExamen (ModificarResultadosExamen viewModel)
        {
            if(ModelState.IsValid)
            {
                //  var user = await _userManager.GetUserAsync(HttpContext.User);
                // /LaboratorioClinico/EditarDetalleExamen/15
                var detalle = _laboratorioClinico.GetDetalleExamenLab((int) viewModel.Id);

                detalle.ExamenId = viewModel.ExamenId;
                detalle.ExamenLabClinicoId = viewModel.DetalleExamen.ExamenLabClinicoId;
                detalle.Resultado = viewModel.DetalleExamen.Resultado;

                _laboratorioClinico.Update(detalle);

                TempData["Message"] = "¡El registro se ha modificado con éxito.!";
                // return RedirectToAction("ListaCategorias");

                // viewModel.Init(_laboratorioClinico, _empleadosDoctoresRepository,_pacientesRepository, _envioRepository);
                // ViewBag.MostrarEstado = true;
                
                return RedirectToAction("EditarDetalleExamen", new {id = viewModel.ExamenId});
            }

            return View(viewModel.DetalleExamen);

        }

    }
}
