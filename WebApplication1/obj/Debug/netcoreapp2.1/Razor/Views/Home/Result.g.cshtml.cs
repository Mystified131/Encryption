#pragma checksum "C:\Users\TPark\source\repos\MVCApplicationOOPersistent\WebApplication1\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7208dbc46bea8693ac56c866a624ad816c0fab4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(AspNetCore.Views_Home_Result))]
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
#line 1 "C:\Users\TPark\source\repos\MVCApplicationOOPersistent\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\TPark\source\repos\MVCApplicationOOPersistent\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7208dbc46bea8693ac56c866a624ad816c0fab4a", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.ViewModels.ResultViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\TPark\source\repos\MVCApplicationOOPersistent\WebApplication1\Views\Home\Result.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
            BeginContext(97, 76, true);
            WriteLiteral("\r\n<h2>Result</h2>\r\n\r\n<br />\r\n\r\n<p>The encrypted message is:</p><br />\r\n\r\n<p>");
            EndContext();
            BeginContext(174, 13, false);
#line 14 "C:\Users\TPark\source\repos\MVCApplicationOOPersistent\WebApplication1\Views\Home\Result.cshtml"
Write(Model.messout);

#line default
#line hidden
            EndContext();
            BeginContext(187, 10, true);
            WriteLiteral("</p>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.ViewModels.ResultViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
