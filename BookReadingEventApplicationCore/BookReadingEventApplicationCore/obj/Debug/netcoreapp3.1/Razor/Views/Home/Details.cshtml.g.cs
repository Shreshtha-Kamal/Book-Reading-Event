#pragma checksum "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "431f468a756fbc2e306c4c9f3b5fd24146f77e62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#nullable restore
#line 3 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"431f468a756fbc2e306c4c9f3b5fd24146f77e62", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0817d30ef3e41b3e99ea95163c1e9794014d6cd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookReadingEventApplicationCore.Models.DisplayEventViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 class=\"main text-center\">DETAILS</h3>\r\n\r\n\r\n<div>\r\n    <h5 class=\"main text-center\">Display Event Details </h5>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 17 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 20 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 24 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 27 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 31 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 34 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 38 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 41 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 45 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DurationInHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 48 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.DurationInHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 52 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 55 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 59 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OtherDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 62 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.OtherDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 66 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalInvitedToEvent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 69 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalInvitedToEvent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
#nullable restore
#line 73 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
       Write(Html.LabelFor(model => model.Comment.Comments, htmlAttributes: new { @class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"input-group col-md-6\">\r\n");
#nullable restore
#line 76 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
             using (Html.BeginForm("Create", "Comment", new { id = Model.EventID }))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
           Write(Html.EditorFor(model => model.Comment.Comments, new { htmlAttributes = new { @class = "form-control " } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>&nbsp;</span>\r\n                <br />\r\n                <input style=\"display :inline\" ; type=\"submit\" value=\"post\" class=\"btn btn-primary text-center\" />\r\n");
#nullable restore
#line 82 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n        <dt></dt>\r\n        <dd>\r\n            <h6>Older Comments...</h6>\r\n        </dd>\r\n");
#nullable restore
#line 90 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
             foreach (var item in Model.Comments.OrderBy(c => c.DateTime))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <dd>\r\n\r\n                ");
#nullable restore
#line 94 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(ModelItem => item.Comments));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n               </dd>\r\n");
#nullable restore
#line 97 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"

             }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n</div>\r\n<p>\r\n");
#nullable restore
#line 102 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
     if (string.IsNullOrEmpty(Convert.ToString(@Context.Session.GetString("Role"))) || Convert.ToString(@Context.Session.GetString("Role")).Equals(User))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
   Write(Html.ActionLink("Back To list", "Index"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
                                                 ;
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
   Write(Html.ActionLink("Back To list", "AllEvents"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "D:\Used later\Assignments\mvc\MVC\MVC\BookReadingEventApplicationCore\BookReadingEventApplicationCore\Views\Home\Details.cshtml"
                                                     ;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookReadingEventApplicationCore.Models.DisplayEventViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
