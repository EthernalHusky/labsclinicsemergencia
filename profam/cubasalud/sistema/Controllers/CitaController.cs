using System;
using Microsoft.AspNetCore.Mvc;
using sistema.Models;
using Database.Shared.Data;
using Database.Shared.IRepository;
using Database.Shared.Models;
using sistema.Json;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Wkhtmltopdf.NetCore;

namespace sistema.Controllers
{
    public class CitaController : Controller
    {
        private readonly ICitas _citasRepository = null;
        // private readonly ICliente _clienteRepository = null;
        private readonly IEmpleado _empleadoRepository = null;
        private readonly IServicio _servicioRepository = null;
        private readonly IUser _userRepository = null;
        private readonly UserManager<User> _userManager = null;
        private readonly IGeneratePdf _generatePdf;
        private readonly IPacientes _pacienteRepository = null;


        public CitaController(ICitas citasRepository, IPacientes pacientesRepository, IEmpleado empleadoRepository, 
        IServicio servicioRepository, UserManager<User> userManager, IUser userRepositry, IGeneratePdf generatePDF)
        {
            _citasRepository = citasRepository;
            _pacienteRepository = pacientesRepository;
            _empleadoRepository = empleadoRepository;
            _servicioRepository = servicioRepository;
            _userManager = userManager;
            _userRepository = userRepositry;
            _generatePdf = generatePDF;
        }

        // public IActionResult Index()
        // {
        //     var lista = _citasRepository.GetList();

        //     var model = new CitasSchedulerViewModel()
        //     {
        //         CitasList = lista,
        //     };

        //     return View(model);
        // }


        // public JsonResult NuevaCita([FromBody]CitasSchedulerViewModel model)
        // {
        //     if(ModelState.IsValid)
        //     {
        //         var cita = new Cita()
        //         {
        //             FechaInicio = model.Cita.FechaInicio,
        //             FechaFinal = model.Cita.FechaFinal,
        //         };

        //         _citasRepository.Add(cita);
        //         return Json(cita.Id);
        //     }
        //    return new JsonErrorResult(new { message = "Ha ocurrido un error de servidor. Por favor intente más tarde." });
        // }

        public IActionResult NuevaCitaAgendarOtraConMismaFecha(string fecha)
        {
            var fechaYHora = Convert.ToDateTime(fecha);

            var model = new CitaBaseViewModel()
            {
                HoraYFecha = fechaYHora
            };

            return View(model);
        }


        public JsonResult EliminarCita(int? id, DateTime fecha)
        {
            if(id == null) return new JsonErrorResult(new { message = "Error 400" });

            var cita = _citasRepository.GetCita((int)id);

            if (cita == null) return new JsonErrorResult(new { message = "Error 404" });
            
            cita.Eliminado = true;
            
            _citasRepository.Update(cita);
            return Json(fecha.ToString("MM/dd/yyyy"));
        }
        

        // public JsonResult MoverCita (int? id, DateTime fechaInicio, DateTime fechaFinal)
        // {
        //     if(id == null) return new JsonErrorResult(new { message = "Error 400" });

        //     var cita = _citasRepository.GetCita((int)id);
            
        //     if (cita == null) return new JsonErrorResult(new { message = "Error 404" });

        //     cita.FechaInicio = fechaInicio;
        //     cita.FechaFinal = fechaFinal;

        //     _citasRepository.Update(cita);
        //     return Json(new object());
        // }

        // public JsonResult ResizeCita(int? id, DateTime fechaInicio, DateTime fechaFinal)
        // {
        //     if(id == null) return new JsonErrorResult(new { message = "Error 400" });

        //     var cita = _citasRepository.GetCita((int)id);
            
        //     if (cita == null) return new JsonErrorResult(new { message = "Error 404" });

        //     cita.FechaInicio = fechaInicio;
        //     cita.FechaFinal = fechaFinal;

        //     _citasRepository.Update(cita);
        //     return Json(new object());
        // }

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

            var lista = _citasRepository.PaginacionCitas(sortOrder, buscar, pageNumber, 35);

            return View(lista);
        }

        public IActionResult NoAsistidas(string sortOrder, string buscar, string currentFilter, int? pageNumber)
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

            var lista = _citasRepository.PaginacionCitasNoAsistidas(sortOrder, buscar, pageNumber, 35);

