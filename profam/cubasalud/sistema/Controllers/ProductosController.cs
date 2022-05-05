using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using sistema.Models;
using Database.Shared.IRepository;
using Database.Shared.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using sistema.Json;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Wkhtmltopdf.NetCore;
using Microsoft.AspNetCore.Identity;
using System.IO.Packaging;
using DocumentFormat.OpenXml;
using OfficeOpenXml;
using IronXL;
using System.Linq;
using System.Globalization;

namespace sistema.Controllers
{
   
    public class ProductosController : Controller
    {
        private readonly IProducto _productosRepository = null;

        private readonly IDespegablesProducto _categoryRepository = null;
        private readonly IPacientes _pacientesRepository = null;
        private readonly ICliente _clienteRepository = null;
        private readonly IGeneratePdf _generatePdf;
        private readonly UserManager<User> _userManager;
        private readonly IUser _userRepository;
        private IWebHostEnvironment _hostEnvironment;
        

        public ProductosController(IDespegablesProducto categoriaRepository, IProducto productosRepository, ICliente clienteRepository, 
        IWebHostEnvironment hostEnvironment, IGeneratePdf generatePdf, UserManager<User> userManager, IUser userRepository
        , IPacientes pacienteRepository)
        {
            _categoryRepository = categoriaRepository;
            _productosRepository = productosRepository;
            _clienteRepository = clienteRepository;
            _hostEnvironment = hostEnvironment;
            _generatePdf = generatePdf;
            _userManager = userManager;
            _userRepository = userRepository;
            _pacientesRepository = pacienteRepository;
        }


