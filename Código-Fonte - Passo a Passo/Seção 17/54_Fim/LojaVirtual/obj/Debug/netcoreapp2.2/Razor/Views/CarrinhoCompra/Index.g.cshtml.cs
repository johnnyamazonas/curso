#pragma checksum "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28490ebe044a596ccc96ecc549173c6a5a1dbd12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarrinhoCompra_Index), @"mvc.1.0.view", @"/Views/CarrinhoCompra/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CarrinhoCompra/Index.cshtml", typeof(AspNetCore.Views_CarrinhoCompra_Index))]
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
#line 3 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 4 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 5 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28490ebe044a596ccc96ecc549173c6a5a1dbd12", @"/Views/CarrinhoCompra/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c8e441a1ad085f94e3a56d46d99a0c2d222558b", @"/Views/_ViewImports.cshtml")]
    public class Views_CarrinhoCompra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<LojaVirtual.Models.ProdutoAgregador.ProdutoItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/imagem-produto.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail img-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CarrinhoCompra", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoverItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
  
    ViewData["Title"] = "Index";
    decimal Subtotal = 0;

#line default
#line hidden
            BeginContext(130, 834, true);
            WriteLiteral(@"
<div class=""container"">
    <section id=""order"">
        <br />
        <br />
        <h2 class=""title-doc"">Carrinho de compras</h2>
        <div class=""alert alert-danger"" style=""display: none;"" role=""alert"">
            
        </div>
        <div id=""code_cart"">
            <div class=""card"">
                <table class=""table table-hover shopping-cart-wrap"">
                    <thead class=""text-muted"">
                        <tr>
                            <th scope=""col"">Produto</th>
                            <th scope=""col"" width=""120"">Quantidade</th>
                            <th scope=""col"" width=""120"">Preço</th>
                            <th scope=""col"" width=""200"" class=""text-right"">Ação</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 27 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1045, 196, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <figure class=\"media\">\r\n                                        <div class=\"img-wrap\">\r\n");
            EndContext();
