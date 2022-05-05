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

namespace sistema.Controllers
{
   [Authorize(Roles = "Administrador, Supervisor, Vendedor")]
    public class PacientesController : Controller
    {
        private readonly IPacientes _pacientesRepository = null;

        public PacientesController(IPacientes pacientesRepository)
        {
            _pacientesRepository = pacientesRepository;
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

            var lista = _pacientesRepository.PaginacionClientes(sortOrder, buscar, pageNumber, 30);

            return View(lista);
        }

        public IActionResult Nuevo()
        {
            var model = new PacientesBaseViewModel();
            model.Init(_pacientesRepository);
            return View(model);
        }

        [HttpPost]
        public IActionResult Nuevo(PacientesBaseViewModel model)
        {
            if(ModelState.IsValid)
            {
                _pacientesRepository.Add(model.Paciente);
                TempData["Message"] = "¡El paciente se ha guardado con éxito.!";
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

            var cliente = _pacientesRepository.Get((int)id);

            if (cliente == null)
            {
                return StatusCode(404);
            }

            var model = new PacientesBaseViewModel()
            {
                Paciente = cliente
            };

            model.Init(_pacientesRepository);

            return View(model);
        }

        [HttpPost]
        public IActionResult Modificar(PacientesBaseViewModel model)
        {
            if (ModelState.IsValid)
            {
                _pacientesRepository.Update(model.Paciente);
                TempData["Message"] = "¡El paciente se ha modificado con exito.!";
                return RedirectToAction("Lista");
            }

            model.Init(_pacientesRepository);
            return View(model.Paciente);
        }

         public IActionResult Eliminar(int? id)
        {
            if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var model = _pacientesRepository.Get((int)id);

            
            if (model == null)
            {
                return StatusCode(404);
            }

            model.Eliminado=true;
                
            _pacientesRepository.Update(model);
            TempData["Message"] = "¡El paciente se ha eliminado con exito.!";
            return RedirectToAction("Lista");
        }

        public JsonResult RetornarCliente(string nombre)
        {
            var clientebuscado = _pacientesRepository.GetPacientePorNombre(nombre);
            return Json(clientebuscado);
        }

        public JsonResult RetornarPacienteById(int id)
        {
            var pacientebuscado = _pacientesRepository.GetPacientePorId(id);

            // if(clientebuscado == null)
            // {
            //     return new JsonErrorResult(new { message = ""});
            // }

            return Json(pacientebuscado);
        }


    }
}
