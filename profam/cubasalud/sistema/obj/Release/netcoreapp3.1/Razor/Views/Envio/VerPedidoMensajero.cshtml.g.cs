#pragma checksum "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ca4782b23faf8f9757b80a5000816691b8a68bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Envio_VerPedidoMensajero), @"mvc.1.0.view", @"/Views/Envio/VerPedidoMensajero.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ca4782b23faf8f9757b80a5000816691b8a68bd", @"/Views/Envio/VerPedidoMensajero.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Envio_VerPedidoMensajero : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Models.EnvioBaseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/FuncionesEnvio.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/moment.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/daterangepicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tempusdominus-bootstrap-4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/daterangepicker.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
  
    decimal sumtotal = 0.00m;
    decimal sumsubtotal = 0.00m;
    decimal sumdescuento = 0.00m;
     int porc = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 12 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<link href=\"https://cdnjs.cloudflare.com/ajax/libs/toastr.js/2.0.1/css/toastr.css\" rel=\"stylesheet\"/>\n\n\n\n\n\n</br>\n\n\n\n\n\n\n\n\n\n\n");
#nullable restore
#line 30 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
 if(Model.Envio.EstadosEnvioId==1 || Model.Envio.EstadosEnvioId==2){

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 402, "\"", 471, 1);
#nullable restore
#line 31 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
WriteAttributeValue("", 409, Url.Action("EnviaraRuta","Envio", new {id = @Model.Envio.Id}), 409, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Enviar a ruta</a>\n<a");
            BeginWriteAttribute("href", " href=\"", 517, "\"", 584, 1);
#nullable restore
#line 32 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
WriteAttributeValue("", 524, Url.Action("Entregado","Envio", new {id = @Model.Envio.Id}), 524, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Entregado</a>\n");
#nullable restore
#line 33 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<div class=\"form-row\">\n    <div class=\"col-md-12\">\n\n\n\n \n                        <div class=\"main-card mb-3 card\">\n\n\n\n                            <div class=\"card-body\">\n");
            WriteLiteral("                                <div class=\"form-row\">\n                                   \n                                    <div class=\"col-md-6\">\n                                        <div class=\"position-relative form-group\"><label");
            BeginWriteAttribute("class", " class=\"", 1133, "\"", 1141, 0);
            EndWriteAttribute();
            WriteLiteral("><strong>Nombre Vendedor:</strong> </label>\n");
#nullable restore
#line 53 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                         if(Model.Empleado != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                             <label");
            BeginWriteAttribute("class", " class=\"", 1347, "\"", 1355, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                                        Write(Model.Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n");
#nullable restore
#line 56 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                         \n\n                                            \n                                        </div>\n                                    </div>\n");
            WriteLiteral(@"
                                </div>
                                <div class=""form-row"">
                                    
                                    <div class=""col-md-6"">
                                        <div class=""position-relative form-group"">
                                        <label><strong>Cliente:</strong> </label>
                                        <label>");
#nullable restore
#line 80 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                          Write(Model.Envio.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                            
                                        </div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""position-relative form-group"">
                                        <label><strong>Nit:</strong> </label>
                                        <label>");
#nullable restore
#line 87 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                          Write(Model.Envio.Nit);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                            
                                        </div>
                                    </div>
                                    
                                   
                                </div>
                                <div class=""form-row"">
                                    
                                    
                                    <div class=""col-md-6"">
                                        <div class=""position-relative form-group"">
                                        <label><strong>Fecha y Hora de entrega:</strong> </label>
                                        <label");
            BeginWriteAttribute("class", " class=\"", 3809, "\"", 3817, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 100 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                                   Write(Model.Envio.FechaEntrega);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                            
                                        </div>
                                    </div>
                                     
                                     <div class=""col-md-12"">
                                        <div class=""position-relative form-group"">
                                        <label");
            BeginWriteAttribute("class", " class=\"", 4216, "\"", 4224, 0);
            EndWriteAttribute();
            WriteLiteral("><strong>Direccion:</strong> </label>\n                                        <label");
            BeginWriteAttribute("class", " class=\"", 4309, "\"", 4317, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 108 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                                   Write(Model.Envio.DireccionExacta);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                                            
                                        </div>
                                    </div>
                                </div>

                               
                            </div>



                        </div>
                 

                 <div class=""main-card mb-3 card"">

                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class='table table-hover' id=""tableventa"">
                                <thead>
                                    <tr>
                                        <th>Codigo</th>
                                        <th>Nombre Producto</th>
                                        <th>Cantidad</th>
                                        <th>Precio</th>
                                        <th>  %  </th>
                                        <th>Descuento</th>
                                        <th>Subtotal</th>
   ");
            WriteLiteral("                                     <th>Total</th>\n");
#nullable restore
#line 137 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                         if(Model.Envio.EstadosEnvioId != 3 && Model.Envio.EstadosEnvioId != 4 && !User.IsInRole("Mensajero")){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <th>Acciones</th>\n");
#nullable restore
#line 139 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tr>\n                                </thead>\n                                <tbody id=\"contentdetalle\">\n\n");
#nullable restore
#line 144 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                      if(Model != null)
                                    {
                                        foreach (var item in Model.Envio.DetalleEnvios)
                                        {
                                            if(item.Descuento == 0 || item.Subtotal == 0){
                                                porc = 0;
                                            }
                                            else 
                                            {
                                                porc = Convert.ToInt32((item.Descuento / item.Subtotal) * 100);
                                            }


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\n                                        <td>");
#nullable restore
#line 157 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                       Write(item.Producto.CodigoReferencia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 158 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                       Write(item.Producto.NombreProducto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 159 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                       Write(item.Cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 160 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                       Write(item.Precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td>");
#nullable restore
#line 161 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                       Write(porc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td class=\"desc-t\">");
#nullable restore
#line 162 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                                      Write(item.Descuento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td class=\"subtotal-t\">");
#nullable restore
#line 163 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                                          Write(item.Subtotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                        <td class=\"total-t\">");
#nullable restore
#line 164 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                                       Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 165 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                         if(Model.Envio.EstadosEnvioId != 3 && Model.Envio.EstadosEnvioId != 4 && !User.IsInRole("Mensajero")){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td><button  type=\"button\"  class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("onclick", " onclick=\"", 7352, "\"", 7393, 3);
            WriteAttributeValue("", 7362, "eliminarFila(this,", 7362, 18, true);
#nullable restore
#line 166 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
WriteAttributeValue("", 7380, item.Precio, 7380, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7392, ")", 7392, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Quitar</button></td>\n");
#nullable restore
#line 167 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td style=\"display: none;\" class=\"idProd\">");
#nullable restore
#line 168 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                                                             Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    </tr>\n");
#nullable restore
#line 170 "/root/profam/cubasalud/sistema/Views/Envio/VerPedidoMensajero.cshtml"
                                        sumdescuento += item.Descuento;
                                        sumsubtotal += item.Subtotal;
                                        sumtotal += item.Total;

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
                                <span>Subtotal:</span> 
                            Q <span id=""subtotal-venta"">0.00</span> 
                            </div> 

                            <div class=""text-right""  style=""font-size: 25px;"">
                                 <span>Descuento:</span> 
                                 Q <span id=""descuento-venta"">0.00</span>           
");
            WriteLiteral(@"                            </div> 

                            <div class=""text-right"" style=""font-size: 25px;"">
                                <span>Total:</span> 
                            Q <span id=""precio-total-a-pagar"">0.00</span> 
                            </div> 


");
            WriteLiteral("\n                    </div>\n                </div>\n      \n\n        </div>\n\n    </div>\n\n    \n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            WriteLiteral("\n");
            WriteLiteral("\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca4782b23faf8f9757b80a5000816691b8a68bd21281", async() => {
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
                WriteLiteral("\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/toastr.js/2.0.1/js/toastr.js\"></script>\n\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca4782b23faf8f9757b80a5000816691b8a68bd22458", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca4782b23faf8f9757b80a5000816691b8a68bd23624", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ca4782b23faf8f9757b80a5000816691b8a68bd24790", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

<script>
    $(function(){
        $('.select2').select2({
            tags: true
        });
        
    $('.select2bs4').select2({
      theme: 'bootstrap4',
      tags: true,
    });

          $('#reservationtime').daterangepicker({
                    timePicker: true,
                    timePickerIncrement: 30,
                    locale: {
                        format: 'MM/DD/YYYY hh:mm A'
                    }
                });
    });


    
</script>
");
            }
            );
            WriteLiteral("\n");
            DefineSection("css", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8ca4782b23faf8f9757b80a5000816691b8a68bd26575", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <link href=\"https://cdnjs.cloudflare.com/ajax/libs/toastr.js/2.0.1/css/toastr.css\" rel=\"stylesheet\"/>\n");
            }
            );
            WriteLiteral("\n                            \n                                \n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Models.EnvioBaseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
