#pragma checksum "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Funcionarios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2e790160cc13c979554847b7af22a1de1bd3517"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funcionarios_Details), @"mvc.1.0.view", @"/Views/Funcionarios/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2e790160cc13c979554847b7af22a1de1bd3517", @"/Views/Funcionarios/Details.cshtml")]
    public class Views_Funcionarios_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjMVC23082021.Models.Funcionario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Funcionarios\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Funcionario</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Funcionarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 852, "\"", 876, 1);
#nullable restore
#line 34 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Funcionarios\Details.cshtml"
WriteAttributeValue("", 867, Model.id, 867, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjMVC23082021.Models.Funcionario> Html { get; private set; }
    }
}
#pragma warning restore 1591