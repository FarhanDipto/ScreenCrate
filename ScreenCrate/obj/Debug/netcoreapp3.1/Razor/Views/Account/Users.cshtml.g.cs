#pragma checksum "C:\Users\fdipt\Documents\Visual Studio 2019\ScreenCrate\ScreenCrate\Views\Account\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1c187d804a0739a532722e26db750b3d34bd456"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Users), @"mvc.1.0.view", @"/Views/Account/Users.cshtml")]
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
#line 1 "C:\Users\fdipt\Documents\Visual Studio 2019\ScreenCrate\ScreenCrate\Views\_ViewImports.cshtml"
using ScreenCrate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fdipt\Documents\Visual Studio 2019\ScreenCrate\ScreenCrate\Views\_ViewImports.cshtml"
using ScreenCrate.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fdipt\Documents\Visual Studio 2019\ScreenCrate\ScreenCrate\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1c187d804a0739a532722e26db750b3d34bd456", @"/Views/Account/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22e1220a3678d643d52a7714e122511ac94254a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\fdipt\Documents\Visual Studio 2019\ScreenCrate\ScreenCrate\Views\Account\Users.cshtml"
  
    ViewData["Title"] = "List of Users";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-6 offset-3\">\n        <p>\n            <h4>List of all users</h4>\n        </p>\n\n        <table class=\"table\">\n            <thead>\n                <tr class=\"text-center\">\n                    <th>");
#nullable restore
#line 16 "C:\Users\fdipt\Documents\Visual Studio 2019\ScreenCrate\ScreenCrate\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 17 "C:\Users\fdipt\Documents\Visual Studio 2019\ScreenCrate\ScreenCrate\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 18 "C:\Users\fdipt\Documents\Visual Studio 2019\ScreenCrate\ScreenCrate\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 22 "C:\Users\fdipt\Documents\Visual Studio 2019\ScreenCrate\ScreenCrate\Views\Account\Users.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td class=\"align-middle\">\n                        ");
#nullable restore
#line 26 "C:\Users\fdipt\Documents\Visual Studio 2019\ScreenCrate\ScreenCrate\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td class=\"align-middle\">\n                        ");
#nullable restore
#line 29 "C:\Users\fdipt\Documents\Visual Studio 2019\ScreenCrate\ScreenCrate\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td class=\"align-middle\">\n                        ");
#nullable restore
#line 32 "C:\Users\fdipt\Documents\Visual Studio 2019\ScreenCrate\ScreenCrate\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 35 "C:\Users\fdipt\Documents\Visual Studio 2019\ScreenCrate\ScreenCrate\Views\Account\Users.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n\n        </table>\n\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591