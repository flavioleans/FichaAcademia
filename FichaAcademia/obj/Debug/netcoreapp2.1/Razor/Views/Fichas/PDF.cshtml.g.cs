#pragma checksum "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\PDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbdc4ca7c2c0b8f8a4c22541a59efe88896e6c73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fichas_PDF), @"mvc.1.0.view", @"/Views/Fichas/PDF.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fichas/PDF.cshtml", typeof(AspNetCore.Views_Fichas_PDF))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbdc4ca7c2c0b8f8a4c22541a59efe88896e6c73", @"/Views/Fichas/PDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13081fbd4135203d621391681268fce7feedca99", @"/Views/_ViewImports.cshtml")]
    public class Views_Fichas_PDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FichaAcademia.Dominio.Models.Ficha>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\PDF.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(70, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(99, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d22116d51e834ee898f8d649559e587d", async() => {
                BeginContext(105, 202, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css\">\r\n    <title>PDF</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(314, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(316, 673, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad3ea8847a4b40689c2d9067dc3f0873", async() => {
                BeginContext(322, 83, true);
                WriteLiteral("\r\n    <div class=\"collection\">\r\n        <div class=\"collection-item\">\r\n            ");
                EndContext();
                BeginContext(406, 56, false);
#line 17 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\PDF.cshtml"
       Write(await Component.InvokeAsync("DadosAluno", Model.AlunoId));

#line default
#line hidden
                EndContext();
                BeginContext(462, 143, true);
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"row collection-item\">\r\n            <div class=\"col s6\">\r\n                <p><strong>Cadastro: </strong>");
                EndContext();
                BeginContext(606, 14, false);
#line 22 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\PDF.cshtml"
                                         Write(Model.Cadastro);

#line default
#line hidden
                EndContext();
                BeginContext(620, 108, true);
                WriteLiteral("</p>\r\n            </div>\r\n\r\n            <div class=\"col s6\">\r\n                <p><strong>Validade: </strong>");
                EndContext();
                BeginContext(729, 14, false);
#line 26 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\PDF.cshtml"
                                         Write(Model.Validade);

#line default
#line hidden
                EndContext();
                BeginContext(743, 137, true);
                WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"collection\">\r\n        <div class=\"collection-item\">\r\n            ");
                EndContext();
                BeginContext(881, 69, false);
#line 33 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Fichas\PDF.cshtml"
       Write(await Component.InvokeAsync("ListagemExerciciosFicha", Model.FichaId));

#line default
#line hidden
                EndContext();
                BeginContext(950, 32, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(989, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
