#pragma checksum "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Objetivos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8926e29edba68c7dd8bd4305538d55d5abc7765f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Objetivos_Index), @"mvc.1.0.view", @"/Views/Objetivos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Objetivos/Index.cshtml", typeof(AspNetCore.Views_Objetivos_Index))]
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
#line 1 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\_ViewImports.cshtml"
using FichaAcademia;

#line default
#line hidden
#line 2 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\_ViewImports.cshtml"
using FichaAcademia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8926e29edba68c7dd8bd4305538d55d5abc7765f", @"/Views/Objetivos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13081fbd4135203d621391681268fce7feedca99", @"/Views/_ViewImports.cshtml")]
    public class Views_Objetivos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FichaAcademia.Dominio.Models.Objetivo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-small green darken-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-small light-blue darken-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Objetivos\Index.cshtml"
  
    ViewData["Title"] = "Objetivos cadastrados";

#line default
#line hidden
            BeginContext(118, 45, true);
            WriteLiteral("\r\n<h5>Objetivos cadastrados</h5>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(163, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86bf4f2337294ea49f48cae3c39f1921", async() => {
                BeginContext(219, 13, true);
                WriteLiteral("Novo Objetivo");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(236, 116, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table striped hover highlight\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(353, 40, false);
#line 16 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Objetivos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(393, 150, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Descrição\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Objetivos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(592, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(653, 39, false);
#line 29 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Objetivos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(692, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(760, 44, false);
#line 32 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Objetivos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(804, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(871, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cab2cade34ae4305b5ddb86d9d3659ca", async() => {
                BeginContext(962, 9, true);
                WriteLiteral("Atualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Objetivos\Index.cshtml"
                                           WriteLiteral(item.ObjetivoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(975, 31, true);
            WriteLiteral(" &nbsp;\r\n                    <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1006, "\"", 1059, 6);
            WriteAttributeValue("", 1016, "ExibirModal(", 1016, 12, true);
#line 36 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Objetivos\Index.cshtml"
WriteAttributeValue("", 1028, item.ObjetivoId, 1028, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 1044, ",", 1044, 1, true);
            WriteAttributeValue(" ", 1045, "\'", 1046, 2, true);
#line 36 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Objetivos\Index.cshtml"
WriteAttributeValue("", 1047, item.Nome, 1047, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 1057, "\')", 1057, 2, true);
            EndWriteAttribute();
            BeginContext(1060, 87, true);
            WriteLiteral(" class=\"btn-small red darken-2\">Deletar</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 39 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Objetivos\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1158, 399, true);
            WriteLiteral(@"    </tbody>
</table>

<div id=""modal1"" class=""modal"">
    <div class=""modal-content"">
        <h4>Confirmar exclusão</h4>
        <p>Deseja prosseguir com a exclusão de <b class=""nome""></b> ?</p>
    </div>
    <div class=""modal-footer"">
        <a class=""modal-close btn green accent-4"">Não</a>
        <a class=""modal-close btn red accent-4 btnConfirmar"">Sim</a>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1576, 604, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".modal"").modal();
        })
        function ExibirModal(id, nome) {
            $("".nome"").html(nome);
            $(""#modal1"").modal(""open"");
            $("".btnConfirmar"").on('click', function () {
                $.ajax({
                    method: ""POST"",
                    url: ""/Objetivos/Delete"",
                    data: { id: id },
                    success: function () {
                        location.reload();
                    }
                });
            });
        }
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FichaAcademia.Dominio.Models.Objetivo>> Html { get; private set; }
    }
}
#pragma warning restore 1591