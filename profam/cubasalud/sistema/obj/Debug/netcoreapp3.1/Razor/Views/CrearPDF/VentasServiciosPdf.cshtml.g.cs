#pragma checksum "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/VentasServiciosPdf.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdd6508e2a3fbc764554673ab69e2ada15aa0cef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CrearPDF_VentasServiciosPdf), @"mvc.1.0.view", @"/Views/CrearPDF/VentasServiciosPdf.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdd6508e2a3fbc764554673ab69e2ada15aa0cef", @"/Views/CrearPDF/VentasServiciosPdf.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_CrearPDF_VentasServiciosPdf : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Database.Shared.Models.VentaServicio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/VentasServiciosPdf.cshtml"
   

Layout = "_HojaLayout";

DateTime fecha = DateTime.Now;



#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n                <img width=\"40\"  src=\"/assets/images/farmamestlogo.png\"");
            BeginWriteAttribute("alt", " alt=\"", 195, "\"", 201, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                       <div class=\"text-right\" style=\"font-size: 12px;\">\n                            <label");
            BeginWriteAttribute("class", " class=\"", 311, "\"", 319, 0);
            EndWriteAttribute();
            WriteLiteral("><strong>Fecha y Hora de Emision: </strong>");
#nullable restore
#line 14 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/VentasServiciosPdf.cshtml"
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
                            <th>Fecha Venta</th>
                            <th>Venta Servicio #</th>
                            <th>Vendedor</th>
                            <th>NoComprobante</th>
                            <th>Nombre</th>
                            <th>Cliente</th>
                            <th>Nit</th>
                            <th>Forma de Pago</th>
                            <th>Dirección</th>
                            <th>Total</th>
                            <th>Acciones</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 35 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/VentasServiciosPdf.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 38 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/VentasServiciosPdf.cshtml"
                               Write(item.FechaVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 39 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/VentasServiciosPdf.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 40 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/VentasServiciosPdf.cshtml"
                               Write(item.Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 41 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/VentasServiciosPdf.cshtml"
                               Write(item.NoComprobante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 42 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/VentasServiciosPdf.cshtml"
                               Write(item.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 43 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/VentasServiciosPdf.cshtml"
                               Write(item.Paciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 44 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/VentasServiciosPdf.cshtml"
                               Write(item.Nit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 45 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/VentasServiciosPdf.cshtml"
                               Write(item.FormaPago);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 46 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/VentasServiciosPdf.cshtml"
                               Write(item.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>Q ");
#nullable restore
#line 47 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/VentasServiciosPdf.cshtml"
                                 Write(item.DetalleServicio.Sum(a => a.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1956, "\"", 2024, 1);
#nullable restore
#line 49 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/VentasServiciosPdf.cshtml"
WriteAttributeValue("", 1963, Url.Action("Modificar","VentaServicio", new {id = @item.Id}), 1963, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n                                        class=\"btn btn-primary\">\n                                        Ver detalles\n                                    </a>\n");
            WriteLiteral("                                </td>\n                            </tr>\n");
#nullable restore
#line 59 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/CrearPDF/VentasServiciosPdf.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n       ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Database.Shared.Models.VentaServicio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
