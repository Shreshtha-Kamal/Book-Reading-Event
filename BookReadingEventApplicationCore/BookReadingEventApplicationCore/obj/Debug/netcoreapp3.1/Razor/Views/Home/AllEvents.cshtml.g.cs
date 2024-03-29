#pragma checksum "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\AllEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79c4be4672a1f7697c2588568d1edc7a6cec5c4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AllEvents), @"mvc.1.0.view", @"/Views/Home/AllEvents.cshtml")]
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
#line 1 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\_ViewImports.cshtml"
using BookReadingEventApplicationCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\_ViewImports.cshtml"
using BookReadingEventApplicationCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79c4be4672a1f7697c2588568d1edc7a6cec5c4e", @"/Views/Home/AllEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0817d30ef3e41b3e99ea95163c1e9794014d6cd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AllEvents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataAccessLayer.DatabaseModels.Event>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\AllEvents.cshtml"
  
    ViewData["Title"] = "AllEvents";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            PAST EVENTS\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 16 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\AllEvents.cshtml"
     foreach (var item in Model)
    {
        if (item.Date < System.DateTime.Now)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 22 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\AllEvents.cshtml"
               Write(Html.ActionLink(item.Title, "Details", new { id = item.EventID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 25 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\AllEvents.cshtml"
               Write(Html.ActionLink("Edit", "Edit", "Event", new { id = item.EventID }, htmlAttributes: new { @class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 26 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\AllEvents.cshtml"
               Write(Html.ActionLink("Delete", "Delete", "Event", new { id = item.EventID }, htmlAttributes: new { @class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\AllEvents.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <tr>\r\n        <th>\r\n            UPCOMING EVENT\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 38 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\AllEvents.cshtml"
     foreach (var item in Model)
    {
        if (item.Date > System.DateTime.Now)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\AllEvents.cshtml"
               Write(Html.ActionLink(item.Title, "Details", new { id = item.EventID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\AllEvents.cshtml"
               Write(Html.ActionLink("Edit", "Edit", "Event", new { id = item.EventID }, htmlAttributes: new { @class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 48 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\AllEvents.cshtml"
               Write(Html.ActionLink("Delete", "Delete", "Event", new { id = item.EventID }, htmlAttributes: new { @class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 51 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\AllEvents.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataAccessLayer.DatabaseModels.Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591
