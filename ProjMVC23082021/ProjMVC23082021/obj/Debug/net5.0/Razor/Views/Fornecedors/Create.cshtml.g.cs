#pragma checksum "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Fornecedors\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2d968bbfced0ef63b2343bb7eaf0b7d0560f674"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fornecedors_Create), @"mvc.1.0.view", @"/Views/Fornecedors/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2d968bbfced0ef63b2343bb7eaf0b7d0560f674", @"/Views/Fornecedors/Create.cshtml")]
    public class Views_Fornecedors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjMVC23082021.Models.Fornecedor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Fornecedors\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Fornecedor</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""NomeFantasia"" class=""control-label""></label>
                <input asp-for=""NomeFantasia"" class=""form-control"" />
                <span asp-validation-for=""NomeFantasia"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CNPJ"" class=""control-label""></label>
                <input asp-for=""CNPJ"" class=""form-control"" />
                <span asp-validation-for=""CNPJ"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjMVC23082021\ProjMVC23082021\Views\Fornecedors\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjMVC23082021.Models.Fornecedor> Html { get; private set; }
    }
}
#pragma warning restore 1591
