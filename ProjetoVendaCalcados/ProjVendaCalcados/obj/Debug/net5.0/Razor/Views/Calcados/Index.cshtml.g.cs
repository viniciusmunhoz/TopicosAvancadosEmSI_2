#pragma checksum "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f58e0110797b8cdab06d89d9ddd8a8f9a2ae12f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calcados_Index), @"mvc.1.0.view", @"/Views/Calcados/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58e0110797b8cdab06d89d9ddd8a8f9a2ae12f9", @"/Views/Calcados/Index.cshtml")]
    public class Views_Calcados_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjVendaCalcados.Models.Calcado>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NomeCalcado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Imagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomeCalcado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Imagem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1365, "\"", 1388, 1);
#nullable restore
#line 52 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml"
WriteAttributeValue("", 1380, item.Id, 1380, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1441, "\"", 1464, 1);
#nullable restore
#line 53 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml"
WriteAttributeValue("", 1456, item.Id, 1456, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1519, "\"", 1542, 1);
#nullable restore
#line 54 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml"
WriteAttributeValue("", 1534, item.Id, 1534, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcados\ProjVendaCalcados\Views\Calcados\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjVendaCalcados.Models.Calcado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
