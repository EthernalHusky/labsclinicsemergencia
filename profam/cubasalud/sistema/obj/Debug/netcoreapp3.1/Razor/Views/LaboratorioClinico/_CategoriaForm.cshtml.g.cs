#pragma checksum "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_CategoriaForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36957bd4e22902f27f9a468da4096fe7aa6ca9ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LaboratorioClinico__CategoriaForm), @"mvc.1.0.view", @"/Views/LaboratorioClinico/_CategoriaForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36957bd4e22902f27f9a468da4096fe7aa6ca9ca", @"/Views/LaboratorioClinico/_CategoriaForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_LaboratorioClinico__CategoriaForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.ModCategoriaListados>
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
                    <div class=""position-relative form-group"">
                        <label");
            BeginWriteAttribute("class", " class=\"", 431, "\"", 439, 0);
            EndWriteAttribute();
            WriteLiteral(">Nombre o Descripción</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 14 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_CategoriaForm.cshtml"
                   Write(Html.TextBoxFor(a => a.CategoriaLabClinico.Nombre, new {@class="form-control", @placeholder="Descripcion"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 15 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/LaboratorioClinico/_CategoriaForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.CategoriaLabClinico.Nombre, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n\n");
            WriteLiteral(@"
            </div>
        
            <div class=""col-md-12"">
                <div class=""position-relative form-group"">
                    <button class=""btn btn-primary"" type=""submit"">Guardar</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.ModCategoriaListados> Html { get; private set; }
    }
}
#pragma warning restore 1591
