#pragma checksum "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e13c293abd17113b8273fcaa8521d3e8324b7e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TrasladosBodegaAFarmacia_ReporteU), @"mvc.1.0.view", @"/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml")]
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
#line 1 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e13c293abd17113b8273fcaa8521d3e8324b7e1", @"/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_TrasladosBodegaAFarmacia_ReporteU : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.TrasladosBaseViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml"
  
    Layout = "_HojaLayout";

    var personaEnviado = Model.TrasladosProductos.ResponsableEnviado == null ? "" : Model.TrasladosProductos.ResponsableEnviadoText;
    var personaRecibido = Model.TrasladosProductos.ResponsableRecibido == null ? "" : Model.TrasladosProductos.ResponsableRecibidoText;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t<div>\n\t\t<div class=\"text-center\" style=\"border: 1px black solid;\">\n\t\t\t<h4> Reporte de Envío </h4>\n\t\t\t<h6>RED OWL SOFTWARE</h6>\n\t\t</div>\n\t</div>\n\t<br>\n    <div>\n\t\t<span class=\"font-weight-bold\">Traslado # </span>\n\t\t<span> ");
#nullable restore
#line 21 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml"
          Write(Model.TrasladosProductos.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\n\t</div>\n\n\t<div>\n\t\t<span class=\"font-weight-bold\">FECHA DE ENV&#205;O</span>\n\t\t<span> ");
#nullable restore
#line 26 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml"
          Write(Model.TrasladosProductos.FechaTraslado.Value.ToString("D",CultureInfo.CreateSpecificCulture("Es-GT")).ToUpperInvariant());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 26 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml"
                                                                                                                                    Write(Model.TrasladosProductos.FechaTraslado.Value.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n\n\t<div>\n\t\t<span class=\"font-weight-bold\">RESPONSABLE</span>\n\t\t<span> ");
#nullable restore
#line 31 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml"
          Write(personaEnviado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n\n    <div>\n\t\t<span class=\"font-weight-bold\">OBSERVACIONES</span>\n\t\t<span> ");
#nullable restore
#line 36 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml"
          Write(Model.TrasladosProductos.Observaciones);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n\n   \n\n    <br>\n\n     <div>\n\t\t<span class=\"font-weight-bold\">ESTADO</span>\n\t\t<span> ");
#nullable restore
#line 45 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml"
          Write(Model.TrasladosProductos.EstadoTraslados.DescripcionEstado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n\n     <div>\n\t\t<span class=\"font-weight-bold\">RESPONSABLE RECIBIDO</span>\n\t\t<span> ");
#nullable restore
#line 50 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml"
          Write(personaRecibido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n     <div>\n\t\t<span class=\"font-weight-bold\">TOTAL ITEMS</span>\n\t\t<span> ");
#nullable restore
#line 54 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml"
          Write(Model.TrasladosProductos.DetalleTrasladoProductos.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
	</div>
	        <div>
		<span class=""font-weight-bold"">TIPO TRASLADO</span>
	<span> BODEGA A FARMACIA</span>
	</div>
    <table class=""table table-bordered"">
                <thead>
                <tr>
                    <th style=""background: #1f4724 !important; color: white;""><span contenteditable>Nombre Producto</span></th>
                    <th style=""background: #1f4724 !important; color: white;""><span contenteditable>Presentación</span></th>
                    <th style=""background: #1f4724 !important; color: white;""><span contenteditable>Cantidad</span></th>
                </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 69 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml"
                 foreach(var producto in Model.TrasladosProductos.DetalleTrasladoProductos)
                    {
                        var presentacion = producto.Producto.PresentacionProducto == null ? "// sin asignar " : producto.Producto.PresentacionProducto.PresentProducto;


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td><span contenteditable>");
#nullable restore
#line 74 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml"
                                             Write(producto.Producto.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                        <td><span contenteditable>");
#nullable restore
#line 75 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml"
                                             Write(presentacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                        <td><span contenteditable>");
#nullable restore
#line 76 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml"
                                             Write(producto.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                    </tr>\n");
#nullable restore
#line 78 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAFarmacia/ReporteU.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n    </table>\n\n\n\n      \n \n\n      \t\n\t\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.TrasladosBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
