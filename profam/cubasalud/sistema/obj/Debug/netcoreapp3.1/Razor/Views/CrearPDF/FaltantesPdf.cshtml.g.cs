#pragma checksum "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/FaltantesPdf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef7728a2a7411f9f1e2d0f79c4d82e505c1cd415"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CrearPDF_FaltantesPdf), @"mvc.1.0.view", @"/Views/CrearPDF/FaltantesPdf.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7728a2a7411f9f1e2d0f79c4d82e505c1cd415", @"/Views/CrearPDF/FaltantesPdf.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_CrearPDF_FaltantesPdf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Database.Shared.Models.Producto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/FaltantesPdf.cshtml"
   

Layout = "_HojaLayout";

DateTime fecha = DateTime.Now;



#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("                <img width=\"40\"  src=\"/assets/images/farmamestlogo.png\"");
            BeginWriteAttribute("alt", " alt=\"", 254, "\"", 260, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                       <div class=\"text-right\" style=\"font-size: 12px;\">\n                            <label");
            BeginWriteAttribute("class", " class=\"", 370, "\"", 378, 0);
            EndWriteAttribute();
            WriteLiteral("><strong>Fecha y Hora de Emision: </strong>");
#nullable restore
#line 17 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/FaltantesPdf.cshtml"
                                                                                 Write(fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label> &nbsp; &nbsp;
                            <br/>   
                        </div>
                
                    <table class=""table"">
                        <thead>
                            <tr >
                               
                                <th>Nombre Producto</th>
                                <th>Codigo Referencia</th>
                                <th>Stock</th>
                                <th>Precio</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 32 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/FaltantesPdf.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr >\n                                    <td>");
#nullable restore
#line 35 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/FaltantesPdf.cshtml"
                                   Write(item.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 36 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/FaltantesPdf.cshtml"
                                   Write(item.CodigoReferencia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 37 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/FaltantesPdf.cshtml"
                                   Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 38 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/FaltantesPdf.cshtml"
                                   Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                </tr>\n");
#nullable restore
#line 40 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/FaltantesPdf.cshtml"
                                
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n                ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Database.Shared.Models.Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
