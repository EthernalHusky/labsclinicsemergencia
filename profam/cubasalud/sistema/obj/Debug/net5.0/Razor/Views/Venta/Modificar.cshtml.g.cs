#pragma checksum "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53621cea65e4b14d50fb749d3b439b1b7236add8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venta_Modificar), @"mvc.1.0.view", @"/Views/Venta/Modificar.cshtml")]
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
#line 1 "/root/farmaciaSistema_Farmamest/sistema/Views/_ViewImports.cshtml"
using farmamest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/root/farmaciaSistema_Farmamest/sistema/Views/_ViewImports.cshtml"
using farmamest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53621cea65e4b14d50fb749d3b439b1b7236add8", @"/Views/Venta/Modificar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Venta_Modificar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.VentaBaseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control select2bs4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("clienteselect-m"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/FuncionesVenta.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            WriteLiteral("\n");
#nullable restore
#line 5 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
  
    decimal suma = 0.00m;
    decimal sumades = 0.00m;
    decimal sumasub = 0.00m;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""form-row"">
    <div class=""col-md-12"">

        

        <div class=""form"">
            <div class=""col-md-12"">
                    <br/>
                <div class=""main-card mb-3 card"">
                    <div class=""card-body"">
                        <div class=""text-right"" style=""font-size: 17px;"">
                            <span>Fecha y hora de venta:</span>
                        <span >");
#nullable restore
#line 23 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                          Write(Model.Venta.FechaVenta);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                        <fieldset disabled>
                            <div class=""form-row"">
                                    <div class=""col-md-12"">
                                        <div class=""position-relative form-group""><label");
            BeginWriteAttribute("class", " class=\"", 894, "\"", 902, 0);
            EndWriteAttribute();
            WriteLiteral(">No.\n                                                Comprobante</label>\n");
            WriteLiteral("                                            ");
#nullable restore
#line 31 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                       Write(Html.TextBoxFor(a => a.Venta.NoComprobante, new
                                                                           {@class="form-control",@id="nocomprobante", @placeholder="No. Comprobante" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            ");
#nullable restore
#line 33 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                       Write(Html.ValidationMessageFor(a => a.Venta.NoComprobante, "", new { @class =
                                                                               "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>

                                </div>
                                <div class=""form-row"">
                                        <div class=""col-md-6"">
                                        <label>Cliente</label>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53621cea65e4b14d50fb749d3b439b1b7236add87527", async() => {
                WriteLiteral("\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 43 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Venta.ClienteId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 43 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ListaClientes;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </div>                  \n                                    <div class=\"col-md-6\">\n                                        <div class=\"position-relative form-group\"><label");
            BeginWriteAttribute("class", " class=\"", 2344, "\"", 2352, 0);
            EndWriteAttribute();
            WriteLiteral(">Nit</label>\n");
            WriteLiteral("                                            ");
#nullable restore
#line 49 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                       Write(Html.TextBoxFor(a => a.Venta.Nit, new {@class="form-control",@id="Nit",
                                                                               @placeholder="Nit"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            ");
#nullable restore
#line 51 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                       Write(Html.ValidationMessageFor(a => a.Venta.Nit, "", new { @class =
                                                                               "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                                <div class=""form-row"">
                                    
                                    <div class=""col-md-12"">
                                        <div class=""position-relative form-group""><label");
            BeginWriteAttribute("class", " class=\"", 3269, "\"", 3277, 0);
            EndWriteAttribute();
            WriteLiteral(">Direccion</label>\n");
            WriteLiteral("                                            ");
#nullable restore
#line 61 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                       Write(Html.TextBoxFor(a => a.Venta.Direccion, new
                                                                           {@class="form-control",@id="direccion", @placeholder="Direccion"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            ");
#nullable restore
#line 63 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                       Write(Html.ValidationMessageFor(a => a.Venta.Direccion, "", new { @class =
                                                                               "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>

                       
                        <br/>

                        <div class=""table-responsive"">
                             <table class='table table-hover' id=""tableventa"">
                                <thead>
                                    <tr>
                                        <th>Codigo</th>
                                        <th>Nombre Producto</th>
                                        <th>Cantidad</th>
                                        <th>Precio</th>
                                        <th>Descuento</th>
                                        <th>Subtotal</th>
                                         <th>Total</th>
");
            WriteLiteral("                                    </tr>\n                                </thead>\n                                <tbody id=\"contentdetalle\">\n\n");
#nullable restore
#line 88 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                      if(Model.Venta != null)
                                    {
                                            
                                            foreach (var item in Model.Venta.DetalleVenta)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\n                                            <td>");
#nullable restore
#line 94 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                           Write(item.Producto.CodigoReferencia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 95 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                           Write(item.Producto.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 96 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                           Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 97 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                           Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 98 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                           Write(item.Descuento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 99 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                           Write(item.Subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            <td>");
#nullable restore
#line 100 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                           Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
            WriteLiteral("                                            <td style=\"display: none;\" class=\"idProd\">");
#nullable restore
#line 102 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        </tr>\n");
#nullable restore
#line 104 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                            suma+=item.Total;
                                            sumades+=item.Descuento;
                                            sumasub+=item.Subtotal;
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                                
                            </table>


                        </div>

                        <br />
                        <div class=""text-right"" style=""font-size: 17px;"">
                            <span>Subtotal:</span>
                            Q <span >");
#nullable restore
#line 120 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                Write(sumasub);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        </div>\n                        <div class=\"text-right\" style=\"font-size: 17px;\">\n                            <span>Descuento:</span>\n                            Q <span>");
#nullable restore
#line 124 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                               Write(sumades);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        </div>\n                        <div class=\"text-right\" style=\"font-size: 17px;\">\n                            <span>Total:</span>\n                            Q <span >");
#nullable restore
#line 128 "/root/farmaciaSistema_Farmamest/sistema/Views/Venta/Modificar.cshtml"
                                Write(suma);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                        </div>\n\n\n\n\n\n\n                    </div>\n\n\n\n\n\n\n\n\n\n\n\n\n                </div>\n            </div>\n        </div>\n\n\n\n\n\n\n\n\n\n\n        <div class=\"main-card mb-3 card\">\n\n\n        </div>\n\n\n    </div>\n\n\n</div>\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53621cea65e4b14d50fb749d3b439b1b7236add818703", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.VentaBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
