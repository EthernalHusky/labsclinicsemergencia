#pragma checksum "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd0ef5f53c7446aafb56bcc0241b701f5da5c9a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacientes__PacientesForm), @"mvc.1.0.view", @"/Views/Pacientes/_PacientesForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd0ef5f53c7446aafb56bcc0241b701f5da5c9a8", @"/Views/Pacientes/_PacientesForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacientes__PacientesForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.PacientesBaseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control select2bs4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""tab-pane tabs-animation fade show active"" id=""tab-content-0"" role=""tabpanel"">
    <div class=""main-card mb-3 card"">
        <div class=""card-body"">

            <div class=""form-row"">
                <div class=""col-md-6"">
                    <div class=""position-relative form-group"">
                        <label");
            BeginWriteAttribute("class", " class=\"", 374, "\"", 382, 0);
            EndWriteAttribute();
            WriteLiteral(">Nombre completo del Paciente</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 12 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Paciente.Nombre, new {@class="form-control", @placeholder="Nombre Paciente"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 13 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Paciente.Nombre, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n\n                 <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\">\n                        <label");
            BeginWriteAttribute("class", " class=\"", 935, "\"", 943, 0);
            EndWriteAttribute();
            WriteLiteral(">Fecha de Nacimiento</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 21 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Paciente.FechaNacimiento, "{0:yyyy-MM-dd}", new {@class="form-control", @type="date"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 22 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Paciente.FechaNacimiento, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"col-md-12\">\n                    <div class=\"position-relative form-group\">\n                        <label");
            BeginWriteAttribute("class", " class=\"", 1505, "\"", 1513, 0);
            EndWriteAttribute();
            WriteLiteral(">Sexo</label>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd0ef5f53c7446aafb56bcc0241b701f5da5c9a86668", async() => {
                WriteLiteral("\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 29 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Paciente.SexoId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 30 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.SexoSelectListItems;

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
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n            <div class=\"form-row\">\n                <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\"><label for=\"exampleEmail11\"");
            BeginWriteAttribute("class", " class=\"", 1977, "\"", 1985, 0);
            EndWriteAttribute();
            WriteLiteral(">Teléfono</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 39 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Paciente.Telefono, new{ type="number", @class="form-control",
                                       @placeholder="Telefono"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                        ");
#nullable restore
#line 43 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Paciente.Telefono, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\"><label for=\"exampleEmail11\"");
            BeginWriteAttribute("class", " class=\"", 2743, "\"", 2751, 0);
            EndWriteAttribute();
            WriteLiteral(">Celular</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 50 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Paciente.Celular, new{ type="number", @class="form-control",
                                       @placeholder="Celular"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                        ");
#nullable restore
#line 54 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Paciente.Celular, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\"><label");
            BeginWriteAttribute("class", "  class=\"", 3483, "\"", 3492, 0);
            EndWriteAttribute();
            WriteLiteral(">Nit</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 60 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Paciente.Nit, new {type="number", @class="form-control",
                                       @placeholder="Nit"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 62 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Paciente.Nit, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                \n                <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\">\n                        <label");
            BeginWriteAttribute("class", " class=\"", 4071, "\"", 4079, 0);
            EndWriteAttribute();
            WriteLiteral(">Direccion</label>\n                        ");
#nullable restore
#line 69 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Paciente.Direccion, new{ @class="form-control",
                                       @placeholder="Direccion"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 71 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Paciente.Direccion, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n\n                 <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\">\n                        <label");
            BeginWriteAttribute("class", " class=\"", 4558, "\"", 4566, 0);
            EndWriteAttribute();
            WriteLiteral(">Número de Afiliación</label>\n                        ");
#nullable restore
#line 78 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Paciente.no_IGGS, new{ @class="form-control",
                                       @placeholder="Número de Afiliación"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 80 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Paciente.no_IGGS, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                 <div class=\"col-md-2\">\n                    <div class=\"position-relative form-group\">\n                        <label");
            BeginWriteAttribute("class", " class=\"", 5062, "\"", 5070, 0);
            EndWriteAttribute();
            WriteLiteral(">¿Está afiliado?</label>\n                        ");
#nullable restore
#line 86 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
                   Write(Html.CheckBoxFor(a => a.Paciente.esta_Afiliado, new{ @class="form-control float-left",
                                       }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 88 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Pacientes/_PacientesForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Paciente.esta_Afiliado, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>

                </div>
                <div class=""form-row"">
                    </div>
                    <div class=""col-md-12"">
                        <div class=""position-relative form-group"">
                            <button class=""btn btn-primary"">Guardar</button>
                        </div>
                    </div>
                </div>
");
            WriteLiteral("            </div>\n        </div>\n    </div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.PacientesBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
