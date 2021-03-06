#pragma checksum "D:\Source\JobSearchTracker\JobSearchTrackerAPI\JobSearchTrackerAPI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70ee5cd28c6ab5114edab54ac120b286716e849a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Source\JobSearchTracker\JobSearchTrackerAPI\JobSearchTrackerAPI\Views\_ViewImports.cshtml"
using JobSearchTrackerAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Source\JobSearchTracker\JobSearchTrackerAPI\JobSearchTrackerAPI\Views\_ViewImports.cshtml"
using JobSearchTrackerAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70ee5cd28c6ab5114edab54ac120b286716e849a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"654bd8c0b5a9002e8de202ee4f0a0d33ddc67c84", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Source\JobSearchTracker\JobSearchTrackerAPI\JobSearchTrackerAPI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
</div>

<div class=""jumbotron"">
    <h1>ProfessDirect</h1>
    <p class=""lead"">Take the Next Step | Connect.</p>
    <p><a href=""https://github.com/ROBERC54/Professional-Directory"" class=""btn btn-primary btn-lg"">Learn more &raquo;</a></p>

    <div>
        <a class=""btn btn-default""
           ");
#nullable restore
#line 16 "D:\Source\JobSearchTracker\JobSearchTrackerAPI\JobSearchTrackerAPI\Views\Home\Index.cshtml"
      Write(Html.ActionLink("List of Parent Companies", "Index", "ParentCompanies"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <a class=\"btn btn-default\"\r\n           ");
#nullable restore
#line 18 "D:\Source\JobSearchTracker\JobSearchTrackerAPI\JobSearchTrackerAPI\Views\Home\Index.cshtml"
      Write(Html.ActionLink("List of Recruiters", "Index", "Recruiters"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <a class=\"btn btn-default\"\r\n           ");
#nullable restore
#line 20 "D:\Source\JobSearchTracker\JobSearchTrackerAPI\JobSearchTrackerAPI\Views\Home\Index.cshtml"
      Write(Html.ActionLink("List of Leads", "Index", "Leads"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <a class=\"btn btn-default\"\r\n           ");
#nullable restore
#line 22 "D:\Source\JobSearchTracker\JobSearchTrackerAPI\JobSearchTrackerAPI\Views\Home\Index.cshtml"
      Write(Html.ActionLink("List of Job Descriptions", "Index", "JobDescriptions"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <a class=\"btn btn-default\"\r\n           ");
#nullable restore
#line 24 "D:\Source\JobSearchTracker\JobSearchTrackerAPI\JobSearchTrackerAPI\Views\Home\Index.cshtml"
      Write(Html.ActionLink("List of Qualifications", "Index", "Qualifications"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <a class=\"btn btn-default\"\r\n        ");
#nullable restore
#line 26 "D:\Source\JobSearchTracker\JobSearchTrackerAPI\JobSearchTrackerAPI\Views\Home\Index.cshtml"
   Write(Html.ActionLink("List of Distinct Qualifications", "Index", "DistinctQuals"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>

</div>
<div class=""row"">
    <div class=""col-md-4"">
        <h2>Diving into ProfessDirect</h2>
        <p>
            ProfessDirect gives you a powerful, systematic approach to enable job hunters to more expediently assess and target professional relationships that are conducive in light of current market trends.
        </p>
        <p><a class=""btn btn-default"" href=""https://github.com/ROBERC54/Professional-Directory"">Learn more &raquo;</a></p>
    </div>
    <div class=""col-md-4"">
        <h2>Enhance your connections</h2>
        <p>ProfessDirect is a job search management tool that makes it easy to add, remove, and update professional opportunities.</p>
        <p><a class=""btn btn-default"" href=""https://github.com/ROBERC54/Professional-Directory"">Learn more &raquo;</a></p>
    </div>
    <div class=""col-md-4"">
        <h2>Don't Go Alone</h2>
        <p>You can easily reach out to contacts; offer your hand in jolly cooperation via built in links to major social media platf");
            WriteLiteral("orms.</p>\r\n        <p><a class=\"btn btn-default\" href=\"https://github.com/ROBERC54/Professional-Directory\">Learn more &raquo;</a></p>\r\n    </div>\r\n</div>");
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
