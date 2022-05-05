using Database.Shared.Models;
using Database.Shared.IRepository;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Database.Shared.Paginacion;
using System;

namespace Database.Shared.Data
{
    public class ConsultasRepository : IConsultas
    {
        private readonly Context _context = null;

        public ConsultasRepository(Context context)
        {
            _context = context;
        }

        public void Add(Consulta consulta, bool saveChanges = true)
        {
            _context.Consultas.Add(consulta);
            if(saveChanges) _context.SaveChanges();
        }

        public void Update(Consulta consulta, bool saveChanges = true)
        {
            _context.Entry(consulta).State = EntityState.Modified;

            if(saveChanges)
            {
            _context.SaveChanges();
            }
        }

        public IList<Consulta> ListaConsultas() => _context.Consultas.Include(a => a.Citas).OrderByDescending(a => a.FechaYHoraInicioConsulta).ToList();
        
        public PaginacionList<Consulta> PaginacionConsultas(string searchString, int? pageNumber, int pageSize)
        {
            var consultas = _context.Consultas.AsQueryable();

            if(!string.IsNullOrEmpty(searchString))
            {
                consultas = consultas.Where(s => 
                s.Citas.Paciente.Nombre.Contains(searchString)
                || s.Citas.Empleado.Nombre.Contains(searchString))
                ;
            }

            return PaginacionList<Consulta>.CreateAsyncc(consultas
            .Include(a => a.Citas).ThenInclude(a => a.Paciente)
            .Include(a => a.Citas).ThenInclude(a => a.Empleado)
            .Include(a => a.EstadoPagoConsulta)
            .OrderBy(a => a.FechaYHoraInicioConsulta)
            .Where(a => a.Archivado == false), 
            pageNumber ?? 1, pageSize);
        }

        public Consulta GetConsulta(int id, bool relatedEntities = true)
        {
            var consulta = _context.Consultas.AsQueryable();
            
            if(relatedEntities)
            {
                consulta = consulta
                .Include(a => a.Citas).ThenInclude(a => a.Especialidad)
                .Include(a => a.Citas).ThenInclude(a => a.Servicio)
                .Include(a => a.Citas).ThenInclude(a => a.Empleado)
                .Include(a => a.Historia)
                .Include(a => a.ExamenFisico)
                .Include(a => a.Citas).ThenInclude(a => a.Paciente);
            }

            return consulta.Where(a => a.Id == id).SingleOrDefault();
        }

    }
}