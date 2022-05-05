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
    public class VentaRepository : IVenta
    {

        private readonly Context _context = null;
        public VentaRepository(Context context)
        {
            _context = context;
        }

        public void Add(DetalleVenta detalle, bool saveChanges = true)
        {
            _context.Add(detalle);
            if (saveChanges)
            {

                _context.SaveChanges();
            }
        }

        public List<Venta> GetList() => _context.Ventas.Include(a => a.Paciente)
        .OrderByDescending(a => a.Id)
        .Where(x => x.Eliminado == false)
        .ToList();

         public List<Venta> GetListado() => _context.Ventas.Include(a => a.Paciente).Include(a => a.DetalleVenta).ThenInclude(a => a.Producto).Include(a => a.Empleado).ToList();

         public List<Venta> GetListadoFecha(DateTime inicio, DateTime final)=> _context.Ventas
         .Include(a => a.Clientes)
         .Include(a => a.DetalleVenta).ThenInclude(a => a.Producto)
         .Include(a => a.Empleado)
         .Include(a => a.Pagos).ThenInclude(a => a.FormaPago)
         .Where(a => a.FechaVenta<=final && a.FechaVenta >=inicio)
         .Where(a => a.Eliminado == false)
         .OrderByDescending(a => a.FechaVenta)
         .ToList();

          public List<Venta> GetListadoFechaEmpleado(DateTime inicio, DateTime final, int? id)=> _context.Ventas
         .Include(a => a.Clientes).Include(a => a.DetalleVenta)
         .ThenInclude(a => a.Producto).Include(a =>a.Empleado)
         .Include(a => a.Pagos).ThenInclude(a => a.FormaPago)
         .Where(a => a.FechaVenta<=final && a.FechaVenta >=inicio)
         .Where(a => a.Eliminado == false)
         .Where(a =>a.EmpleadoId==id)
         .OrderByDescending(a => a.FechaVenta)
         .ToList();


        public List<DetalleVenta> GetDetalle(int id, bool includeRelatedEntities = true)
        {

            var detalle = _context.DetalleVentas.AsQueryable();

            if (includeRelatedEntities)
            {
                detalle = detalle.Include(x => x.Producto);
            }

            return detalle.Where(x => x.Venta.Id == id).ToList();


        }

         public List<DetalleVenta> GetListadoDetalles() => _context.DetalleVentas.Include(a=>a.Venta).Include(a=>a.Producto).ToList();

    

        public PaginacionList<Venta> PaginacionVentasFarmacia(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var venta = _context.Ventas.AsQueryable();

            if(!string.IsNullOrEmpty(searchString))
            {
                venta = venta.Where(s => s.NoComprobante.Contains(searchString) || s.Id.ToString().Contains(searchString));
            }


            return PaginacionList<Venta>.CreateAsyncc(venta
            .Include(a => a.Paciente)
            .Include(a => a.DetalleVenta)
            .Include(a => a.Empleado)
            .Include(a => a.Pagos).ThenInclude(a => a.FormaPago)
            .Where(a => a.Eliminado == false && a.TipoVenta == "farmacia")
            .OrderByDescending(a=>a.FechaVenta)
            , pageNumber ?? 1, pageSize);
        }

        public PaginacionList<Venta> PaginacionVentasClinica(string sortOrder, string searchString, int? pageNumber, int pageSize)
        {
            var venta = _context.Ventas.AsQueryable();

            if(!string.IsNullOrEmpty(searchString))
            {
                venta = venta.Where(s => s.NoComprobante.Contains(searchString) || s.Id.ToString().Contains(searchString));
            }


            return PaginacionList<Venta>.CreateAsyncc(venta
            .Include(a => a.Paciente)
            .Include(a => a.DetalleVenta)
            .Include(a => a.Empleado)
            .Include(a => a.Pagos).ThenInclude(a => a.FormaPago)
            .OrderByDescending(a=>a.FechaVenta)
            .Where(a => a.Eliminado == false && a.TipoVenta == "clinica")
            , pageNumber ?? 1, pageSize);
        }

        public List<User> GetUsersRole(string rolename){

          var users =  (from user in _context.Usuarios
                                 join userRole in _context.UserRoles
                                 on user.Id equals userRole.UserId
                                 join role in _context.Roles 
                                 on userRole.RoleId equals role.Id
                                 where role.Name == rolename 
                                 select user)
                                 .ToList();

        return users;
        }


         public List<Venta> GetVentasFechas(DateTime fecha1, DateTime fecha2){


          var ventas = _context.Ventas.FromSqlRaw("DECLARE @fecha1  DATETIME, @fecha2  DATETIME;  SELECT   @fecha1 = '20210101' ,@fecha2   = '20210201';  SELECT  DATENAME(MONTH, DATEADD(MONTH, x.number, @fecha1)) AS MonthName FROM Ventas x WHERE   x.type = 'P'  AND  x.number <= DATEDIFF(MONTH, @fecha1, @fecha2)").ToList();
                                

        return ventas;
        }

        public Empleado GetEmpleadoUser(string id){

          var emp =  (from empleado in _context.Empleados
                        join user in _context.Usuarios
                        on empleado.Id equals user.EmpleadoId
                        join envio in _context.Envios
                        on user.Id equals envio.UserId1
                        where user.Id == id
                        select empleado
                        ).SingleOrDefault();

                                

        return emp;
        }

        public void saveChanges()
        {
            _context.SaveChanges();
        }

        public Venta Get(int id, bool includeRelatedEntities = true)
        {
            var Venta = _context.Ventas.AsQueryable();

            if (includeRelatedEntities)
            {
                Venta = Venta
                .Include(a => a.DetalleVenta).ThenInclude(a => a.Producto)
                .Include(a => a.DetalleVenta).ThenInclude(a => a.Servicio)
                .Include(a => a.Pagos).ThenInclude(a => a.FormaPago)
                .Include(a => a.Empleado)
                .Include(a=> a.Paciente);
            }

            return Venta.Where(a => a.Id == id).SingleOrDefault();
        }

        public void Delete(int id, bool savechanges = true)
        {
            var set = _context.Set<DetalleVenta>();
            var entity = set.Find(id);
            set.Remove(entity);

            if (true)
            {
                _context.SaveChanges();

            }

        }

        public void Update(Venta model, bool saveChanges = true)
        {

            _context.Entry(model).State = EntityState.Modified;

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }





    }

}



