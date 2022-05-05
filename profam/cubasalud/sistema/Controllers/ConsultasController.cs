using System;
using Microsoft.AspNetCore.Mvc;
using Database.Shared.IRepository;
using sistema.Models;
using Database.Shared.Models;

namespace sistema.Controllers
{
    public class ConsultasController : Controller
    {
        private readonly ICitas _citasRepository = null;
        private readonly IConsultas _consultasRepository = null;

        public ConsultasController(ICitas citasRepository, IConsultas consultasRepository)
        {
            _citasRepository = citasRepository;
            _consultasRepository = consultasRepository;
        }
        public IActionResult Index(ConsultasViewModel viewModel)
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
            viewModel.Consultas = _consultasRepository.PaginacionConsultas(viewModel.buscar, viewModel.pageNumber, 25);
            return View(viewModel);
        }

        public IActionResult IniciarConsulta(int? citaId)
        {
            if(citaId == null) return StatusCode(400);
            var cita = _citasRepository.GetCita((int)citaId);
            if(cita == null) return StatusCode(404);

            var model = new ConsultasViewModel()
            {
                CitaId = (int)citaId,
                Nombres = cita.ClienteText,
                Servicio = cita.ServicioText,
                MedicoAsignado = cita.EmpleadoText,
                FechaYHoraInicio = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),
                CostoConsulta = cita.Servicio.Precio
            };

            model.Init(_citasRepository);

            return View(model);
        }

        [HttpPost]
        public IActionResult IniciarConsulta(ConsultasViewModel model)
        {
            if(ModelState.IsValid)
            {
                var historia = new Historia()
                {
                    HistoriaProblema = "--- Historia del problema ---",
                    Sintomas =  "--- Sintomas ---",
                    Diagnostico = "--- Diagnostico ---"
                };

                var consulta = new Consulta()
                {
                    CitasId = model.CitaId,
                    EstadoPagoConsultaId = model.EstadoPagoId,
                    CostoConsulta = model.CostoConsulta,
                    ObservacionesAdicionales = model.Consulta.ObservacionesAdicionales,
                    FechaYHoraInicioConsulta = Convert.ToDateTime(model.FechaYHoraInicio),
                    Historia = historia,
                };

                _consultasRepository.Add(consulta);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Informacion(int? id)
        {
            if(id == null) return StatusCode(404);
            var consulta = _consultasRepository.GetConsulta((int)id);
            if(consulta == null) return StatusCode(400);
            
            var model = new InfoConsultaViewModel()
            {
                Consulta = consulta
            };

            return View(model);
        }

        public IActionResult ModificarHistoria(int? consultaId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult ModificarHistoria()
        {
            return View();
        }

        public IActionResult ModificarExamenFisico(int? consultaId)
        {
            if(consultaId == null) return StatusCode(404);
            var consulta = _consultasRepository.GetConsulta((int)consultaId);
            if(consulta == null) return StatusCode(400);

            var model = new ExamenFisicoViewModel()
            {
                ConsultaId = consulta.Id,
                ExamenFisico = consulta.ExamenFisico,
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult ModificarExamenFisico(ExamenFisicoViewModel model)
        {
            return View();
        }

        public IActionResult CrearExamenFisico(int? consultaId)
        {
            if(consultaId == null) return StatusCode(404);
            var consulta = _consultasRepository.GetConsulta((int)consultaId);
            if(consulta == null) return StatusCode(400);

            var examenFisico = new ExamenFisico()
            {
                Temperatura = "--- Temperatura ---",
                FrecuenciaRespiratoria = "--- FrecuenciaRespiratoria ---",
                FrecuenciaCardiaca = "--- Frecuencia Cardiaca ---",
                SaturacionDeOxigeno = "--- Saturacion De Oxigeno ---",
                PresionArterialBrazoDerecho = "--- Presion Arterial Brazo Derecho ---",
                PresionArterialBrazoIzquierdo = "--- Presion Arterial Brazo Izquierdo ---",
                Observaciones = "--- Observaciones o texto adicional ---",
            };

            consulta.ExamenFisico = examenFisico;
            _consultasRepository.Update(consulta);

            return RedirectToAction("Informacion", new {id = consulta.Id});
        }
    }
}