#pragma checksum "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "712fddcce15689f02b738e09eda5d2bbef163886"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compra__CompraForm), @"mvc.1.0.view", @"/Views/Compra/_CompraForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"712fddcce15689f02b738e09eda5d2bbef163886", @"/Views/Compra/_CompraForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Compra__CompraForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.CompraBaseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control select2bs4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("proveedorselect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("tipolistaselect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("disabled", new global::Microsoft.AspNetCore.Html.HtmlString("disabled"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("readonly", new global::Microsoft.AspNetCore.Html.HtmlString("readonly"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fechalimite"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Nuevo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<ul class=""body-tabs body-tabs-layout tabs-animated body-tabs-animated nav"">
    <li class=""nav-item"">
        <a role=""tab"" class=""nav-link active"" id=""tab-0"" data-toggle=""tab"" href=""#tab-content-0"">
            <span>Datos de la Compra</span>
        </a>
    </li>
    <li class=""nav-item"">
        <a role=""tab"" class=""nav-link"" id=""tab-2"" data-toggle=""tab"" href=""#tab-content-2"">
            <span>Detalle de la Compra</span>
        </a>
    </li>

");
            WriteLiteral(@"</ul>


<div class=""form-row"">
    <div class=""col-md-12"">
        <div class=""tab-content"">
            <div class=""tab-pane tabs-animation fade show active"" id=""tab-content-0"" role=""tabpanel"">
                <div class=""form"">
                    <div class=""col-md-12"">
                        <div class=""main-card mb-3 card"">
                            <div class=""card-body"">
");
            WriteLiteral("                                                               <div class=\"form-row\">\n                                    <div class=\"col-md-6\">\n                                        <div class=\"position-relative form-group\"><label");
            BeginWriteAttribute("class", " class=\"", 1390, "\"", 1398, 0);
            EndWriteAttribute();
            WriteLiteral(">No.\n                                                Comprobante</label>\n");
            WriteLiteral("                                            ");
#nullable restore
#line 38 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
                                       Write(Html.TextBoxFor(a => a.Compra.NoComprobante, new
                                                                           {@class="form-control",@id="nocomprobante", @placeholder="No. Comprobante"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            ");
#nullable restore
#line 40 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
                                       Write(Html.ValidationMessageFor(a => a.Compra.NoComprobante, "", new { @class =
                                                                               "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </div>\n                                    </div>\n                                    <div class=\"col-md-6\">\n                                        <div class=\"position-relative form-group\"><label");
            BeginWriteAttribute("class", " class=\"", 2283, "\"", 2291, 0);
            EndWriteAttribute();
            WriteLiteral(">Codigo Del Vendedor</label>\n");
            WriteLiteral("                                            ");
#nullable restore
#line 47 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
                                       Write(Html.TextBoxFor(a => a.Compra.EmpleadoId, new
                                                                           {@class="form-control",@id="empleadocompraid", @placeholder="Codigo Empleado"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                            ");
#nullable restore
#line 49 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
                                       Write(Html.ValidationMessageFor(a => a.Compra.EmpleadoId, "", new { @class =
                                                                               "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>

                                </div>
                                <div class=""form-row"">
                                    <div class=""col-md-6"">
                                        <label>Proveedor</label>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "712fddcce15689f02b738e09eda5d2bbef16388611429", async() => {
                WriteLiteral("\n\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 59 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Compra.ProveedorId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ListaProveedores;

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
            WriteLiteral("\n\n                                    </div>\n");
#nullable restore
#line 65 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
                                     if(@Model.Compra.TipoCompraId != 2)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-md-6\">\n                                            <label>Tipo</label>\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "712fddcce15689f02b738e09eda5d2bbef16388614247", async() => {
                WriteLiteral("\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 70 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Compra.TipoCompraId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 70 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ListaTipoCompra;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        </div>\n");
#nullable restore
#line 74 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
                                    }
                                    else 
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-md-6\">\n                                            <label>Tipo</label>\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "712fddcce15689f02b738e09eda5d2bbef16388617076", async() => {
                WriteLiteral("\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 80 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Compra.TipoCompraId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 80 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ListaTipoCompra;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                        </div>\n");
#nullable restore
#line 84 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    
                                </div>
                                <div class=""form-row"">
                                    <div class=""col-md-12"">
                                        <div class=""position-relative form-group""><label");
            BeginWriteAttribute("class", " class=\"", 5190, "\"", 5198, 0);
            EndWriteAttribute();
            WriteLiteral(">Fecha Limite</label>\n");
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "712fddcce15689f02b738e09eda5d2bbef16388620336", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
#nullable restore
#line 92 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Compra.FechaLimite);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                            ");
#nullable restore
#line 93 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
                                       Write(Html.ValidationMessageFor(a => a.Compra.FechaLimite, "", new { @class =
                                                                               "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                        </div>\n                                    </div>\n");
            WriteLiteral(@"                                </div>

                                <div class=""form-row"">
                                    <div class=""col-md-12"">
                                        <div class=""position-relative form-group"">
                                            <label");
            BeginWriteAttribute("class", " class=\"", 7069, "\"", 7077, 0);
            EndWriteAttribute();
            WriteLiteral(">Observación</label>\n");
            WriteLiteral("                                            ");
#nullable restore
#line 113 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
                                       Write(Html.TextAreaFor(a => a.Compra.Observaciones,5,500 ,htmlAttributes : new {
                                                            @class="form-control ", @placeholder="Observación", @style="max-width:100% !important;", @id="observacion"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                                            ");
#nullable restore
#line 117 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
                                       Write(Html.ValidationMessageFor(a => a.Compra.Observaciones, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""tab-pane tabs-animation fade show "" id=""tab-content-2"" role=""tabpanel"">
                <div class=""main-card mb-3 card"">
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class='table table-hover' id=""tablecompra"">
                                <thead>
                                    <tr>
                                        <th>Codigo</th>
                                        <th>Producto</th>
                                        <th>Cantidad</th>
                                        <th>Precio</th>
");
            WriteLiteral(@"                                        <th>Total</th>
                                        <th>Acciones</th>
                                    </tr>
                                </thead>
                                <tbody id=""contentdetalle"">
");
#nullable restore
#line 145 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
                                     if(Model.Compra != null)
                                    {
                                        foreach (var item in Model.Compra.DetalleCompras)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                        <td class=\"idProd\">");
#nullable restore
#line 150 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
                                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 151 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
                                       Write(item.Producto.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td class=\"cantidad-fila\"><input type=\"number\" step=\"any\"");
            BeginWriteAttribute("value", " value=\"", 9654, "\"", 9676, 1);
#nullable restore
#line 152 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
WriteAttributeValue("", 9662, item.Cantidad, 9662, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" onchange=\"editarValorFila(this)\" ></td>\n                                        <td class=\"precio-fila\"><input type=\"number\" step=\"any\"");
            BeginWriteAttribute("value", " value=\"", 9834, "\"", 9854, 1);
#nullable restore
#line 153 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
WriteAttributeValue("", 9842, item.Precio, 9842, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"  onchange=\"actualizarPreciosVenta()\"></td>\n                                        <td class=\"total-t\">");
#nullable restore
#line 154 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
                                                       Write(item.PrecioTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td><button  type=\"button\"  class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 10100, "\"", 10141, 3);
            WriteAttributeValue("", 10110, "eliminarFila(this,", 10110, 18, true);
#nullable restore
#line 155 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
WriteAttributeValue("", 10128, item.Precio, 10128, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10140, ")", 10140, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Quitar</button></td>\n                                        <td style=\"display: none;\" >");
#nullable restore
#line 156 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
                                                               Write(item.Producto.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    </tr>\n");
#nullable restore
#line 158 "/home/benjamin/Desktop/labs2/labsclinicsemergencia/profam/cubasalud/sistema/Views/Compra/_CompraForm.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                                
                            </table>


                        </div>

                            <br/>
                            
                            <div class=""text-right"" style=""font-size: 25px;"">
                                <span>Total:</span> 
                            Q <span id=""precio-total-a-pagar"">0.00</span> 
                            </div> 
");
            WriteLiteral("                    </div>\n                </div>\n            </div>\n\n                <div class=\"tab-pane tabs-animation fade show \" id=\"tab-content-3\" role=\"tabpanel\">\n                                                <br />\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "712fddcce15689f02b738e09eda5d2bbef16388630206", async() => {
                WriteLiteral(@"
                                <div class=""col-md-12"">
                                    <div class=""input-group"">
                                        <div class=""input-group-prepend"">
                                            <input value=""Buscar"" class=""btn btn-success"" onclick=""FiltrarProductos(document.getElementById('buscarfiltro').value)""></input>
                                        </div>
                                        <input type=""text"" name=""buscar"" id=""buscarfiltro"" class=""form-control""
                                            placeholder=""Buscar Producto..."">
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <br />

                            <div class=""main-card mb-6 card"">
                                <div class=""container-fluid"">
                                    <div class=""card-body my-gallery"" itemscope itemtype=""http://schema.org/ImageGallery"">
                                        <div class=""card-deck-wrapper"">
                                            <div class=""card-deck"">
                                                <div class=""row"" id=""listafiltro"">

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.CompraBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
