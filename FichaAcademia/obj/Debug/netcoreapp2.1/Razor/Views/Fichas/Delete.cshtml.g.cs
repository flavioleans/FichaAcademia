#pragma checksum "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d616dc7852051148a0ff9d4a70c944197e9c1c72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fichas_Delete), @"mvc.1.0.view", @"/Views/Fichas/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fichas/Delete.cshtml", typeof(AspNetCore.Views_Fichas_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d616dc7852051148a0ff9d4a70c944197e9c1c72", @"/Views/Fichas/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13081fbd4135203d621391681268fce7feedca99", @"/Views/_ViewImports.cshtml")]
    public class Views_Fichas_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FichaAcademia.Dominio.Models.Ficha>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(87, 166, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Ficha</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(254, 40, false);
#line 15 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(294, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(338, 36, false);
#line 18 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(374, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(418, 44, false);
#line 21 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cadastro));

#line default
#line hidden
            EndContext();
            BeginContext(462, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(506, 40, false);
#line 24 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cadastro));

#line default
#line hidden
            EndContext();
            BeginContext(546, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(590, 44, false);
#line 27 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Validade));

#line default
#line hidden
            EndContext();
            BeginContext(634, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(678, 40, false);
#line 30 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Validade));

#line default
#line hidden
            EndContext();
            BeginContext(718, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(762, 41, false);
#line 33 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Aluno));

#line default
#line hidden
            EndContext();
            BeginContext(803, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(847, 50, false);
#line 36 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Aluno.NomeCompleto));

#line default
#line hidden
            EndContext();
            BeginContext(897, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(935, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c3990dcf014471fb36fb09b0ccdbc35", async() => {
                BeginContext(961, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(971, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ea3e41423dfc47c984bb720ab384376d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 41 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FichaId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1012, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1096, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d386a870578040de8a264dde118926f1", async() => {
                    BeginContext(1118, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1134, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1147, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FichaAcademia.Dominio.Models.Ficha> Html { get; private set; }
    }
}
#pragma warning restore 1591
