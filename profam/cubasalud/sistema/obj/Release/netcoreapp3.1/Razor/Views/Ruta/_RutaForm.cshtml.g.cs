#pragma checksum "/root/profam/cubasalud/sistema/Views/Ruta/_RutaForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6819a0a44c140145fa72e1579c2f3cb99dbf3f76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ruta__RutaForm), @"mvc.1.0.view", @"/Views/Ruta/_RutaForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6819a0a44c140145fa72e1579c2f3cb99dbf3f76", @"/Views/Ruta/_RutaForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Ruta__RutaForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Database.Shared.Models.Ruta>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""tab-pane tabs-animation fade show active"" id=""tab-content-0"" role=""tabpanel"">
    <div class=""main-card mb-3 card"">
        <div class=""card-body"">

            <div class=""form-row"">
                <div class=""col-md-12"">
                    <div class=""position-relative form-group""><label for=""exampleEmail11""");
            BeginWriteAttribute("class", " class=\"", 361, "\"", 369, 0);
            EndWriteAttribute();
            WriteLiteral(">Direccion Destino</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 11 "/root/profam/cubasalud/sistema/Views/Ruta/_RutaForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Destino, new{ @class="form-control",
                                       @placeholder="Direccion Destino"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                        ");
#nullable restore
#line 15 "/root/profam/cubasalud/sistema/Views/Ruta/_RutaForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Destino, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n                <div class=\"form-row\">\n                    <div class=\"col-md-12\">\n                        <div class=\"position-relative form-group\">\n                            <label");
            BeginWriteAttribute("class", " class=\"", 1184, "\"", 1192, 0);
            EndWriteAttribute();
            WriteLiteral(">Descripcion</label>\n");
            WriteLiteral("                            ");
#nullable restore
#line 24 "/root/profam/cubasalud/sistema/Views/Ruta/_RutaForm.cshtml"
                       Write(Html.TextAreaFor(a => a.Descripcion,5,500 ,htmlAttributes : new {
                                               @class="form-control ", @placeholder="Descripcion", @style="max-width:100% !important;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                            ");
#nullable restore
#line 28 "/root/profam/cubasalud/sistema/Views/Ruta/_RutaForm.cshtml"
                       Write(Html.ValidationMessageFor(a => a.Descripcion, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""form-row"">
                    <div class=""col-md-12"">
                        <div class=""position-relative form-group"">
                            <button class=""btn btn-primary"">Guardar</button>
                        </div>
                    </div>
                </div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Database.Shared.Models.Ruta> Html { get; private set; }
    }
}
#pragma warning restore 1591
