using Database.Shared.IRepository;
using Database.Shared.Models;
using Database.Shared.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Database.Shared.Paginacion;
using System;


namespace Database.Shared.Data
{
    public class CompraRepository : ICompra
    {

        private readonly Context _context = null;
        public CompraRepository(Context context)
        {
            _context = context;
        }

        public void Add(DetalleCompra detalle, bool saveChanges = true)
        {
            _context.Add(detalle);
            if (saveChanges)
            {

                _context.SaveChanges();
            }
        }
        // este es un metodo azucarado ya ya
        public List<Compra> GetList() => _context.Compras.Include(a => a.Proveedor).Include(x => x.Recepciones).ThenInclude(x => x.EstadoRecepcion).Where(x => x.Eliminado == false).ToList();

        public List<Recepcion> GetRecepciones() => _context.Recepciones.Include(x => x.Compra).ThenInclude(x => x.Proveedor).Include(x => x.EstadoRecepcion).ToList();

        public List<Compra> GetListadoFecha(DateTime inicio, DateTime final) => _context.Compras.Include(a => a.Proveedor).Include(a => a.DetalleCompras)
          .ThenInclude(a => a.Producto).Include(a => a.Empleado).Where(a => a.FechaCompra <= final && a.FechaCompra >= inicio).ToList();

        public List<Compra> GetListadoFechaEmpleado(DateTime inicio, DateTime final, int? id) => _context.Compras.Include(a => a.Proveedor).Include(a => a.DetalleCompras)
       .ThenInclude(a => a.Producto).Include(a => a.Empleado).Where(a => a.FechaCompra <= final && a.FechaCompra >= inicio).Where(a => a.EmpleadoId == id).ToList();
        public void saveChanges()
        {

            _context.SaveChanges();
        }
        // para variables usa camelCase
        public Compra Get(int id, bool includeRelatedEntities = true)
        {
            var compra = _context.Compras.AsQueryable();

            if (includeRelatedEntities)
            {
                compra = compra
                .Include(a => a.DetalleCompras).ThenInclude(a => a.Producto)
                .Include(a => a.Empleado)
                .Include(a => a.Proveedor)
                .Include(a => a.TipoCompra);
            }

            return compra.Where(a => a.Id == id).SingleOrDefault();
        }



        public List<DetalleCompra> GetDetalle(int id, bool includeRelatedEntities = true)
        {

            var detalle = _context.DetalleCompras.AsQueryable();

            if (includeRelatedEntities)
            {
                detalle = detalle.Include(x => x.Producto);
            }

            return detalle.Where(x => x.CompraId == id).ToList();

        }


        public DetalleCompra GetDetalleC(int id, bool includeRelatedEntities = true)
        {

            var detalle = _context.DetalleCompras.AsQueryable();

            if (includeRelatedEntities)
            {
                detalle = detalle.Include(x => x.Producto);
            }

            return detalle.Where(x => x.Id == id).SingleOrDefault();

        }

        public void Update(Compra model, bool saveChanges = true)
        {

            _context.Entry(model).State = EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }


