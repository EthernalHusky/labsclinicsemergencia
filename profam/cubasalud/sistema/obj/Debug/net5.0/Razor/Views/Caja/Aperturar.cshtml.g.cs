#pragma checksum "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c980524a76434f11bca4ccaec02ceb634e349800"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Caja_Aperturar), @"mvc.1.0.view", @"/Views/Caja/Aperturar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c980524a76434f11bca4ccaec02ceb634e349800", @"/Views/Caja/Aperturar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Caja_Aperturar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.CajaBaseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Caja", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Aperturar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n ");
#nullable restore
#line 6 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c980524a76434f11bca4ccaec02ceb634e3498004309", async() => {
                WriteLiteral(@"
    <div class=""form-row"">
        <div class=""col-md-12"">

                <div class=""col-md-6"">
                    <div class=""main-card mb-3 card"">
                        <div class=""card-body"">

                            <div class=""text-center"">
                                <div class=""position-relative form-group""><label for=""exampleEmail11""");
                BeginWriteAttribute("class", " class=\"", 602, "\"", 610, 0);
                EndWriteAttribute();
                WriteLiteral(">Monto Apertura</label>\n                                    ");
#nullable restore
#line 18 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                               Write(Html.TextBoxFor(a => a.Caja.MontoApertura, new {@class="form-control", @placeholder="Monto a Aperturar"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    ");
#nullable restore
#line 19 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                               Write(Html.ValidationMessageFor(a => a.Caja.MontoApertura, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </div>
                            </div>
                            <button type=""submit"" class=""btn btn-primary text-center"">Abrir caja</button>

                        </div>
                    </div>

                </div>
        </div>
</div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"



<div class=""form-row"">
 <div class=""col-md-12"">
                <div class=""main-card mb-3 card"">
                    <div class=""card-body"">
                        
                        <div class=""form-row"">
                            <div class=""col-md-12"">
                                            <div class=""table-responsive"">
                                                <table class=""mb-0 table table-hover "">
                                                    <thead>
                                                    <tr>
                                                        <th>Fecha Apertura</th>
                                                        <th>Monto Apertura</th>
                                                        <th>Gastos</th>
                                                        <th>Ingresos</th>
                                                        <th>Total Cierre</th>
                                                        <th>Acciones</th>

               ");
            WriteLiteral("                                     </tr>\n                                                    </thead>\n                                                    <tbody>\n");
#nullable restore
#line 55 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                         foreach(var item in Model.ListaCajas)
                                                        {
                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                             if(item.EstadoCaja == true)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <tr class=\"bg-success\">\n                                                                     <td>");
#nullable restore
#line 60 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                                    Write(item.FechaApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 61 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                                   Write(item.MontoApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 62 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                                   Write(item.DetalleCajas.Sum(x=>x.Gasto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 63 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                                   Write(item.DetalleCajas.Sum(x=>x.Ingreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n");
#nullable restore
#line 65 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                                      
                                                                        decimal suma1 = item.DetalleCajas.Sum(x=>x.Ingreso - x.Gasto);
                                                                        decimal  montoap = item.MontoApertura;

                                                                        decimal res= suma1 + montoap;


                                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                                    <td>");
#nullable restore
#line 74 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                                   Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td> \n                                                                        <a");
            BeginWriteAttribute("href", " href=\"", 3920, "\"", 3980, 1);
#nullable restore
#line 76 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
WriteAttributeValue("", 3927, Url.Action("VerDetalle","Caja", new {id = @item.Id}), 3927, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-warning btn-sm"">
                                                                            Ver Detalle
                                                                        </a>
                                                                        
                                                                    </td>
                                                                </tr>
");
#nullable restore
#line 82 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                            }
                                                            else 
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <tr>\n                                                                    <td>");
#nullable restore
#line 86 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                                   Write(item.FechaApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 87 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                                   Write(item.MontoApertura);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 88 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                                   Write(item.DetalleCajas.Sum(x=>x.Gasto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td>");
#nullable restore
#line 89 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                                   Write(item.DetalleCajas.Sum(x=>x.Ingreso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 90 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                                      
                                                                        decimal suma1 = item.DetalleCajas.Sum(x=>x.Ingreso - x.Gasto);
                                                                        decimal  montoap = item.MontoApertura;

                                                                        decimal res= suma1 + montoap;


                                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                                    <td>");
#nullable restore
#line 99 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                                   Write(res);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                                    <td> \n                                                                        <a");
            BeginWriteAttribute("href", " href=\"", 5798, "\"", 5858, 1);
#nullable restore
#line 101 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
WriteAttributeValue("", 5805, Url.Action("VerDetalle","Caja", new {id = @item.Id}), 5805, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-warning btn-sm"">
                                                                            Ver Detalle
                                                                        </a>
                                                                        
                                                                    </td>
                                                                </tr>
");
#nullable restore
#line 107 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "/root/farmaciaSistema_Farmamest/sistema/Views/Caja/Aperturar.cshtml"
                                                             
                                                   
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    </tbody>
                                                </table>
            </div>
                               
                            </div>
                        </div>
                        
                    </div>

                </div>
            </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.CajaBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591