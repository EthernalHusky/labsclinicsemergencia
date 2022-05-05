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
    // [Authorize(Roles = "Administrador, Supervisor")]
    [AllowAnonymous]
    public class EmpleadoController : Controller
    {


        private readonly IEmpleado _empleadoRepository = null;

        public EmpleadoController(IEmpleado empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }

        public IActionResult Lista(string sortOrder, string buscar, string currentFilter, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["ApellidoSortParam"] = string.IsNullOrEmpty(sortOrder) ? "Apellido_desc" : "";
            ViewData["NombreSortParam"] = string.IsNullOrEmpty(sortOrder) ? "Nombre_desc" : "";

            if (buscar != null)
            {
                pageNumber = 1;
            }
            else
            {
                buscar = currentFilter;
            }

            ViewData["CurrentFilter"] = buscar;

            var lista = _empleadoRepository.PaginacionEmpleados(sortOrder, buscar, pageNumber, 10);

            return View(lista);
        }

        public IActionResult Nuevo()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Nuevo(Empleado model, IFormFile file)
        {
            // var _dir = "wwwroot/images/empleados";
            // var filename = Path.GetFileNameWithoutExtension(file.FileName) + Guid.NewGuid().ToString();
            // var fileextencion = Path.GetExtension(file.FileName);

            // using (var fileStream = new FileStream(Path.Combine(_dir, filename + fileextencion), FileMode.Create, FileAccess.Write))
            // {

            //     file.CopyTo(fileStream);
            // }

           // var empleado = model;
           // empleado.Imagen = filename + fileextencion;

            if (ModelState.IsValid)
            {
                _empleadoRepository.Add(model);
                TempData["Message"] = "¡El empleado se ha guardado con exito.!";

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

            var empleado = _empleadoRepository.Get((int)id);

            if (empleado == null)
            {
                return StatusCode(404);
            }

            var model = new EmpleadoBaseViewModel()
            {
                Empleado = empleado,
            };


            return View(model.Empleado);
        }

        [HttpPost]
        public IActionResult Modificar(Empleado model, IFormFile file)
        {
           // var empleado = _empleadoRepository.Get(model.Id);
            //var _dir = "wwwroot/images/empleados";

            // if (file != null)
            // {
            //     if (empleado.Imagen != null)
            //     {
            //         var current = Path.Combine(_dir, empleado.Imagen);
            //         if (System.IO.File.Exists(current))
            //         {
            //             System.IO.File.Delete(current);
            //         }
            //     }


            // }


            // var filename = Path.GetFileNameWithoutExtension(file.FileName) + Guid.NewGuid().ToString();
            // var fileextencion = Path.GetExtension(file.FileName).ToString();


           // empleado.Imagen = filename + fileextencion;

            if (ModelState.IsValid)
            {

                _empleadoRepository.Update(model);

                // using (var fileStream = new FileStream(Path.Combine(_dir, filename + fileextencion), FileMode.Create, FileAccess.Write))
                // {

                //     file.CopyTo(fileStream);
                // }


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

            var model = _empleadoRepository.Get((int)id);

            if (model == null)
            {
                return StatusCode(404);
            }

            model.Eliminado = true;

            _empleadoRepository.Update(model);
            TempData["Message"] = "¡El empleado se ha modificado con exito.!";

            return RedirectToAction("Lista");
        }

    }
}