            return View(lista);
        }

        public IActionResult CitasFinalizadas(string sortOrder, string buscar, string currentFilter, int? pageNumber)
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

            var lista = _citasRepository.PaginacionCitasFinalizadas(sortOrder, buscar, pageNumber, 35);

            return View(lista);
        }

        public JsonResult FinalizarCita(int? id, DateTime fecha)
        {
            if(id == null) return new JsonErrorResult(new { message = "Error 400" });

            var cita = _citasRepository.GetCita((int)id);
            
            if (cita == null) return new JsonErrorResult(new { message = "Error 404" });

            cita.Finalizada = true;
            cita.EstadoCita = "asistida";

            _citasRepository.Update(cita);

            return Json(fecha.ToString("MM/dd/yyyy"));
        }

        public IActionResult AgendarCita(string fecha)
        {
            var model = new CitaAddViewModel()
            {
                HoraYFecha = Convert.ToDateTime(fecha)
            };

            model.Init(_citasRepository, _pacienteRepository, _empleadoRepository, _servicioRepository);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AgendarCita(CitaAddViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                var esMenor = viewModel.Cita.Edad < 18 ? true : false;

                var nuevaCita = new Citas()
                {
                    EspecialidadId = viewModel.Cita.EspecialidadId,
                    PacienteId = viewModel.Cita.PacienteId,
                    ServicioId = viewModel.Cita.ServicioId,
                    EmpleadoId = viewModel.Cita.EmpleadoId, // es el medico
                    User = user,
                    FechaInicio = viewModel.HoraYFecha,
                    FechaFinal = viewModel.HoraYFecha,
                    Motivo = viewModel.Cita.Motivo,
                    Edad = viewModel.Cita.Edad, 
                    NombreEncargado = viewModel.Cita.NombreEncargado,
                    EstadoCita = "normal",
                    EsMenorDeEdad = esMenor,
                };

                _citasRepository.Add(nuevaCita);
                TempData["Message"] = "¡La cita se ha agendado con exito.!";
                return RedirectToAction("CalendarioLineal", new { buscar = viewModel.HoraYFecha.ToString("MM/dd/yyyy")});

            }
            return View(viewModel);
        }


          public IActionResult EditarCita (int? id)
        {
            if(id == null) return StatusCode(400);

            var cita = _citasRepository.GetCita((int)id);

            if (cita == null) return StatusCode(404);

            var model = new CitasEditViewModel()
            {
                Cita = cita,
                HoraYFecha = cita.FechaInicio
            };

            model.Init(_citasRepository, _pacienteRepository, _empleadoRepository, _servicioRepository);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditarCita (CitasEditViewModel viewModel)
        {
    
            if(ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                var esMenor = viewModel.Cita.Edad < 18 ? true : false;
                
                var nuevaCita = new Citas()
                {
                    Id = viewModel.Cita.Id,
                    EspecialidadId = viewModel.Cita.EspecialidadId,
                    PacienteId = viewModel.Cita.PacienteId,
                    ServicioId = viewModel.Cita.ServicioId,
                    EmpleadoId = viewModel.Cita.EmpleadoId, // es el medico
                    User = user,
                    FechaInicio = viewModel.HoraYFecha,
                    FechaFinal = viewModel.HoraYFecha,
                    Motivo = viewModel.Cita.Motivo,
                    Edad = viewModel.Cita.Edad, 
                    NombreEncargado = viewModel.Cita.NombreEncargado,
                    EsMenorDeEdad = esMenor,
                    EstadoCita = viewModel.Cita.EstadoCita,
                };

               _citasRepository.Update(nuevaCita);
               TempData["Message"] = "¡La cita se ha modificado con exito.!";

               return RedirectToAction("EditarCita", new {id = viewModel.Cita.Id});

            }

            return View(viewModel);
        }

        public IActionResult NoAsistio(int? citaId, DateTime fecha)
        {
            if(citaId == null) return StatusCode(400);

            var cita = _citasRepository.GetCita((int)citaId);

            if (cita == null) return StatusCode(404);

            cita.EstadoCita = "No asistida";

            _citasRepository.Update(cita);
            TempData["Message"] = "¡La cita se ha movido a No asistidas con exito.!";

            return RedirectToAction("CalendarioLineal", new { buscar = fecha.ToString("MM/dd/yyyy")});
        }

        public IActionResult NoAsistioL(int? citaId)
        {
            if(citaId == null) return StatusCode(400);

            var cita = _citasRepository.GetCita((int)citaId);

            if (cita == null) return StatusCode(404);

            cita.EstadoCita = "No asistida";

            _citasRepository.Update(cita);
            TempData["Message"] = "¡La cita se ha movido a No asistidas con exito.!";

            return RedirectToAction("Lista");
        }

        public IActionResult ReprogramarCita (int? citaId, DateTime fecha)
        {
            if(citaId == null) return StatusCode(400);

            var cita = _citasRepository.GetCita((int)citaId);

            if (cita == null) return StatusCode(404);

            var model = new CitasEditViewModel()
            {
                Cita = cita,
                HoraYFecha = fecha
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult ReprogramarCita (CitasEditViewModel viewModel)
        {
    
            if(ModelState.IsValid)
            {
                var cita = _citasRepository.GetCita(viewModel.Cita.Id);
                cita.FechaInicio = viewModel.Cita.FechaInicio;
                cita.FechaFinal = viewModel.Cita.FechaInicio;
                cita.EstadoCita = "normal";

               _citasRepository.Update(cita);
               TempData["Message"] = "¡La cita se ha reprogramdo con exito.!";
               return RedirectToAction("ReprogramarCita", new {citaId = viewModel.Cita.Id, fecha = viewModel.Cita.FechaInicio.ToString("MM/dd/yyyy")});

            }

            return View(viewModel);
        }        

        public async Task<IActionResult> CitasListadoNormales(string currentFilter)
        {
            var citas = _citasRepository.CitasNormales(currentFilter);
            
            var user = _userManager.GetUserAsync(HttpContext.User);
            var u = _userRepository.GetbyId(user.Result.Id).Persona.Nombre;
            
            var model = new ReporteCitasViewModel()
            {
                Citas = citas,
                Usuario = u
            };

            return await _generatePdf.GetPdf("Views/Cita/CitasListadoNormales.cshtml", model);
        }

    
        public IActionResult CalendarioLineal(string buscar, string currentFilter)
        {
            // var b = buscar == null ? currentFilter : DateTime.Now.ToString("dd/MM/yyyy");
            var b = "";

            if(buscar == null)
            {
                b = DateTime.Now.ToString("MM/dd/yyyy");
            }
            else {
                b = buscar;
            }

            var fechaConvertida = Convert.ToDateTime(b);
            var citaPorFecha = _citasRepository.CitasPorFecha(fechaConvertida);

            ViewData["currentFilter"] = b;

            var model = new CalendarioLinealViewModel()
            {
                Fecha = b,
                Citas = citaPorFecha
            };

            return View(model);
        }

    }
}