#line 33 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                             if (item.Imagens.Count > 0)
                                            {

#line default
#line hidden
            BeginContext(1362, 52, true);
            WriteLiteral("                                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1414, "\"", 1449, 1);
#line 35 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 1420, item.Imagens.First().Caminho, 1420, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1450, 32, true);
            WriteLiteral(" class=\"img-thumbnail img-sm\">\r\n");
            EndContext();
#line 36 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(1626, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(1674, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "28490ebe044a596ccc96ecc549173c6a5a1dbd128548", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1739, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(1788, 197, true);
            WriteLiteral("                                        </div>\r\n                                        <figcaption class=\"media-body\">\r\n                                            <h6 class=\"title text-truncate\">");
            EndContext();
            BeginContext(1986, 9, false);
#line 43 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                                       Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1995, 206, true);
            WriteLiteral("</h6>\r\n                                            <dl class=\"dlist-inline small\">\r\n                                                <dt>Descrição: </dt>\r\n                                                <dd>");
            EndContext();
            BeginContext(2202, 14, false);
#line 46 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                               Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(2216, 471, true);
            WriteLiteral(@"</dd>
                                            </dl>
                                        </figcaption>
                                    </figure>
                                </td>
                                <td>
                                    <div class=""col-auto"">
                                        <div class=""input-group mb-2 control-inline"">
                                            <input type=""hidden"" class=""inputProdutoId""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2687, "\"", 2703, 1);
#line 54 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 2695, item.Id, 2695, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2704, 100, true);
            WriteLiteral(" />\r\n                                            <input type=\"hidden\" class=\"inputQuantidadeEstoque\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2804, "\"", 2828, 1);
#line 55 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 2812, item.Quantidade, 2812, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2829, 96, true);
            WriteLiteral(" />\r\n                                            <input type=\"hidden\" class=\"inputValorUnitario\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2925, "\"", 2944, 1);
#line 56 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 2933, item.Valor, 2933, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2945, 412, true);
            WriteLiteral(@" />
                                            <div class=""input-group-prepend"">
                                                <a href=""#"" class=""btn btn-primary diminuir""> - </a>
                                            </div>
                                            <input type=""text"" style=""width: 60px; text-align: center"" readonly=""readonly"" class=""form-control inputQuantidadeProdutoCarrinho""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3357, "\"", 3396, 1);
#line 60 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
WriteAttributeValue("", 3365, item.QuantidadeProdutoCarrinho, 3365, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3397, 366, true);
            WriteLiteral(@">
                                            <div class=""input-group-append"">
                                                <a href=""#"" class=""btn btn-primary aumentar""> + </a>
                                            </div>
                                        </div>
                                    </div>
                                </td>
");
            EndContext();
#line 67 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                   
                                    var ResultadoSubtotalItem = item.Valor* item.QuantidadeProdutoCarrinho;
                                    Subtotal = Subtotal + ResultadoSubtotalItem;
                                

#line default
#line hidden
            BeginContext(4026, 159, true);
            WriteLiteral("                                <td>\r\n                                    <div class=\"price-wrap\">\r\n                                        <var class=\"price\">");
            EndContext();
            BeginContext(4187, 35, false);
#line 73 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                       Write(ResultadoSubtotalItem.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(4223, 75, true);
            WriteLiteral("</var>\r\n                                        <small class=\"text-muted\">(");
            EndContext();
            BeginContext(4299, 24, false);
#line 74 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                              Write(item.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(4323, 192, true);
            WriteLiteral(" cada)</small>\r\n                                    </div>\r\n                                </td>\r\n                                <td class=\"text-right\">\r\n                                    ");
            EndContext();
            BeginContext(4515, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28490ebe044a596ccc96ecc549173c6a5a1dbd1216364", async() => {
                BeginContext(4630, 9, true);
                WriteLiteral(" × Remove");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4643, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 81 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4746, 1654, true);
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
    </section>


    <section id=""parameters"">
        <h2 class=""title-doc""># Description lists</h2>
        <div class=""row"">

            <aside class=""col-md-4"">
                <h4 class=""subtitle-doc"">
                    Frete
                </h4>
                <div id=""code_desc_align"">
                    <div class=""box"">
                        <dl class=""dlist-align"">
                            <dt>CEP: </dt>
                            <dd>
                                <div class=""input-group"">
                                    <input type=""text"" name=""cep"" class=""form-control cep"" />
                                    <div class=""input-group-append"">
                                        <a href=""#"" class=""btn btn-outline-primary btn-calcular-frete"">OK</a>
                                    </div>
                                </div>
                             </dd>");
            WriteLiteral(@"
                        </dl>
                        <div class=""container-frete""></div>
                    </div>
                </div>
            </aside>
            <aside class=""col-md-4"">
                <h4 class=""subtitle-doc"">
                    Resumo
                    <a href=""#"" data-html=""code_desc_right"" class=""showcode"">[code]</a>
                </h4>
                <div id=""code_desc_right"">
                    <div class=""box"">
                        <dl class=""dlist-align"">
                            <dt>Subtotal: </dt>
                            <dd class=""text-right subtotal"">");
            EndContext();
            BeginContext(6401, 22, false);
#line 123 "C:\Users\elias\Desktop\ASPNETCoreMVCLojaVirtual\Seção 17\54_Fim\LojaVirtual\Views\CarrinhoCompra\Index.cshtml"
                                                       Write(Subtotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(6423, 698, true);
            WriteLiteral(@"</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>Frete:</dt>
                            <dd class=""text-right frete"">R$ 0,00</dd>
                        </dl>
                        <dl class=""dlist-align"">
                            <dt>TOTAL:</dt>
                            <dd class=""text-right total"">R$ 0,00</dd>
                        </dl>
                    </div>
                </div>
            </aside>
            <aside class=""col-md-4"">
                <a href=""#"" class=""btn btn-primary btn-continuar disabled"">Continuar</a>
            </aside>
        </div>

    </section>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<LojaVirtual.Models.ProdutoAgregador.ProdutoItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
