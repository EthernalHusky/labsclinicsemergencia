#pragma checksum "/root/profam/cubasalud/sistema/Views/CategoriaGasto/_CategoriaGastoForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6271ce115b1c8d5cfa4c2be7e03a55bf5efb49e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CategoriaGasto__CategoriaGastoForm), @"mvc.1.0.view", @"/Views/CategoriaGasto/_CategoriaGastoForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6271ce115b1c8d5cfa4c2be7e03a55bf5efb49e4", @"/Views/CategoriaGasto/_CategoriaGastoForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_CategoriaGasto__CategoriaGastoForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Database.Shared.Models.CategoriaGasto>
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
            BeginWriteAttribute("class", " class=\"", 403, "\"", 411, 0);
            EndWriteAttribute();
            WriteLiteral(">Nombre Categoría</label>\r\n");
            WriteLiteral("                                ");
#nullable restore
#line 12 "/root/profam/cubasalud/sistema/Views/CategoriaGasto/_CategoriaGastoForm.cshtml"
                           Write(Html.TextBoxFor(a => a.NombreCategoria, new {@class="form-control", @placeholder="Nombre Categoría"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 13 "/root/profam/cubasalud/sistema/Views/CategoriaGasto/_CategoriaGastoForm.cshtml"
                           Write(Html.ValidationMessageFor(a => a.NombreCategoria, "", new { @class = "text-danger"}));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Database.Shared.Models.CategoriaGasto> Html { get; private set; }
    }
}
#pragma warning restore 1591
