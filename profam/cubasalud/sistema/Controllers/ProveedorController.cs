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
using Microsoft.AspNetCore.Authorization;


namespace sistema.Controllers
{
    [Authorize(Roles = "Administrador, Supervisor")]
    public class ProveedorController : Controller
    {
   

        private readonly IProveedor _proveedorRepository = null;

        public ProveedorController(IProveedor proveedorRepository)
        {
           _proveedorRepository=proveedorRepository;
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

            var lista = _proveedorRepository.PaginacionProveedores(sortOrder, buscar, pageNumber, 10);

            return View(lista);
        }

        public IActionResult Nuevo()
        {
           var modelo = new ProveedorBaseViewModel()
            {
              
            };

            modelo.Init(_proveedorRepository);

            return View(modelo);
        }

        [HttpPost]
       public IActionResult Nuevo(ProveedorBaseViewModel model)
        {
         
            if(ModelState.IsValid)
            {
                var proveedor = model.Proveedor;
                _proveedorRepository.Add(proveedor);
                TempData["Message"] = "¡El proveedor se ha guardado con exito.!";
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
            
            var proveedor = _proveedorRepository.Get((int)id);

            if (proveedor == null)
            {
                return StatusCode(404);
            }

            var model = new ProveedorBaseViewModel(){
                Proveedor = proveedor,
            };

            model.Init(_proveedorRepository);

            return View(model);
        }

        [HttpPost]
        public IActionResult Modificar(ProveedorBaseViewModel model)
        {
            if (ModelState.IsValid)
            {
                _proveedorRepository.Update(model.Proveedor);
                TempData["Message"] = "¡El proveedor se ha modificado con exito.!";
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

            var model = _proveedorRepository.Get((int)id);

             if (model == null)
            {
                return StatusCode(404);
            }

            model.Eliminado=true;
                
            _proveedorRepository.Update(model);
            TempData["Message"] = "¡El proveedor se ha eliminado con exito.!";
               
            return RedirectToAction("Lista");
        }


    }
}
