#pragma checksum "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/Productos/FaltantesClinica.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c01f54e20656c3fb3b4486b482351659d435b73b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_FaltantesClinica), @"mvc.1.0.view", @"/Views/Productos/FaltantesClinica.cshtml")]
namespace AspNetCore
{
    #line hidden
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
#nullable restore
#line 1 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/Productos/FaltantesClinica.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/Productos/FaltantesClinica.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c01f54e20656c3fb3b4486b482351659d435b73b", @"/Views/Productos/FaltantesClinica.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_FaltantesClinica : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Database.Shared.Models.Producto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/Productos/FaltantesClinica.cshtml"
  
    Layout = "_HojaLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t<div>\n\t\t<div class=\"text-center\" style=\"border: 1px black solid;\">\n\t\t\t<h4> Reporte de productos con bajo stock </h4>\n\t\t\t<h6>RED OWL SOFTWARE</h6>\n\t\t</div>\n\t</div>\n\t<br>\n\t<div>\n\t\t<span class=\"font-weight-bold\">FECHA DE EMISI&#211;N </span>\n\t\t<span> ");
#nullable restore
#line 18 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/Productos/FaltantesClinica.cshtml"
          Write(DateTime.Now.ToString("D",CultureInfo.CreateSpecificCulture("Es-GT")).ToUpperInvariant());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
	</div>

    <div>
		<span class=""font-weight-bold""> Lugar </span>
		<span> Clínica </span>
	</div>
<br>

        <table class=""table table-bordered"">
                    <thead>
                    <tr>
                        <th style=""background: #1f4724 !important; color: white;""><span contenteditable>Producto</span></th>
                        <th style=""background: #1f4724 !important; color: white;""><span contenteditable>Presentación</span></th>
                        <th style=""background: #1f4724 !important; color: white;""><span contenteditable>Stock</span></th>
                    </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 36 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/Productos/FaltantesClinica.cshtml"
                     foreach(var producto in Model)
                        {
                            var presentacion = producto.PresentacionProducto == null ? "// sin asignar" : producto.PresentacionProducto.PresentProducto;


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td><span contenteditable>");
#nullable restore
#line 41 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/Productos/FaltantesClinica.cshtml"
                                                 Write(producto.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                            <td><span data-prefix>");
#nullable restore
#line 42 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/Productos/FaltantesClinica.cshtml"
                                             Write(presentacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                            <td><span>");
#nullable restore
#line 43 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/Productos/FaltantesClinica.cshtml"
                                 Write(producto.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </td>\n                        </tr>\n");
#nullable restore
#line 45 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/Productos/FaltantesClinica.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n        </table>\n\n\n      \n \n\n      \t\n\t\n");
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
