#pragma checksum "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Cities\CityRating.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e7ed14cd5a3b7f0edd3a7d5cc4fdabe65af9ac0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cities_CityRating), @"mvc.1.0.view", @"/Views/Cities/CityRating.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cities/CityRating.cshtml", typeof(AspNetCore.Views_Cities_CityRating))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e7ed14cd5a3b7f0edd3a7d5cc4fdabe65af9ac0", @"/Views/Cities/CityRating.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82926b6740ca118b3c3995ca1063417f60daec74", @"/Views/_ViewImports.cshtml")]
    public class Views_Cities_CityRating : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TravelWebApp.Controllers.CityModelRating>>
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
#line 2 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Cities\CityRating.cshtml"
  
    ViewData["Title"] = "Рейтинг городов";

#line default
#line hidden
            BeginContext(106, 1303, true);
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
            BeginContext(1409, 226, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f5d36cb01aa42ccafc799d6997ed578", async() => {
                BeginContext(1469, 159, true);
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
            BeginContext(1635, 1165, true);
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
        <h2>Рейтинг городов</h2>
        <input type=""checkbox"" class=""form-check-input"" id=""exampleCheck1"" onclick=""shadow()"">
        <label class=""form-check-label"" for=""exampleCheck1"" style=""font-size: 25px;"">Скрыть посещённые города</label>
        <table class=""table"" id=""myTable"" style=""color: white; font-size: 20px;"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"" onclick=""sortTable(0)"">Город</th>
                    <th scope=""col"" onclick=""sortTable(1)"">Ср. оценка</th>
  ");
            WriteLiteral("                  <th scope=\"col\" onclick=\"sortTable(2)\">Ваша оценка</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 56 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Cities\CityRating.cshtml"
                 foreach (var city in @Model)
                {

#line default
#line hidden
            BeginContext(2866, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(2913, 9, false);
#line 59 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Cities\CityRating.cshtml"
                   Write(city.City);

#line default
#line hidden
            EndContext();
            BeginContext(2922, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 60 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Cities\CityRating.cshtml"
                     if (city.AverageCount != 0)
                    {

#line default
#line hidden
            BeginContext(3002, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(3031, 17, false);
#line 62 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Cities\CityRating.cshtml"
                       Write(city.AverageCount);

#line default
#line hidden
            EndContext();
            BeginContext(3048, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 63 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Cities\CityRating.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3127, 65, true);
            WriteLiteral("                        <td>Ещё никто не оценил этот город</td>\r\n");
            EndContext();
#line 67 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Cities\CityRating.cshtml"
                    }

#line default
#line hidden
            BeginContext(3215, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 68 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Cities\CityRating.cshtml"
                     if (city.UserMark != 0)
                    {

#line default
#line hidden
            BeginContext(3284, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(3313, 13, false);
#line 70 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Cities\CityRating.cshtml"
                       Write(city.UserMark);

#line default
#line hidden
            EndContext();
            BeginContext(3326, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 71 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Cities\CityRating.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3405, 63, true);
            WriteLiteral("                        <td>Вы ещё не оценили этот город</td>\r\n");
            EndContext();
#line 75 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Cities\CityRating.cshtml"
                    }

#line default
#line hidden
            BeginContext(3491, 45, true);
            WriteLiteral("                    <td style=\"display:none\">");
            EndContext();
            BeginContext(3537, 14, false);
#line 76 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Cities\CityRating.cshtml"
                                        Write(city.IsVisited);

#line default
#line hidden
            EndContext();
            BeginContext(3551, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 78 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Cities\CityRating.cshtml"
                }

#line default
#line hidden
            BeginContext(3600, 555, true);
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
            BeginContext(4156, 33, false);
#line 100 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Cities\CityRating.cshtml"
               Write(Url.Action("SearchCity","Cities"));

#line default
#line hidden
            EndContext();
            BeginContext(4189, 543, true);
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
    });
    function AJAXstar(count, cityId) {
        sendAjaxPostRequest(""");
            EndContext();
            BeginContext(4733, 32, false);
#line 113 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Cities\CityRating.cshtml"
                        Write(Url.Action("AddRating","Cities"));

#line default
#line hidden
            EndContext();
            BeginContext(4765, 2887, true);
            WriteLiteral(@""", count, cityId)
    }
    function sendAjaxPostRequest(url, mark, cityId) {
        $.post(url + '?mark=' + mark + '&cityId=' + cityId,
            function (returnedData) {
                console.log(returnedData);
            });
    }
    function sortTable(rr) {
        var table, rows, switching, i, x, y, shouldSwitch;
        table = document.getElementById(""myTable"");
        switching = true;
        /* Make a loop that will continue until
        no switching has been done: */
        while (switching) {
            // Start by saying: no switching is done:
            switching = false;
            rows = table.rows;
            /* Loop through all table rows (except the
            first, which contains table headers): */
            for (i = 1; i < (rows.length - 1); i++) {
                // Start by saying there should be no switching:
                shouldSwitch = false;
                /* Get the two elements you want to compare,
                one from current row");
            WriteLiteral(@" and one from the next: */
                x = rows[i].getElementsByTagName(""TD"")[rr];
                y = rows[i + 1].getElementsByTagName(""TD"")[rr];
                // Check if the two rows should switch place:
                if (rr != 0) {
                    if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
                        // If so, mark as a switch and break the loop:
                        shouldSwitch = true;
                        break;
                    }
                } else {
                    if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
                        // If so, mark as a switch and break the loop:
                        shouldSwitch = true;
                        break;
                    }
                }
            }
            if (shouldSwitch) {
                /* If a switch has been marked, make the switch
                and mark that a switch has been done: */
                rows[i].parentNode.insertBefore(r");
            WriteLiteral(@"ows[i + 1], rows[i]);
                switching = true;
            }
        }
    }

    function shadow() {
        table = document.getElementById(""myTable"");
        rows = table.rows;
        for (i = 1; i < (rows.length); i++) {
            if (rows[i].getElementsByTagName(""TD"")[3].innerHTML == 'True') {
                if (document.getElementById('exampleCheck1').checked) {
                    rows[i].style.display = 'none';
                } else {
                    rows[i].style.display = '';
                }
            }
            else {
                if (document.getElementById('exampleCheck1').checked) {
                    rows[i].style.display = '';

                } else {
                    rows[i].style.display = '';
                }
            }
        }
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TravelWebApp.Controllers.CityModelRating>> Html { get; private set; }
    }
}
#pragma warning restore 1591