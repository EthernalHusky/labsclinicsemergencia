#pragma checksum "/root/farmaciaSistema_Farmamest/sistema/Views/Compra/Modificar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78e68a2724d42687d4835b1a144e7ded56f68683"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compra_Modificar), @"mvc.1.0.view", @"/Views/Compra/Modificar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78e68a2724d42687d4835b1a144e7ded56f68683", @"/Views/Compra/Modificar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Compra_Modificar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.CompraBaseViewModel>
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
#line 5 "/root/farmaciaSistema_Farmamest/sistema/Views/Compra/Modificar.cshtml"
  
    ViewData["Title"] = "Modifica Compra";

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
            <div>Modificar Compra
                <div class=""page-title-subheading"">Modifica una compra
                    etc.
                </div>
            </div>
        </div>
    </div>
</div>
 ");
#nullable restore
#line 24 "/root/farmaciaSistema_Farmamest/sistema/Views/Compra/Modificar.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 26 "/root/farmaciaSistema_Farmamest/sistema/Views/Compra/Modificar.cshtml"
 if(Model.Compra.Estado != true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"position-relative form-group\">\n<button type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 804, "\"", 847, 3);
            WriteAttributeValue("", 814, "ModificarCompra(", 814, 16, true);
#nullable restore
#line 29 "/root/farmaciaSistema_Farmamest/sistema/Views/Compra/Modificar.cshtml"
WriteAttributeValue("", 830, Model.Compra.Id, 830, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 846, ")", 846, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Guardar</button>\n<button type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 911, "\"", 954, 3);
            WriteAttributeValue("", 921, "ConfirmarCompra(", 921, 16, true);
#nullable restore
#line 30 "/root/farmaciaSistema_Farmamest/sistema/Views/Compra/Modificar.cshtml"
WriteAttributeValue("", 937, Model.Compra.Id, 937, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 953, ")", 953, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Confirmar</button>\n</div>\n");
#nullable restore
#line 32 "/root/farmaciaSistema_Farmamest/sistema/Views/Compra/Modificar.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 35 "/root/farmaciaSistema_Farmamest/sistema/Views/Compra/Modificar.cshtml"
Write(await Html.PartialAsync("_Compraform"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78e68a2724d42687d4835b1a144e7ded56f686836211", async() => {
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
                WriteLiteral("\n");
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