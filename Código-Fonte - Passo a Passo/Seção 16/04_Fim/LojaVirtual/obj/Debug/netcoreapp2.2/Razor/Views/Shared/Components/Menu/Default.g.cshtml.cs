#pragma checksum "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\04_Fim\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "840c1e66823bccb33f8dd8288df7a8796b9e02d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Menu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Menu_Default))]
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
#line 3 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\04_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"840c1e66823bccb33f8dd8288df7a8796b9e02d1", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14cc5c6a58e3d403c8bc86e45fe3db3aac6026c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2458, true);
            WriteLiteral(@"<nav class=""navbar navbar-expand-lg navbar-dark fixed-top bg-dark"">
    <a class=""navbar-brand"" href=""/""> LojaVirtual</a>
    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
            aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>

    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
        <ul class=""dropdown-menu multi-level"" role=""menu"" aria-labelledby=""dropdownMenu"">
            <li class=""dropdown-item""><a href=""#"">Some action</a></li>
            <li class=""dropdown-item""><a href=""#"">Some other action</a></li>
            <li class=""dropdown-divider""></li>
            <li class=""dropdown-submenu"">
                <a class=""dropdown-item"" tabindex=""-1"" href=""#"">Hover me for more options</a>
                <ul class=""dropdown-menu"">
                    <li class=""dropdown-item""><a tabindex=""-1"" href=""#"">");
            WriteLiteral(@"Second level</a></li>
                    <li class=""dropdown-submenu"">
                        <a class=""dropdown-item"" href=""#"">Even More..</a>
                        <ul class=""dropdown-menu"">
                            <li class=""dropdown-item""><a href=""#"">3rd level</a></li>
                            <li class=""dropdown-submenu"">
                                <a class=""dropdown-item"" href=""#"">another level</a>
                                <ul class=""dropdown-menu"">
                                    <li class=""dropdown-item""><a href=""#"">4th level</a></li>
                                    <li class=""dropdown-item""><a href=""#"">4th level</a></li>
                                    <li class=""dropdown-item""><a href=""#"">4th level</a></li>
                                </ul>
                            </li>
                            <li class=""dropdown-item""><a href=""#"">3rd level</a></li>
                        </ul>
                    </li>
                    <li class=""dr");
            WriteLiteral(@"opdown-item""><a href=""#"">Second level</a></li>
                    <li class=""dropdown-item""><a href=""#"">Second level</a></li>
                </ul>
            </li>
        </ul>
        <ul class=""navbar-nav mr-auto"">
            <li class=""nav-item active"">
                <a class=""nav-link"" href=""/""><i class=""fas fa-home""></i> Home <span class=""sr-only"">(current)</span></a>
            </li>
");
            EndContext();
#line 42 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\04_Fim\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
             if (Model != null && Model.Count > 0)
            {

#line default
#line hidden
            BeginContext(2549, 414, true);
            WriteLiteral(@"                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown""
                       aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""fas fa-list-ul""></i> Categorias
                    </a>
                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
");
            EndContext();
#line 50 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\04_Fim\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                         foreach (var categoria in Model)
                        {

#line default
#line hidden
            BeginContext(3049, 62, true);
            WriteLiteral("                            <a class=\"dropdown-item\" href=\"#\">");
            EndContext();
            BeginContext(3112, 14, false);
#line 52 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\04_Fim\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                                                         Write(categoria.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3126, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 53 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\04_Fim\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(3159, 53, true);
            WriteLiteral("\r\n                    </div>\r\n                </li>\r\n");
            EndContext();
#line 57 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\04_Fim\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(3227, 184, true);
            WriteLiteral("            <li class=\"nav-item\">\r\n                <a class=\"nav-link\" href=\"/Home/Contato\"><i class=\"far fa-address-book\"></i> Contato </a>\r\n            </li>\r\n        </ul>\r\n        ");
            EndContext();
            BeginContext(3411, 466, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "840c1e66823bccb33f8dd8288df7a8796b9e02d18809", async() => {
                BeginContext(3450, 420, true);
                WriteLiteral(@"
            <input class=""form-control mr-sm-2"" type=""search"" placeholder=""palavra"" aria-label=""Search"">
            <button class=""btn btn-outline-success my-2 my-sm-0"" type=""submit"">Pesquisa</button>
            <a class=""nav-link"" href=""/Home/Login""><i class=""fas fa-user-alt""></i> Login</a>
            <a class=""nav-link"" href=""/Home/CarrinhoCompras""><i class=""fas fa-shopping-cart""></i> Carrinho</a>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3877, 20, true);
            WriteLiteral("\r\n    </div>\r\n</nav>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
