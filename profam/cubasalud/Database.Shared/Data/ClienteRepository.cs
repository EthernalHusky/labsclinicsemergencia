using Database.Shared.Models;
using Database.Shared.IRepository;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Database.Shared.Paginacion;

namespace Database.Shared.Data
{
    public class ClienteRepository : ICliente
    {
        private readonly Context _context = null;
        public ClienteRepository(Context context)
        {
            _context = context;
        }

        public void Add(Clientes cliente, bool saveChanges = true)
        {
            _context.Clientes.Add(cliente);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public Clientes Get(int id, bool includeRelatedEntities = true)
        {

            return _context.Clientes.Where(a => a.Id == id).SingleOrDefault();


        }

        // capturar esa lista solo para comboboxes y listas comunes.
        // no se debe usar para paginacionPaciente
        public List<Clientes> GetList() 
        {
            return _context.Clientes.Where(x=>x.Eliminado==false).ToList();
        } 

        // usar para paginacion
        public PaginacionList<Clientes> PaginacionClientes(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var cliente = _context.Clientes.AsQueryable();


            // para hacer la busqueda, el IsNullOrEmpty verifica que no este vacia la cadena entrante
            if(!string.IsNullOrEmpty(searchString))
            {
                cliente = cliente.Where(s => s.Nombre.Contains(searchString));
            }

            // esto que hice no es buena practica, lo ideal seria hacer un patron por estrategia
            // visitar : https://refactoring.guru/es/design-patterns/strategy
            // asi como lo tengo funciona pero no es tan tan tan recomendado
            // quizas mas adelante lo mejoremos con un patron de estrategia.

            switch(sortOrder)
            {
                case "Nombre_desc":
                cliente = cliente.OrderByDescending(s => s.Nombre);
                break;

                default:
                cliente = cliente.OrderBy(s => s.Nombre);
                break;
            }

            return PaginacionList<Clientes>.CreateAsyncc(cliente
            .Where(x => x.Eliminado == false), 
            pageNumber ?? 1, pageSize);
        }


        public void Update(Clientes model, bool saveChanges = true)
        {
            _context.Entry(model).State = EntityState.Modified;

            if(saveChanges)
            {
            _context.SaveChanges();
            }
        }

        public Clientes GetClientePorNombre(string nombre)
        {
            return _context.Clientes.Where(a => a.Nombre == nombre && a.Eliminado == false).SingleOrDefault();
        }

        public Clientes GetClientePorId(int id)
        {
            return _context.Clientes.Where(a => a.Id == id && a.Eliminado == false).SingleOrDefault();
        }
        
    }
}