#pragma checksum "/root/profam/cubasalud/sistema/Views/CrearPDF/RutasPdf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e775c5971698d49c51d42c7ef94c5f191bad5eb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CrearPDF_RutasPdf), @"mvc.1.0.view", @"/Views/CrearPDF/RutasPdf.cshtml")]
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
#line 1 "/root/profam/cubasalud/sistema/Views/_ViewImports.cshtml"
using farmamest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/root/profam/cubasalud/sistema/Views/_ViewImports.cshtml"
using farmamest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e775c5971698d49c51d42c7ef94c5f191bad5eb2", @"/Views/CrearPDF/RutasPdf.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_CrearPDF_RutasPdf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Database.Shared.Models.Ruta>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/root/profam/cubasalud/sistema/Views/CrearPDF/RutasPdf.cshtml"
   

Layout = "_HojaLayout";

DateTime fecha = DateTime.Now;



#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n                <img width=\"40\"  src=\"/assets/images/farmamestlogo.png\"");
            BeginWriteAttribute("alt", " alt=\"", 186, "\"", 192, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                       <div class=\"text-right\" style=\"font-size: 12px;\">\n                            <label");
            BeginWriteAttribute("class", " class=\"", 302, "\"", 310, 0);
            EndWriteAttribute();
            WriteLiteral("><strong>Fecha y Hora de Emision: </strong>");
#nullable restore
#line 14 "/root/profam/cubasalud/sistema/Views/CrearPDF/RutasPdf.cshtml"
                                                                                 Write(fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label> &nbsp; &nbsp;
                            <br/>   
                        </div>
             
                    <table class=""table"">
                        <thead>
                        <tr>
                            <th>Direccion Destino</th>
                            <th>Descripcion</th>
                            

                            
                        </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 29 "/root/profam/cubasalud/sistema/Views/CrearPDF/RutasPdf.cshtml"
                             foreach(var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 32 "/root/profam/cubasalud/sistema/Views/CrearPDF/RutasPdf.cshtml"
                           Write(item.Destino);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 33 "/root/profam/cubasalud/sistema/Views/CrearPDF/RutasPdf.cshtml"
                           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                           \n                        </tr>\n");
#nullable restore
#line 36 "/root/profam/cubasalud/sistema/Views/CrearPDF/RutasPdf.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n         ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Database.Shared.Models.Ruta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
