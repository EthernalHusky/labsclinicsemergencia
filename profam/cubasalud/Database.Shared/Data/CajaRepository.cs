using System.Collections.Generic;
using System.Linq;
using Database.Shared.IRepository;
using Database.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Database.Shared.Paginacion;
using System;

namespace Database.Shared.Data
{
    
    public class CajaRepository : ICaja
    {
        private readonly Context _context = null;
        public CajaRepository(Context context)
        {
            _context = context;
        }

        public IList<Caja> ListarCajas()
        {
            return _context.Cajas
            .Include(x => x.DetalleCajas)
            .Include(a => a.ResponsableApertura).ThenInclude(a => a.Persona)
            .Include(a => a.ResponsableCierre).ThenInclude(a => a.Persona)
            .OrderByDescending(a => a.FechaApertura).ToList();
        }

        public List<Caja> GetListadoFecha(DateTime inicio, DateTime final) => 
        _context.Cajas
        .Include(x => x.DetalleCajas)
        .Include(a => a.DetalleCajas).ThenInclude(a => a.Venta).ThenInclude(a => a.Paciente)
        // .Include(a => a.DetalleCajas).ThenInclude(a => a.Compra).ThenInclude(a => a.Proveedor)
        // .Include(a => a.DetalleCajas).ThenInclude(a => a.VentaServicio).ThenInclude(a => a.Paciente)
        .Include(a => a.ResponsableApertura).ThenInclude(a => a.Persona)
        .Include(a => a.ResponsableCierre).ThenInclude(a => a.Persona)
        .Where(a => a.FechaApertura <= final && a.FechaApertura >= inicio)
        .OrderByDescending(a => a.FechaApertura)
        .ToList();

       

        public void Add(Caja caja, bool saveChanges = true)
        {
            _context.Cajas.Add(caja);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public void Update(Caja caja, bool saveChanges = true)
        {

            _context.Entry(caja).State = EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }

        }

        public PaginacionList<Caja> PaginacionCategoria(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var caja = _context.Cajas.AsQueryable();


            // para hacer la busqueda, el IsNullOrEmpty verifica que no este vacia la cadena entrante
            if (!string.IsNullOrEmpty(searchString))
            {
                // categoria = categoria.Where(s => s..Contains public DetalleCaja GetDetalleCajaVentaServicio(int id)(searchString));
            }


            return PaginacionList<Caja>.CreateAsyncc(caja, pageNumber ?? 1, pageSize);
        }

        public Caja GetCajaAbierta()
        {
            return _context.Cajas.Where(a => a.EstadoCaja == true).FirstOrDefault();
        }


        public Caja GetCaja(int id, bool includeRelatedEntities = true)
        {
            var caja = _context.Cajas.AsQueryable();

            if (includeRelatedEntities)
            {
                caja = caja
                .Include(a => a.DetalleCajas).ThenInclude(a => a.Venta).ThenInclude(a => a.Clientes)
                .Include(a => a.DetalleCajas).ThenInclude(a => a.Venta).ThenInclude(a => a.Empleado)
                .Include(a => a.DetalleCajas).ThenInclude(a => a.Compra).ThenInclude(a => a.Proveedor)
                .Include(a => a.DetalleCajas).ThenInclude(a => a.Compra).ThenInclude(a => a.Empleado)
                .Include(a => a.DetalleCajas).ThenInclude(a => a.VentaServicio).ThenInclude(a => a.Paciente)
                .Include(a => a.DetalleCajas).ThenInclude(a => a.VentaServicio).ThenInclude(a => a.Empleado)
                .Include(a => a.ResponsableApertura).ThenInclude(a => a.Persona)
                .Include(a => a.ResponsableCierre).ThenInclude(a => a.Persona);
            }

            return caja.Where(a => a.Id == id).SingleOrDefault();
        }


        // para detalles

        public void Add(DetalleCaja detalle, bool saveChanges = true)
        {
            _context.DetalleCajas.Add(detalle);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public DetalleCaja GetDetalleCaja(int id)
        {
            return _context.DetalleCajas.Where(a => a.VentaId == id).SingleOrDefault();
        }

        public DetalleCaja GetDetalleCajaVentaServicio(int id)
        {
            return _context.DetalleCajas.Where(a => a.VentaServicioId == id).SingleOrDefault();
        }

        
        public void GetDetalleCajaPorVentaId(int id, bool savechanges = true)
        {
            var set = _context.Set<DetalleCaja>();
            var entity = set.Find(id);
            set.Remove(entity);

            if (true)
            {
                _context.SaveChanges();
            }
        }

        public void DeleteDetalleCaja(int id, bool saveChanges = true)
        {
            var set = _context.Set<DetalleCaja>();
            var entity = set.Find(id);
            set.Remove(entity);
            
            if (saveChanges)
            {
                _context.SaveChanges();

            }
        }
    }
}