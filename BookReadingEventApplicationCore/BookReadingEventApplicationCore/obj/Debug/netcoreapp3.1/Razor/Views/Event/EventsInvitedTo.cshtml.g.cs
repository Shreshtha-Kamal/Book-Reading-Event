#pragma checksum "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Event\EventsInvitedTo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75223d1cdce405c69cbb0f62c3413f8ffc67fbfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_EventsInvitedTo), @"mvc.1.0.view", @"/Views/Event/EventsInvitedTo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75223d1cdce405c69cbb0f62c3413f8ffc67fbfb", @"/Views/Event/EventsInvitedTo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0817d30ef3e41b3e99ea95163c1e9794014d6cd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_EventsInvitedTo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataAccessLayer.DatabaseModels.Event>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Event\EventsInvitedTo.cshtml"
  
    ViewData["Title"] = "EventsInvitedTo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 class=\"main text-center\">EVENTS INVITED TO</h3>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 12 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Event\EventsInvitedTo.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 16 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Event\EventsInvitedTo.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 20 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Event\EventsInvitedTo.cshtml"
           Write(Html.ActionLink(item.Title, "Details", "Home", new { id = item.EventID }, htmlAttributes: new { @class = " " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 23 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Event\EventsInvitedTo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
