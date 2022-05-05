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
    public class VentaServicioRepository : IVentaServicio
    {

        private readonly Context _context = null;
        public VentaServicioRepository(Context context)
        {
            _context = context;
        }

        public void Add(DetalleServicio detalle, bool saveChanges = true)
        {
            _context.Add(detalle);
            if (saveChanges)
            {

                _context.SaveChanges();
            }
        }

        public List<VentaServicio> GetList() => _context.VentaServicios.Include(a => a.Paciente)
        .Include(a=>a.DetalleServicio)
        .ThenInclude(a=>a.Servicio)
        .OrderByDescending(a => a.Id)
        .Where(x => x.Eliminado == false)
        .ToList();


         
        public List<DetalleServicio> GetDetalle(int id, bool includeRelatedEntities = true)
        {

            var detalle = _context.DetalleServicios.AsQueryable();

            if (includeRelatedEntities)
            {
                detalle = detalle.Include(x => x.Servicio);
            }

            return detalle.Where(x => x.VentaServicio.Id == id).ToList();


        }

        public PaginacionList<VentaServicio> PaginacionVentaServicios(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var ventaServicios = _context.VentaServicios.AsQueryable();


            // para hacer la busqueda, el IsNullOrEmpty verifica que no este vacia la cadena entrante
            if(!string.IsNullOrEmpty(searchString))
            {
                ventaServicios = ventaServicios.Where(s => s.NoComprobante.Contains(searchString) || s.Id.ToString().Contains(searchString));
            }

            // esto que hice no es buena practica, lo ideal seria hacer un patron por estrategia
            // visitar : https://refactoring.guru/es/design-patterns/strategy
            // asi como lo tengo funciona pero no es tan tan tan recomendado
            // quizas mas adelante lo mejoremos con un patron de estrategia.

            switch(sortOrder)
            {
                case "Nombre_desc":
                ventaServicios = ventaServicios.OrderByDescending(s => s.NoComprobante);
                break;

                default:
                ventaServicios = ventaServicios.OrderByDescending(s => s.FechaVenta);
                break;
            }

            return PaginacionList<VentaServicio>.CreateAsyncc(ventaServicios
            .Include(a => a.Paciente)
            .Include(a=>a.DetalleServicio).ThenInclude(a=>a.Servicio)
            .Include(a => a.Empleado)
            .Where(a => a.Eliminado == false)
            ,pageNumber ?? 1, pageSize);
        }


        public void saveChanges()
        {

            _context.SaveChanges();
        }

        public VentaServicio Get(int id, bool includeRelatedEntities = true)
        {
            var ventaServicio = _context.VentaServicios.AsQueryable();

            if (includeRelatedEntities)
            {
                ventaServicio = ventaServicio
                .Include(a => a.DetalleServicio).ThenInclude(a => a.Servicio).Include(a=> a.Paciente);
            }

            return ventaServicio.Where(a => a.Id == id).SingleOrDefault();
        }

        public List<VentaServicio> GetListadoFecha(DateTime inicio, DateTime final)=> _context.VentaServicios.Include(a => a.Paciente).Include(a => a.DetalleServicio)
         .ThenInclude(a => a.Servicio).Include(a => a.Empleado).Where(a => a.FechaVenta<=final && a.FechaVenta >=inicio).ToList();

          public List<VentaServicio> GetListadoFechaEmpleado(DateTime inicio, DateTime final, int? id)=> _context.VentaServicios.Include(a => a.Paciente).Include(a => a.DetalleServicio)
         .ThenInclude(a => a.Servicio).Include(a =>a.Empleado).Where(a => a.FechaVenta<=final && a.FechaVenta >=inicio).Where(a =>a.EmpleadoId==id).ToList();

        public void Delete(int id, bool savechanges = true)
        {
            var set = _context.Set<DetalleServicio>();
            var entity = set.Find(id);
            set.Remove(entity);

            if (true)
            {
                _context.SaveChanges();

            }

        }

        public void Update(VentaServicio model, bool saveChanges = true)
        {

            _context.Entry(model).State = EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }





    }

}