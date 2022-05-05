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
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity;
using sistema.Areas.Identity.Pages.Account;
using Microsoft.Extensions.Logging;
using Wkhtmltopdf.NetCore;
using Rotativa;



namespace sistema.Controllers
{

    public class CrearPdfController : Controller
    {

        private readonly IGeneratePdf _generatePdf;
        // private readonly SignInManager<User> _signInManager;
        // private readonly ILogger<LogoutModel> _logger;
        private readonly IVenta _ventaRepository = null;
        private readonly ICotizacion _cotizacionRepository = null;
        private readonly IProducto _productoRepository = null;
        private readonly IEmpleado _empleadoRepository = null;
        private readonly IProveedor _proveedorRepository = null;
        private readonly ICliente _clienteRepository = null;
        private readonly ICompra _compraRepository = null;
        private readonly IVentaServicio _ventaServicioRepository = null;
        private readonly IServicio _servicioRepository = null;
        private readonly IRuta _rutaRepository = null;
        private readonly IGasto _gastoRepository = null;
        private readonly ICaja _cajaRepository = null;
        private readonly ICajaClinica _cajaClinicaRepository = null;
        private readonly IEnvio _envioRepository = null;
        private readonly IDespegablesProducto _categoriaRepository = null;
        private readonly ICategoriaGasto _categoriaGastoRepository = null;
        private readonly IUser _userRepository = null;
        private readonly ILaboratorioClinico _laboratorioClinico = null;


         public CrearPdfController(IVenta ventaRepository, ICotizacion cotizacionRepository, IProducto productoRepository, 
         IEmpleado empleadoRepository, IProveedor proveedorRepository, ICliente clienteRepository, 
         ICompra compraRepository, IVentaServicio ventaServicioRepository, IServicio servicioRepository, 
         IRuta rutaRepository,IGasto gastoRepository, ICaja cajaRepository,IEnvio envioRepository, ICategoriaGasto categoriaGastoRepository, 
         IDespegablesProducto categoriaRepository, IUser userRepository, IGeneratePdf generatePdf,ICajaClinica cajaClinicaRepository,
         ILaboratorioClinico laboratorioClinico)
        {
            _ventaRepository = ventaRepository;
            _cotizacionRepository = cotizacionRepository;
            _productoRepository = productoRepository;
            _empleadoRepository = empleadoRepository;
            _proveedorRepository = proveedorRepository;
            _clienteRepository = clienteRepository;
            _compraRepository = compraRepository;
            _ventaServicioRepository = ventaServicioRepository;
            _servicioRepository = servicioRepository;
            _rutaRepository = rutaRepository;
            _gastoRepository = gastoRepository;
            _cajaRepository = cajaRepository;
            _envioRepository = envioRepository;
            _categoriaGastoRepository = categoriaGastoRepository;
            _categoriaRepository = categoriaRepository;
            _userRepository = userRepository;
            _generatePdf = generatePdf;
            _cajaClinicaRepository = cajaClinicaRepository;
            _laboratorioClinico = laboratorioClinico;


        }

        public async Task<IActionResult> ReciboVentaPdf(int? id)
        {
            if(id == null)
            {
                return StatusCode(404);
            }

            var venta = _ventaRepository.Get((int)id);

            if(venta == null)
            {
                return StatusCode(400);
            }
            
            // var model = new VentaBaseViewModel(){
                
            //     Venta = venta,
            // };

            // int tam = model.Venta.DetalleVenta.Count();
        
            // var view = new ViewAsPdf("ReciboVentaPdf", model)
            // {
            //     PageMargins = { Left = 5, Bottom = 2, Right = 5, Top = 2 }, 
            // };

            // view.PageWidth = 40;
            // view.PageHeight =(93 +(tam*5)); 

            var options = new ConvertOptions
            {
                PageMargins = {Top = 0, Left = 0, Right = 0, Bottom = 0},
                // PageSize = Wkhtmltopdf.NetCore.Options.Size.B9,
                PageWidth = 58.0,
                PageHeight = 600,
            };

            // return new ViewAsPdf("ReciboVentaPdf",model)
            //  {  
            //   PageWidth: 600,
            //  // PageSize=Rotativa.Options.Size.A4, 
              
            //  };

             _generatePdf.SetConvertOptions(options);

            return await _generatePdf.GetPdf("Views/CrearPDF/ReciboVentaPdf.cshtml", venta);
        }

