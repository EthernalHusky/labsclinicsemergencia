#pragma checksum "/root/profam/cubasalud/sistema/Views/Consultas/_ConsultaForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6eec5b31f1c918888cd2785ee50dba91bd1a1d58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultas__ConsultaForm), @"mvc.1.0.view", @"/Views/Consultas/_ConsultaForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6eec5b31f1c918888cd2785ee50dba91bd1a1d58", @"/Views/Consultas/_ConsultaForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultas__ConsultaForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.ConsultasViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control select2bs4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("readonly", new global::Microsoft.AspNetCore.Html.HtmlString("readonly"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    ");
#nullable restore
#line 2 "/root/profam/cubasalud/sistema/Views/Consultas/_ConsultaForm.cshtml"
Write(Html.HiddenFor(a => a.CitaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"main-card mb-3 card\">\n        <div class=\"card-body\">\n            <div class=\"text-center\">\n                <h3 class=\"text-primary\">Datos de Consulta</h3>\n                <hr>\n                <h5>Paciente: ");
#nullable restore
#line 8 "/root/profam/cubasalud/sistema/Views/Consultas/_ConsultaForm.cshtml"
                         Write(Model.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <h5>Servicio: ");
#nullable restore
#line 9 "/root/profam/cubasalud/sistema/Views/Consultas/_ConsultaForm.cshtml"
                         Write(Model.Servicio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                <h5>Médico asignado: ");
#nullable restore
#line 10 "/root/profam/cubasalud/sistema/Views/Consultas/_ConsultaForm.cshtml"
                                Write(Model.MedicoAsignado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            </div>\n            <br>\n            <div class=\"form-row\">\n                <div class=\"col-6\">\n                     <div class=\"position-relative form-group\"><label for=\"exampleEmail11\"");
            BeginWriteAttribute("class", " class=\"", 631, "\"", 639, 0);
            EndWriteAttribute();
            WriteLiteral(">Costo de consulta</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 17 "/root/profam/cubasalud/sistema/Views/Consultas/_ConsultaForm.cshtml"
                   Write(Html.TextBoxFor(a => a.CostoConsulta, new {@class="form-control",
                                       @placeholder="Costo de consulta"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 19 "/root/profam/cubasalud/sistema/Views/Consultas/_ConsultaForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.CostoConsulta, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n\n                 <div class=\"col-md-6\">\n                     <div class=\"position-relative form-group\">\n                        <label>Estado de pago</label>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6eec5b31f1c918888cd2785ee50dba91bd1a1d587098", async() => {
                WriteLiteral("\n");
                WriteLiteral("                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 26 "/root/profam/cubasalud/sistema/Views/Consultas/_ConsultaForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.EstadoPagoId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "/root/profam/cubasalud/sistema/Views/Consultas/_ConsultaForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.EstadosPagosLista;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        ");
#nullable restore
#line 31 "/root/profam/cubasalud/sistema/Views/Consultas/_ConsultaForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Consulta.EstadoPagoConsultaId, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                     </div>
                </div>

                <div class=""col-md-12"">
                     <div class=""position-relative form-group"">
                        <label>Fecha de creación de consulta (automática)</label>
                       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6eec5b31f1c918888cd2785ee50dba91bd1a1d589809", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 38 "/root/profam/cubasalud/sistema/Views/Consultas/_ConsultaForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FechaYHoraInicio);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        ");
#nullable restore
#line 39 "/root/profam/cubasalud/sistema/Views/Consultas/_ConsultaForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Consulta.EstadoPagoConsultaId, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                     </div>\n                </div>\n\n                 <div class=\"col-md-12\">\n                     <div class=\"position-relative form-group\">\n                        <label>Observaciones adicionales</label>\n                        ");
#nullable restore
#line 46 "/root/profam/cubasalud/sistema/Views/Consultas/_ConsultaForm.cshtml"
                   Write(Html.TextAreaFor(a => a.Consulta.ObservacionesAdicionales ,5,500 ,htmlAttributes : new { @class="form-control ", @placeholder="Observaciones adicionales", @style="max-width:100% !important;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 47 "/root/profam/cubasalud/sistema/Views/Consultas/_ConsultaForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Consulta.EstadoPagoConsultaId, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                     </div>
                </div>
            </div>
            <br>
            <div>
                <button class=""btn btn-primary"">
                    Crear consulta
                </button>
            </div>

        </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.ConsultasViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
