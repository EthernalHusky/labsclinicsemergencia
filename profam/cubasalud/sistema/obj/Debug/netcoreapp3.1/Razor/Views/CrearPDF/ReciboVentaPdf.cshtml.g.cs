#pragma checksum "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c2650dc4feeb0471e0555405b669b8c4d30b250"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CrearPDF_ReciboVentaPdf), @"mvc.1.0.view", @"/Views/CrearPDF/ReciboVentaPdf.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/_ViewImports.cshtml"
using farmamest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/_ViewImports.cshtml"
using farmamest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c2650dc4feeb0471e0555405b669b8c4d30b250", @"/Views/CrearPDF/ReciboVentaPdf.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_CrearPDF_ReciboVentaPdf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Database.Shared.Models.Venta>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
  
Layout = "_HojaLayout";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
  
  decimal total = 0.00m;
  string codigo = Guid.NewGuid().ToString();
  

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div id=\"showScroll\" class=\"container\">\n\n\t<div class=\"receipt\">\n\t\t<h2 class=\"logo\">RED OWL SOFTWARE</h2>\n        <div class=\"address text-center\">\n");
            WriteLiteral("           Aldea Buena Vista, zona 0, 01 Avenida Sur 1-01, Chimaltenango, Chimaltenango\n        </div>\n\t\t<div class=\"transactionDetails\">\n\t\t\t<div class=\"detail\">Fecha: ");
#nullable restore
#line 22 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
                                  Write(Model.FechaVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\t\t\t<div class=\"detail\">Le atendió: ");
#nullable restore
#line 23 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
                                       Write(Model.Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n\n\n    <div class=\"detail\">\n       \n      </div>\n      <br>\n      <div class=\"detail\">\n        Cliente: ");
#nullable restore
#line 32 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
            Write(Model.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      </div>\n      <div class=\"detail\">\n        NIT: ");
#nullable restore
#line 35 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
        Write(Model.Nit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      </div>\n      <div class=\"detail\">\n        Dirección: ");
#nullable restore
#line 38 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
              Write(Model.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n      </div>\n\t</div>\n  \n\n<table class=\"table borderless\">\n\t<thead>\n\t\t<tr>\n\t\t\t<th colspan>cant</th>\n\t\t\t<th colspan>descr</th>\n\t\t\t<th colspan>monto</th>\n\t\t</tr>\n\t</thead>\n\t<tbody>\n\n");
#nullable restore
#line 53 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
     foreach(var item in Model.DetalleVenta)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr style=\"line-height: 0.9em;\">\n      <td class=\"leftHeader\">");
#nullable restore
#line 56 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
                        Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td class=\"leftHeader\">\n");
#nullable restore
#line 58 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
          if(item.Producto != null)
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
                                               Write(item.Producto.NombreProducto);

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
                                                                                 
                                                }
                                                else 
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
                                               Write(item.Servicio.NombreServicio);

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
                                                                                 
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </td>\n      <td class=\"leftHeader\">");
#nullable restore
#line 67 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
                        Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      \n    </tr>\n");
#nullable restore
#line 70 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
    
    total += @item.Total;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t</tbody>\n</table>\n\n\n\t\t\n\t\t<div class=\"paymentDetails bold\">\n\t\t\t<div class=\"detail\">TOTAL</div>\n\t\t\t<div class=\"detail\">Q ");
#nullable restore
#line 81 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
                             Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\t\t</div>\n\n");
#nullable restore
#line 84 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
     foreach(var item in Model.Pagos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"paymentDetails bold\">\n\t\t\t<div class=\"detail\">");
#nullable restore
#line 87 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
                           Write(item.FormaPago.NombreFormaPago);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\t\t\t<div class=\"detail\">Q ");
