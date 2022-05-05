using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using farmamest.Models;
using Database.Shared.IRepository;
using Database.Shared.Data;
using Wkhtmltopdf.NetCore;
using sistema.Models;
using sistema.Json;
using Database.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace sistema.Controllers
{
    public class TrasladosBodegaAFarmaciaController : Controller
    {
        private readonly IProducto _productoRepository = null;
        private readonly ITraslados _trasladosRepository = null;
        private readonly UserManager<User> _userManager = null;
        private readonly IGeneratePdf _generatePdf = null;
        private readonly IUser _userRepository;

        public TrasladosBodegaAFarmaciaController(IProducto productoRepository, ITraslados trasladosRepository, UserManager<User> userManager,
        IGeneratePdf generatePDF, IUser userRepository)
        {
            _productoRepository = productoRepository;
            _userManager = userManager;
            _trasladosRepository = trasladosRepository;
            _generatePdf = generatePDF;
            _userRepository = userRepository;
        }

        public IActionResult NuevoTraslado()
        {
            var model = new TrasladosBaseViewModel();
            model.Init(_productoRepository);
            return View(model);
        }

        public JsonResult GuardarTraslado([FromBody]TrasladosBaseViewModel model)
        {
            if(model.DetalleTrasladoProductos.Count() <= 0)
            {
                return new JsonErrorResult(new { message = "El detalle del traslado está vacío." });
            }

            if(ModelState.IsValid)
            {
                var user = _userManager.GetUserAsync(HttpContext.User);

                var nuevoTraslado = new TrasladosProductos()
                {
                    EstadoTrasladosId = 5, // en tansito es el inicial
                    FechaTraslado = DateTime.Now,
                    Observaciones = model.TrasladosDto.Observaciones,
                    ResponsableEnviado = user.Result,
                    TipoTrasladoBodega = "BodegaAFarmacia"
                };

                _trasladosRepository.Add(nuevoTraslado, false);

                foreach (var item in model.DetalleTrasladoProductos)
                {
                    var nuevoDetalle = new DetalleTrasladoProductos()
                    {
                        ProductoId = item.ProductoId,
                        Cantidad = item.Cantidad,
                        TrasladosProductos = nuevoTraslado
                    };

                    _trasladosRepository.Add(nuevoDetalle, false);

                    var producto = _productoRepository.Get(item.ProductoId);
                    producto.Stock -= item.Cantidad;
                    _productoRepository.Update(producto, false);
                }


                _productoRepository.SaveChanges();
                return Json(nuevoTraslado.Id);
            }

            return new JsonErrorResult(new { message = "ERROR." });
            
        }

        public IActionResult AceptarTraslado(int? id)
        {
            if (id == null) return StatusCode(400);

            var traslado = _trasladosRepository.GetTraslados((int)id);

            if(traslado == null) return StatusCode(404);

            // verificar si ya esta aceptado
            if(traslado.EstadoTrasladosId == 1)
            {
                TempData["Message"] = "¡Error, este registro ya esta registrado como: Aceptado.!";
                return RedirectToAction("Editar", new {id = id});
            }

            foreach(var item in traslado.DetalleTrasladoProductos)
            {
                // 1 farmmacia
                // 2 clinica
                // 3 bodega
                var productoFarmacia = _productoRepository.GetProductoByTipoBodegaAndNombre(1, item.Producto.NombreProducto);
                
                // agregar
                if(productoFarmacia == null)
                {   
                    var productoBodega = _productoRepository.GetProductoByTipoBodegaAndNombre(3, item.Producto.NombreProducto);
                    
                    if(item.Producto.TipoProductoId == 10)
                    {
                        var nuevoProductoClinicaMedicamentos = new Producto()
                        {
                            TipoBodegaId = 1, // farmacia
                            TipoProductoId = 10,  // medicamento
                            ViadminId = productoBodega.ViadminId,
                            GrupoTProductoId = productoBodega.GrupoTProductoId,
                            PresentacionProductoId = productoBodega.PresentacionProductoId,
                            LaboratorioProductoId = productoBodega.LaboratorioProductoId,
                            NombreProducto = productoBodega.NombreProducto,
                            Precio = productoBodega.Precio,
                            Precio_2 = productoBodega.Precio_2,
                            Precio_3 = productoBodega.Precio_3,
                            Precio_4 = productoBodega.Precio_4,
                            Precio_5 = productoBodega.Precio_5,
                            Precio_6 = productoBodega.Precio_6,
                            Precio_7 = productoBodega.Precio_7,
                            PrecioCosto = productoBodega.PrecioCosto,
                            Stock = item.Cantidad,
                            StockInical = item.Cantidad,
                            CodigoReferencia = productoBodega.CodigoReferencia,
                            Imagen = productoBodega.Imagen,
                            Descripcion = productoBodega.Descripcion,
                            ActivoYConcentracion = productoBodega.ActivoYConcentracion,
                            Dosis = productoBodega.Dosis,
                            FechaVencimiento = productoBodega.FechaVencimiento,
                            Eliminado = productoBodega.Eliminado,
                        };

                        _productoRepository.Add(nuevoProductoClinicaMedicamentos, false);
                    }
                    
                    else if(item.Producto.TipoProductoId == 11)
                    {
                        var nuevoProductoClinicaInsumo = new Producto()
                        {
                            CategoriaId = productoBodega.CategoriaId,
                            MarcaId = productoBodega.MarcaId,
                            GrupoId = productoBodega.GrupoId,
                            TipoBodegaId = 1, // farmacia
                            TipoProductoId = 11, //insumo
                            NombreProducto = productoBodega.NombreProducto,
                            Precio = productoBodega.Precio,
                            Precio_2 = productoBodega.Precio_2,
                            Precio_3 = productoBodega.Precio_3,
                            Precio_4 = productoBodega.Precio_4,
                            Precio_5 = productoBodega.Precio_5,
                            Precio_6 = productoBodega.Precio_6,
                            Precio_7 = productoBodega.Precio_7,
                            PrecioCosto = productoBodega.PrecioCosto,
                            Stock = item.Cantidad,
                            StockInical = item.Cantidad,
                            CodigoReferencia = productoBodega.CodigoReferencia,
                            Imagen = productoBodega.Imagen,
                            Descripcion = productoBodega.Descripcion,
                            ActivoYConcentracion = productoBodega.ActivoYConcentracion,
                            Dosis = productoBodega.Dosis,
                            FechaVencimiento = productoBodega.FechaVencimiento,
                            Eliminado = productoBodega.Eliminado,
                        };

                        _productoRepository.Add(nuevoProductoClinicaInsumo, false);

                    }
                    
                    _productoRepository.SaveChanges();
                    
                }

                else 
                {
                    productoFarmacia.Stock += item.Cantidad;
                    productoFarmacia.StockInical +=  item.Cantidad;

                    _productoRepository.Update(productoFarmacia, false);

                }
            }

             // cambiar el estado a aceptado del traslado
            var user = _userManager.GetUserAsync(HttpContext.User);
            traslado.ResponsableRecibido = user.Result;
            traslado.EstadoTrasladosId = 1; // aceptado
            _trasladosRepository.UpdateTraslado(traslado, false);

            _productoRepository.SaveChanges();
            TempData["Message"] = "¡Se ha modificado con éxito.!";
            return RedirectToAction("Editar", new {id = id});
        }


        public IActionResult Lista(string sortOrder, string buscar, string currentFilter, int? pageNumber)
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

            var lista = _trasladosRepository.PaginacionTrasladosBodegaAFarmacia(sortOrder, buscar, pageNumber, 20);

            return View(lista);
        }

        public IActionResult EnTransito(string sortOrder, string buscar, string currentFilter, int? pageNumber)
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

            var lista = _trasladosRepository.PaginacionEnTransitoBodegaAFarmacia(sortOrder, buscar, pageNumber, 20);

            return View(lista);
        }

        public IActionResult Aceptados(string sortOrder, string buscar, string currentFilter, int? pageNumber)
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

            var lista = _trasladosRepository.PaginacionAceptadosBodegaAFarmacia(sortOrder, buscar, pageNumber, 20);

            return View(lista);
        }

        public IActionResult Faltantes(string sortOrder, string buscar, string currentFilter, int? pageNumber)
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

            var lista = _trasladosRepository.PaginacionFaltantesBodegaAFarmacia(sortOrder, buscar, pageNumber, 20);

            return View(lista);
        }

        public IActionResult Cancelados(string sortOrder, string buscar, string currentFilter, int? pageNumber)
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

            var lista = _trasladosRepository.PaginacionCanceladosBodegaAFarmacia(sortOrder, buscar, pageNumber, 20);

            return View(lista);
        }

        public IActionResult ConProblema(string sortOrder, string buscar, string currentFilter, int? pageNumber)
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

            var lista = _trasladosRepository.PaginacionConProblemaBodegaAFarmacia(sortOrder, buscar, pageNumber, 20);

            return View(lista);
        }
        

        public IActionResult Editar(int? id)
        {
            if(id == null) return StatusCode(404);

            var traslado = _trasladosRepository.GetTraslados((int)id);

            if(traslado == null) return StatusCode(400);

            var model = new TrasladosBaseViewModel()
            {
                TrasladosProductos = traslado
            };


            model.Init(_productoRepository);

            return View(model);
        }

        public JsonResult GuardarModificacionTraslado([FromBody]TrasladosBaseViewModel model)
        {
            if(ModelState.IsValid)
            {
                var listaProductosByTrasladoId = _trasladosRepository.GetListDetalleTrasladoProductos(model.TrasladosDto.Id);

                foreach(var item in listaProductosByTrasladoId)
                {
                    bool flag = false;

                    foreach(var prod in model.DetalleTrasladoProductos)
                    {
                        if(item.Id == prod.Id)
                        {
                            flag = true;
                            break;
                        }
                    }

                    if(!flag)
                    {
                        // hay que regresarlo a invnetario
                        var producto = _productoRepository.Get(item.ProductoId);
                        producto.Stock += item.Cantidad;
                        _productoRepository.Update(producto, false);
                        
                        _trasladosRepository.DeleteDetalleTraslado(item.Id, false);
                    }
                }

                foreach(var item in model.DetalleTrasladosProductosNuevos)
                {
                    var nuevoDetalle = new DetalleTrasladoProductos()
                    {
                        TrasladosProductosId = model.TrasladosDto.Id,
                        ProductoId = item.ProductoId,
                        Cantidad = item.Cantidad
                    };

                    _trasladosRepository.Add(nuevoDetalle, false);

                    // hay que regresarlo a invnetario
                    var producto = _productoRepository.Get(item.ProductoId);
                    producto.Stock -= item.Cantidad;
                    _productoRepository.Update(producto, false);

                }

                foreach(var item in model.DetalleTrasladoProductos)
                {
                    var detalleTrasladoProductos = _trasladosRepository.GetDetalleTrasladoProductos(item.Id);
                   
                    //modificar 
                    // primro hay qu regresar todo para evitar las difrencias
                    // hay que regresarlo a invnetario
                    var producto = _productoRepository.Get(item.ProductoId);
                    producto.Stock += detalleTrasladoProductos.Cantidad;
                    _productoRepository.Update(producto, false);

                     detalleTrasladoProductos.Cantidad = item.Cantidad;
                    _trasladosRepository.UpdateDetalleTrasladoProductos(detalleTrasladoProductos, false);


                    // ahora modificarlos
                    var product = _productoRepository.Get(item.ProductoId);
                    product.Stock -= item.Cantidad;
                    _productoRepository.Update(product, false);
                }

                // var traslado = new TrasladosProductos()
                // {
                //     Id = model.TrasladosDto.Id,
                //     Observaciones = model.TrasladosDto.Observaciones,
                // };

                // _trasladosRepository.UpdateTraslado(traslado, false);

                _trasladosRepository.SaveChanges();
                TempData["Message"] = "¡Se ha modificado con éxito.!";
                return Json(new Object());
            }

            return new JsonErrorResult(new { message = "Ha ocurrido un error de servidor." });
        }

        public IActionResult CambiarAEnTransito(int? trasladoId)
        {
            if(trasladoId == null) return StatusCode(400);

            var traslado = _trasladosRepository.GetTraslados((int)trasladoId);

            if(traslado == null) return StatusCode(404);

            if(traslado.EstadoTrasladosId == 1)
            {
                TempData["Message"] = "¡Error, este registro ya esta registrado como: Aceptado.!";
                return RedirectToAction("Editar", new {id = trasladoId});
            }

             var user = _userManager.GetUserAsync(HttpContext.User);
            traslado.ResponsableRecibido = user.Result;
            traslado.EstadoTrasladosId = 5;

            _trasladosRepository.UpdateTraslado(traslado);

            TempData["Message"] = "¡Se ha modificado con éxito.!";
            return RedirectToAction("Editar", new {id = trasladoId});
        }

        public IActionResult CambiarAFaltantes(int? trasladoId)
        {
            if(trasladoId == null) return StatusCode(400);

            var traslado = _trasladosRepository.GetTraslados((int)trasladoId);

            if(traslado == null) return StatusCode(404);

            if(traslado.EstadoTrasladosId == 1)
            {
                TempData["Message"] = "¡Error, este registro ya esta registrado como: Aceptado.!";
                return RedirectToAction("Editar", new {id = trasladoId});
            }

            var user = _userManager.GetUserAsync(HttpContext.User);
            traslado.ResponsableRecibido = user.Result;
            traslado.EstadoTrasladosId = 4;

            _trasladosRepository.UpdateTraslado(traslado);

            TempData["Message"] = "¡Se ha modificado con éxito.!";
            return RedirectToAction("Editar", new {id = trasladoId});
        }

        public IActionResult CambiarAConProblema(int? trasladoId)
        {
            if(trasladoId == null) return StatusCode(400);

            var traslado = _trasladosRepository.GetTraslados((int)trasladoId);

            if(traslado == null) return StatusCode(404);

            if(traslado.EstadoTrasladosId == 1)
            {
                TempData["Message"] = "¡Error, este registro ya esta registrado como: Aceptado.!";
                return RedirectToAction("Editar", new {id = trasladoId});
            }

             var user = _userManager.GetUserAsync(HttpContext.User);
            traslado.ResponsableRecibido = user.Result;
            traslado.EstadoTrasladosId = 3;

            _trasladosRepository.UpdateTraslado(traslado);

            TempData["Message"] = "¡Se ha modificado con éxito.!";
            return RedirectToAction("Editar", new {id = trasladoId});
        }

        public IActionResult CambiarACancelado(int? trasladoId)
        {
            if(trasladoId == null) return StatusCode(400);

            var traslado = _trasladosRepository.GetTraslados((int)trasladoId);

            if(traslado == null) return StatusCode(404);

            if(traslado.EstadoTrasladosId == 1)
            {
                TempData["Message"] = "¡Error, este registro ya esta registrado como: Aceptado.!";
                return RedirectToAction("Editar", new {id = trasladoId});
            }

            var user = _userManager.GetUserAsync(HttpContext.User);
            traslado.ResponsableRecibido = user.Result;
            traslado.EstadoTrasladosId = 2; // denegado

            _trasladosRepository.UpdateTraslado(traslado);

            TempData["Message"] = "¡Se ha modificado con éxito.!";
            return RedirectToAction("Editar", new {id = trasladoId});
        }

        public JsonResult RetornarItemsAFarmacia(int trasladoId)
        {
            var traslado = _trasladosRepository.GetTraslados((int)trasladoId);

            foreach(var item in traslado.DetalleTrasladoProductos)
            {
                var producto = _productoRepository.Get(item.ProductoId);
                producto.Stock += item.Cantidad;
                _productoRepository.Update(producto, false);
            }

            traslado.ProductosRegresadosAFarmacia = true;
            _trasladosRepository.UpdateTraslado(traslado, false);

            _trasladosRepository.SaveChanges();

            TempData["Message"] = "¡Se han trasnferido con éxito.!";
            return Json(new object());
        }


        [Authorize(Roles = "Administrador, Supervisor")]
        public async Task<IActionResult> Reporte(int? trasladoId)
        {
            if(trasladoId == null) return StatusCode(400);

            var traslado = _trasladosRepository.GetTraslados((int)trasladoId);

            if(traslado == null) return StatusCode(404);

            var user = _userManager.GetUserAsync(HttpContext.User);
            var u = _userRepository.GetbyId(user.Result.Id).Persona.Nombre;

            var model = new TrasladosBaseViewModel()
            {
                TrasladosProductos = traslado,
            };
            
            return await _generatePdf.GetPdf("Views/TrasladosBodegaAFarmacia/Reporte.cshtml", model);
        }

        public async Task<IActionResult> ReporteU(int? trasladoId)
        {
            if(trasladoId == null) return StatusCode(400);

            var traslado = _trasladosRepository.GetTraslados((int)trasladoId);

            if(traslado == null) return StatusCode(404);

            var user = _userManager.GetUserAsync(HttpContext.User);
            var u = _userRepository.GetbyId(user.Result.Id).Persona.Nombre;

            var model = new TrasladosBaseViewModel()
            {
                TrasladosProductos = traslado,
            };
            
            return await _generatePdf.GetPdf("Views/TrasladosBodegaAFarmacia/ReporteU.cshtml", model);
        }
       
    }
}
