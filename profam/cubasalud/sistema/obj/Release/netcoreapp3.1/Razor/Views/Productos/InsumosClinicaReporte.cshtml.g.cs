#pragma checksum "/root/profam/cubasalud/sistema/Views/Productos/InsumosClinicaReporte.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a04905ae838ec2dbb330df557a7097eeb952af6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos_InsumosClinicaReporte), @"mvc.1.0.view", @"/Views/Productos/InsumosClinicaReporte.cshtml")]
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
#nullable restore
#line 1 "/root/profam/cubasalud/sistema/Views/Productos/InsumosClinicaReporte.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/root/profam/cubasalud/sistema/Views/Productos/InsumosClinicaReporte.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a04905ae838ec2dbb330df557a7097eeb952af6", @"/Views/Productos/InsumosClinicaReporte.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos_InsumosClinicaReporte : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.ReportesProductosViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/root/profam/cubasalud/sistema/Views/Productos/InsumosClinicaReporte.cshtml"
  
    Layout = "_HojaLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t<div>\n\t\t<div class=\"text-center\" style=\"border: 1px black solid;\">\n\t\t\t<h4> Reporte de Insumos </h4>\n\t\t\t<h6>RED OWL SOFTWARE</h6>\n\t\t</div>\n\t</div>\n\t<br>\n\t<div>\n\t\t<span class=\"font-weight-bold\">FECHA DE EMISI&#211;N </span>\n\t\t<span> ");
#nullable restore
#line 18 "/root/profam/cubasalud/sistema/Views/Productos/InsumosClinicaReporte.cshtml"
          Write(DateTime.Now.ToString("D",CultureInfo.CreateSpecificCulture("Es-GT")).ToUpperInvariant());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n\n\t<div>\n\t\t<span class=\"font-weight-bold\">USUARIO QUE LO EMITE </span>\n\t\t<span> ");
#nullable restore
#line 23 "/root/profam/cubasalud/sistema/Views/Productos/InsumosClinicaReporte.cshtml"
          Write(Model.Usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
	</div>

    <div>
		<span class=""font-weight-bold""> Lugar </span>
		<span> Clínica </span>
	</div>
<br>

        <table class=""table table-bordered"">
                    <thead>
                    <tr>
                        <th style=""background: #1f4724 !important; color: white;""><span contenteditable>Ref.</span></th>
                        <th style=""background: #1f4724 !important; color: white;""><span contenteditable>Producto</span></th>
                        <th style=""background: #1f4724 !important; color: white;""><span contenteditable>Categoría</span></th>
                        <th style=""background: #1f4724 !important; color: white;""><span contenteditable>Marca</span></th>
                        <th style=""background: #1f4724 !important; color: white;""><span contenteditable>Stock</span></th>
                    </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 43 "/root/profam/cubasalud/sistema/Views/Productos/InsumosClinicaReporte.cshtml"
                     foreach(var producto in Model.Productos)
                        {
                            var categoria = producto.Categoria == null ? "// sin asignar" : producto.Categoria.NombreCategoria;
							var marca = producto.Marca == null ? "// sin asignar" : producto.Marca.NombreMarca;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td><span contenteditable>");
#nullable restore
#line 48 "/root/profam/cubasalud/sistema/Views/Productos/InsumosClinicaReporte.cshtml"
                                                 Write(producto.CodigoReferencia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                            <td><span contenteditable>");
#nullable restore
#line 49 "/root/profam/cubasalud/sistema/Views/Productos/InsumosClinicaReporte.cshtml"
                                                 Write(producto.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                            <td><span data-prefix>");
#nullable restore
#line 50 "/root/profam/cubasalud/sistema/Views/Productos/InsumosClinicaReporte.cshtml"
                                             Write(categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                            <td><span data-prefix>");
#nullable restore
#line 51 "/root/profam/cubasalud/sistema/Views/Productos/InsumosClinicaReporte.cshtml"
                                             Write(marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                            <td><span>");
#nullable restore
#line 52 "/root/profam/cubasalud/sistema/Views/Productos/InsumosClinicaReporte.cshtml"
                                 Write(producto.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </td>\n                        </tr>\n");
#nullable restore
#line 54 "/root/profam/cubasalud/sistema/Views/Productos/InsumosClinicaReporte.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.ReportesProductosViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