#nullable restore
#line 88 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
                             Write(item.Monto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\t\t</div>\n");
#nullable restore
#line 90 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"paymentDetails bold\">\n\t\t\t<div class=\"detail\">VUELTO</div>\n\t\t\t<div class=\"detail\">Q ");
#nullable restore
#line 94 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
                             Write(Model.Vuelto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\t\t</div>\n\n");
            WriteLiteral("        \n            <br>\n        <div class=\"detail\">\n\n");
            WriteLiteral("\t\t</div>\n\n        \n\n\t\t<div class=\"receiptBarcode\">\n\t\t\t<div class=\"barcode\">\n\t\t\t\tHotel_Tzalamha\n\t\t\t</div>\n\t\t\t");
#nullable restore
#line 117 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/CrearPDF/ReciboVentaPdf.cshtml"
       Write(codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t</div>\n        \n        \n\t\t\n\t\t<div class=\"feedback\">\n      <div class=\"break\">\n\t\t\t\tGRACIAS POR SU COMPRA\n\t\t\t</div>\n\t\t\t<div class=\"break\">\n\t\t\t\t***********************\n\t\t\t</div>\n\t\t</div>\n\n        \t\n\t</div>\n</div>\n\n");
            DefineSection("css", async() => {
                WriteLiteral(@"
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=VT323&display=swap"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Libre+Barcode+128|VT323"" rel=""stylesheet"">
   <style>

* {
     margin: 0;
    box-sizing: border-box;
    font-family: 'VT323', monospace;
");
                WriteLiteral(@"    color: #1f1f1f;
    font-size: 20px;
  }
  
tr    { page-break-inside:avoid !important;
        page-break-after:auto !important;
      }

  .table thead tr th, .table tbody tr td {
    border: none;
}

  .container {

  }
  
  .bold {
    font-weight: bold;
  }
  
  .center {
    text-align: center;
  }
  
  .receipt {
    width: 64mm;
");
                WriteLiteral("    height: 100%;\n");
                WriteLiteral(@"  }
  
  .logo {
   text-align: center;
    padding: 20px;
    font-size : 1.5em;
  }
  
  .barcode {
    font-family: ""Libre Barcode 128"", cursive;
    font-size: 42px;
    text-align: center;
  }
  
  .address {
    text-align: center;
    margin-bottom: 10px;
  }
  
  .transactionDetails {
    display: flex;
    justify-content: space-between;
    margin: 0 5px 5px;
  }
  .transactionDetails .detail {
    text-transform: uppercase;
  }
  
  .centerItem {
    display: flex;
    justify-content: center;
    margin-bottom: 8px;
  }
  
  .survey {
    text-align: center;
    margin-bottom: 12px;
  }
  .survey .surveyID {
    font-size: 20px;
  }
  
  .paymentDetails {
    display: flex;
    justify-content: space-between;
    margin: 0 auto;
    width: 150px;
  }
  
  .creditDetails {
    margin: 10px auto;
    width: 230px;
    font-size: 14px;
    text-transform: uppercase;
  }
  
  .receiptBarcode {
    margin: 10px 0;
    text-align: center;
  }
  
  .returnPolicy {
    margin: 10px 20px;
    width: 220px;");
                WriteLiteral(@"
    display: flex;
    justify-content: space-between;
  }
  
  .coupons {
    margin-top: 20px;
  }
  
  .tripSummary {
    margin: auto;
    width: 255px;
  }
  .tripSummary .item {
    display: flex;
    justify-content: space-between;
    margin: auto;
    width: 220px;
  }
  
  .feedback {
    margin: 20px auto;
  }
  .feedback h3.clickBait {
    font-size: 30px;
    font-weight: bold;
    text-align: center;
    margin: 10px 0;
  }
  .feedback h4.web {
    font-size: 20px;
    font-weight: bold;
    text-align: center;
    margin: 10px 0;
  }
  .feedback .break {
    text-align: center;
    font-size: 18px;
    font-weight: bold;
    margin: 10px 0;
  }
  
  .couponContainer {
    border-top: 1px dashed #1f1f1f;
    margin-bottom: 20px;
  }
  .couponContainer .discount {
    font-size: 35px;
    text-align: center;
    margin-bottom: 10px;
  }
  .couponContainer .discountDetails {
    font-size: 20px;
    text-align: center;
    margin-bottom: 15px;
  }
  .couponContainer .barcode {
    margin: 10px 0 ");
                WriteLiteral(@"0;
  }
  .couponContainer .legal {
    font-size: 12px;
    margin-bottom: 12px;
  }
  .couponContainer .barcodeID {
    margin-bottom: 8px;
  }
  .couponContainer .expiration {
    display: flex;
    justify-content: space-between;
    margin: 10px;
  }
  .couponContainer .couponBottom {
    font-size: 13px;
    text-align: center;
  }
   </style>
");
            }
            );
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Database.Shared.Models.Venta> Html { get; private set; }
    }
}
#pragma warning restore 1591
