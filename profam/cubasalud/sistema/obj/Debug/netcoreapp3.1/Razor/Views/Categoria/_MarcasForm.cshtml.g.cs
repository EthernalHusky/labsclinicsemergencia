#pragma checksum "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/Categoria/_MarcasForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eed87e5890e67a4c58756c207c42fecdd6da2b16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria__MarcasForm), @"mvc.1.0.view", @"/Views/Categoria/_MarcasForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eed87e5890e67a4c58756c207c42fecdd6da2b16", @"/Views/Categoria/_MarcasForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoria__MarcasForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.MarcaViewModel>
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
            BeginWriteAttribute("class", " class=\"", 386, "\"", 394, 0);
            EndWriteAttribute();
            WriteLiteral(">Marca</label>\n");
            WriteLiteral("                                ");
#nullable restore
#line 12 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/Categoria/_MarcasForm.cshtml"
                           Write(Html.TextBoxFor(a => a.Marca.NombreMarca, new {@class="form-control", @placeholder="Marca"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 13 "/home/benjamin/Desktop/labs/LabsClinics/profam/cubasalud/sistema/Views/Categoria/_MarcasForm.cshtml"
                           Write(Html.ValidationMessageFor(a => a.Marca.NombreMarca, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                    </div>
                </div>
                <div class=""form-row"">
                    <div class=""col-md-12"">
                            <button class=""btn btn-primary"">Guardar</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.MarcaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
