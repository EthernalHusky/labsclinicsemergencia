#pragma checksum "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a69abda2a8776aa19a19161bebe9aff63297727"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CrearPDF_DetalleCotizacionListaPdf), @"mvc.1.0.view", @"/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml")]
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
#line 1 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/_ViewImports.cshtml"
using farmamest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/_ViewImports.cshtml"
using farmamest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a69abda2a8776aa19a19161bebe9aff63297727", @"/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_CrearPDF_DetalleCotizacionListaPdf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Database.Shared.Models.Cotizacion>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
  
    ViewData["Title"] = "Lista Productos";
   Layout = "_HojaLayout";
    int porc = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 9 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
 foreach(var item in Model)
 {
                     

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                     <div class=""form-row"">
                                   
                                    <hr style=""border-top: 3px double #8c8b8b;"">
                                    <div class=""col-md-6"">
                                        <div class=""position-relative form-group""><label");
            BeginWriteAttribute("class", " class=\"", 510, "\"", 518, 0);
            EndWriteAttribute();
            WriteLiteral("><strong>Cotizacion #: </strong></label>\n                                             <label");
            BeginWriteAttribute("class", " class=\"", 611, "\"", 619, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                           
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""position-relative form-group""><label");
            BeginWriteAttribute("class", " class=\"", 919, "\"", 927, 0);
            EndWriteAttribute();
            WriteLiteral("><strong>Fecha Cotizacion: </strong></label>\n                                            <label");
            BeginWriteAttribute("class", " class=\"", 1023, "\"", 1031, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
                                                       Write(item.FechaCotizacion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                        </div>
                                    </div>
                                    
                                     <div class=""col-md-6"">
                                        <div class=""position-relative form-group""><label");
            BeginWriteAttribute("class", " class=\"", 1338, "\"", 1346, 0);
            EndWriteAttribute();
            WriteLiteral("><strong>Cliente: </strong></label>\n                                             <label");
            BeginWriteAttribute("class", " class=\"", 1434, "\"", 1442, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
                                                        Write(item.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                           
                                        </div>
                                    </div>
                                     <div class=""col-md-6"">
                                        <div class=""position-relative form-group""><label");
            BeginWriteAttribute("class", " class=\"", 1748, "\"", 1756, 0);
            EndWriteAttribute();
            WriteLiteral("><strong>Nit Cliente: </strong></label>\n                                             <label");
            BeginWriteAttribute("class", " class=\"", 1848, "\"", 1856, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
                                                        Write(item.Nit);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                           
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""position-relative form-group""><label");
            BeginWriteAttribute("class", " class=\"", 2157, "\"", 2165, 0);
            EndWriteAttribute();
            WriteLiteral("><strong>Valido Hasta: </strong></label>\n                                             <label");
            BeginWriteAttribute("class", " class=\"", 2258, "\"", 2266, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 41 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
                                                        Write(item.FechaValida);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                           
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""position-relative form-group""><label");
            BeginWriteAttribute("class", " class=\"", 2575, "\"", 2583, 0);
            EndWriteAttribute();
            WriteLiteral("><strong>Total: </strong></label>\n                                             <label");
            BeginWriteAttribute("class", " class=\"", 2669, "\"", 2677, 0);
            EndWriteAttribute();
            WriteLiteral(">Q ");
#nullable restore
#line 47 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
                                                          Write(item.DetalleCotizacion.Sum(a => a.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                                           \n                                        </div>\n                                    </div>\n                                  \n                                </div>\n");
            WriteLiteral(@"                    <table class="" table  "">
                        <thead>
                        <tr>
                       
                            <th>Nombre Producto</th>
                            <th>Cantidad</th>
                            <th>Precio</th>
                            <th>%</th>
                            <th>Descuento</th>
                            <th>Subtotal</th>
                            <th>Total</th>
                        </tr>
                        </thead>
                        <tbody>
                            
                      
                            
                        
");
#nullable restore
#line 74 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
                             foreach(var det in item.DetalleCotizacion)
                            {
                                
                                            if(det.Descuento == 0 || det.Subtotal == 0){
                                                porc = 0;
                                            }
                                            else 
                                            {
                                                porc = Convert.ToInt32((det.Descuento / det.Subtotal) * 100);
                                            }
                                           

#line default
#line hidden
#nullable disable
            WriteLiteral("                                     <tr>\n                                     \n                                        <td>");
#nullable restore
#line 87 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
                                       Write(det.Producto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 88 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
                                       Write(det.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>Q ");
#nullable restore
#line 89 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
                                         Write(det.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 90 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
                                       Write(porc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>Q ");
#nullable restore
#line 91 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
                                         Write(det.Descuento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td class=\"subtotal-t\">Q ");
#nullable restore
#line 92 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
                                                            Write(det.Subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td class=\"total-t\">Q ");
#nullable restore
#line 93 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
                                                         Write(det.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td style=\"display: none;\" class=\"idProd\">");
#nullable restore
#line 94 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
                                                                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    </tr>\n");
#nullable restore
#line 96 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            \n                            \n                    \n                        </tbody>\n                    </table>\n");
#nullable restore
#line 102 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/DetalleCotizacionListaPdf.cshtml"
        


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Database.Shared.Models.Cotizacion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
