using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Database.Shared.IRepository;
using sistema.Models;
using Database.Shared.Paginacion;
using System.Linq;
using Database.Shared.Models;
using Rotativa.AspNetCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using Database.Shared.Data;
using ClosedXML.Excel;
using System.IO;

namespace sistema.Controllers
{

    public class ReportesController : Controller
    {

        private readonly IVenta _ventaRepository = null;
        private readonly ICompra _compraRepository = null;
        private readonly IVentaServicio _ventaServicioRepository = null;
        private readonly IEmpleado _empleadoRepository = null;
        private readonly ICliente _clienteRepository = null;
        private readonly IProveedor _proveedorRepository = null;



        public ReportesController(IVenta ventaRepository, ICompra compraRepository, IVentaServicio ventaServicioRepository, IEmpleado empleadoRepository, ICliente clienteRepository, IProveedor proveedorRepository)
        {
            _ventaRepository = ventaRepository;
            _compraRepository = compraRepository;
            _ventaServicioRepository = ventaServicioRepository;
            _empleadoRepository = empleadoRepository;
            _clienteRepository = clienteRepository;
            _proveedorRepository = proveedorRepository;

        }
        public IActionResult Utilidad(string fecha)
        {
            var fechas = fecha.Split('-');
            var ventasutilidad = _ventaRepository.GetListadoFecha(Convert.ToDateTime(fechas[0]), Convert.ToDateTime(fechas[1]).AddDays(1));
            DateTime fechahoy = DateTime.Now;
            var row = 1;

            //var detalles = _ventaRepository.GetListadoDetalles();

            using (var workboook = new XLWorkbook())
            {
                var worksheet = workboook.Worksheets.Add("Reporte utilidad generado");

                worksheet.Cell(row, 1).Value = "Fecha Emision ";
                worksheet.Cell(row, 2).Value = fechahoy;
                row++;
                row++;

                worksheet.Cell(row, 1).Value = "Venta #";
                worksheet.Cell(row, 2).Value = "Fecha Venta";
                worksheet.Cell(row, 3).Value = "Cliente";
                worksheet.Cell(row, 4).Value = "Vendedor";
                worksheet.Cell(row, 5).Value = "Total Venta";
                worksheet.Cell(row, 6).Value = " Total Adquisición";
                worksheet.Cell(row, 7).Value = "Total Utilidad";


               
                
                var sumatoriaTotal = 0.00m;

                foreach (var uti in ventasutilidad)
                {
                    decimal utilidad = 0.00m;
                    decimal costot= 0.00m;
                    decimal ventat = 0.00m;
                    decimal total = 0.00m;

                    foreach (var item in uti.DetalleVenta)
                    {
                        // pcosto = item.Producto.PrecioCosto;
                        // costot += item.Producto.PrecioCosto;
                        // pventa = item.Precio;
                        ventat += item.Total;
                        costot += (item.Producto.PrecioCosto) * item.Cantidad;
                        utilidad = ventat - costot;
                        // cantidad = item.Cantidad;
                        // utilidad += cantidad * (pventa - pcosto);
                    }

                    total += utilidad;
                    sumatoriaTotal += total;


                    row++;
                    worksheet.Cell(row, 1).Value = uti.Id;
                    worksheet.Cell(row, 2).Value = uti.FechaVenta;
                    worksheet.Cell(row, 3).Value = uti.Paciente.Nombre;
                    worksheet.Cell(row, 4).Value = uti.Empleado.Nombre;
                    worksheet.Cell(row, 5).Value = "Q"+ventat;
                    worksheet.Cell(row, 6).Value = "Q"+costot;
                    worksheet.Cell(row, 7).Value = "Q"+utilidad;


                }

                row++;
                row++;
                worksheet.Cell(row, 7).Value = $"TOTAL: Q {sumatoriaTotal}" ;

                using (var stream = new MemoryStream())
                {
                    workboook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officefocument.spreadsheet",
                    "UtilidadVentas.xlsx"
                    );
                }

            }

        }