        public void Update(DetalleCompra model, bool saveChanges = true)
        {

            _context.Entry(model).State = EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public void Add(Recepcion recepcion, bool saveChanges = true)
        {
            _context.Add(recepcion);
            if (saveChanges)
            {

                _context.SaveChanges();
            }
        }

        public void Update(Recepcion recepcion, bool saveChanges = true)
        {

            _context.Entry(recepcion).State = EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }


        //    public void Delete(DetalleCompra detalle){

        //         _context.DetalleCompras.Remove(detalle);
        //         _context.SaveChanges();
        //    }

        public void Delete(int id, bool savechanges = true)
        {
            var set = _context.Set<DetalleCompra>();
            var entity = set.Find(id);
            set.Remove(entity);

            if (true)
            {
                _context.SaveChanges();

            }

        }

        public PaginacionList<Compra> PaginacionCompras(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var compra = _context.Compras.AsQueryable();


            // para hacer la busqueda, el IsNullOrEmpty verifica que no este vacia la cadena entrante
            if (!string.IsNullOrEmpty(searchString))
            {
                compra = compra.Where(s => s.NoComprobante.Contains(searchString) || s.Id.ToString().Contains(searchString));
            }

            // esto que hice no es buena practica, lo ideal seria hacer un patron por estrategia
            // visitar : https://refactoring.guru/es/design-patterns/strategy
            // asi como lo tengo funciona pero no es tan tan tan recomendado
            // quizas mas adelante lo mejoremos con un patron de estrategia.

            switch (sortOrder)
            {
                case "Nombre_desc":
                    compra = compra.OrderByDescending(s => s.NoComprobante);
                    break;

                default:
                    compra = compra.OrderBy(s => s.NoComprobante);
                    break;
            }

            return PaginacionList<Compra>.CreateAsyncc(compra
            .Include(a => a.Proveedor)
            .Include(a => a.TipoCompra)
            .Include(a => a.Empleado)
            .Include(a => a.DetalleCompras), pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Compra> PaginacionComprasPeticion(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var compra = _context.Compras.Where(x => x.Estado == false).AsQueryable();


            // para hacer la busqueda, el IsNullOrEmpty verifica que no este vacia la cadena entrante
            if (!string.IsNullOrEmpty(searchString))
            {
                compra = compra.Where(s => s.NoComprobante.Contains(searchString) || s.Id.ToString().Contains(searchString));
            }

            // esto que hice no es buena practica, lo ideal seria hacer un patron por estrategia
            // visitar : https://refactoring.guru/es/design-patterns/strategy
            // asi como lo tengo funciona pero no es tan tan tan recomendado
            // quizas mas adelante lo mejoremos con un patron de estrategia.

            switch (sortOrder)
            {
                case "Nombre_desc":
                    compra = compra.OrderByDescending(s => s.NoComprobante);
                    break;

                default:
                    compra = compra.OrderBy(s => s.NoComprobante);
                    break;
            }

            return PaginacionList<Compra>.CreateAsyncc(compra
            .Include(a => a.Proveedor)
            .Include(a => a.Empleado)
            .Include(a => a.TipoCompra)
            .Include(a => a.DetalleCompras), pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Compra> PaginacionComprasComprados(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var compra = _context.Compras.Where(x => x.Estado == true).AsQueryable();


            // para hacer la busqueda, el IsNullOrEmpty verifica que no este vacia la cadena entrante
            if (!string.IsNullOrEmpty(searchString))
            {
                compra = compra.Where(s => s.NoComprobante.Contains(searchString) || s.Id.ToString().Contains(searchString));
            }

            // esto que hice no es buena practica, lo ideal seria hacer un patron por estrategia
            // visitar : https://refactoring.guru/es/design-patterns/strategy
            // asi como lo tengo funciona pero no es tan tan tan recomendado
            // quizas mas adelante lo mejoremos con un patron de estrategia.

            switch (sortOrder)
            {
                case "Nombre_desc":
                    compra = compra.OrderByDescending(s => s.NoComprobante);
                    break;

                default:
                    compra = compra.OrderBy(s => s.NoComprobante);
                    break;
            }

            return PaginacionList<Compra>.CreateAsyncc(compra.Include(a => a.Proveedor).Include(a => a.DetalleCompras), pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Recepcion> PaginacionRecepciones(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var recepcion = _context.Recepciones.AsQueryable();


            // para hacer la busqueda, el IsNullOrEmpty verifica que no este vacia la cadena entrante
            if (!string.IsNullOrEmpty(searchString))
            {
                recepcion = recepcion.Where(s => s.Compra.NoComprobante.Contains(searchString) || s.Id.ToString().Contains(searchString));
            }

            // esto que hice no es buena practica, lo ideal seria hacer un patron por estrategia
            // visitar : https://refactoring.guru/es/design-patterns/strategy
            // asi como lo tengo funciona pero no es tan tan tan recomendado
            // quizas mas adelante lo mejoremos con un patron de estrategia.

            switch (sortOrder)
            {
                case "Nombre_desc":
                    recepcion = recepcion.OrderByDescending(s => s.Compra.NoComprobante);
                    break;

                default:
                    recepcion = recepcion.OrderBy(s => s.Compra.NoComprobante);
                    break;
            }

            return PaginacionList<Recepcion>.CreateAsyncc(recepcion
            .Include(x => x.Compra).ThenInclude(x => x.DetalleCompras)
            .Include(a => a.Compra).ThenInclude(a => a.TipoCompra)
            .Include(x => x.Compra).ThenInclude(x => x.Proveedor)
            .Include(a => a.EstadoRecepcion)
            .Include(x => x.EstadoRecepcion), pageNumber ?? 1, pageSize);
        }

        public Recepcion GetRecepcion(int id, bool includeRelatedEntities = true)
        {
            var recepcion = _context.Recepciones.AsQueryable();

            if (includeRelatedEntities)
            {
                recepcion = recepcion
                .Include(a => a.Compra).ThenInclude(a => a.DetalleCompras).ThenInclude(a => a.Producto);
            }

            return recepcion.Where(x => x.Id == id).SingleOrDefault();
        }
        

        public IList<TipoCompra> TipoCompraLista()
        {
            return _context.TipoCompra.OrderBy(x => x.Tipo).ToList();
        }


    }

}
