#pragma checksum "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "528887ee5b958eb6a93cb650fc3985849bb1b661"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productos__ProductoForm), @"mvc.1.0.view", @"/Views/Productos/_ProductoForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"528887ee5b958eb6a93cb650fc3985849bb1b661", @"/Views/Productos/_ProductoForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Productos__ProductoForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.ProductoBaseViewModel>
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
                    <div class=""position-relative form-group""><label for=""exampleEmail11""");
            BeginWriteAttribute("class", " class=\"", 370, "\"", 378, 0);
            EndWriteAttribute();
            WriteLiteral(">Nombre\n                            Producto</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 13 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Producto.NombreProducto, new {@class="form-control",
                                       @placeholder="Nombre Producto"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 15 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Producto.NombreProducto, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"col-md-6\">\n                    <label>Categoría</label>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "528887ee5b958eb6a93cb650fc3985849bb1b6615203", async() => {
                WriteLiteral("\n\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 21 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Producto.CategoriaId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 22 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ListCategorias;

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
            WriteLiteral("\n                    ");
#nullable restore
#line 25 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
               Write(Html.ValidationMessageFor(a => a.Producto.CategoriaId, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n\n\n            </div>\n            <div class=\"form-row\">\n                <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\"><label for=\"exampleEmail11\"");
            BeginWriteAttribute("class", " class=\"", 1472, "\"", 1480, 0);
            EndWriteAttribute();
            WriteLiteral(">Precio al publico</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 34 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Producto.Precio, new{ type="number",step="any", @class="form-control",
                                       @placeholder="Precio"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                        ");
#nullable restore
#line 38 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Producto.Precio, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\"><label for=\"exampleEmail11\"");
            BeginWriteAttribute("class", " class=\"", 2251, "\"", 2259, 0);
            EndWriteAttribute();
            WriteLiteral(">Precio mayorista</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 44 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Producto.Precio_2, new{ type="number",step="any", @class="form-control",
                                       @placeholder="Precio"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                        ");
#nullable restore
#line 48 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Producto.Precio_2, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n               \n                <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\">\n                        <label");
            BeginWriteAttribute("class", " class=\"", 3053, "\"", 3061, 0);
            EndWriteAttribute();
            WriteLiteral(">Precio de fardo</label>\n\n");
            WriteLiteral("                        ");
#nullable restore
#line 58 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Producto.Precio_3, new{ type="number",step="any", @class="form-control",
                                       @placeholder="Precio 3"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 60 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Producto.Precio_3, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\">\n                        <label");
            BeginWriteAttribute("class", " class=\"", 3728, "\"", 3736, 0);
            EndWriteAttribute();
            WriteLiteral(">Precio cliente especial</label>\n\n");
            WriteLiteral("                        ");
#nullable restore
#line 69 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Producto.Precio_4, new{ type="number",step="any", @class="form-control",
                                       @placeholder="Precio 4"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 71 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Producto.Precio_4, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\">\n                        <label");
            BeginWriteAttribute("class", " class=\"", 4411, "\"", 4419, 0);
            EndWriteAttribute();
            WriteLiteral(">Precio cuentas clave</label>\n\n");
            WriteLiteral("                        ");
#nullable restore
#line 80 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Producto.Precio_5, new{ type="number",step="any", @class="form-control",
                                       @placeholder="Precio 5"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 82 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Producto.Precio_5, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\">\n                        <label");
            BeginWriteAttribute("class", " class=\"", 5091, "\"", 5099, 0);
            EndWriteAttribute();
            WriteLiteral(">Precio modificable</label>\n\n                      \n                        ");
#nullable restore
#line 90 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Producto.Precio_6, new{ type="number",step="any", @class="form-control",
                                       @placeholder="Precio 6"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 92 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Producto.Precio_6, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                 <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\">\n                        <label");
            BeginWriteAttribute("class", " class=\"", 5633, "\"", 5641, 0);
            EndWriteAttribute();
            WriteLiteral(">Precio de adquisición</label>\n\n                    \n                        ");
#nullable restore
#line 100 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Producto.PrecioCosto, new{ type="number",step="any", @class="form-control",
                                       @placeholder="Precio 2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 102 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Producto.PrecioCosto, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                     <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\">\n                        <label");
            BeginWriteAttribute("class", " class=\"", 6186, "\"", 6194, 0);
            EndWriteAttribute();
            WriteLiteral(">Precio 7</label>\n\n                        \n                        ");
#nullable restore
#line 110 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Producto.Precio_7,"", new{ type="number",step="any", @class="form-control",
                                       @placeholder="Precio 7"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 112 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Producto.Precio_7, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\">\n                        <label");
            BeginWriteAttribute("class", " class=\"", 6722, "\"", 6730, 0);
            EndWriteAttribute();
            WriteLiteral(">Stock</label>\n\n                    \n                        ");
#nullable restore
#line 120 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Producto.Stock, new{ type="number",step="any", @class="form-control",
                                       @placeholder="Stock"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 122 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Producto.Stock, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\"><label for=\"exampleEmail11\"");
            BeginWriteAttribute("class", " class=\"", 7235, "\"", 7243, 0);
            EndWriteAttribute();
            WriteLiteral(">Codigo\n                            Referencia</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 129 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Producto.CodigoReferencia, new {@class="form-control",
                                       @placeholder="Codigo de Referencia"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 131 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Producto.CodigoReferencia, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                 <div class=\"col-md-6\">\n                    <div class=\"position-relative form-group\"><label for=\"exampleEmail11\"");
            BeginWriteAttribute("class", " class=\"", 7872, "\"", 7880, 0);
            EndWriteAttribute();
            WriteLiteral(">Stock Inicial</label>\n");
            WriteLiteral("                        ");
#nullable restore
#line 137 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.TextBoxFor(a => a.Producto.StockInical, new {type="number",step="any", @class="form-control",
                                       @placeholder="Stock Inicial"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 139 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                   Write(Html.ValidationMessageFor(a => a.Producto.StockInical,"", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                </div>\n                \n                <div class=\"form-row\">\n                    <div class=\"col-md-12\">\n                        <div class=\"position-relative form-group\">\n                            <label");
            BeginWriteAttribute("class", " class=\"", 8557, "\"", 8565, 0);
            EndWriteAttribute();
            WriteLiteral(">Descripcion</label>\n");
            WriteLiteral("                            ");
#nullable restore
#line 148 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                       Write(Html.TextAreaFor(a => a.Producto.Descripcion,5,500 ,htmlAttributes : new {
                                               @class="form-control ", @placeholder="Descripcion", @style="max-width:100% !important;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                            ");
#nullable restore
#line 152 "/root/farmaciaSistema_Farmamest/sistema/Views/Productos/_ProductoForm.cshtml"
                       Write(Html.ValidationMessageFor(a => a.Producto.Descripcion, "", new { @class = "text-danger"}));

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
                            <label");
            BeginWriteAttribute("class", " class=\"", 9486, "\"", 9494, 0);
            EndWriteAttribute();
            WriteLiteral(@">Imagen</label>
                            <input type=""file"" name=""file"" class=""form-control"" />
                        </div>
                    </div>
                    <div class=""col-md-12"">
                        <div class=""position-relative form-group"">
                            <button class=""btn btn-primary"">Guardar</button>
                        </div>
                    </div>

                </div>
");
            WriteLiteral("\n\n\n\n\n            </div>\n        </div>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.ProductoBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
