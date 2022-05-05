using System.Collections.Generic;
using System.Linq;
using Database.Shared.IRepository;
using Database.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Database.Shared.Paginacion;
using System;

namespace Database.Shared.Data
{
    
    public class CajaClinicaRepository : ICajaClinica
    {
        private readonly Context _context = null;
        public CajaClinicaRepository(Context context)
        {
            _context = context;
        }

        public List<CajaClinica> ListarCajas()
        {
            return _context.CajaClinicas.Include(x => x.DetalleCajaClinicas)
            .OrderByDescending(a => a.FechaApertura).ToList();
        }

        public List<CajaClinica> GetListadoFecha(DateTime inicio, DateTime final) => _context.CajaClinicas
        .Include(a => a.DetalleCajaClinicas).ThenInclude(a => a.Venta).ThenInclude(a => a.Paciente)
        .Include(a => a.DetalleCajaClinicas).ThenInclude(a => a.Compra).ThenInclude(a => a.Proveedor)
        .Include(a => a.DetalleCajaClinicas).ThenInclude(a => a.VentaServicio).ThenInclude(a => a.Paciente)
        .Where(a => a.FechaApertura <= final && a.FechaApertura >= inicio).ToList();

       

        public void Add(CajaClinica caja, bool saveChanges = true)
        {
            _context.CajaClinicas.Add(caja);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public void Update(CajaClinica caja, bool saveChanges = true)
        {

            _context.Entry(caja).State = EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }

        }

        public PaginacionList<CajaClinica> PaginacionCategoria(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var caja = _context.CajaClinicas.AsQueryable();


            // para hacer la busqueda, el IsNullOrEmpty verifica que no este vacia la cadena entrante
            if (!string.IsNullOrEmpty(searchString))
            {
                // categoria = categoria.Where(s => s..Contains public DetalleCaja GetDetalleCajaVentaServicio(int id)(searchString));
            }

            // esto que hice no es buena practica, lo ideal seria hacer un patron por estrategia
            // visitar : https://refactoring.guru/es/design-patterns/strategy
            // asi como lo tengo funciona pero no es tan tan tan recomendado
            // quizas mas adelante lo mejoremos con un patron de estrategia.

            // switch(sortOrder)
            // {
            //     case "Nombre_desc":
            //     categoria = categoria.OrderByDescending(s => s.NombreCategoria);
            //     break;

            //     default:
            //     categoria = categoria.OrderBy(s => s.NombreCategoria);
            //     break;
            // }

            return PaginacionList<CajaClinica>.CreateAsyncc(caja, pageNumber ?? 1, pageSize);
        }

        public CajaClinica GetCajaAbierta()
        {
            return _context.CajaClinicas.Where(a => a.EstadoCaja == true).FirstOrDefault();
        }


        public CajaClinica GetCaja(int id, bool includeRelatedEntities = true)
        {
            var caja = _context.CajaClinicas.AsQueryable();

            if (includeRelatedEntities)
            {
                caja = caja
                .Include(a => a.DetalleCajaClinicas).ThenInclude(a => a.Venta).ThenInclude(a => a.Paciente)
                .Include(a => a.DetalleCajaClinicas).ThenInclude(a => a.Venta).ThenInclude(a => a.Empleado)
                .Include(a => a.DetalleCajaClinicas).ThenInclude(a => a.Compra).ThenInclude(a => a.Proveedor)
                .Include(a => a.DetalleCajaClinicas).ThenInclude(a => a.Compra).ThenInclude(a => a.Empleado)
                .Include(a => a.DetalleCajaClinicas).ThenInclude(a => a.VentaServicio).ThenInclude(a => a.Paciente)
                .Include(a => a.DetalleCajaClinicas).ThenInclude(a => a.VentaServicio).ThenInclude(a => a.Empleado);
            }

            return caja.Where(a => a.Id == id).SingleOrDefault();
        }


        // para detalles

        public void Add(DetalleCajaClinica detalle, bool saveChanges = true)
        {
            _context.DetalleCajaClinicas.Add(detalle);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public DetalleCajaClinica GetDetalleCaja(int id)
        {
            return _context.DetalleCajaClinicas.Where(a => a.VentaId == id).SingleOrDefault();
        }

        public DetalleCajaClinica GetDetalleCajaVentaServicio(int id)
        {
            return _context.DetalleCajaClinicas.Where(a => a.VentaServicioId == id).SingleOrDefault();
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

        public void GetDetalleCajaPorVentaIdC(int id, bool savechanges = true)
        {
            var set = _context.Set<DetalleCajaClinica>();
            var entity = set.Find(id);
            set.Remove(entity);

            if (true)
            {
                _context.SaveChanges();

            }

        }
    }
}