using Database.Shared.Models;
using Database.Shared.IRepository;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Database.Shared.Paginacion;

namespace Database.Shared.Data
{
    public class PacientesRepository : IPacientes
    {

        private readonly Context _context = null;

        public PacientesRepository(Context context)
        {
            _context = context;
        }

        public void Add(Paciente cliente, bool saveChanges = true)
        {
            _context.Pacientes.Add(cliente);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public IList<Sexo> GetSexosList()
        {
            return _context.Sexo.ToList();
        }

        public Paciente Get(int id, bool includeRelatedEntities = true)
        {
            return _context.Pacientes.Where(a => a.Id == id).SingleOrDefault();
        }

        public List<Paciente> GetList() 
        {
            return _context.Pacientes.Where(x=>x.Eliminado==false).ToList();
        } 

        public List<EstadoExamen> GetListEstadosExamen() 
        {
            return _context.EstadoExamenes.OrderBy(a => a.Nombre).ToList();
        } 

        // usar para paginacion
        public PaginacionList<Paciente> PaginacionClientes(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var cliente = _context.Pacientes.AsQueryable();


            // para hacer la busqueda, el IsNullOrEmpty verifica que no este vacia la cadena entrante
            if(!string.IsNullOrEmpty(searchString))
            {
                cliente = cliente
                .Where(s => s.Nombre.Contains(searchString));
            }

            switch(sortOrder)
            {
                case "Nombre_desc":
                cliente = cliente.OrderByDescending(s => s.Nombre);
                break;

                default:
                cliente = cliente.OrderBy(s => s.Nombre);
                break;
            }

            return PaginacionList<Paciente>.CreateAsyncc(cliente
            .Include(a => a.Sexo)
            .Where(x => x.Eliminado==false)
            .OrderBy(a => a.Nombre), 
            pageNumber ?? 1, pageSize);
        }


        public void Update(Paciente model, bool saveChanges = true)
        {
            _context.Entry(model).State = EntityState.Modified;

            if(saveChanges)
            {
            _context.SaveChanges();
            }
        }

        public Paciente GetPacientePorNombre(string nombre)
        {
            return _context.Pacientes.Where(a => a.Nombre == nombre && a.Eliminado == false).SingleOrDefault();
        }

        public Paciente GetPacientePorId(int id)
        {
            return _context.Pacientes.Where(a => a.Id == id && a.Eliminado == false).SingleOrDefault();
        }
        
    }
}