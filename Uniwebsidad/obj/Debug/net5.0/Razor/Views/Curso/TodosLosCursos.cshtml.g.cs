#pragma checksum "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\TodosLosCursos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20aae29211a96afe458284e63f68c533606862c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_TodosLosCursos), @"mvc.1.0.view", @"/Views/Curso/TodosLosCursos.cshtml")]
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
#nullable restore
#line 1 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\_ViewImports.cshtml"
using Uniwebsidad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\_ViewImports.cshtml"
using Uniwebsidad.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20aae29211a96afe458284e63f68c533606862c2", @"/Views/Curso/TodosLosCursos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56b9a026bb969f9b7752353c67391ac4d670d188", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_TodosLosCursos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("700"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/iconProject.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    img .zoom{
        width: 90%;
    }

        img .zoom:hover {
            width: 95%;
        }

        .active, .collapsible:hover {
            background-color: #555;
        }

        h4 .card-title:hover{
            text-decoration:none;
            width:50%;
        }

    .content {
        padding: 0 18px;
        display: none;
        overflow: hidden;
        background-color: #f1f1f1;
    }

    .zoom {
        transition: transform .2s;
    }

        .zoom:hover {
            transform: scale(1.1);
        }
</style>

<div style=""text-align:center;"">
    <a href=""/Curso/TodosLosCursos"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "20aae29211a96afe458284e63f68c533606862c25139", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20aae29211a96afe458284e63f68c533606862c26345", async() => {
                WriteLiteral("\n    <input type=\"text\" placeholder=\"Buscar Curso\" name=\"busqueda\" autocomplete=\"off\"/>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<div class=\"row\">\n    <div class=\"container\">\n        <div class=\"card-deck\">\n");
#nullable restore
#line 47 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\TodosLosCursos.cshtml"
             foreach (var item in @ViewBag.Cursos)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-4"">
                    <div class=""card text-white bg-secondary mb-3"" style=""max-width: 18rem;"">
                        <img class=""card-img-top zoom"" src=""https://strategyco.es/wp-content/uploads/2020/10/Imagen-BlogStrategyco-202010A-JB.jpg"" />
                        <div class=""card-body"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 1310, "\"", 1348, 2);
            WriteAttributeValue("", 1317, "/Curso/DetalleCurso?Id=", 1317, 23, true);
#nullable restore
#line 53 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\TodosLosCursos.cshtml"
WriteAttributeValue("", 1340, item.Id, 1340, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h4 class=\"card-title text-white\">");
#nullable restore
#line 53 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\TodosLosCursos.cshtml"
                                                                                                   Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\n                            <p>");
#nullable restore
#line 54 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\TodosLosCursos.cshtml"
                          Write(ViewBag.Categorias[@item.Id]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 55 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\TodosLosCursos.cshtml"
                             if (ViewBag.UsuarioId != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"btn btn-info p-2\"");
            BeginWriteAttribute("href", " href=\"", 1620, "\"", 1658, 2);
            WriteAttributeValue("", 1627, "/Curso/agregarCurso?Id=", 1627, 23, true);
#nullable restore
#line 57 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\TodosLosCursos.cshtml"
WriteAttributeValue("", 1650, item.Id, 1650, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-plus\"></i></a>\n");
#nullable restore
#line 58 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\TodosLosCursos.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1752, "\"", 1790, 2);
            WriteAttributeValue("", 1759, "/Curso/DetalleCurso?Id=", 1759, 23, true);
#nullable restore
#line 59 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\TodosLosCursos.cshtml"
WriteAttributeValue("", 1782, item.Id, 1782, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-center\">Leer m&aacute;s...</a>\n                        </div>\n                    </div>\n                </div>\n");
#nullable restore
#line 63 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\TodosLosCursos.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
