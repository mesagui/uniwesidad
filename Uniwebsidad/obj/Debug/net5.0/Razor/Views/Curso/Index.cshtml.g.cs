#pragma checksum "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50c2d8d4185f96c4c5d057b92ddfa59bf3b397a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Curso_Index), @"mvc.1.0.view", @"/Views/Curso/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50c2d8d4185f96c4c5d057b92ddfa59bf3b397a2", @"/Views/Curso/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56b9a026bb969f9b7752353c67391ac4d670d188", @"/Views/_ViewImports.cshtml")]
    public class Views_Curso_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<style>
    img .zoom {
        width: 90%;
    }

        img .zoom:hover {
            width: 95%;
        }

    .active, .collapsible:hover {
        background-color: #555;
    }

    h4 .card-title:hover {
        text-decoration: none;
        width: 50%;
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
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50c2d8d4185f96c4c5d057b92ddfa59bf3b397a23789", async() => {
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
            WriteLiteral("\n\n<h1 class=\"p-4 text-white text-center\">Mi Lista</h1>\n\n<div class=\"row\">\n    <div class=\"container\">\n        <div class=\"card-deck\">\n");
#nullable restore
#line 45 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
             if (ViewBag.Cantidad != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
                 foreach (var item in @ViewBag.MisCursos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-4"">
                        <div class=""card text-white bg-secondary mb-3"" style=""max-width: 18rem;"">
                            <img class="" card-img-top zoom"" src=""https://strategyco.es/wp-content/uploads/2020/10/Imagen-BlogStrategyco-202010A-JB.jpg"" />
                            <div class=""card-header text-center"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 1295, "\"", 1333, 2);
            WriteAttributeValue("", 1302, "/Curso/DetalleCurso?Id=", 1302, 23, true);
#nullable restore
#line 53 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
WriteAttributeValue("", 1325, item.Id, 1325, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h4 class=\"text-white\">");
#nullable restore
#line 53 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
                                                                                            Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\n                            </div>\n                            <div class=\"card-body\">\n                                <label>");
#nullable restore
#line 56 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
                                  Write(ViewBag.Categorias[@item.Id]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                            </div>\n                            <div class=\"card-footer text-center\">\n                                <a class=\"btn btn-danger\" title=\"Eliminar curso\"");
            BeginWriteAttribute("href", " href=\"", 1725, "\"", 1766, 2);
            WriteAttributeValue("", 1732, "/Curso/desagregarCurso?Id=", 1732, 26, true);
#nullable restore
#line 59 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
WriteAttributeValue("", 1758, item.Id, 1758, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""far fa-trash-alt""></i></a>
                                <a class=""btn btn-info"" title=""Me gustó el curso"" href=#><i class=""fas fa-thumbs-up""></i></a>
                                <a class=""btn btn-info"" title=""No me gustó el curso"" href=#><i class=""fas fa-thumbs-down""></i></a>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 65 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>\n\n");
#nullable restore
#line 71 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
 if (ViewBag.Cantidad == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h2 class=""text-white text-center"" style=""position:absolute;left:50%;top:50%;transform: translateX(-50%) translateY(-50%)"">Tu lista esta vacia</h2>
    <h5 class=""text-white text-center"" style=""position:absolute;left:50%;top:53%;transform: translateX(-50%) translateY(-50%)"">Agrega cursos en Inicio!</h5>
");
#nullable restore
#line 75 "D:\U\Calidad y Pruebas de Software\Proyecto\uniwebsidad\Uniwebsidad\Views\Curso\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
    var coll = document.getElementsByClassName(""collapsible"");
    var i;

    for (i = 0; i < coll.length; i++) {
        coll[i].addEventListener(""click"", function () {
            this.classList.toggle(""active"");
            var content = this.nextElementSibling;
            if (content.style.display === ""block"") {
                content.style.display = ""none"";
            } else {
                content.style.display = ""block"";
            }
        });
    }
</script>");
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
