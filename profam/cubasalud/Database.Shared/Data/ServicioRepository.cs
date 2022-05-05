using Database.Shared.Models;
using Database.Shared.IRepository;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Database.Shared.Paginacion;


namespace Database.Shared.Data
{
    public class ServicioRepository : IServicio
    {
        private readonly Context _context = null;

        public ServicioRepository(Context context)
        {
            _context = context;
        }

        public void Add(Servicio servicio, bool saveChanges = true)
        {
            _context.Servicios.Add(servicio);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }
        public List<ListadoServiciosIdYNombres> GetList()
        {
            return _context.Servicios
                .Where(a => a.Eliminado == false)
                .Select(a => new ListadoServiciosIdYNombres{
                    Id = a.Id,
                    NombreServicio = a.NombreServicio
                })
                .OrderBy(a => a.NombreServicio)
                .ToList();
        }

        public IList<Servicio> BuscarPorNombreBusquedaAjax(string searchString)
        {
            return _context.Servicios.Where(s => s.NombreServicio.Contains(searchString))
                            .Where(a => a.Eliminado == false)
                            .ToList();
        }


        // SELECT *FROM PRODUCTOS WHERE ID = <id>
        public Servicio Get(int id, bool includeRelatedEntities = true)
        {
            var servicios = _context.Servicios.AsQueryable();

            return servicios
               .Where(a => a.Id == id)
               .SingleOrDefault();
        }

        public Servicio GetNombre(string nombre, bool includeRelatedEntities = true)
        {
            var servicios = _context.Servicios.AsQueryable();


            return servicios
               .Where(a => a.NombreServicio == nombre)
               .SingleOrDefault();

        }

        public PaginacionList<Servicio> PaginacionServicios(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var servicios = _context.Servicios.AsQueryable();


            // para hacer la busqueda, el IsNullOrEmpty verifica que no este vacia la cadena entrante
            if (!string.IsNullOrEmpty(searchString))
            {
                servicios = servicios.Where(s => s.NombreServicio.Contains(searchString));
            }

            // esto que hice no es buena practica, lo ideal seria hacer un patron por estrategia
            // visitar : https://refactoring.guru/es/design-patterns/strategy
            // asi como lo tengo funciona pero no es tan tan tan recomendado
            // quizas mas adelante lo mejoremos con un patron de estrategia.

            switch (sortOrder)
            {
                case "Nombre_desc":
                    servicios = servicios.OrderByDescending(s => s.NombreServicio);
                    break;

                default:
                    servicios = servicios.OrderBy(s => s.NombreServicio);
                    break;
            }

            return PaginacionList<Servicio>.CreateAsyncc(servicios.Where(a => a.Eliminado == false), pageNumber ?? 1, pageSize);
        }

        public void Update(Servicio model, bool saveChanges = true)
        {

            _context.Entry(model).State = EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }

        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }


    }

    public class ListadoServiciosIdYNombres
    {
        public int Id {get;set;}
        public string NombreServicio {get;set;} 
    }
}