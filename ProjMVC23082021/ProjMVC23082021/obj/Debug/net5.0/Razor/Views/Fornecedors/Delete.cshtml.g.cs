#pragma checksum "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Fornecedors\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1af392d0d3cd0ecae13febf44119c6ab5cc41d98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fornecedors_Delete), @"mvc.1.0.view", @"/Views/Fornecedors/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af392d0d3cd0ecae13febf44119c6ab5cc41d98", @"/Views/Fornecedors/Delete.cshtml")]
    public class Views_Fornecedors_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjMVC23082021.Models.Fornecedor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Fornecedors\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Fornecedor</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Fornecedors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeFantasia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Fornecedors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NomeFantasia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Fornecedors\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CNPJ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Fornecedors\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CNPJ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"hidden\" asp-for=\"id\" />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjMVC23082021.Models.Fornecedor> Html { get; private set; }
    }
}
#pragma warning restore 1591
