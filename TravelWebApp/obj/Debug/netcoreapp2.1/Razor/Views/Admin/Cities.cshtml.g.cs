#pragma checksum "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Admin\Cities.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df695e7e2585e3473fd967fa1c12698e1f858789"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Cities), @"mvc.1.0.view", @"/Views/Admin/Cities.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Cities.cshtml", typeof(AspNetCore.Views_Admin_Cities))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df695e7e2585e3473fd967fa1c12698e1f858789", @"/Views/Admin/Cities.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82926b6740ca118b3c3995ca1063417f60daec74", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Cities : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TravelWebApp.Models.City>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: white;  border: 3px solid white;padding: 10px 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Admin\Cities.cshtml"
  
    ViewData["Title"] = "Города";

#line default
#line hidden
            BeginContext(90, 1381, true);
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
                        <li><a cla");
            WriteLiteral(@"ss=""scroll"" href=""/Identity/Account/Logout""><span>ВЫЙТИ</span></a></li>
                    </ul>
                </nav>
            </div>
        </nav>
    </div>
</div>
<div class=""w3lsaboutaits"" id=""w3lsaboutaits"" style=""height: 100vh;"">
    <div class=""container"">
        <h2>Города</h2>
        <div style=""text-align: end;"">
            ");
            EndContext();
            BeginContext(1471, 122, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fa483be40824427a37025421970c764", async() => {
                BeginContext(1562, 27, true);
                WriteLiteral("<span>Добавить город</span>");
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
            BeginContext(1593, 303, true);
            WriteLiteral(@"
        </div>
        <br>
        <div>
            <table class=""table"" style=""color: white; font-size: 40px;"">
                <thead class=""thead-dark"">
                    <th>Название города</th>
                    <th>Страна</th>
                </thead>
                    <tbody>
");
            EndContext();
#line 47 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Admin\Cities.cshtml"
                         foreach (var item in Model) {


#line default
#line hidden
            BeginContext(1954, 62, true);
            WriteLiteral("                        <tr>\r\n                            <th>");
            EndContext();
            BeginContext(2017, 9, false);
#line 50 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Admin\Cities.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2026, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(2066, 17, false);
#line 51 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Admin\Cities.cshtml"
                           Write(item.Country.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2083, 68, true);
            WriteLiteral("</th>\r\n                            \r\n                        </tr>\r\n");
            EndContext();
#line 54 "C:\Users\Аида\source\repos\TravelWebApp\TravelWebApp\Views\Admin\Cities.cshtml"
                        }

#line default
#line hidden
            BeginContext(2178, 88, true);
            WriteLiteral("                    </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TravelWebApp.Models.City>> Html { get; private set; }
    }
}
#pragma warning restore 1591