        public async Task<IActionResult> ReciboServicios(int? id)
        {
             if(id == null)
            {
                return StatusCode(404);
            }

            var ventaServicio = _ventaServicioRepository.Get((int)id);

            if(ventaServicio == null)
            {
                return StatusCode(400);
            }

            var options = new ConvertOptions
            {
                PageMargins = {Top = 0, Left = 0, Right = 0, Bottom = 0},
                // PageSize = Wkhtmltopdf.NetCore.Options.Size.B9,
                PageWidth = 58.0,
                PageHeight = 600,
            };

             _generatePdf.SetConvertOptions(options);

            return await _generatePdf.GetPdf("Views/CrearPDF/ReciboServicios.cshtml", ventaServicio);
        }

        public IActionResult Utilidad()
        {

            var ventas = _ventaRepository.GetListado();

            var model = new VentaBaseViewModel(0){
                
                ListaVentas = ventas,
            };

            return new ViewAsPdf("Utilidad",model);
           
        }

        public IActionResult Cotizacion(int id)
        {

            var cotizacion = _cotizacionRepository.Get(id);

           

            return new ViewAsPdf("Cotizacion",cotizacion);
        }

    //      public IActionResult FaltantesPdf()
    //      {

    //         var productos = _productoRepository.GetListadoFaltantes();



    //             return new ViewAsPdf("FaltantesPdf",productos)
    //          {  
    //     //CustomSwitches = "--disable-smart-shrinking",
    //     CustomSwitches = "--page-offset 0 --footer-center [page] --footer-font-size 12",
    //    // PageMargins = new Rotativa.Options.Margins(40, 10, 10, 10),
    //    PageMargins = { Left = 5, Bottom = 8, Right = 5, Top = 5 }, 
    //   //PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
    //   // PageOrientation = Rotativa.AspNetCore.Options.Orientation.Landscape,
              
    //          }; 
    //     }

        public IActionResult ProveedoresPdf()
         {

            var proveedores = _proveedorRepository.GetList();

           

            return new ViewAsPdf("ProveedoresPdf",proveedores);
        }

        public IActionResult EmpleadosPdf()
         {

            var empleados = _empleadoRepository.GetList();

           

            return new ViewAsPdf("EmpleadosPdf",empleados);
        }

        public IActionResult ClientesPdf()
         {

            var clientes = _clienteRepository.GetList();

           

            return new ViewAsPdf("ClientesPdf",clientes);
        }


        public IActionResult ImprimirPDFVentas(IList<Venta> venta)
        {
            return new ViewAsPdf("ImprimirPDFVentas",venta);
        }

        public IActionResult ComprasPdf(string fecha, int? empleadoid)
         {

              var fechas = fecha.Split('-');
              var compras = new List<Compra>();

             if(empleadoid == null)
            {
                
                compras = _compraRepository.GetListadoFecha(Convert.ToDateTime(fechas[0]), Convert.ToDateTime(fechas[1]).AddDays(1));
                //return Json (ventas);
            }
            else
            {
                 compras = _compraRepository.GetListadoFechaEmpleado(Convert.ToDateTime(fechas[0]), Convert.ToDateTime(fechas[1]).AddDays(1),empleadoid); 
                //return Json (ventas);
            }
            
            return new ViewAsPdf("ComprasPdf",compras);
        }

        

