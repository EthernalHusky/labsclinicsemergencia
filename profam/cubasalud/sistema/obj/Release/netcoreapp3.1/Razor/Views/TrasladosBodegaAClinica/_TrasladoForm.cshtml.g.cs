#pragma checksum "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79b83984471a64d3cfc7b6581fbf41785b9b05ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TrasladosBodegaAClinica__TrasladoForm), @"mvc.1.0.view", @"/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79b83984471a64d3cfc7b6581fbf41785b9b05ca", @"/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_TrasladosBodegaAClinica__TrasladoForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.TrasladosBaseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control select2bs4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("prodselected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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

<div class=""row"">
    <div class=""col-md-6"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body"">
                <div class=""form-row"">
                        <div class=""col-md-12"">
                            <div class=""position-relative form-group"">
                                <label");
            BeginWriteAttribute("class", " class=\"", 366, "\"", 374, 0);
            EndWriteAttribute();
            WriteLiteral(">Observación</label>\n                                ");
#nullable restore
#line 12 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                           Write(Html.TextAreaFor(a => a.TrasladosProductos.Observaciones,5,500 ,htmlAttributes : new {
                                                @class="form-control ", @placeholder="Descripcion", @style="max-width:100% !important;", @id ="txtObservacion"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 14 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                           Write(Html.ValidationMessageFor(a => a.TrasladosProductos.Observaciones, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n                    </div>\n\n");
#nullable restore
#line 19 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                     if(Model.TrasladosProductos == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""form-row"">
                                <div class=""col-md-12"">
                                    <a class=""btn btn-primary text-white"" id=""guardar""> Guardar </a>
                                </div>
                        </div>
");
#nullable restore
#line 26 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                        
                       
                    }
                    else {
                         

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                          if(Model.TrasladosProductos.EstadoTrasladosId != 1 && @Model.TrasladosProductos.EstadoTrasladosId != 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""form-row"">
                                <div class=""col-md-12"">
                                    <a class=""btn btn-primary text-white"" id=""guardar""> Guardar </a>
                                </div>
                        </div>
");
#nullable restore
#line 37 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   
                        
            </div>
        </div>
    </div>



    <div class=""col-md-6"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body"">
               <div class=""form-row"">
                   <div class=""col-md-12"">
                        <label>Añadir producto</label>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79b83984471a64d3cfc7b6581fbf41785b9b05ca7858", async() => {
                WriteLiteral("\n");
                WriteLiteral("                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 53 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ProductoSelectListItems;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <br>\n\n");
#nullable restore
#line 58 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                     if(Model.TrasladosProductos == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div>
                                <a class=""btn btn-primary text-white"" id=""btnanadir"">
                                <i class=""fas fa-plus""></i>  Añadir
                                </a>
                            </div>
");
#nullable restore
#line 65 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                    }
                    else {
                         

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                          if(Model.TrasladosProductos.EstadoTrasladosId != 1 && @Model.TrasladosProductos.EstadoTrasladosId != 2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                             <div>
                                <a class=""btn btn-primary text-white"" id=""btnanadir"">
                                <i class=""fas fa-plus""></i>  Añadir
                                </a>
                            </div>
");
#nullable restore
#line 74 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <br>
                        <div class=""table-responsive"">
                            <table class='table table-hover' id=""tableventa-c"">
                                <thead>
                                    <tr>
                                        <th>Codigo</th>
                                        <th>Nombre Producto</th>
                                        <th>Cantidad</th>
                                        <th>Acciones</th>
                                        <th>Cod.</th>
                                    </tr>
                                </thead>
                                <tbody id=""contentdetalle-c"">
");
#nullable restore
#line 90 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                                     if (Model.TrasladosProductos != null)
                                    {
                                        foreach (var item in Model.TrasladosProductos.DetalleTrasladoProductos)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\n                                                <td class=\"idProd\">");
#nullable restore
#line 95 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                                                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td>");
#nullable restore
#line 96 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                                               Write(item.Producto.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                <td><input type=\"number\" step=\"any\"");
            BeginWriteAttribute("value", " value=\"", 4576, "\"", 4598, 1);
#nullable restore
#line 97 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
WriteAttributeValue("", 4584, item.Cantidad, 4584, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control""></td>
                                                <td> <button type=""button"" class=""btn btn-danger btn-sm""
                                                            onclick=""eliminarFilaC(this)"">Quitar</button></td>
                                                <td>");
#nullable restore
#line 100 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                                               Write(item.ProductoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                            </tr>\n");
#nullable restore
#line 102 "/root/profam/cubasalud/sistema/Views/TrasladosBodegaAClinica/_TrasladoForm.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\n                            </table>\n                        </div>\n                    </div>\n               </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.TrasladosBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