        [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
        // string buscar, string currentFilter, int? pageNumber, int? terapeuticoId
        public IActionResult MedicamentosFarmacia(MedicamentosFarmaciaViewModel viewModel)
        {
            
            if (viewModel.buscar != null)
            {
                viewModel.pageNumber = 1;
            }
            else
            {
                viewModel.buscar = viewModel.currentFilter;
            }

            viewModel.currentFilter = viewModel.buscar;
            viewModel.Init(_categoryRepository);
            viewModel.Productos = _productosRepository.PaginacionProductosFarmaciaMedicamentos(viewModel.buscar, viewModel.pageNumber, 25, viewModel.terapeuticoId);
            viewModel.TotalMedicamentos = _productosRepository.GetTotalMedicamentosFarmacia();
            // var grupot = new SelectList(_categoryRepository.ListarGrupoT(), "Id", "NombreGrupoT");
            // ViewData["CurrentFilter"] = viewModel.buscar;
            // ViewData["TerapeuticoId"] = viewModel.terapeuticoId;
            // ViewData["GrupoTLista"] = grupot;
            
            return View(viewModel);
        }

        public async Task<IActionResult> MedicamentosFarmaciaReporte(int terapeuticoId, string currentFilter)
        {
            var productos = _productosRepository.FiltrarPorBusquedaYTerapeutico(currentFilter, terapeuticoId, 1);
            var user = _userManager.GetUserAsync(HttpContext.User);
            var u = _userRepository.GetbyId(user.Result.Id).Persona.Nombre;
            
            var model = new ReportesProductosViewModel()
            {
                Productos = productos,
                Usuario = u
            };

            return await _generatePdf.GetPdf("Views/Productos/MedicamentosFarmaciaReporte.cshtml", model);
        }

        public async Task<IActionResult> InsumosFarmaciaReporte(int categoriaId, string currentFilter)
        {
            var productos = _productosRepository.FiltrarPorBusquedaYCategoria(currentFilter, categoriaId, 1);
            var user = _userManager.GetUserAsync(HttpContext.User);
            var us = _userRepository.GetbyId(user.Result.Id);
            string nombre = "";
            if(us.Persona != null)
                nombre = us.Persona.Nombre;
            
            var model = new ReportesProductosViewModel()
            {
                Productos = productos,
                Usuario = nombre            
            };

            return await _generatePdf.GetPdf("Views/Productos/InsumosFarmaciaReporte.cshtml", model);
        }

        public async Task<IActionResult> MedicamentosClinicaReporte(int terapeuticoId, string currentFilter)
        {
            var productos = _productosRepository.FiltrarPorBusquedaYTerapeutico(currentFilter, terapeuticoId, 2);
            var user = _userManager.GetUserAsync(HttpContext.User);
            var u = _userRepository.GetbyId(user.Result.Id).Persona.Nombre;
            
            var model = new ReportesProductosViewModel()
            {
                Productos = productos,
                Usuario = u
            };

            return await _generatePdf.GetPdf("Views/Productos/MedicamentosClinicaReporte.cshtml", model);
        }

        public async Task<IActionResult> InsumosClinicaReporte(int categoriaId, string currentFilter)
        {
            var productos = _productosRepository.FiltrarPorBusquedaYCategoria(currentFilter, categoriaId, 2);
            var user = _userManager.GetUserAsync(HttpContext.User);
            var u = _userRepository.GetbyId(user.Result.Id).Persona.Nombre;
            
            var model = new ReportesProductosViewModel()
            {
                Productos = productos,
                Usuario = u
            };

            return await _generatePdf.GetPdf("Views/Productos/InsumosClinicaReporte.cshtml", model);
        }
        public async Task<IActionResult> MedicamentosBodegaReporte(int terapeuticoId, string currentFilter)
        {
            var productos = _productosRepository.FiltrarPorBusquedaYTerapeutico(currentFilter, terapeuticoId, 3);
            var user = _userManager.GetUserAsync(HttpContext.User);
            var u = _userRepository.GetbyId(user.Result.Id).Persona.Nombre;
            
            var model = new ReportesProductosViewModel()
            {
                Productos = productos,
                Usuario = u
            };

            return await _generatePdf.GetPdf("Views/Productos/MedicamentosBodegaReporte.cshtml", model);
        }

        public async Task<IActionResult> InsumosBodegaReporte(int categoriaId, string currentFilter)
        {
            var productos = _productosRepository.FiltrarPorBusquedaYCategoria(currentFilter, categoriaId, 3);
            var user = _userManager.GetUserAsync(HttpContext.User);
            var us = _userRepository.GetbyId(user.Result.Id);
            string nombre = "";
            if(us.Persona != null)
                nombre = us.Persona.Nombre;
            
            var model = new ReportesProductosViewModel()
            {
                Productos = productos,
                Usuario = nombre            
            };
            
            return await _generatePdf.GetPdf("Views/Productos/InsumosBodegaReporte.cshtml", model);
        }



        [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
        public IActionResult InsumosMedicosFarmacia(InsumosFarmaciaViewModel viewModel)
        {
            if (viewModel.buscar != null)
            {
                viewModel.pageNumber = 1;
            }
            else
            {
                viewModel.buscar = viewModel.currentFilter;
            }

            viewModel.currentFilter = viewModel.buscar;
            viewModel.Init(_categoryRepository);
            viewModel.Productos = _productosRepository.PaginacionProductosFarmaciaInsumosMedicos(viewModel.buscar, viewModel.pageNumber, 25, viewModel.categoriaId);
            viewModel.TotalInsumos = _productosRepository.GetTotalInsumosFarmacia();
            return View(viewModel);
        }

        [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
        public IActionResult MedicamentosClinica(MedicamentosFarmaciaViewModel viewModel)
        {
            
            if (viewModel.buscar != null)
            {
                viewModel.pageNumber = 1;
            }
            else
            {
                viewModel.buscar = viewModel.currentFilter;
            }

            viewModel.currentFilter = viewModel.buscar;
            viewModel.Init(_categoryRepository);
            viewModel.Productos = _productosRepository.PaginacionProductosClinicaMedicamentos(viewModel.buscar, viewModel.pageNumber, 25, viewModel.terapeuticoId);
            viewModel.TotalMedicamentos = _productosRepository.GetTotalMedicamentosClinica();
            
            return View(viewModel);
        }

        [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
        public IActionResult MedicamentosBodega(MedicamentosFarmaciaViewModel viewModel)
        {
            
            if (viewModel.buscar != null)
            {
                viewModel.pageNumber = 1;
            }
            else
            {
                viewModel.buscar = viewModel.currentFilter;
            }

            viewModel.currentFilter = viewModel.buscar;
            viewModel.Init(_categoryRepository);
            viewModel.Productos = _productosRepository.PaginacionBodegaMedicamentos(viewModel.buscar, viewModel.pageNumber, 25, viewModel.terapeuticoId);
            viewModel.TotalMedicamentos = _productosRepository.GetTotalMedicamentosBodega();
            
            return View(viewModel);
        }

        [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
        public IActionResult InsumosMedicosBodega(InsumosFarmaciaViewModel viewModel)
        {
            if (viewModel.buscar != null)
            {
                viewModel.pageNumber = 1;
            }
            else
            {
                viewModel.buscar = viewModel.currentFilter;
            }

            viewModel.currentFilter = viewModel.buscar;
            viewModel.Init(_categoryRepository);
            viewModel.Productos = _productosRepository.PaginacionProductosBodegaInsumosMedicos(viewModel.buscar, viewModel.pageNumber, 25, viewModel.categoriaId);
            viewModel.TotalInsumos = _productosRepository.GetTotalInsumosBodega();
            return View(viewModel);
        }

        [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
        public IActionResult InsumosMedicosClinica(InsumosFarmaciaViewModel viewModel)
        {
            
            if (viewModel.buscar != null)
            {
                viewModel.pageNumber = 1;
            }
            else
            {
                viewModel.buscar = viewModel.currentFilter;
            }

            viewModel.currentFilter = viewModel.buscar;
            viewModel.Init(_categoryRepository);
            viewModel.TotalInsumos = _productosRepository.GetTotalInsumosClinica();
            viewModel.Productos = _productosRepository.PaginacionProductosClinicaInsumosMedicos(viewModel.buscar, viewModel.pageNumber, 25, viewModel.categoriaId);

            
            return View(viewModel);
        }



       [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
        public IActionResult ListaFaltantesFarmacia(string sortOrder, string buscar, string currentFilter, int? pageNumber)
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

            var lista = _productosRepository.PaginacionProductosFaltantes(sortOrder, buscar, pageNumber, 25);

            return View(lista);
        }

        public async Task<IActionResult> FaltantesFarmacia(string currentFilter)
        {

            var productos = _productosRepository.GetListadoFaltantesFarmacia(currentFilter);
            return await _generatePdf.GetPdf("Views/Productos/FaltantesFarmacia.cshtml", productos);
        }

        [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
        public IActionResult ListaFaltantesClinica(string sortOrder, string buscar, string currentFilter, int? pageNumber)
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

            var lista = _productosRepository.PaginacionProductosFaltantesClinica(sortOrder, buscar, pageNumber, 25);

            return View(lista);
        }

        public async Task<IActionResult> FaltantesClinica(string currentFilter)
        {

            var productos = _productosRepository.GetListadoFaltantesClinica(currentFilter);
            return await _generatePdf.GetPdf("Views/Productos/FaltantesClinica.cshtml", productos);
        }

        [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
         public IActionResult ListaVencimiento(string sortOrder, string buscar, string currentFilter, int? pageNumber)
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

            var lista = _productosRepository.PaginacionProductosVencimiento(sortOrder, buscar, pageNumber, 25);

            return View(lista);
        }

       
        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult NuevoFarmaciaMedicamentos()
        {
            // var cargarCategorias = _categoryRepository.ListarCategorias();

            var modelo = new ProductoBaseViewModel()
            {
                Modificar = true,
            };

            modelo.Init(_categoryRepository);

            return View(modelo);
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult NuevoClinicaMedicamentos()
        {
            // var cargarCategorias = _categoryRepository.ListarCategorias();

            var modelo = new ProductoBaseViewModel()
            {
                Modificar = true,
            };

            modelo.Init(_categoryRepository);

            return View(modelo);
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult NuevoBodegaMedicamentos()
        {
            // var cargarCategorias = _categoryRepository.ListarCategorias();

            var modelo = new ProductoBaseViewModel(){};

            modelo.Init(_categoryRepository);

            return View(modelo);
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult NuevoFarmaciaInsumosMedicos()
        {
            // var cargarCategorias = _categoryRepository.ListarCategorias();

            var modelo = new ProductoInsumosBaseViewModel()
            {
                Modificar = true,
            };

            modelo.Init(_categoryRepository);

            return View(modelo);
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult NuevoClinicaInsumosMedicos()
        {

            var modelo = new ProductoInsumosBaseViewModel()
            {
                Modificar = true,
            };

            modelo.Init(_categoryRepository);

            return View(modelo);
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult NuevoBodegaInsumosMedicos()
        {

            var modelo = new ProductoInsumosBaseViewModel()
            {
                Modificar = true,
            };

            modelo.Init(_categoryRepository);

            return View(modelo);
        }

       

        [Authorize(Roles = "Administrador, Supervisor")]
        [HttpPost]
        public IActionResult NuevoFarmaciaMedicamentos(ProductoBaseViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Producto.TipoBodegaId = 1;
                    model.Producto.TipoProductoId = 10; // Medicamentos
                    _productosRepository.Add(model.Producto);
                    TempData["Message"] = "¡El producto se ha guardado con éxito.!";
                    return RedirectToAction("MedicamentosFarmacia");
                }
                catch (System.Exception)
                {
                    TempData["Message"] = "ERROR, ESTE PRODUCTO YA EXISTE EN ESTA FARMACIA. ";
                    model.Init(_categoryRepository);
                    return View(model);
                }
            }

            model.Init(_categoryRepository);
            return View(model);
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        [HttpPost]
        public IActionResult NuevoClinicaMedicamentos(ProductoBaseViewModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    model.Producto.TipoBodegaId = 2;
                    model.Producto.TipoProductoId = 10; // Medicamentos
                    _productosRepository.Add(model.Producto);
                    TempData["Message"] = "¡El producto se ha guardado con éxito.!";
                    return RedirectToAction("MedicamentosClinica");

                }
                catch (System.Exception)
                {
                    TempData["Message"] = "ERROR, ESTE PRODUCTO YA EXISTE EN ESTA CLINICA. ";
                    model.Init(_categoryRepository);
                    return View(model);
                }
            }

            model.Init(_categoryRepository);
            return View(model);
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        [HttpPost]
        public IActionResult NuevoBodegaMedicamentos(ProductoBaseViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Producto.TipoBodegaId = 3;
                    model.Producto.TipoProductoId = 10; // Medicamentos
                    _productosRepository.Add(model.Producto);
                    TempData["Message"] = "¡El producto se ha guardado con éxito.!";
                    return RedirectToAction("MedicamentosBodega");

                }
                catch (System.Exception)
                {
                    TempData["Message"] = "ERROR, ESTE PRODUCTO YA EXISTE EN ESTA BODEGA. ";
                    model.Init(_categoryRepository);
                    return View(model);
                }
            }

            model.Init(_categoryRepository);
            return View(model);
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        [HttpPost]
        public IActionResult NuevoBodegaInsumosMedicos(ProductoInsumosBaseViewModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    model.Producto.TipoBodegaId = 3;
                    model.Producto.TipoProductoId = 11; // Insumos
                    _productosRepository.Add(model.Producto);
                    TempData["Message"] = "¡El producto se ha guardado con exito.!";
                    return RedirectToAction("InsumosMedicosBodega");
                }
                catch (System.Exception)
                {
                    TempData["Message"] = "ERROR, ESTE PRODUCTO YA EXISTE EN ESTA BODEGA. ";
                    model.Init(_categoryRepository);
                    return View(model);
                }
            }
            model.Init(_categoryRepository);
            return View(model);
        }


        [Authorize(Roles = "Administrador, Supervisor")]
        [HttpPost]
        public IActionResult NuevoFarmaciaInsumosMedicos(ProductoInsumosBaseViewModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    model.Producto.TipoBodegaId = 1;
                    model.Producto.TipoProductoId = 11; // Insumos
                    _productosRepository.Add(model.Producto);
                    TempData["Message"] = "¡El producto se ha guardado con exito.!";
                    return RedirectToAction("InsumosMedicosFarmacia");
                }
                catch (System.Exception)
                {
                    TempData["Message"] = "ERROR, ESTE PRODUCTO YA EXISTE EN ESTA FARMACIA. ";
                    model.Init(_categoryRepository);
                    return View(model);
                }
               
            }

            model.Init(_categoryRepository);
            return View(model);
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        [HttpPost]
        public IActionResult NuevoClinicaInsumosMedicos(ProductoInsumosBaseViewModel model)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    model.Producto.TipoBodegaId = 2;
                    model.Producto.TipoProductoId = 11; // Insumos
                    _productosRepository.Add(model.Producto);
                    TempData["Message"] = "¡El producto se ha guardado con éxito.!";

                    return RedirectToAction("InsumosMedicosClinica");
                }
                catch (System.Exception)
                {
                    TempData["Message"] = "ERROR, ESTE PRODUCTO YA EXISTE EN ESTA CLINICA. ";
                    model.Init(_categoryRepository);
                    return View(model);
                }

                
            }

            model.Init(_categoryRepository);
            return View(model);
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult ModificarMedicamentosFarmacia(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var producto = _productosRepository.Get((int)id);

            if (producto == null)
            {
                return StatusCode(404);
            }

            var modelo = new ProductoBaseViewModel()
            {
                Producto = producto,
            };

            modelo.Init(_categoryRepository);

            return View(modelo);
        }
        
        [Authorize(Roles = "Administrador, Supervisor")]
        [HttpPost]
        public IActionResult ModificarMedicamentosFarmacia(ProductoBaseViewModel model)
        {
             if (ModelState.IsValid)
            {
                try
                {
                    model.Producto.TipoBodegaId = 1;
                    model.Producto.TipoProductoId = 10;
                    _productosRepository.Update(model.Producto);

                    TempData["Message"] = "¡El producto se ha modificado con éxito.!";
                    return RedirectToAction("ModificarMedicamentosFarmacia", new {id = model.Producto.Id});
                }
                catch (System.Exception)
                {
                    TempData["Message"] = "ERROR, ESTE PRODUCTO YA EXISTE EN ESTA FARMACIA. ";
                    model.Init(_categoryRepository);
                    return View(model);
                }
            }

            return View(model);
        }


         [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult ModificarInsumosFarmacia(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var producto = _productosRepository.Get((int)id);

            if (producto == null)
            {
                return StatusCode(404);
            }

            var modelo = new ProductoInsumosBaseViewModel()
            {
                Producto = producto,
            };

            modelo.Init(_categoryRepository);

            return View(modelo);
        }
        
        [Authorize(Roles = "Administrador, Supervisor")]
        [HttpPost]
        public IActionResult ModificarInsumosFarmacia(ProductoInsumosBaseViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Producto.TipoBodegaId = 1;
                    model.Producto.TipoProductoId = 11;
                    _productosRepository.Update(model.Producto);

                    TempData["Message"] = "¡El producto se ha modificado con éxito.!";
                    return RedirectToAction("ModificarInsumosFarmacia", new {id = model.Producto.Id});
                }
                catch (System.Exception)
                {
                    TempData["Message"] = "ERROR, ESTE PRODUCTO YA EXISTE EN ESTA FARMACIA. ";
                    model.Init(_categoryRepository);
                    return View(model);
                }

               
            }

            return View(model);
        }

        public IActionResult ModificarMedicamentosClinica(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var producto = _productosRepository.Get((int)id);

            if (producto == null)
            {
                return StatusCode(404);
            }

            var modelo = new ProductoBaseViewModel()
            {
                Producto = producto,
            };

            modelo.Init(_categoryRepository);

            return View(modelo);
        }


        [Authorize(Roles = "Administrador, Supervisor")]
        [HttpPost]
        public IActionResult ModificarMedicamentosClinica(ProductoBaseViewModel model)
        {
             if (ModelState.IsValid)
            {
                try
                {
                    model.Producto.TipoBodegaId = 2;
                    model.Producto.TipoProductoId = 10;
                    _productosRepository.Update(model.Producto);

                    TempData["Message"] = "¡El producto se ha modificado con éxito.!";
                    return RedirectToAction("ModificarMedicamentosClinica", new {id = model.Producto.Id});
                }
                catch (System.Exception)
                {
                    TempData["Message"] = "ERROR, ESTE PRODUCTO YA EXISTE EN ESTA CLINICA. ";
                    model.Init(_categoryRepository);
                    return View(model);
                }
                   
            }

            return View(model);
        }

        public IActionResult ModificarInsumosMedicosClinica(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var producto = _productosRepository.Get((int)id);

            if (producto == null)
            {
                return StatusCode(404);
            }

            var modelo = new ProductoInsumosBaseViewModel()
            {
                Producto = producto,
            };

            modelo.Init(_categoryRepository);

            return View(modelo);
        }


        [Authorize(Roles = "Administrador, Supervisor")]
        [HttpPost]
        public IActionResult ModificarInsumosMedicosClinica(ProductoInsumosBaseViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Producto.TipoBodegaId = 2;
                    model.Producto.TipoProductoId = 11;
                    _productosRepository.Update(model.Producto);

                    TempData["Message"] = "¡El producto se ha modificado con éxito.!";
                    return RedirectToAction("ModificarInsumosMedicosClinica", new {id = model.Producto.Id});
                }
                catch (System.Exception)
                {
                    TempData["Message"] = "ERROR, ESTE PRODUCTO YA EXISTE EN ESTA CLINICA. ";
                    model.Init(_categoryRepository);
                    return View(model);
                }
            }
            return View(model);
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult ModificarMedicamentosBodega(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var producto = _productosRepository.Get((int)id);

            if (producto == null)
            {
                return StatusCode(404);
            }

            var modelo = new ProductoBaseViewModel()
            {
                Producto = producto,
            };

            modelo.Init(_categoryRepository);

            return View(modelo);
        }
        
        [Authorize(Roles = "Administrador, Supervisor")]
        [HttpPost]
        public IActionResult ModificarMedicamentosBodega(ProductoBaseViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Producto.TipoBodegaId = 3;
                    model.Producto.TipoProductoId = 10;
                    _productosRepository.Update(model.Producto);

                    TempData["Message"] = "¡El producto se ha modificado con éxito.!";
                    return RedirectToAction("ModificarMedicamentosBodega", new {id = model.Producto.Id});
                }
                catch (System.Exception)
                {
                    TempData["Message"] = "ERROR, ESTE PRODUCTO YA EXISTE EN ESTA EN ESTA BODEGA.";
                    model.Init(_categoryRepository);
                    return View(model);
                }
            }

