#pragma checksum "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "300d0ff1c764935c19073382baebe93f358c7893"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CajaClinica_VerDetalle), @"mvc.1.0.view", @"/Views/CajaClinica/VerDetalle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"300d0ff1c764935c19073382baebe93f358c7893", @"/Views/CajaClinica/VerDetalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_CajaClinica_VerDetalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.CajaClinicaBaseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/FuncionesCajaClinica.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 6 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
  

    decimal totalVenta = 0.00m;

    decimal totalVentaServ = 0.00m;

    decimal totalCompra = 0.00m;

    decimal totalIngreso = 0.00m;

    decimal totalEgreso = 0.00m;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 19 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""form-row"">
        <div class=""col-md-12"">

            <div class=""col-md-6"">
                <div class=""main-card mb-3 card"">
                    <div class=""card-body"">

                        <button type=""button"" class=""btn btn-primary""");
            BeginWriteAttribute("onclick", " onclick=\"", 626, "\"", 673, 3);
            WriteAttributeValue("", 636, "GuardarIngreso(", 636, 15, true);
#nullable restore
#line 28 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
WriteAttributeValue("", 651, Model.CajaClinica.Id, 651, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 672, ")", 672, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Nuevo Ingreso</button>\n                        <button type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 767, "\"", 813, 3);
            WriteAttributeValue("", 777, "GuardarEgreso(", 777, 14, true);
#nullable restore
#line 29 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
WriteAttributeValue("", 791, Model.CajaClinica.Id, 791, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 812, ")", 812, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Nuevo Egreso</button>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 863, "\"", 939, 1);
#nullable restore
#line 30 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
WriteAttributeValue("", 870, Url.Action("Cerrar","CajaClinica", new {id = @Model.CajaClinica.Id}), 870, 69, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n                            class=\"btn btn-primary text-left\">\n                            Cerrar caja\n                        </a>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1099, "\"", 1188, 1);
#nullable restore
#line 34 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
WriteAttributeValue("", 1106, Url.Action("CajaDetallePdfClinica", "CrearPDF", new {id = @Model.CajaClinica.Id}), 1106, 82, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                            class=""btn btn-primary text-left"">
                            Generar Pdf
                        </a>
                    </div>
                </div>

            </div>
        </div>
    </div>



<div class=""form-row"">
    <div class=""col-md-12"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body"">
                <h4>Ventas</h4>
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <div class=""table-responsive"">
                            <table class=""mb-0 table table-hover "">
                                <thead>
                                    <tr>
                                        <th>Fecha Venta</th>
                                        <th># Venta</th>
                                        <th>Comprobante</th>
                                        <th>Descripción</th>
                                        <th>Cliente</th>
                                        <th>Ven");
            WriteLiteral("dedor</th>\n                                        <th>Total</th>\n\n                                    </tr>\n                                </thead>\n                                <tbody>\n");
#nullable restore
#line 69 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                     foreach (var item in Model.CajaClinica.DetalleCajaClinicas.Where(a => a.Venta != null).OrderByDescending(a=>a.Venta.FechaVenta))



                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 75 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                           Write(item.Venta.FechaVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 76 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                           Write(item.Venta.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>\n");
#nullable restore
#line 78 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                                 if (String.IsNullOrEmpty(item.Venta.NoComprobante))



                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>CF</span>\n");
#nullable restore
#line 84 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"

                                                }

                                                else

                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>");
#nullable restore
#line 90 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                                     Write(item.Venta.NoComprobante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 91 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"

                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\n                                            <td>");
#nullable restore
#line 94 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 95 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                           Write(item.Venta.Paciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 96 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                           Write(item.Venta.Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>Q ");
#nullable restore
#line 97 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                             Write(item.Ingreso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        </tr>\n");
#nullable restore
#line 99 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"

                                        totalVenta += item.Ingreso;

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>

                    </div>
                </div>
                <div class=""text-right"" style=""font-size: 17px;"">
                    <span>_____________________</span><br/>
                    Q <span>");
#nullable restore
#line 111 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                       Write(totalVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div> 
            </div>

        </div>
    </div>
</div>


<div class=""form-row"">
    <div class=""col-md-12"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body"">
                <h4>Venta de Servicios</h4>
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <div class=""table-responsive"">
                            <table class=""mb-0 table table-hover "">
                                <thead>
                                    <tr>
                                        <th>Fecha Venta</th>
                                        <th>Comprobante</th>
                                        <th>Descripción</th>
                                        <th>Cliente</th>
                                        <th>Vendedor</th>
                                        <th>Total</th>

                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 141 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                     foreach (var item in Model.CajaClinica.DetalleCajaClinicas.Where(a => a.VentaServicio != null).OrderByDescending(a=>a.VentaServicio.FechaVenta))

                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 145 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                           Write(item.VentaServicio.FechaVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>\n");
#nullable restore
#line 147 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                                 if (String.IsNullOrEmpty(item.VentaServicio.NoComprobante))



                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>CF</span>\n");
#nullable restore
#line 153 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"

                                                }

                                                else

                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>");
#nullable restore
#line 159 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                                     Write(item.VentaServicio.NoComprobante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 160 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"

                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\n                                            <td>");
#nullable restore
#line 163 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 164 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                           Write(item.VentaServicio.Paciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 165 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                           Write(item.VentaServicio.Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>Q ");
#nullable restore
#line 166 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                             Write(item.Gasto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        </tr>\n");
#nullable restore
#line 168 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"

                                        totalVentaServ += item.Ingreso;

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>

                    </div>
                </div>
                 <div class=""text-right"" style=""font-size: 17px;"">
                    <span>_____________________</span><br/>
                    Q <span>");
#nullable restore
#line 180 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                       Write(totalVentaServ);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div>
            </div>

        </div>
    </div>
</div>

<div class=""form-row"">
    <div class=""col-md-6"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body"">
                <h4>Ingresos</h4>
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <div class=""table-responsive"">
                            <table class=""mb-0 table table-hover "">
                                <thead>
                                    <tr>
                                        <th>Fecha Ingreso</th>
                                        <th>Descripción</th>
                                        <th>Total</th>

                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 206 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                     foreach (var item in Model.CajaClinica.DetalleCajaClinicas.Where(a => a.Ingreso != 0.00m && a.Venta==null && a.VentaServicio==null).OrderByDescending(a=>a.Fecha))



                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 212 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                           Write(item.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 213 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>Q ");
#nullable restore
#line 214 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                             Write(item.Ingreso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        </tr>\n");
#nullable restore
#line 216 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"

                                        totalIngreso += item.Ingreso;

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>

                    </div>
                </div>
                    <div class=""text-right"" style=""font-size: 17px;"">
                    <span>_____________________</span><br/>
                    Q <span>");
#nullable restore
#line 228 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                       Write(totalIngreso);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div>
            </div>

        </div>
    </div>
     <div class=""col-md-6"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body"">
                <h4>Egresos</h4>
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <div class=""table-responsive"">
                            <table class=""mb-0 table table-hover "">
                                <thead>
                                    <tr>
                                        <th>Fecha Venta</th>
                                        <th>Descripción</th>
                                        <th>Total</th>

                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 251 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                     foreach (var item in Model.CajaClinica.DetalleCajaClinicas.Where(a => a.Gasto != 0.00m && a.Compra == null).OrderByDescending(a=>a.Fecha))



                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                            <td>");
#nullable restore
#line 257 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                           Write(item.Fecha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 258 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                           Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>Q ");
#nullable restore
#line 259 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                                             Write(item.Gasto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        </tr>\n");
#nullable restore
#line 261 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"

                                        totalEgreso += item.Gasto;

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>

                    </div>
                </div>
                    <div class=""text-right"" style=""font-size: 17px;"">
                    <span>_____________________</span><br/>
                    Q <span>");
#nullable restore
#line 273 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                       Write(totalEgreso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n            </div>\n\n        </div>\n    </div>\n</div>\n\n\n");
#nullable restore
#line 282 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
  

    decimal sumaing = totalVenta + totalVentaServ + totalIngreso;
    decimal sumaeg = totalCompra + totalEgreso;
    decimal res = sumaing - sumaeg + Model.CajaClinica.MontoApertura;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""form-row"">
    <div class=""col-md-12"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body"">
                <div class=""text-right"" style=""font-size: 17px;"">
                    <span>Monto Apertura:</span>
                    Q <span>");
#nullable restore
#line 295 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                       Write(Model.CajaClinica.MontoApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n                <div class=\"text-right\" style=\"font-size: 17px;\">\n                    <span>Total Egresos:</span>\n                    Q <span>");
#nullable restore
#line 299 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                       Write(sumaeg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n                <div class=\"text-right\" style=\"font-size: 17px;\">\n                    <span>Total Ingresos</span>\n                    Q <span>");
#nullable restore
#line 303 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                       Write(sumaing);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n                <div class=\"text-right\" style=\"font-size: 17px;\">\n                    <span>Total Cierre:</span>\n                    Q <span>");
#nullable restore
#line 307 "/root/profam/cubasalud/sistema/Views/CajaClinica/VerDetalle.cshtml"
                       Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "300d0ff1c764935c19073382baebe93f358c789325772", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.CajaClinicaBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
