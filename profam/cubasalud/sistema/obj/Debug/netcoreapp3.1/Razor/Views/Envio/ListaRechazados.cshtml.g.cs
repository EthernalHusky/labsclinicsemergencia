#pragma checksum "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bac253ce3017e2e036e6c2b201672a3e1ef487d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Envio_ListaRechazados), @"mvc.1.0.view", @"/Views/Envio/ListaRechazados.cshtml")]
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
#nullable restore
#line 1 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
using Database.Shared.Paginacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bac253ce3017e2e036e6c2b201672a3e1ef487d", @"/Views/Envio/ListaRechazados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Envio_ListaRechazados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginacionList<Database.Shared.Models.Envio>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Lista", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""app-page-title"">
    <div class=""page-title-wrapper"">

        <div class=""page-title-heading"">
            <div class=""page-title-icon"">
                <i class=""pe-7s-graph text-success"">
                </i>
            </div>
            <div>Listado De Envios Rechazados
                <div class=""page-title-subheading"">Envios.
                </div>
            </div>
        </div>
    </div>
</div>
 ");
#nullable restore
#line 20 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br/>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bac253ce3017e2e036e6c2b201672a3e1ef487d5299", async() => {
                WriteLiteral(@"
    <div class=""col-md-12"">
        <div class=""input-group"">
            <div class=""input-group-prepend"">
                <input type=""submit"" value=""Buscar"" class=""btn btn-success""></input>
            </div>
            <input type=""text"" name=""buscar""");
                BeginWriteAttribute("value", " value=\"", 857, "\"", 891, 1);
#nullable restore
#line 28 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
WriteAttributeValue("", 865, ViewData["CurrentFilter"], 865, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" placeholder=\"Buscar Envios...\">\n        </div>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br/>
 
<div class=""tab-pane tabs-animation fade show active"" id=""tab-content-0"" role=""tabpanel"">
    <div class=""main-card mb-3 card"">
        <div class=""card-body"">
            <div class=""table-responsive"">
                    <table class=""mb-0 table table-hover "">
                        <thead>
                        <tr>
                            <th>Fecha Creacion</th>
                            <th>Envio #</th>
                            <th>Ruta</th>
                            <th>Cliente</th>
                            <th>Nombre Piloto</th>
                            <th>Usuario Piloto</th>
                            <th>Fecha y Hora de entrega</th>
                            <th>Direccion Exacta</th>
                            <th>Estado</th>
                            <th>Acciones</th>

                            
                        </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 56 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                             foreach(var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                             <td>");
#nullable restore
#line 59 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                            Write(item.FechaEnvio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 60 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"width:200px\">");
#nullable restore
#line 61 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                                               Write(item.Ruta.Destino);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"width:200px\">");
#nullable restore
#line 62 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                                               Write(item.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 63 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                             if(item.User != null)
                                {
                                    if(item.User.Persona != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td style=\"width:200px\">");
#nullable restore
#line 67 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                                                           Write(item.User.Persona.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td style=\"width:200px\">");
#nullable restore
#line 68 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                                                           Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 69 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                                    }
                                    else
                                    {
                                   

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"width:200px\">Sin Asignar</td>\n                                    <td style=\"width:200px\">");
#nullable restore
#line 74 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                                                       Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 75 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                                    }
                                
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td style=\"width:200px\">Sin Asignar</td>\n                                    <td style=\"width:200px\">Sin Asignar</td>\n");
#nullable restore
#line 82 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 83 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                           Write(item.FechaEntrega);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td style=\"width:200px\">");
#nullable restore
#line 84 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                                               Write(item.DireccionExacta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \n                            <td>");
#nullable restore
#line 85 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                           Write(item.EstadosEnvio.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td> \n                                <a");
            BeginWriteAttribute("href", " href=\"", 3622, "\"", 3682, 1);
#nullable restore
#line 87 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
WriteAttributeValue("", 3629, Url.Action("VerPedido","Envio", new {id = @item.Id}), 3629, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">\n                                    Ver detalles\n                                </a>\n");
            WriteLiteral("                            </td>\n                        </tr>\n");
#nullable restore
#line 95 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\n                    </table>\n            </div>\n             \n        </div>\n    </div>\n</div>\n\n");
#nullable restore
#line 104 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
  
    var prevDisabled = !Model.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.HasNextPage ? "disabled" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bac253ce3017e2e036e6c2b201672a3e1ef487d15474", async() => {
                WriteLiteral("\n    Anterior\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 110 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
              WriteLiteral(Model.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4546, "btn", 4546, 3, true);
            AddHtmlAttributeValue(" ", 4549, "btn-danger", 4550, 11, true);
            AddHtmlAttributeValue(" ", 4560, "btn-sm", 4561, 7, true);
#nullable restore
#line 113 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
AddHtmlAttributeValue(" ", 4567, prevDisabled, 4568, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bac253ce3017e2e036e6c2b201672a3e1ef487d19825", async() => {
                WriteLiteral("\n    Siguiente\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
            WriteLiteral(ViewData["CurrentSort"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
              WriteLiteral(Model.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4789, "btn", 4789, 3, true);
            AddHtmlAttributeValue(" ", 4792, "btn-danger", 4793, 11, true);
            AddHtmlAttributeValue(" ", 4803, "btn-sm", 4804, 7, true);
#nullable restore
#line 120 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Envio/ListaRechazados.cshtml"
AddHtmlAttributeValue(" ", 4810, nextDisabled, 4811, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginacionList<Database.Shared.Models.Envio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