            return View(model);
        }

        
        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult ModificarInsumosBodega(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var producto = _productosRepository.Get((int)id);

            if (producto == null)
            {
                return StatusCode(404);
            }

            var modelo = new ProductoInsumosBaseViewModel()
            {
                Producto = producto,
            };

            modelo.Init(_categoryRepository);

            return View(modelo);
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        [HttpPost]
        public IActionResult ModificarInsumosBodega(ProductoInsumosBaseViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Producto.TipoBodegaId = 3;
                    model.Producto.TipoProductoId = 11;
                    _productosRepository.Update(model.Producto);

                    TempData["Message"] = "¡El producto se ha modificado con éxito.!";
                    return RedirectToAction("ModificarInsumosBodega", new {id = model.Producto.Id});
                }
                catch (System.Exception)
                {
                    TempData["Message"] = "ERROR, ESTE PRODUCTO YA EXISTE EN ESTA BODEGA. ";
                    model.Init(_categoryRepository);
                    return View(model);
                }
            }

            return View(model);
        }



        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult EliminarMedicamentoFarmacia(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var model = _productosRepository.Get((int)id);

            if (model == null)
            {
                return StatusCode(404);
            }

            model.Eliminado = true;
            _productosRepository.Update(model);
            
            TempData["Message"] = "¡El producto se ha eliminado con éxito.!";
            return RedirectToAction("MedicamentosFarmacia");
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult EliminarInsumoFarmacia(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var model = _productosRepository.Get((int)id);

            if (model == null)
            {
                return StatusCode(404);
            }

            model.Eliminado = true;
            _productosRepository.Update(model);
            
            TempData["Message"] = "¡El producto se ha eliminado con éxito.!";
            return RedirectToAction("InsumosMedicosFarmacia");
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult EliminarInsumosClinica(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var model = _productosRepository.Get((int)id);

            if (model == null)
            {
                return StatusCode(404);
            }

            model.Eliminado = true;
            _productosRepository.Update(model);
            
            TempData["Message"] = "¡El producto se ha eliminado con éxito.!";
            return RedirectToAction("InsumosMedicosClinica");
        }

         [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult EliminarMedicamentoClinica(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var model = _productosRepository.Get((int)id);

            if (model == null)
            {
                return StatusCode(404);
            }

            model.Eliminado = true;
            _productosRepository.Update(model);
            
            TempData["Message"] = "¡El producto se ha eliminado con éxito.!";
            return RedirectToAction("MedicamentosClinica");
        }


        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult EliminarProductoClinica(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var model = _productosRepository.Get((int)id);

            if (model == null)
            {
                return StatusCode(404);
            }

            model.Eliminado = true;
            _productosRepository.Update(model);
            
            TempData["Message"] = "¡El producto se ha eliminado con éxito.!";
            return RedirectToAction("ListaClinica");
        }

        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult EliminarMedicamentoBodega(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var model = _productosRepository.Get((int)id);

            if (model == null)
            {
                return StatusCode(404);
            }

            model.Eliminado = true;
            _productosRepository.Update(model);
            
            TempData["Message"] = "¡El producto se ha eliminado con éxito.!";
            return RedirectToAction("MedicamentosBodega");
        }


        [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult EliminarInsumoBodega(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var model = _productosRepository.Get((int)id);

            if (model == null)
            {
                return StatusCode(404);
            }

            model.Eliminado = true;
            _productosRepository.Update(model);
            
            TempData["Message"] = "¡El producto se ha eliminado con éxito.!";
            return RedirectToAction("InsumosMedicosBodega");
        }

         [Authorize(Roles = "Administrador, Supervisor")]
        public IActionResult EliminarCuadricula(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var model = _productosRepository.Get((int)id);

            if (model == null)
            {
                return StatusCode(404);
            }

            model.Eliminado = true;

            _productosRepository.Update(model);
            TempData["Message"] = "¡El producto se ha eliminado con éxito.!";


            return RedirectToAction("ListaCuadricula");
        }

        [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
        public JsonResult RetornarProducto(string codigo)
        {
            // para depurar
            var productoBuscadoList = _productosRepository.GetPorNumeroDeReferenciaList(codigo); 

            var productoBuscado = _productosRepository.GetPorNumeroDeReferencia(codigo);

            if (productoBuscado == null)
            {
                return new JsonErrorResult(new { message = "" });
            }

            return Json(productoBuscado);
        }

        [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
        public JsonResult RetornarProductoClinica(string codigo)
        {
            var productoBuscado = _productosRepository.GetPorNumeroDeReferenciaClinica(codigo);

            if (productoBuscado == null)
            {
                return new JsonErrorResult(new { message = "" });
            }

            return Json(productoBuscado);
        }

        [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
        public JsonResult RetornarProductoById(int id)
        {
            var productoBuscado = _productosRepository.GetProdutoById(id);

            if (productoBuscado == null)
            {
                return new JsonErrorResult(new { message = "" });
            }

            return Json(productoBuscado);
        }

        [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
        public JsonResult RetornarProductoByIdCompras(int id)
        {
            var productoBuscado = _productosRepository.GetProdutoById(id);

            if (productoBuscado == null)
            {
                return new JsonErrorResult(new { message = "" });
            }
            
            var objeto = new {id = productoBuscado.Id, nombreProducto = productoBuscado.NombreProducto, 
                precio = productoBuscado.PrecioCosto};

            return Json(objeto);
        }

         [Authorize(Roles = "Administrador, Supervisor, Vendedor")]

        public JsonResult RetornarProductoCotizacion(string codigo)
        {
            var productoBuscado = _productosRepository.GetPorNumeroDeReferenciayNombre(codigo, false);

            if (productoBuscado == null)
            {
                return new JsonErrorResult(new { message = "" });
            }
            

            return Json(productoBuscado);
        }

         [Authorize(Roles = "Administrador, Supervisor, Vendedor")]

        public JsonResult RetornarProductoLista()
        {
            var productos = _productosRepository.GetListParaCotizacion();
            return Json(productos);
        }

         [Authorize(Roles = "Administrador, Supervisor")]

        public IActionResult Importar()
        {
            return View();
        }


        [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
        public IActionResult ExportarProductos ()
        {
            var productos = _productosRepository.GetList();

            using (var workboook = new XLWorkbook())
            {
                var worksheet = workboook.Worksheets.Add("Productos");
                var row = 1;
                worksheet.Cell(row,1).Value = "CodigoReferencia";
                worksheet.Cell(row,2).Value = "NombreProducto";
                worksheet.Cell(row,3).Value = "Descripcion";
                worksheet.Cell(row,4).Value = "CategoriaId";
                worksheet.Cell(row,5).Value = "PrecioCosto";
                worksheet.Cell(row,6).Value = "PrecioVenta";
                worksheet.Cell(row,7).Value = "PrecioDeFardo";
                worksheet.Cell(row,8).Value = "PrecioClienteEspecial";
                worksheet.Cell(row,9).Value = "PrecioCuentasClave";
                worksheet.Cell(row,10).Value = "PrecioModificable";
                worksheet.Cell(row,11).Value = "PrecioMayorista";    
                worksheet.Cell(row,12).Value = "StockIncial";
                worksheet.Cell(row,13).Value = "Stock";
                worksheet.Cell(row,14).Value = "FechaVencimiento";
                

                foreach (var prod in productos)
                {
                row++;
                worksheet.Cell(row,1).Value = prod.CodigoReferencia;;
                worksheet.Cell(row,2).Value = prod.NombreProducto;
                worksheet.Cell(row,3).Value = prod.Descripcion;
                worksheet.Cell(row,4).Value = prod.ViadminId;
                worksheet.Cell(row,5).Value = prod.PrecioCosto;
                worksheet.Cell(row,6).Value = prod.Precio;
                worksheet.Cell(row,7).Value = prod.Precio_3;
                worksheet.Cell(row,8).Value = prod.Precio_4;
                worksheet.Cell(row,9).Value = prod.Precio_5;
                worksheet.Cell(row,10).Value = prod.Precio_6;
                worksheet.Cell(row,11).Value = prod.Precio_2;    
                worksheet.Cell(row,12).Value = prod.StockInical;
                worksheet.Cell(row,13).Value = prod.Stock;
                worksheet.Cell(row,14).Value = prod.FechaVencimiento;
                
                }

                using (var stream = new MemoryStream())
                {
                    workboook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officefocument.spreadsheet",
                    "Productos.xlsx"
                    );

                }
            }
        }


        public IActionResult VencidosFarmacia(string sortOrder, string buscar, string currentFilter, int? pageNumber)
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

            var lista = _productosRepository.PaginacionVencidosFarmacia(sortOrder, buscar, pageNumber, 35);

            return View(lista);
        }

         public IActionResult ProximosAVencerFarmacia(string sortOrder, string buscar, string currentFilter, int? pageNumber)
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

            var lista = _productosRepository.PaginacionProximosAVencerFarmacia(sortOrder, buscar, pageNumber, 35);

            return View(lista);
        }


        public IActionResult VencidosClinica(string sortOrder, string buscar, string currentFilter, int? pageNumber)
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

            var lista = _productosRepository.PaginacionVencidosClinica(sortOrder, buscar, pageNumber, 25);

            return View(lista);
        }

        public IActionResult ProximosAVencerClinica(string sortOrder, string buscar, string currentFilter, int? pageNumber)
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

            var lista = _productosRepository.PaginacionProximosAVencerClinica(sortOrder, buscar, pageNumber, 25);

            return View(lista);
        }

        public IActionResult ImportarDesdeExcel()
        { 
            IronXL.License.LicenseKey = "IRONXL.RAPH123007.31044-196C95EBA4-HQKBRQ-NRCMJN4U2ESS-V3WHT3FOV3EE-C2BP7NANSYLY-GQSSALBCK5T6-QTJFDBQ2D6TB-NB7IY5-T6HG27VPP5WEUA-DEPLOYMENT.TRIAL-ZRJCLZ.TRIAL.EXPIRES.09.APR.2022";

            bool is_licensed = IronXL.License.IsLicensed;
            ViewBag.Licencia = is_licensed;

            

            return View();
        }

        [HttpPost]
        public IActionResult ImportarDesdeExcel(IFormFile file)
        {
            IronXL.License.LicenseKey = "IRONXL.RAPH123007.31044-196C95EBA4-HQKBRQ-NRCMJN4U2ESS-V3WHT3FOV3EE-C2BP7NANSYLY-GQSSALBCK5T6-QTJFDBQ2D6TB-NB7IY5-T6HG27VPP5WEUA-DEPLOYMENT.TRIAL-ZRJCLZ.TRIAL.EXPIRES.09.APR.2022";

            if(file != null)
            {
                var rootFolder = _hostEnvironment.WebRootPath;
                var filename = "meds.xlsx";
                var filepath = Path.Combine(rootFolder, filename);

                var workbook = WorkBook.Load(filepath);
                var sheet = workbook.WorkSheets[0];
                string val = sheet.Rows[2].Columns[2].Value.ToString();

                for(var y = 2; y <= 121; y++)
                {
                    var cells =  sheet[$"A{y}:M{y}"].ToList();
                    
                    var producto = _productosRepository.GetByName(cells[1].StringValue, false);

                    if(producto != null) continue; // si se repite se salta y no se lee lo que hay abajo

                    // el laboratorio es un texto, asi que si no existe hay que crearlo
                    // var laboratorio = _categoryRepository.GetLaboratorioPorNombre(cells[5].StringValue);
                    Viadmin Viadmin = null;
                    PresentacionProducto presentacion = null;
                    GrupoTProducto GrupoT = null;
                    LaboratorioProducto lab = null;
                    DateTime? fech = null;
                    int stock = 0;
                    decimal PrecioNormal = 0;
                    decimal PrecioFamiliar = 0;
                    decimal PrecioCosto = 0; 

                    // pendiente
                    // if(laboratorio == null)
                    // {
                    //     var nuevoLab = new LaboratorioProducto()
                    //     {
                    //         NombreLaboratorioProducto = cells[5].StringValue
                    //     };                 

                    //     _categoryRepository.Add(nuevoLab, false);
                    //     cells[5].StringValue = nuevoLab.Id.ToString();
                    // }

                    // precio normal
                    if(string.IsNullOrEmpty(cells[7].StringValue))
                    {
                        cells[8].StringValue = "0.00";
                    }

                    // // precio plan familiar
                    // if(string.IsNullOrEmpty(cells[9].StringValue))
                    // {
                    //     cells[9].StringValue = "0.00";
                    // }

                    // precio costo
                    if(string.IsNullOrEmpty(cells[8].StringValue))
                    {
                        cells[10].StringValue = "0.00";
                    }

                    // if(string.IsNullOrEmpty(cells[11].StringValue))
                    // {
                    //     fech = null;
                    // }
                    // else 
                    // {
                    //     var fecha = cells[11].StringValue;
                    //     var partesFecha = fecha.Split('-','.',',',' ').ToList();
                    //     partesFecha.Insert(1,"01");
                    //     var fechaNueva = string.Join("-", partesFecha);
                        
                    //     fech = Convert.ToDateTime(fechaNueva);
                    // }

                    // // viAdmin
                    // if(!string.IsNullOrEmpty(cells[2].StringValue))
                    // {
                    //     Viadmin = Convert.ToInt32(cells[2].StringValue);
                    // }

                    var viadminn = _categoryRepository.GetViadminByname(cells[2].StringValue);

                    if(viadminn == null)
                    {
                        var nuevaViadmin = new Viadmin()
                        {
                            NombreViadmin = cells[2].StringValue
                        };

                        _categoryRepository.Add(nuevaViadmin);

                        Viadmin = nuevaViadmin;
                    }
                    else {
                        Viadmin = viadminn;
                    }

                    // // Presentacion
                    // if(!string.IsNullOrEmpty(cells[3].StringValue))
                    // {
                    //     Presentacion = Convert.ToInt32(cells[3].StringValue);
                    // }

                    var pres = _categoryRepository.GetPresentacionProductoByName(cells[3].StringValue);

                    if(pres == null)
                    {
                        var nuevapres = new PresentacionProducto()
                        {
                            PresentProducto = cells[3].StringValue
                        };

                        _categoryRepository.Add(nuevapres);

                        presentacion = nuevapres;
                    }
                    else {
                        presentacion = pres;
                    }

                    // // GrupoTerapeutico
                    // if(!string.IsNullOrEmpty(cells[4].StringValue))
                    // {
                    //     GrupoT = Convert.ToInt32(cells[4].StringValue);
                    // }

                    var grupot = _categoryRepository.GetGrupoTProductoByName(cells[4].StringValue);

                    if(grupot == null)
                    {
                        var nuevotrupot = new GrupoTProducto()
                        {
                            NombreGrupoT = cells[4].StringValue
                        };

                        _categoryRepository.Add(nuevotrupot);

                        GrupoT = nuevotrupot;
                    }
                    else {
                        GrupoT = grupot;
                    }

                    // // Laboratorio
                    // if(!string.IsNullOrEmpty(cells[5].StringValue))
                    // {
                    //     lab = Convert.ToInt32(cells[5].StringValue);
                    // }

                    var labs = _categoryRepository.GetLaboratorioProductoByName(cells[5].StringValue);

                    if(labs == null)
                    {
                        var nuevolabs = new LaboratorioProducto()
                        {
                            NombreLaboratorioProducto = cells[5].StringValue
                        };

                        _categoryRepository.Add(nuevolabs);

                        lab = nuevolabs;
                    }
                    else {
                        lab = labs;
                    }

                    // stock
                    if(!string.IsNullOrEmpty(cells[6].StringValue))
                    {
                        stock = Convert.ToInt32(cells[6].StringValue);
                    }

                    // precio normal
                    if(!string.IsNullOrEmpty(cells[7].StringValue))
                    {
                        PrecioNormal = Convert.ToDecimal(cells[7].StringValue);
                    }

                    // // precio familiar
                    // if(!string.IsNullOrEmpty(cells[9].StringValue))
                    // {
                    //     PrecioFamiliar = Convert.ToDecimal(cells[9].StringValue);
                    // }

                    // precio costo
                    if(!string.IsNullOrEmpty(cells[8].StringValue))
                    {
                        PrecioCosto = Convert.ToDecimal(cells[8].StringValue);
                    }

                    var medicamentoFarmacia = new Producto()
                    {
                        CodigoReferencia = cells[0].StringValue,
                        NombreProducto = cells[1].StringValue,
                        Viadmin =  Viadmin,
                        PresentacionProducto = presentacion,
                        GrupoTProducto = GrupoT,
                        LaboratorioProducto = lab,
                        Stock = stock,
                        ActivoYConcentracion = cells[9].StringValue,
                        Dosis = cells[10] == null ? "" : cells[10].StringValue,
                        Precio_5 = PrecioNormal,
                        PrecioCosto = PrecioCosto,
                        TipoBodegaId = 2,
                        TipoProductoId = 10,
                    };

                        _productosRepository.Add(medicamentoFarmacia, false);
                }

                _productosRepository.SaveChanges();
                TempData["Message"] = "OK";
                return View();
            
                
            }

            return View();
        }


        public IActionResult ImportarDesdeExcelPacientes()
        { 
            IronXL.License.LicenseKey = "IRONXL.RAPH123007.31044-196C95EBA4-HQKBRQ-NRCMJN4U2ESS-V3WHT3FOV3EE-C2BP7NANSYLY-GQSSALBCK5T6-QTJFDBQ2D6TB-NB7IY5-T6HG27VPP5WEUA-DEPLOYMENT.TRIAL-ZRJCLZ.TRIAL.EXPIRES.09.APR.2022";

            bool is_licensed = IronXL.License.IsLicensed;
            ViewBag.Licencia = is_licensed;

            return View();
        }

        [HttpPost]
        public IActionResult ImportarDesdeExcelPacientes(IFormFile file)
        {
            IronXL.License.LicenseKey = "IRONXL.RAPH123007.31044-196C95EBA4-HQKBRQ-NRCMJN4U2ESS-V3WHT3FOV3EE-C2BP7NANSYLY-GQSSALBCK5T6-QTJFDBQ2D6TB-NB7IY5-T6HG27VPP5WEUA-DEPLOYMENT.TRIAL-ZRJCLZ.TRIAL.EXPIRES.09.APR.2022";

            if(file != null)
            {
                var rootFolder = _hostEnvironment.WebRootPath;
                var filename = "pacientes.xlsx";
                var filepath = Path.Combine(rootFolder, filename);

                var workbook = WorkBook.Load(filepath);
                var sheet = workbook.WorkSheets[0];
                string val = sheet.Rows[2].Columns[2].Value.ToString();

                for(var y = 2; y <= 24; y++)
                {
                    var cells =  sheet[$"A{y}:H{y}"].ToList();
                    
                    // var producto = _productosRepository.GetByName(cells[1].StringValue, false);

                    // if(producto != null) continue; // si se repite se salta y no se lee lo que hay abajo

                    // el laboratorio es un texto, asi que si no existe hay que crearlo
                    // var laboratorio = _categoryRepository.GetLaboratorioPorNombre(cells[5].StringValue);
                    // Viadmin Viadmin = null;
                    // PresentacionProducto presentacion = null;
                    // GrupoTProducto GrupoT = null;
                    // LaboratorioProducto lab = null;
                    // DateTime? fech = null;
                    // int stock = 0;
                    // decimal PrecioNormal = 0;
                    // decimal PrecioFamiliar = 0;
                    // decimal PrecioCosto = 0; 

                    // pendiente
                    // if(laboratorio == null)
                    // {
                    //     var nuevoLab = new LaboratorioProducto()
                    //     {
                    //         NombreLaboratorioProducto = cells[5].StringValue
                    //     };                 

                    //     _categoryRepository.Add(nuevoLab, false);
                    //     cells[5].StringValue = nuevoLab.Id.ToString();
                    // }

                    // precio normal
                    // if(string.IsNullOrEmpty(cells[7].StringValue))
                    // {
                    //     cells[8].StringValue = "0.00";
                    // }

                    // // precio plan familiar
                    // if(string.IsNullOrEmpty(cells[9].StringValue))
                    // {
                    //     cells[9].StringValue = "0.00";
                    // }

                    // precio costo
                    // if(string.IsNullOrEmpty(cells[8].StringValue))
                    // {
                    //     cells[10].StringValue = "0.00";
                    // }

                    // if(string.IsNullOrEmpty(cells[11].StringValue))
                    // {
                    //     fech = null;
                    // }
                    // else 
                    // {
                    //     var fecha = cells[11].StringValue;
                    //     var partesFecha = fecha.Split('-','.',',',' ').ToList();
                    //     partesFecha.Insert(1,"01");
                    //     var fechaNueva = string.Join("-", partesFecha);
                        
                    //     fech = Convert.ToDateTime(fechaNueva);
                    // }

                    // // viAdmin
                    // if(!string.IsNullOrEmpty(cells[2].StringValue))
                    // {
                    //     Viadmin = Convert.ToInt32(cells[2].StringValue);
                    // }

                    // var viadminn = _categoryRepository.GetViadminByname(cells[2].StringValue);

                    // if(viadminn == null)
                    // {
                    //     var nuevaViadmin = new Viadmin()
                    //     {
                    //         NombreViadmin = cells[2].StringValue
                    //     };

                    //     _categoryRepository.Add(nuevaViadmin);

                    //     Viadmin = nuevaViadmin;
                    // }
                    // else {
                    //     Viadmin = viadminn;
                    // }

                    // // Presentacion
                    // if(!string.IsNullOrEmpty(cells[3].StringValue))
                    // {
                    //     Presentacion = Convert.ToInt32(cells[3].StringValue);
                    // }

                    // var pres = _categoryRepository.GetPresentacionProductoByName(cells[3].StringValue);

                    // if(pres == null)
                    // {
                    //     var nuevapres = new PresentacionProducto()
                    //     {
                    //         PresentProducto = cells[3].StringValue
                    //     };

                    //     _categoryRepository.Add(nuevapres);

                    //     presentacion = nuevapres;
                    // }
                    // else {
                    //     presentacion = pres;
                    // }

                    // // GrupoTerapeutico
                    // if(!string.IsNullOrEmpty(cells[4].StringValue))
                    // {
                    //     GrupoT = Convert.ToInt32(cells[4].StringValue);
                    // }

                    // var grupot = _categoryRepository.GetGrupoTProductoByName(cells[4].StringValue);

                    // if(grupot == null)
                    // {
                    //     var nuevotrupot = new GrupoTProducto()
                    //     {
                    //         NombreGrupoT = cells[4].StringValue
                    //     };

                    //     _categoryRepository.Add(nuevotrupot);

                    //     GrupoT = nuevotrupot;
                    // }
                    // else {
                    //     GrupoT = grupot;
                    // }

                    // // Laboratorio
                    // if(!string.IsNullOrEmpty(cells[5].StringValue))
                    // {
                    //     lab = Convert.ToInt32(cells[5].StringValue);
                    // }

                    // var labs = _categoryRepository.GetLaboratorioProductoByName(cells[5].StringValue);

                    // if(labs == null)
                    // {
                    //     var nuevolabs = new LaboratorioProducto()
                    //     {
                    //         NombreLaboratorioProducto = cells[5].StringValue
                    //     };

                    //     _categoryRepository.Add(nuevolabs);

                    //     lab = nuevolabs;
                    // }
                    // else {
                    //     lab = labs;
                    // }

                    // // stock
                    // if(!string.IsNullOrEmpty(cells[6].StringValue))
                    // {
                    //     stock = Convert.ToInt32(cells[6].StringValue);
                    // }

                    // precio normal
                    // if(!string.IsNullOrEmpty(cells[7].StringValue))
                    // {
                    //     PrecioNormal = Convert.ToDecimal(cells[7].StringValue);
                    // }

                    // // precio familiar
                    // if(!string.IsNullOrEmpty(cells[9].StringValue))
                    // {
                    //     PrecioFamiliar = Convert.ToDecimal(cells[9].StringValue);
                    // }

                    // precio costo
                    // if(!string.IsNullOrEmpty(cells[8].StringValue))
                    // {
                    //     PrecioCosto = Convert.ToDecimal(cells[8].StringValue);
                    // }

                    var nuevoPaciente = new Paciente()
                    {
                        Nombre = cells[0].StringValue,
                        Celular = cells[2].StringValue,
                        Nit =  cells[3].StringValue,
                        Direccion = cells[4].StringValue,
                        SexoId = cells[6].StringValue == "F" ? 2 : 1,
                    };
                    
                    _pacientesRepository.Add(nuevoPaciente, false);
                }

                _productosRepository.SaveChanges();
                TempData["Message"] = "OK";
                return View();
            
                
            }

            return View();
        }

        

        public IActionResult ImportarDesdeExcelInsumos()
        { 
            IronXL.License.LicenseKey = "IRONXL.RAPH123007.31044-196C95EBA4-HQKBRQ-NRCMJN4U2ESS-V3WHT3FOV3EE-C2BP7NANSYLY-GQSSALBCK5T6-QTJFDBQ2D6TB-NB7IY5-T6HG27VPP5WEUA-DEPLOYMENT.TRIAL-ZRJCLZ.TRIAL.EXPIRES.09.APR.2022";

            bool is_licensed = IronXL.License.IsLicensed;
            ViewBag.Licencia = is_licensed;

            

            return View();
        }

        [HttpPost]
        public IActionResult ImportarDesdeExcelInsumos(IFormFile file)
        {
            IronXL.License.LicenseKey = "IRONXL.RAPH123007.31044-196C95EBA4-HQKBRQ-NRCMJN4U2ESS-V3WHT3FOV3EE-C2BP7NANSYLY-GQSSALBCK5T6-QTJFDBQ2D6TB-NB7IY5-T6HG27VPP5WEUA-DEPLOYMENT.TRIAL-ZRJCLZ.TRIAL.EXPIRES.09.APR.2022";

            if(file != null)
            {
                var rootFolder = _hostEnvironment.WebRootPath;
                var filename = "invprods.xlsx";
                var filepath = Path.Combine(rootFolder, filename);

                var workbook = WorkBook.Load(filepath);
                var sheet = workbook.WorkSheets[0];
                string val = sheet.Rows[2].Columns[2].Value.ToString();

                for(var y = 2; y <= 121; y++)
                {
                    var cells =  sheet[$"A{y}:M{y}"].ToList();

                    // el laboratorio es un texto, asi que si no existe hay que crearlo
                    // var laboratorio = _categoryRepository.GetLaboratorioPorNombre(cells[5].StringValue);
                    Categoria categoria = null;
                    PresentacionProducto presentacion = null;
                    Grupo grupo = null;
                    int stock = 0;
                    Marca marca = null;
                    decimal precioNormal = 0;


                    // precio normal
                    if(string.IsNullOrEmpty(cells[7].StringValue))
                    {
                        cells[7].StringValue = "0.00";
                    }


                    // // Categoria
                    // if(!string.IsNullOrEmpty(cells[2].StringValue))
                    // {
                    //     categoria = Convert.ToInt32(cells[2].StringValue);
                    // }

                    // chequear si existe la categoria, sino crearla.
                    var cat = _categoryRepository.GetCategoriaByName(cells[2].StringValue);

                    if(cat == null)
                    {
                        var nuevacat = new Categoria()
                        {
                            NombreCategoria = cells[2].StringValue
                        };

                        _categoryRepository.Add(nuevacat);

                        categoria = nuevacat;
                    }
                    else {
                        categoria = cat;
                    }
                    

                    // // Presentacion
                    // if(!string.IsNullOrEmpty(cells[5].StringValue))
                    // {
                    //     presentacion = Convert.ToInt32(cells[5].StringValue);
                    // }

                    var pres = _categoryRepository.GetPresentacionProductoByName(cells[5].StringValue);

                    if(pres == null)
                    {
                        var nuevapres = new PresentacionProducto()
                        {
                            PresentProducto = cells[5].StringValue
                        };

                        _categoryRepository.Add(nuevapres);

                        presentacion = nuevapres;
                    }
                    else {
                        presentacion = pres;
                    }

                    // // grupo
                    // if(!string.IsNullOrEmpty(cells[4].StringValue))
                    // {
                    //     grupo = Convert.ToInt32(cells[4].StringValue);
                    // }

                    var grup = _categoryRepository.GetGrupoByName(cells[4].StringValue);

                    if(pres == null)
                    {
                        var nuevogrupo = new Grupo()
                        {
                            NombreGrupo = cells[4].StringValue
                        };

                        _categoryRepository.Add(nuevogrupo);

                        grupo = nuevogrupo;
                    }
                    else {
                        grupo = grup;
                    }


                    // stock
                    if(!string.IsNullOrEmpty(cells[6].StringValue))
                    {
                        stock = Convert.ToInt32(cells[6].StringValue);
                    }

                    // // marca
                    // if(!string.IsNullOrEmpty(cells[3].StringValue))
                    // {
                    //     marca = Convert.ToInt32(cells[3].StringValue);
                    // }

                    var marc = _categoryRepository.GetMarcaByName(cells[3].StringValue);

                    if(marc == null)
                    {
                        var nuevaMarca = new Marca()
                        {
                            NombreMarca = cells[3].StringValue
                        };

                        _categoryRepository.Add(nuevaMarca);

                        marca = nuevaMarca;
                    }
                    else {
                        marca = marc;
                    }

                    // precio normal
                    if(!string.IsNullOrEmpty(cells[7].StringValue))
                    {
                        precioNormal = Convert.ToDecimal(cells[7].StringValue);
                    }

                    var nuevoInsumo = new Producto()
                    {
                        CodigoReferencia = cells[0].StringValue,
                        NombreProducto = cells[1].StringValue,
                        Categoria =  categoria,
                        PresentacionProducto = presentacion,
                        Grupo = grupo,
                        Stock = stock,
                        Marca = marca,
                        Precio_5 = precioNormal,
                        TipoBodegaId = 2,
                        TipoProductoId = 11,
                    };

                        _productosRepository.Add(nuevoInsumo, false);
                }

                _productosRepository.SaveChanges();
                TempData["Message"] = "OK";
                return View();
            
                
            }

            return View();
        }

        public JsonResult GetProductosByLaboratorioId(int? laboratorioId)
        {
            if(laboratorioId == null) return Json(_productosRepository.GetProductosLaboratorio());
            return Json(_productosRepository.GetProductosByLaboratorioId((int)laboratorioId));
        }

        // temporal eliminar pls
        public IActionResult ImportarMedicamentosFarmaciaABodega()
        {
            var listaProductosFarmacia = _productosRepository.GetMedicamentosFarmaciaList();
            // crear nuevo objeto para insertarlo a bodega

            foreach(var item in listaProductosFarmacia)
            {
                var nuevoProducto = new Producto()
                {
                    CodigoReferencia = item.CodigoReferencia,
                    NombreProducto = item.NombreProducto,
                    ViadminId =  item.ViadminId,
                    PresentacionProductoId = item.PresentacionProductoId,
                    GrupoTProductoId = item.GrupoTProductoId,
                    LaboratorioProductoId = item.LaboratorioProductoId,
                    Stock = 0,
                    ActivoYConcentracion = item.ActivoYConcentracion,
                    Precio_5 = item.Precio_5,
                    Precio_6 = item.Precio_6,

                    PrecioCosto = item.PrecioCosto,
                    FechaVencimiento = item.FechaVencimiento,
                    TipoBodegaId = 3, // a bodega
                    TipoProductoId = 10, // medicamento
                    Eliminado = false
                };

                _productosRepository.Add(nuevoProducto, false);
            }

            _productosRepository.SaveChanges();

             TempData["Message"] = "OK";
            return View();
        }


    }
}
