using Database.Shared.Models;
using Database.Shared.IRepository;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Database.Shared.Paginacion;
using System;

namespace Database.Shared.Data
{
    public class CitasRepository : ICitas
    {
        private readonly Context _context = null;

        public CitasRepository(Context context)
        {
            _context = context;
        }

        public IList<Citas> GetList()
        {
            return _context.Citass
            .Include(a => a.Especialidad)
            .Include(a => a.Paciente)
            .Where(a => a.Eliminado == false && a.Finalizada == false)
            .ToList();
        }

        public IList<Especialidad> GetEspecialidadesList()
        {
            return _context.Especialidads
            .OrderBy(a => a.NombreEspecialidad).ToList();
        }

        public void Add(Citas cita, bool saveChanges = true)
        {
            _context.Citass.Add(cita);

            if(saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public Citas GetCita(int id)
        {
            return _context.Citass
            .Include(a => a.Paciente)
            .Include(a => a.Servicio)
            .Include(a => a.Empleado)
            .Where(a => a.Id == id).SingleOrDefault();
        }

        public void Update(Citas model, bool saveChanges = true)
        {
            _context.Entry(model).State = EntityState.Modified;

            if(saveChanges)
            {
            _context.SaveChanges();
            }
        }

        public PaginacionList<Citas> PaginacionCitas(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var cita = _context.Citass.AsQueryable();

            //is
            if(!string.IsNullOrEmpty(searchString))
            {
                cita = cita.Where(s => s.Paciente.Nombre
                .Contains(searchString) || s.Especialidad.NombreEspecialidad.Contains(searchString));
            }
           
            return PaginacionList<Citas>.CreateAsyncc(cita
            .Include(a => a.Especialidad)
            .Include(a => a.Paciente).ThenInclude(a => a.Sexo)
            .Include(a => a.Empleado)
            .Include(a => a.User).ThenInclude(a => a.Persona)
            .Include(a=> a.Servicio)
            .OrderByDescending(a => a.FechaInicio)
            .Where(a => a.Eliminado == false && a.Finalizada == false && a.EstadoCita == "normal"), 
            pageNumber ?? 1, pageSize);
        } 

        public IList<Citas> CitasNormales(string searchString)
        {
            var citas = _context.Citass.AsQueryable();

            if(!string.IsNullOrEmpty(searchString))
            {
                citas = citas.Where(s => 
                s.Paciente.Nombre.Contains(searchString) || s.Especialidad.NombreEspecialidad.Contains(searchString));
            }

            return citas
            .Include(a => a.Especialidad)
            .Include(a => a.Paciente).ThenInclude(a => a.Sexo)
            .Include(a => a.Empleado)
            .Include(a => a.User).ThenInclude(a => a.Persona)
            .Include(a=> a.Servicio)
            .OrderByDescending(a => a.FechaInicio)
            .Where(a => a.Eliminado == false && a.Finalizada == false && a.EstadoCita == "normal").ToList();
        }

        public PaginacionList<Citas> PaginacionCitasNoAsistidas(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var cita = _context.Citass.AsQueryable();

            //is
            if(!string.IsNullOrEmpty(searchString))
            {
                cita = cita.Where(s => s.Paciente.Nombre
                .Contains(searchString) || s.Especialidad.NombreEspecialidad.Contains(searchString));
            }
           
            return PaginacionList<Citas>.CreateAsyncc(cita
            .Include(a => a.Especialidad)
            .Include(a => a.Paciente).ThenInclude(a => a.Sexo)
            .Include(a => a.Empleado)
            .Include(a => a.User).ThenInclude(a => a.Persona)
            .Include(a=> a.Servicio)
            .OrderByDescending(a => a.FechaInicio)
            .Where(a => a.Eliminado == false && a.Finalizada == false && a.EstadoCita == "No asistida"), 
            pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Citas> PaginacionCitasFinalizadas(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var cita = _context.Citass.AsQueryable();

            if(!string.IsNullOrEmpty(searchString))
            {
                cita = cita.Where(s => s.Paciente.Nombre
                .Contains(searchString) || s.Motivo.Contains(searchString));
            }
           
            return PaginacionList<Citas>.CreateAsyncc(cita
              .Include(a => a.Especialidad)
            .Include(a => a.Paciente).ThenInclude(a => a.Sexo)
            .Include(a => a.Empleado)
            .Include(a => a.User).ThenInclude(a => a.Persona)
            .Include(a=> a.Servicio)
            .OrderByDescending(a => a.FechaInicio)
            .Where(a => a.Eliminado == false && a.Finalizada == true), 
            pageNumber ?? 1, pageSize);
        }

        public IList<Citas> CitasPorFecha(DateTime fecha)
        {
            return _context.Citass
            .Include(a => a.Especialidad)
            .Include(a => a.Paciente).ThenInclude(a => a.Sexo)
            .Include(a => a.Empleado)
            .Include(a => a.User).ThenInclude(a => a.Persona)
            .Include(a=> a.Servicio)
            .Where(a => a.Eliminado == false)
            .Where(a => a.FechaInicio >= fecha && a.FechaInicio < fecha.AddDays(1)).ToList();
        }

        public IList<EstadoPagoConsulta> EstadoPagosConsultasLista()
        {
            return _context.EstadoPagoConsultas.OrderBy(a => a.Estado).ToList();
        }

    }
}