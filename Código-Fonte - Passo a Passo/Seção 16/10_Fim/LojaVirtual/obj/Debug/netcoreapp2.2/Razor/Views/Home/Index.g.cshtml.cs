#pragma checksum "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e57c1b340126d3b46bddf9d106ee8c406e207604"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 3 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 4 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 5 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e57c1b340126d3b46bddf9d106ee8c406e207604", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8207d58974b08cb1ae03fc6f6f73d81d00a8cba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LojaVirtual.Models.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/imagem-produto.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var pesquisa = Context.Request.Query["pesquisa"];

#line default
#line hidden
            BeginContext(149, 3609, true);
            WriteLiteral(@"
<main role=""main"">

    <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#myCarousel"" data-slide-to=""1""></li>
            <li data-target=""#myCarousel"" data-slide-to=""2""></li>
        </ol>
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                <img class=""first-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==""
                     alt=""First slide"">
                <div class=""container"">
                    <div class=""carousel-caption text-left"">
                        <h1>Example headline.</h1>
                        <p>
                            Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut ");
            WriteLiteral(@"id elit.
                        </p>
                        <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Sign up today</a></p>
                    </div>
                </div>
            </div>
            <div class=""carousel-item"">
                <img class=""second-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==""
                     alt=""Second slide"">
                <div class=""container"">
                    <div class=""carousel-caption"">
                        <h1>Another example headline.</h1>
                        <p>
                            Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
                        </p>
                        <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Learn more</a></p>
                    </div>
                </div>");
            WriteLiteral(@"
            </div>
            <div class=""carousel-item"">
                <img class=""third-slide"" src=""data:image/gif;base64,R0lGODlhAQABAIAAAHd3dwAAACH5BAAAAAAALAAAAAABAAEAAAICRAEAOw==""
                     alt=""Third slide"">
                <div class=""container"">
                    <div class=""carousel-caption text-right"">
                        <h1>One more for good measure.</h1>
                        <p>
                            Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta
                            gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.
                        </p>
                        <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Browse gallery</a></p>
                    </div>
                </div>
            </div>
        </div>
        <a class=""carousel-control-prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon");
            WriteLiteral(@""" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>




    <!-- Lista de Produtos
            ================================================== -->
    <!-- Wrap the rest of the page in another container to center all the content. -->

");
            EndContext();
#line 76 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
     if (Model.lista.Count > 0)
    {

#line default
#line hidden
            BeginContext(3798, 87, true);
            WriteLiteral("        <div class=\"container\" id=\"code_prod_complex\">\r\n            <div class=\"row\">\r\n");
            EndContext();
#line 80 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
                 foreach (var produto in Model.lista)
                {

#line default
#line hidden
            BeginContext(3959, 156, true);
            WriteLiteral("                    <div class=\"col-md-3\">\r\n                        <figure class=\"card card-product\">\r\n                            <div class=\"img-wrap\">\r\n");
            EndContext();
#line 85 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
                                 if (produto.Imagens != null && produto.Imagens.Count() > 0)
                                {

#line default
#line hidden
            BeginContext(4244, 40, true);
            WriteLiteral("                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4284, "\"", 4327, 1);
#line 87 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
WriteAttributeValue("", 4290, produto.Imagens.ElementAt(0).Caminho, 4290, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4328, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 88 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(4441, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(4477, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e57c1b340126d3b46bddf9d106ee8c406e2076049996", async() => {
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
            EndContext();
            BeginContext(4515, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 92 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(4552, 148, true);
            WriteLiteral("\r\n                            </div>\r\n                            <figcaption class=\"info-wrap\">\r\n                                <h4 class=\"title\">");
            EndContext();
            BeginContext(4701, 12, false);
#line 96 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
                                             Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(4713, 336, true);
            WriteLiteral(@"</h4>
                            </figcaption>
                            <div class=""bottom-wrap"">
                                <a href="""" class=""btn btn-sm btn-primary float-right"">Adicionar Carrinho</a>
                                <div class=""price-wrap h5"">
                                    <span class=""price-new"">");
            EndContext();
            BeginContext(5050, 27, false);
#line 101 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
                                                       Write(produto.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(5077, 211, true);
            WriteLiteral("</span>\r\n                                </div> <!-- price-wrap.// -->\r\n                            </div> <!-- bottom-wrap.// -->\r\n                        </figure>\r\n                    </div> <!-- col // -->\r\n");
            EndContext();
#line 106 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(5307, 48, true);
            WriteLiteral("            </div> <!-- row.// -->\r\n            ");
            EndContext();
            BeginContext(5356, 122, false);
#line 108 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
       Write(Html.PagedListPager((IPagedList)Model.lista, pagina => Url.Action("Index", new { pagina = pagina, pesquisa = pesquisa  })));

#line default
#line hidden
            EndContext();
            BeginContext(5478, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 110 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(5503, 15, true);
            WriteLiteral("    </main>\r\n\r\n");
            EndContext();
#line 113 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
  
/*
 * Razor - Motor Template do ASP.NET
 * Html Helper - Interface que proporciona gerar código HTML por meio do C#, isso ajuda na manipulação de informações entre HTML e Tecnologia ASP.NET
 */

/*
 * URL: #Fragmento
 */

/*
 * Primeiro formulário:
 * @using (Html.BeginForm("index", "home", FormMethod.Post))
 */

#line default
#line hidden
            BeginContext(5852, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 131 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
 using (Html.BeginForm(null, null, null, FormMethod.Post, true, new { @action = @Url.Action("index", "home") + "#formulario" }))
{


#line default
#line hidden
            BeginContext(5993, 132, true);
            WriteLiteral("        <div class=\"container\" id=\"formulario\">\r\n            <div class=\"row\">\r\n                <div class=\"col-sm-8 offset-sm-2\">\r\n");
            EndContext();
#line 137 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
                     if (TempData["MSG_S"] != null)
                    {

#line default
#line hidden
            BeginContext(6201, 55, true);
            WriteLiteral("                        <p class=\"alert alert-success\">");
            EndContext();
            BeginContext(6257, 17, false);
#line 139 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
                                                  Write(TempData["MSG_S"]);

#line default
#line hidden
            EndContext();
            BeginContext(6274, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 140 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(6303, 568, true);
            WriteLiteral(@"                </div>
            </div>
            <div class=""row"">
                
                <div class=""col-sm-6 offset-sm-2"">
                    <div class=""form-group"">
                        <label for=""nome"">Cadastre seu e-mail para receber promoções:</label>
                        <div class=""input-group"">
                            <div class=""input-group-prepend"">
                                <span class=""input-group-text""><i class=""fa  fa-envelope ""></i></span>
                            </div>
                            ");
            EndContext();
            BeginContext(6872, 97, false);
#line 152 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
                       Write(Html.EditorFor(m => m.newsletter.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(6969, 84, true);
            WriteLiteral("\r\n                        </div>\r\n                        <span style=\"color: red;\">");
            EndContext();
            BeginContext(7054, 50, false);
#line 154 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
                                             Write(Html.ValidationMessageFor(m => m.newsletter.Email));

#line default
#line hidden
            EndContext();
            BeginContext(7104, 328, true);
            WriteLiteral(@"</span>
                    </div>
                </div>
                <div class=""col-sm-2"">
                    <br />
                    <button class=""subscribe btn btn-primary btn-block"" type=""submit"" style=""margin-top: 7px""> Cadastrar-se </button>
                </div>


            </div>
        </div>
");
            EndContext();
#line 165 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 16\10_Fim\LojaVirtual\Views\Home\Index.cshtml"
    
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LojaVirtual.Models.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
