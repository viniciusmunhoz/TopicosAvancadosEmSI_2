#pragma checksum "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcado\ProjVendaCalcado\Views\Calcados\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52eda3404a577f1b7aa5a28ee32d9ab99509d8f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calcados_Create), @"mvc.1.0.view", @"/Views/Calcados/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52eda3404a577f1b7aa5a28ee32d9ab99509d8f9", @"/Views/Calcados/Create.cshtml")]
    public class Views_Calcados_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjVendaCalcado.Models.Calcado>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcado\ProjVendaCalcado\Views\Calcados\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Calcado</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""NomeCalcado"" class=""control-label""></label>
                <input asp-for=""NomeCalcado"" class=""form-control"" />
                <span asp-validation-for=""NomeCalcado"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Tipo"" class=""control-label""></label>
                <input asp-for=""Tipo"" class=""form-control"" />
                <span asp-validation-for=""Tipo"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Numero"" class=""control-label""></label>
                <input asp-for=""Numero"" class=""form-control"" />
                <span asp-validation-for=""Numero"" class=""text-danger""></span>
   ");
            WriteLiteral(@"         </div>
            <div class=""form-group"">
                <label asp-for=""Preco"" class=""control-label""></label>
                <input asp-for=""Preco"" class=""form-control"" />
                <span asp-validation-for=""Preco"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Imagem"" class=""control-label""></label>
                <input asp-for=""Imagem"" class=""form-control"" />
                <span asp-validation-for=""Imagem"" class=""text-danger""></span>
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
#line 52 "C:\GITHUB\TopicosAvancadosEmSI_2\ProjVendaCalcado\ProjVendaCalcado\Views\Calcados\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjVendaCalcado.Models.Calcado> Html { get; private set; }
    }
}
#pragma warning restore 1591