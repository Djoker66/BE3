#pragma checksum "C:\Users\User\Desktop\Back-end\Back\3 (30.03.2023)\HW\HW\Views\Team\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2521ccd4d8b31b8bf62a673947e1e56a4d20942d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Detail), @"mvc.1.0.view", @"/Views/Team/Detail.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Back-end\Back\3 (30.03.2023)\HW\HW\Views\_ViewImports.cshtml"
using HW.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Back-end\Back\3 (30.03.2023)\HW\HW\Views\_ViewImports.cshtml"
using HW.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2521ccd4d8b31b8bf62a673947e1e56a4d20942d", @"/Views/Team/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3abb1b80a31035ecdda2198d7a563160b2d6a97a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Team_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Team>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\User\Desktop\Back-end\Back\3 (30.03.2023)\HW\HW\Views\Team\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Detail</h1>\r\n\r\n<h2>FullName: ");
#nullable restore
#line 10 "C:\Users\User\Desktop\Back-end\Back\3 (30.03.2023)\HW\HW\Views\Team\Detail.cshtml"
         Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>Prof: ");
#nullable restore
#line 11 "C:\Users\User\Desktop\Back-end\Back\3 (30.03.2023)\HW\HW\Views\Team\Detail.cshtml"
     Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Team> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
