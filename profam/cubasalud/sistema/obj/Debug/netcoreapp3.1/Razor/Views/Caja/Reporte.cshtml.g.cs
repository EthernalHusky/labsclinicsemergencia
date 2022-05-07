#pragma checksum "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/Reporte.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94b814c5e6eca9aec2ae74e567a7221ffc0ced03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Caja_Reporte), @"mvc.1.0.view", @"/Views/Caja/Reporte.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94b814c5e6eca9aec2ae74e567a7221ffc0ced03", @"/Views/Caja/Reporte.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Caja_Reporte : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.ReporteCajaFarmaciaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/Reporte.cshtml"
  
    Layout = "_HojaLayout";
    decimal TotalCierre = 0m;
    
    var Desde = Convert.ToDateTime(@Model.Desde).ToString("MM/dd/yyyy");
    var Hasta = Convert.ToDateTime(@Model.Hasta).ToString("MM/dd/yyyy");


#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t<div>\n\t\t<div class=\"text-center\" style=\"border: 1px black solid;\">\n\t\t\t<h4> Reporte de Caja Farmacia </h4>\n\t\t\t<h6>RED OWL SOFTWARE</h6>\n\t\t</div>\n\t</div>\n\t<br>\n     <div>\n\t\t<span class=\"font-weight-bold\">FECHA Y HORA DE EMISIÓN  </span>\n\t\t<span> ");
#nullable restore
#line 21 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/Reporte.cshtml"
          Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n     <div>\n\t\t<span class=\"font-weight-bold\">DESDE</span>\n\t\t<span> ");
#nullable restore
#line 25 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/Reporte.cshtml"
          Write(Desde);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\n\t</div>\n     <div>\n\t\t<span class=\"font-weight-bold\">HASTA</span>\n\t\t<span> ");
#nullable restore
#line 29 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/Reporte.cshtml"
          Write(Hasta);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
	</div>
    <br>
  
   
    <table class=""table table-sm table-striped"">
                <thead>
                    <tr>
                        <th>Fecha Apertura</th>
                        <th>Monto Apertura</th>
                        <th>Gastos</th>
                        <th>Ingresos</th>
                        <th>Total Cierre</th>
                        <th>Resp. Apertura</th>
                        <th>Resp. Cierre</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 47 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/Reporte.cshtml"
                     foreach(var item in Model.Cajas)
                    {
                        
                            var personaApertura = item.ResponsableApertura == null ? "" : item.ResponsableAperturaText;
                            var personaCierre = item.ResponsableCierre == null ? "" : item.ResponsableCierreText;


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 54 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/Reporte.cshtml"
                               Write(item.FechaApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 55 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/Reporte.cshtml"
                               Write(item.MontoApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 56 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/Reporte.cshtml"
                               Write(item.DetalleCajas.Sum(x => x.Gasto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 57 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/Reporte.cshtml"
                               Write(item.DetalleCajas.Sum(x => x.Ingreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n");
#nullable restore
#line 59 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/Reporte.cshtml"
                                  
                                    decimal suma1 = item.DetalleCajas.Sum(x=>x.Ingreso - x.Gasto);
                                    decimal  montoap = item.MontoApertura;

                                    decimal res = suma1 + montoap;
                                    TotalCierre += res;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                <td>");
#nullable restore
#line 67 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/Reporte.cshtml"
                               Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 68 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/Reporte.cshtml"
                               Write(personaApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 69 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/Reporte.cshtml"
                               Write(personaCierre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>\n");
#nullable restore
#line 71 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/Reporte.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </tbody>\n    </table>\n    <br>\n\n <div>\n\t\t<span class=\"font-weight-bold\">Monto</span>\n\t\t<span> Q ");
#nullable restore
#line 79 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Caja/Reporte.cshtml"
            Write(TotalCierre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.ReporteCajaFarmaciaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