           public IActionResult ReporteVentas(string fecha, int? empleadoid )
        {
            var fechas = fecha.Split('-');
            var ventas = new List<Venta>();
            
            if(empleadoid == null)
            {
                ventas = _ventaRepository.GetListadoFecha(Convert.ToDateTime(fechas[0]), Convert.ToDateTime(fechas[1]).AddDays(1));
            }
            else
            {
                ventas = _ventaRepository.GetListadoFechaEmpleado(Convert.ToDateTime(fechas[0]), Convert.ToDateTime(fechas[1]).AddDays(1),empleadoid); 
            }

           

            DateTime fechahoy = DateTime.Now; 
            var row = 1;
            var total=0.00m;
            var subtotal=0.00m;
            var descuento=0.00m;




            //var detalles = _ventaRepository.GetListadoDetalles();

            using (var workboook = new XLWorkbook())
            {
                var worksheet = workboook.Worksheets.Add("Ventas");

                worksheet.Cell(row, 1).Value = "Fecha Emision ";
                worksheet.Cell(row, 2).Value = fechahoy;
                row++;
                row++;
                
                worksheet.Cell(row, 1).Value = "Vendedor";
                worksheet.Cell(row, 2).Value = "Venta #";
                worksheet.Cell(row, 3).Value = "Cliente";
                worksheet.Cell(row, 4).Value = "NoComprobante";
                worksheet.Cell(row, 5).Value = "Nit";
                worksheet.Cell(row, 6).Value = "Nombres";
                worksheet.Cell(row, 7).Value = "Direccion";
                worksheet.Cell(row, 8).Value = "FechaVenta";
                worksheet.Cell(row, 9).Value = "Subtotal";
                worksheet.Cell(row, 10).Value = "Descuento";
                worksheet.Cell(row, 11).Value = "Total";




                foreach (var ven in ventas)
                {
                     row++;
                    worksheet.Cell(row, 1).Value = ven.Empleado.Nombre;
                    worksheet.Cell(row, 2).Value = ven.Id;
                    worksheet.Cell(row, 3).Value = ven.Clientes.Nombre;
                    worksheet.Cell(row, 4).Value = ven.NoComprobante;
                    worksheet.Cell(row, 5).Value = ven.Nit;
                    worksheet.Cell(row, 6).Value = ven.Nombres;
                    worksheet.Cell(row, 7).Value = ven.Direccion;
                    worksheet.Cell(row, 8).Value = ven.FechaVenta;
                    worksheet.Cell(row, 9).Value = ven.DetalleVenta.Sum(a => a.Subtotal);
                    worksheet.Cell(row, 10).Value = ven.DetalleVenta.Sum(a => a.Descuento);
                    worksheet.Cell(row, 11).Value = ven.DetalleVenta.Sum(a => a.Total);

                    subtotal+=ven.DetalleVenta.Sum(a => a.Subtotal);
                    descuento+=ven.DetalleVenta.Sum(a => a.Descuento);
                    total+=ven.DetalleVenta.Sum(a => a.Total);

                }

                row++;
                worksheet.Cell(row, 10).Value = "Subtotal ";
                worksheet.Cell(row, 11).Value = "Q"+subtotal;

                 row++;
                worksheet.Cell(row, 10).Value = "Descuento ";
                worksheet.Cell(row, 11).Value = "Q"+descuento;

                 row++;
                worksheet.Cell(row, 10).Value = "Total ";
                worksheet.Cell(row, 11).Value = "Q"+total;


                using (var stream = new MemoryStream())
                {
                    workboook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officefocument.spreadsheet",
                    "Ventas - "+fechas[0]+"a "+fechas[1]+".xlsx"
                    );

                }



            }

        }

         public IActionResult ReporteCompras(string fecha, int? empleadoid )
        {
        

            var fechas = fecha.Split('-');

            var compras = new List<Compra>();

            
            if(empleadoid == null)
            {
                 compras = _compraRepository.GetListadoFecha(Convert.ToDateTime(fechas[0]), Convert.ToDateTime(fechas[1]).AddDays(1));
            }
            else
            {
                 compras = _compraRepository.GetListadoFechaEmpleado(Convert.ToDateTime(fechas[0]), Convert.ToDateTime(fechas[1]).AddDays(1),empleadoid); 
            }

           

            DateTime fechahoy = DateTime.Now; 
            var row = 1;
            var total=0.00m;




            //var detalles = _ventaRepository.GetListadoDetalles();

            using (var workboook = new XLWorkbook())
            {
                var worksheet = workboook.Worksheets.Add("Compras");

                worksheet.Cell(row, 1).Value = "Fecha Emision ";
                worksheet.Cell(row, 2).Value = fechahoy;
                row++;
                row++;
                
                worksheet.Cell(row, 1).Value = "Empleado";
                worksheet.Cell(row, 2).Value = "Compra #";
                worksheet.Cell(row, 3).Value = "Proveedor";
                worksheet.Cell(row, 4).Value = "NoComprobante";
                worksheet.Cell(row, 5).Value = "Estado";
                worksheet.Cell(row, 6).Value = "FechaVenta";
                worksheet.Cell(row, 7).Value = "Total";




                foreach (var com in compras)
                {
                     row++;
                    worksheet.Cell(row, 1).Value = com.Empleado.Nombre;
                    worksheet.Cell(row, 2).Value = com.Id;
                    worksheet.Cell(row, 3).Value = com.Proveedor.Nombre;
                    worksheet.Cell(row, 4).Value = com.NoComprobante;
                    worksheet.Cell(row, 5).Value = com.verEstado();
                    worksheet.Cell(row, 6).Value = com.FechaCompra;
                    worksheet.Cell(row, 7).Value =com.DetalleCompras.Sum(a => a.PrecioTotal);

                  
                    total+=com.DetalleCompras.Sum(a => a.PrecioTotal);

                }

                 row++;
                worksheet.Cell(row, 6).Value = "Total ";
                worksheet.Cell(row, 7).Value = "Q"+total;


                using (var stream = new MemoryStream())
                {
                    workboook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officefocument.spreadsheet",
                    "Compras.xlsx"
                    );

                }



            }

        }

           public IActionResult ReporteVentasServicios(string fecha, int? empleadoid )
        {
        

            var fechas = fecha.Split('-');

            var ventas= new List<VentaServicio>();

            
            if(empleadoid == null)
            {
                 ventas = _ventaServicioRepository.GetListadoFecha(Convert.ToDateTime(fechas[0]), Convert.ToDateTime(fechas[1]).AddDays(1));
            }
            else
            {
                 ventas = _ventaServicioRepository.GetListadoFechaEmpleado(Convert.ToDateTime(fechas[0]), Convert.ToDateTime(fechas[1]).AddDays(1),empleadoid); 
            }

           

            DateTime fechahoy = DateTime.Now; 
           var row = 1;
            var total=0.00m;
            var subtotal=0.00m;
            var descuento=0.00m;



            //var detalles = _ventaRepository.GetListadoDetalles();

             using (var workboook = new XLWorkbook())
            {
                var worksheet = workboook.Worksheets.Add("VentasServicios");

                worksheet.Cell(row, 1).Value = "Fecha Emision ";
                worksheet.Cell(row, 2).Value = fechahoy;
                row++;
                row++;
                
                worksheet.Cell(row, 1).Value = "Vendedor";
                worksheet.Cell(row, 2).Value = "Venta #";
                worksheet.Cell(row, 3).Value = "Cliente";
                worksheet.Cell(row, 4).Value = "NoComprobante";
                worksheet.Cell(row, 5).Value = "Nit";
                worksheet.Cell(row, 6).Value = "Nombres";
                worksheet.Cell(row, 7).Value = "Direccion";
                worksheet.Cell(row, 8).Value = "FechaVenta";
                worksheet.Cell(row, 9).Value = "Subtotal";
                worksheet.Cell(row, 10).Value = "Descuento";
                worksheet.Cell(row, 11).Value = "Total";




                foreach (var ven in ventas)
                {
                     row++;
                    worksheet.Cell(row, 1).Value = ven.Empleado.Nombre;
                    worksheet.Cell(row, 2).Value = ven.Id;
                    worksheet.Cell(row, 3).Value = ven.Paciente.Nombre;
                    worksheet.Cell(row, 4).Value = ven.NoComprobante;
                    worksheet.Cell(row, 5).Value = ven.Nit;
                    worksheet.Cell(row, 6).Value = ven.Nombres;
                    worksheet.Cell(row, 7).Value = ven.Direccion;
                    worksheet.Cell(row, 8).Value = ven.FechaVenta;
                    worksheet.Cell(row, 9).Value = ven.DetalleServicio.Sum(a => a.Subtotal);
                    worksheet.Cell(row, 10).Value = ven.DetalleServicio.Sum(a => a.Descuento);
                    worksheet.Cell(row, 11).Value = ven.DetalleServicio.Sum(a => a.Total);

                    subtotal+=ven.DetalleServicio.Sum(a => a.Subtotal);
                    descuento+=ven.DetalleServicio.Sum(a => a.Descuento);
                    total+=ven.DetalleServicio.Sum(a => a.Total);

                }

                row++;
                worksheet.Cell(row, 10).Value = "Subtotal ";
                worksheet.Cell(row, 11).Value = "Q"+subtotal;

                 row++;
                worksheet.Cell(row, 10).Value = "Descuento ";
                worksheet.Cell(row, 11).Value = "Q"+descuento;

                 row++;
                worksheet.Cell(row, 10).Value = "Total ";
                worksheet.Cell(row, 11).Value = "Q"+total;


                using (var stream = new MemoryStream())
                {
                    workboook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officefocument.spreadsheet",
                    "VentasServicios.xlsx"
                    );

                }



            }

        }

        public IActionResult ReporteEmpleados()
        {

    
            var empleado = _empleadoRepository.GetList(); 

            DateTime fechahoy = DateTime.Now; 
            var row = 1;
           


            using (var workboook = new XLWorkbook())
            {
                var worksheet = workboook.Worksheets.Add("Ventas");

                worksheet.Cell(row, 1).Value = "Fecha Emision ";
                worksheet.Cell(row, 2).Value = fechahoy;
                row++;
                row++;
                
                worksheet.Cell(row, 1).Value = "Codigo";
                worksheet.Cell(row, 2).Value = "Nombre";
                worksheet.Cell(row, 3).Value = "Apellido";
                worksheet.Cell(row, 4).Value = "Direccion";
                worksheet.Cell(row, 5).Value = "Edad";
                worksheet.Cell(row, 6).Value = "Sueldo";
                worksheet.Cell(row, 7).Value = "Telefono";
                worksheet.Cell(row, 8).Value = "Dpi";
                worksheet.Cell(row, 9).Value = "Nit";
                worksheet.Cell(row, 10).Value = "Estado Civil";


                foreach (var em in empleado)
                {
                     row++;
                    worksheet.Cell(row, 1).Value = em.Id;
                    worksheet.Cell(row, 2).Value = em.Nombre;
                    worksheet.Cell(row, 3).Value = em.Apellido;
                    worksheet.Cell(row, 4).Value = em.Direccion;
                    worksheet.Cell(row, 5).Value = em.Edad;
                    worksheet.Cell(row, 6).Value = em.Salario;
                    worksheet.Cell(row, 7).Value = em.Telefono;
                    worksheet.Cell(row, 8).Value = em.Dpi;
                    worksheet.Cell(row, 9).Value = em.Nit;
                    worksheet.Cell(row, 10).Value = em.EstadoCivil;
        
                }


                using (var stream = new MemoryStream())
                {
                    workboook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officefocument.spreadsheet",
                    "Personal - "+fechahoy+".xlsx"
                    );

                }



            }

        }

           public IActionResult ReporteClientes()
        {

    
            var clientes = _clienteRepository.GetList(); 

            DateTime fechahoy = DateTime.Now; 
            var row = 1;
           


            using (var workboook = new XLWorkbook())
            {
                var worksheet = workboook.Worksheets.Add("Clientes");

                worksheet.Cell(row, 1).Value = "Fecha Emision ";
                worksheet.Cell(row, 2).Value = fechahoy;
                row++;
                row++;
                
                worksheet.Cell(row, 1).Value = "Nombre";
                worksheet.Cell(row, 2).Value = "Direccion";
                worksheet.Cell(row, 3).Value = "Telefono";
                worksheet.Cell(row, 4).Value = "Nit";
                worksheet.Cell(row, 5).Value = "Alias";
  




                foreach (var item in clientes)
                {
                     row++;
                    worksheet.Cell(row, 1).Value = item.Nombre;
                    worksheet.Cell(row, 2).Value = item.Direccion;
                    worksheet.Cell(row, 3).Value = item.Telefono;
                    worksheet.Cell(row, 4).Value = item.Nit;
                    // worksheet.Cell(row, 5).Value = item.Alias;
        
                }


                using (var stream = new MemoryStream())
                {
                    workboook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officefocument.spreadsheet",
                    "Clientes- "+fechahoy+".xlsx"
                    );

                }



            }

        }

        
        public IActionResult ReporteProveedores()
        {

    
            var proveedores = _proveedorRepository.GetList(); 

            DateTime fechahoy = DateTime.Now; 
            var row = 1;
           


            using (var workboook = new XLWorkbook())
            {
                var worksheet = workboook.Worksheets.Add("Proveedores");

                worksheet.Cell(row, 1).Value = "Fecha Emision ";
                worksheet.Cell(row, 2).Value = fechahoy;
                row++;
                row++;
                
                worksheet.Cell(row, 1).Value = "Nombre";
                worksheet.Cell(row, 2).Value = "Giro";
                worksheet.Cell(row, 3).Value = "Telefono";
                worksheet.Cell(row, 4).Value = "Nit";
                worksheet.Cell(row, 5).Value = "Direccion";
                worksheet.Cell(row, 6).Value = "Correo";
                worksheet.Cell(row, 7).Value = "Celular";
                worksheet.Cell(row, 8).Value = "Cuenta Bancaria";
                worksheet.Cell(row, 9).Value = "Tipo de Proveedor";
                worksheet.Cell(row, 10).Value = "Observaciones";
               
  
                foreach (var item in proveedores)
                {
                     row++;
                    worksheet.Cell(row, 1).Value = item.Nombre;
                    worksheet.Cell(row, 2).Value = item.Giro;
                    worksheet.Cell(row, 3).Value = item.Telefono_1;
                    worksheet.Cell(row, 4).Value = item.Nit;
                    worksheet.Cell(row, 5).Value = item.Direccion;
                    worksheet.Cell(row, 6).Value = item.Correo;
                    worksheet.Cell(row, 7).Value = item.Celular_1;
                    worksheet.Cell(row, 8).Value = item.CuentaBancaria;
                    worksheet.Cell(row, 9).Value = item.TipoProveedor;
                    worksheet.Cell(row, 10).Value = item.Observaciones;
        
                }


                using (var stream = new MemoryStream())
                {
                    workboook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officefocument.spreadsheet",
                    "Proveedores- "+fechahoy+".xlsx"
                    );

                }



            }

        }

    }


}