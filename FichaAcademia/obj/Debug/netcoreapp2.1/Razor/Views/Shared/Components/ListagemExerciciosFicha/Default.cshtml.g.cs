#pragma checksum "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExerciciosFicha\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96b4bce4ee4eb8b0351ac1e225f533e1a184ece0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ListagemExerciciosFicha_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ListagemExerciciosFicha/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ListagemExerciciosFicha/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ListagemExerciciosFicha_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96b4bce4ee4eb8b0351ac1e225f533e1a184ece0", @"/Views/Shared/Components/ListagemExerciciosFicha/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13081fbd4135203d621391681268fce7feedca99", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ListagemExerciciosFicha_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FichaAcademia.Dominio.Models.ListaExercicio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 250, true);
            WriteLiteral("\r\n    <div>\r\n        <h5>Exercícios</h5>\r\n        <hr />\r\n        <div>\r\n            <table class=\"table hover striped highlight centered\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(316, 45, false);
#line 11 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExerciciosFicha\Default.cshtml"
                       Write(Html.DisplayNameFor(model => model.Exercicio));

#line default
#line hidden
            EndContext();
            BeginContext(361, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(453, 46, false);
#line 14 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExerciciosFicha\Default.cshtml"
                       Write(Html.DisplayNameFor(model => model.Frequencia));

#line default
#line hidden
            EndContext();
            BeginContext(499, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(591, 46, false);
#line 17 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExerciciosFicha\Default.cshtml"
                       Write(Html.DisplayNameFor(model => model.Repeticoes));

#line default
#line hidden
            EndContext();
            BeginContext(637, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(729, 41, false);
#line 20 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExerciciosFicha\Default.cshtml"
                       Write(Html.DisplayNameFor(model => model.Carga));

#line default
#line hidden
            EndContext();
            BeginContext(770, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(862, 41, false);
#line 23 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExerciciosFicha\Default.cshtml"
                       Write(Html.DisplayNameFor(model => model.Ficha));

#line default
#line hidden
            EndContext();
            BeginContext(903, 111, true);
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 28 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExerciciosFicha\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1087, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1184, 49, false);
#line 32 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExerciciosFicha\Default.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Exercicio.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1233, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1337, 45, false);
#line 35 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExerciciosFicha\Default.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Frequencia));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1486, 45, false);
#line 38 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExerciciosFicha\Default.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Repeticoes));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1635, 40, false);
#line 41 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExerciciosFicha\Default.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Carga));

#line default
#line hidden
            EndContext();
            BeginContext(1675, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1779, 45, false);
#line 44 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExerciciosFicha\Default.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Ficha.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1824, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 47 "D:\ProjetosC#\EstudosC#\ASPNET_CORE_MVC2\FichaAcademia_0096\FichaAcademia\FichaAcademia\Views\Shared\Components\ListagemExerciciosFicha\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(1915, 74, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FichaAcademia.Dominio.Models.ListaExercicio>> Html { get; private set; }
    }
}
#pragma warning restore 1591