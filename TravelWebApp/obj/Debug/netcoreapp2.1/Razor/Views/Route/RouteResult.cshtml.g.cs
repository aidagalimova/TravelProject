#pragma checksum "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Route\RouteResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec532be82d896265243292e50284d9d9bc179566"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Route_RouteResult), @"mvc.1.0.view", @"/Views/Route/RouteResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Route/RouteResult.cshtml", typeof(AspNetCore.Views_Route_RouteResult))]
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
#line 1 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\_ViewImports.cshtml"
using TravelWebApp;

#line default
#line hidden
#line 2 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\_ViewImports.cshtml"
using TravelWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec532be82d896265243292e50284d9d9bc179566", @"/Views/Route/RouteResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82926b6740ca118b3c3995ca1063417f60daec74", @"/Views/_ViewImports.cshtml")]
    public class Views_Route_RouteResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TravelWebApp.Controllers.RouteModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/search/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Route\RouteResult.cshtml"
  
    ViewData["Title"] = "RouteResult";

#line default
#line hidden
            BeginContext(99, 1303, true);
            WriteLiteral(@"
<div class=""agileheader"" id=""agileitshome"">

    <!-- Navigation -->
    <div class=""w3lsnavigation"">
        <nav class=""navbar-default agilehovereffect wthreehovereffect"">
            <div class=""navbar-header navbar-left"">
                <li><a class=""scroll"" href=""/Profile/Home""><span>ПРОФИЛЬ</span></a></li>
                <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#bs-example-navbar-collapse-1"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
            </div>

            <div class=""collapse navbar-collapse navbar-nav-left"" id=""bs-example-navbar-collapse-1"" style=""float: right!important"">
                <nav class=""link-effect-2"" id=""link-effect-2"">
                    <ul class=""nav navbar-nav-right"">
                        <li><a class");
            WriteLiteral(@"=""scroll"" href=""/Route/SearchRoute""><span>НАЙТИ МАРШРУТ</span></a></li>
                        <li><a class=""scroll"" href=""/Cities/CityRating""><span>РЕЙТИНГ ГОРОДОВ</span></a></li>
                        <li style=""float: left; margin-top: 4%;"">
                            ");
            EndContext();
            BeginContext(1402, 226, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e23464c9872f4aba94489327d7ee8b7a", async() => {
                BeginContext(1462, 159, true);
                WriteLiteral("\r\n                                <input type=\"search\" name=\"text\" id=\"mysearch\" placeholder=\"Поиск города\" style=\"color: white\">\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            EndContext();
            BeginContext(1628, 933, true);
            WriteLiteral(@"
                            <div id=""result-search"" class=""search_result""></div>
                        </li>
                        <li><a class=""scroll"" href=""/Identity/Account/Logout""><span>ВЫЙТИ</span></a></li>
                    </ul>
                </nav>
            </div>
        </nav>
    </div>
    <!-- //Navigation -->
    <!-- //Slider -->

</div>

<div class=""w3lsaboutaits"" id=""w3lsaboutaits"" style=""height: 100vh;"">
    <div class=""container"">
        <h2>Ваш маршрут</h2>
        <table class=""table"" style=""color: white; font-size: 25px;"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">Маршрут</th>
                    <th scope=""col"">Пункт отправления</th>
                    <th scope=""col"">Пункт назначения</th>
                    <th scope=""col"">Перевозчик</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 57 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Route\RouteResult.cshtml"
                 foreach (var r in @Model)
                {

#line default
#line hidden
            BeginContext(2624, 54, true);
            WriteLiteral("                    <tr>\r\n                        <th>");
            EndContext();
            BeginContext(2679, 12, false);
#line 60 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Route\RouteResult.cshtml"
                       Write(r.ShortTitle);

#line default
#line hidden
            EndContext();
            BeginContext(2691, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(2727, 11, false);
#line 61 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Route\RouteResult.cshtml"
                       Write(r.Departure);

#line default
#line hidden
            EndContext();
            BeginContext(2738, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2774, 9, false);
#line 62 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Route\RouteResult.cshtml"
                       Write(r.Arrival);

#line default
#line hidden
            EndContext();
            BeginContext(2783, 37, true);
            WriteLiteral("</td>\r\n                        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2820, "\"", 2833, 1);
#line 63 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Route\RouteResult.cshtml"
WriteAttributeValue("", 2827, r.URL, 2827, 6, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2834, 25, true);
            WriteLiteral(" style=\"color: white\"><u>");
            EndContext();
            BeginContext(2860, 9, false);
#line 63 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Route\RouteResult.cshtml"
                                                                Write(r.Company);

#line default
#line hidden
            EndContext();
            BeginContext(2869, 42, true);
            WriteLiteral("</u></a></td>\r\n                    </tr>\r\n");
            EndContext();
#line 65 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Route\RouteResult.cshtml"
                }

#line default
#line hidden
            BeginContext(2930, 557, true);
            WriteLiteral(@"            </tbody>
        </table>

    </div>
</div>

<script src=""https://yastatic.net/jquery/3.3.1/jquery.min.js""></script>

<script type=""text/javascript"">
				$(document).ready(function() {
					var defaults = {
						containerID: 'toTop',
						containerHoverID: 'toTopHover',
						scrollSpeed: 100,
						easingType: 'linear',
					};
                });

    $('#mysearch').on('keyup', function () {
        var text = $(this).val();
        $('#result-search').html('');
        if (text.length > 2) {
            $.post(""");
            EndContext();
            BeginContext(3488, 33, false);
#line 88 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Route\RouteResult.cshtml"
               Write(Url.Action("SearchCity","Cities"));

#line default
#line hidden
            EndContext();
            BeginContext(3521, 482, true);
            WriteLiteral(@""" + ""?text="" + text,
                function (returnedData) {
                    result = ''
                    console.log(returnedData)
                    for (var c of returnedData) {
                        var t = '<a href=""/Cities/Details/' + c.id + '"">' + c.name + ' ' + c.country.name + '</a><br>';
                        result += t;
                    }
                    $('#result-search').html(result);
                });
        }
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TravelWebApp.Controllers.RouteModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