        public IActionResult VentasServiciosPdf(string fecha,int? empleadoid)
         {

              var fechas = fecha.Split('-');
              var ventas = new List<VentaServicio>();

             if(empleadoid == null)
            {
                
                ventas = _ventaServicioRepository.GetListadoFecha(Convert.ToDateTime(fechas[0]), Convert.ToDateTime(fechas[1]).AddDays(1));
                //return Json (ventas);
            }
            else
            {
                 ventas = _ventaServicioRepository.GetListadoFechaEmpleado(Convert.ToDateTime(fechas[0]), Convert.ToDateTime(fechas[1]).AddDays(1),empleadoid); 
                //return Json (ventas);
            }
            
            return new ViewAsPdf("VentasServiciosPdf",ventas);
        }

         public IActionResult ServiciosPdf()
         {

            var servicios = _servicioRepository.GetList();

           

            return new ViewAsPdf("ServiciosPdf",servicios);
        }

         public IActionResult RutasPdf()
         {

            var servicios = _rutaRepository.GetList();


            return new ViewAsPdf("RutasPdf",servicios);
        }

        public IActionResult GastosPdf()
         {

            var gastos = _gastoRepository.GetList();
            

            return new ViewAsPdf("GastosPdf",gastos);
        }

        public IActionResult CategoriasPdf()
         {

            var categorias = _categoriaRepository.ListarCategorias();
            

            return new ViewAsPdf("CategoriasPdf",categorias);
        }

        public IActionResult CategoriasGastosPdf()
         {

            var categorias = _categoriaGastoRepository.ListarCategorias();
            

            return new ViewAsPdf("CategoriasGastosPdf",categorias);
        }
        // public IActionResult UsuariosPdf()
        //  {
        //    var usuarios = new LogoutModel(_signInManager, _logger) { };

        //     usuarios.Init(_userRepository);

        //     return new ViewAsPdf("UsuariosPdf",usuarios);
        // }

         public IActionResult CajasPdf(string fecha)
         {

              var fechas = fecha.Split('-');
            
                
             var  cajas = _cajaRepository.GetListadoFecha(Convert.ToDateTime(fechas[0]), Convert.ToDateTime(fechas[1]).AddDays(1));

             var model = new CajaBaseViewModel(){
                 ListaCajas = cajas
             };
                //return Json (ventas);
            
            
            return new ViewAsPdf("CajasPdf",model);
        }


         public IActionResult CajaDetallePdfClinica(int? id)
         {
             if (id == null)
            {
                return BadRequest("request is incorrect");
            }

            var caja = _cajaClinicaRepository.GetCaja((int)id);

            if (caja == null)
            {
                return StatusCode(404);
            }

            var model = new CajaClinicaBaseViewModel()
            {
                CajaClinica = caja
            };

            return new ViewAsPdf("CajaDetalleClinicaPDF",model);
        }

         public IActionResult EnviosPdf(string fecha)
         {

              var fechas = fecha.Split('-');
              

            
              var  ventas = _ventaServicioRepository.GetListadoFecha(Convert.ToDateTime(fechas[0]), Convert.ToDateTime(fechas[1]).AddDays(1));
                //return Json (ventas);
           
            
            return new ViewAsPdf("VentasServiciosPdf",ventas);
        }

        public IActionResult CategoriasLabClinico()
        {

              var lista = _laboratorioClinico.GetListCategoriasLab();
            
            return new ViewAsPdf("CategoriasLabClinicoPDF",lista);
        }

        public IActionResult GenerarReporteExamen(int id)
        {
            var lista = _laboratorioClinico.GetExamenRealizado(id);
            
            return new ViewAsPdf("GenerarReporteExamen",lista);
        }

        public IActionResult GenerarResultados(int id)
        {
            var lista = _laboratorioClinico.GetExamenRealizado(id);
            
            return new ViewAsPdf("GenerarResultados",lista);
        }
        

         public IActionResult CotizacionesListaPdf()
         {

              var cotizaciones = _cotizacionRepository.GetList();
            
           
            
            return new ViewAsPdf("CotizacionesListaPdf",cotizaciones);
        }

         public IActionResult DetalleCotizacionListaPdf()
         {

              var cotizaciones = _cotizacionRepository.GetList();
            
           
            
            return new ViewAsPdf("DetalleCotizacionListaPdf",cotizaciones);
        }
        

    }

}