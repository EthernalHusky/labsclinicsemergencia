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
using System.IO;
using Microsoft.AspNetCore.Hosting;
using sistema.Json;
using Microsoft.AspNetCore.Authorization;

namespace sistema.Controllers
{
    [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
    public class ServicioController : Controller
    {
        private readonly IServicio _servicioRepository = null;


       // private string _dir;

        public ServicioController(IServicio servicioRepository)
        {
            _servicioRepository = servicioRepository;
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

            var lista = _servicioRepository.PaginacionServicios(sortOrder, buscar, pageNumber, 15);

            return View(lista);
        }

        public IActionResult Nuevo()
        {

            // var cargarCategorias = _categoryRepository.ListarCategorias();

            var modelo = new ServicioBaseViewModel()
            {
            };


            return View(modelo);
        }

        [HttpPost]
        public IActionResult Nuevo(ServicioBaseViewModel model)//, IFormFile file)
        {


            if (ModelState.IsValid)
            {
                var servicio = model.Servicio;

                _servicioRepository.Add(servicio);
                TempData["Message"] = "¡El Servicio se ha guardado con exito.!";

                return RedirectToAction("Lista");
            }

            return View(model);
        }

        public IActionResult Modificar(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var servicio = _servicioRepository.Get((int)id);

            if (servicio == null)
            {
                return StatusCode(404);
            }

            var modelo = new ServicioBaseViewModel()
            {
                Servicio = servicio,
                Modificar=false,
            };


            return View(modelo);
        }

        [HttpPost]
        public IActionResult Modificar(ServicioBaseViewModel model)
        {
            if (ModelState.IsValid)
            {

                _servicioRepository.Update(model.Servicio);
                TempData["Message"] = "¡El servicio se ha modificado con exito.!";
                return RedirectToAction("Lista");
            }

            return View(model);
        }

         public IActionResult Eliminar(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var model = _servicioRepository.Get((int)id);

             if (model == null)
            {
                return StatusCode(404);
            }

            model.Eliminado=true;
                
            _servicioRepository.Update(model);
            TempData["Message"] = "¡El Servicio se ha eliminado con exito.!";
               
            return RedirectToAction("Lista");
        }

        public JsonResult RetornarServicios(string id)
        {
            var servicioBuscado = _servicioRepository.Get(Convert.ToInt16(id));

            if(servicioBuscado == null)
            {
                return new JsonErrorResult(new { message = ""});
            }

            var objetos = new {id = servicioBuscado.Id, nombreServicio = servicioBuscado.NombreServicio, precio = servicioBuscado.Precio};

            return Json(objetos);
        }

        public JsonResult RetornarServiciosPorNombre(string nombre)
        {
            var servicioBuscado = _servicioRepository.GetNombre(nombre);

            if(servicioBuscado == null)
            {
                return new JsonErrorResult(new { message = ""});
            }

            return Json(servicioBuscado);
        }
       
    }
}