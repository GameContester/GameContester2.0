#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameContester.Web.Views.Home
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using GameContester.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Home/_Layout.cshtml")]
    public partial class Layout : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Layout()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0\"");

WriteLiteral(">\r\n    <meta");

WriteLiteral(" http-equiv=\"content-type\"");

WriteLiteral(" content=\"text/html; charset=utf-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"description\"");

WriteLiteral(" content=\"\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"keywords\"");

WriteLiteral(" content=\"\"");

WriteLiteral(" />\r\n    <script");

WriteLiteral(" src=\"App/boot/require.config.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" data-main=\"App/boot/startup\"");

WriteLiteral(" src=\"Scripts/require/require.js\"");

WriteLiteral("></script>\r\n    <title>");

            
            #line 11 "..\..\Views\Home\_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(" -GameContester</title>\r\n\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 503), Tuple.Create("\"", 532)
, Tuple.Create(Tuple.Create("", 509), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/jquery.min.js")
, 509), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 556), Tuple.Create("\"", 583)
, Tuple.Create(Tuple.Create("", 562), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/skel.min.js")
, 562), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 607), Tuple.Create("\"", 641)
, Tuple.Create(Tuple.Create("", 613), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/skel-layers.min.js")
, 613), false)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 665), Tuple.Create("\"", 688)
, Tuple.Create(Tuple.Create("", 671), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/init.js")
, 671), false)
);

WriteLiteral("></script>\r\n\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 729), Tuple.Create("\"", 754)
, Tuple.Create(Tuple.Create("", 736), Tuple.Create<System.Object, System.Int32>(Href("~/Content/skel.css")
, 736), false)
);

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 786), Tuple.Create("\"", 812)
, Tuple.Create(Tuple.Create("", 793), Tuple.Create<System.Object, System.Int32>(Href("~/Content/style.css")
, 793), false)
);

WriteLiteral(" />\r\n    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 844), Tuple.Create("\"", 877)
, Tuple.Create(Tuple.Create("", 851), Tuple.Create<System.Object, System.Int32>(Href("~/Content/style-xlarge.css")
, 851), false)
);

WriteLiteral(" />\r\n\r\n   \r\n");

WriteLiteral("    ");

            
            #line 23 "..\..\Views\Home\_Layout.cshtml"
Write(Scripts.Render("~/bundles/modernizr"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n</head>\r\n<body>\r\n    <header");

WriteLiteral(" id=\"header\"");

WriteLiteral(">\r\n        <h1><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Transit</a></h1>\r\n        <nav");

WriteLiteral(" id=\"nav\"");

WriteLiteral(">\r\n            <ul>\r\n                <li><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">Home</a></li>\r\n                <li><a");

WriteLiteral(" href=\"#register\"");

WriteLiteral(" id=\"registerLink\"");

WriteLiteral(" class=\"button special\"");

WriteLiteral(">Sign Up</a></li>\r\n                <li><a");

WriteLiteral(" href=\"#login\"");

WriteLiteral(" id=\"loginLink\"");

WriteLiteral(" class=\"button special\"");

WriteLiteral(">Sign In</a></li>\r\n\r\n            </ul>\r\n        </nav>\r\n    </header>\r\n\r\n    <div" +
"");

WriteLiteral(" class=\"container body-content\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" id=\"page1\"");

WriteLiteral(" class=\"container\"");

WriteLiteral(" style=\"padding-top:50px\"");

WriteLiteral(" data-bind=\"component: { name: route().page, params: route }\"");

WriteLiteral("></div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"container body-content\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 43 "..\..\Views\Home\_Layout.cshtml"
   Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n</body>\r\n");

WriteLiteral("    ");

            
            #line 46 "..\..\Views\Home\_Layout.cshtml"
Write(Scripts.Render("~/bundles/jquery"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 47 "..\..\Views\Home\_Layout.cshtml"
Write(Scripts.Render("~/bundles/bootstrap"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 48 "..\..\Views\Home\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n    \r\n\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
