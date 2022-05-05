#pragma checksum "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe6acf95104923a7c3a9f4d9d46cd412e56a8107"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Lista), @"mvc.1.0.view", @"/Views/Account/Lista.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe6acf95104923a7c3a9f4d9d46cd412e56a8107", @"/Views/Account/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5db3d1b3fd50b9fbe59a9ed236babcd45883d8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sistema.Areas.Identity.Pages.Account.LogoutModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n\n");
#nullable restore
#line 8 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
  
    ViewData["Title"] = "Lista Usuarios";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<br />\n");
#nullable restore
#line 26 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
Write(await Html.PartialAsync("_MensajeExito"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""tab-pane tabs-animation fade show active"" id=""tab-content-0"" role=""tabpanel"">
    <div class=""main-card mb-3 card"">
        <div class=""card-body"">

            <div class=""table-responsive"">
                <table class=""mb-0 table table-hover "">
                    <thead>
                        <tr>
                            <th>Correo</th>
                            <th>Empleado</th>
                            <th>Estado</th>
                            <th>Acciones</th>
                        </tr>
                    </thead>
                    <tbody>
                  
");
#nullable restore
#line 45 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
                         foreach (var item in Model.ListaUsers)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 49 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
                               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                               \n\n");
#nullable restore
#line 53 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
                                  if (item.Persona == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Sin Asignar</td>\n");
#nullable restore
#line 56 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
                                }
                                else
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 60 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
                                   Write(item.Persona.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 61 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 63 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
                                  if (item.LockoutEnabled== true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Activo</td>\n");
#nullable restore
#line 66 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
                                }
                                else
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Inactivo</td>\n");
#nullable restore
#line 71 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                <td>\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2342, "\"", 2402, 1);
#nullable restore
#line 74 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
WriteAttributeValue("", 2349, Url.Action("Modificar","Account", new {id=@item.Id}), 2349, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">\n                                        Modificar\n                                    </a>\n");
#nullable restore
#line 77 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
                                     if(item.LockoutEnabled==true){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a");
            BeginWriteAttribute("href", " href=\"", 2630, "\"", 2705, 1);
#nullable restore
#line 78 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
WriteAttributeValue("", 2637, Url.Action("Desactivar","Account", new {username = @item.UserName}), 2637, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">\n                                        Desactivar\n                                    </a>\n");
#nullable restore
#line 81 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
                                    }else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a");
            BeginWriteAttribute("href", " href=\"", 2945, "\"", 3020, 1);
#nullable restore
#line 83 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
WriteAttributeValue("", 2952, Url.Action("Desactivar","Account", new {username = @item.UserName}), 2952, 68, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">\n                                        Activar\n                                    </a>\n");
#nullable restore
#line 86 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("                                    \n                                </td>\n                            </tr>\n");
#nullable restore
#line 94 "/root/profam/cubasalud/sistema/Views/Account/Lista.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sistema.Areas.Identity.Pages.Account.LogoutModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
