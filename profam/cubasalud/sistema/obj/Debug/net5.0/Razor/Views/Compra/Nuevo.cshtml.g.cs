#pragma checksum "/root/farmaciaSistema_Farmamest/sistema/Views/Compra/Nuevo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14b5627f0cc7b35493bda26fd33e6d8c44e2215a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compra_Nuevo), @"mvc.1.0.view", @"/Views/Compra/Nuevo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14b5627f0cc7b35493bda26fd33e6d8c44e2215a", @"/Views/Compra/Nuevo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Compra_Nuevo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.CompraBaseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/FuncionesCompra.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n\n");
#nullable restore
#line 5 "/root/farmaciaSistema_Farmamest/sistema/Views/Compra/Nuevo.cshtml"
  
    ViewData["Title"] = "Nuevo Compra";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""app-page-title bg-night-sky text-white"">
    <div class=""page-title-wrapper"">

        <div class=""page-title-heading"">
            <div class=""page-title-icon"">
                <i class=""pe-7s-graph text-success"">
                </i>
            </div>
            <div>Insertar Nueva Compra
                <div class=""page-title-subheading"">Agrega una compra
                    etc.
                </div>
            </div>
        </div>
    </div>
</div>

 ");
#nullable restore
#line 25 "/root/farmaciaSistema_Farmamest/sistema/Views/Compra/Nuevo.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <link href=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/2.0.1/css/toastr.css"" rel=""stylesheet""/>
<div class=""position-relative form-group"">
    
<button type=""button"" class=""btn btn-primary"" onclick=""GuardarCompra()"">Guardar</button>
<button type=""button"" class=""btn btn-primary"" onclick=""ConfirmarCompraNuevo()"">Confirmar</button>
</div>


");
#nullable restore
#line 34 "/root/farmaciaSistema_Farmamest/sistema/Views/Compra/Nuevo.cshtml"
Write(await Html.PartialAsync("_Compraform"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14b5627f0cc7b35493bda26fd33e6d8c44e2215a4992", async() => {
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
                WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/2.0.1/js/toastr.js""></script>

<script>
    $(function(){
        $('.select2').select2({
            tags: true
        });
        
    $('.select2bs4').select2({
      theme: 'bootstrap4',
      tags: true,
    })
    });
    
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.CompraBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591