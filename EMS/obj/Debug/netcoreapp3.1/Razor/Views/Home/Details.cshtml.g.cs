#pragma checksum "C:\Users\Admin\source\repos\EMS\EMS\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da2e1ae40bed377bc7066b06e770f4cbc6c8434c"
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
#line 1 "C:\Users\Admin\source\repos\EMS\EMS\Views\_ViewImports.cshtml"
using DemoDotNetCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\EMS\EMS\Views\_ViewImports.cshtml"
using DemoDotNetCore.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\EMS\EMS\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da2e1ae40bed377bc7066b06e770f4cbc6c8434c", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f8b18d61694679451c9f215b57ef84d0fa6d007", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\EMS\EMS\Views\Home\Details.cshtml"
  
	ViewBag.Title = "Employee Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\r\n\t<div>Id : ");
#nullable restore
#line 8 "C:\Users\Admin\source\repos\EMS\EMS\Views\Home\Details.cshtml"
         Write(Model.Employee.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t<div>Name : ");
#nullable restore
#line 9 "C:\Users\Admin\source\repos\EMS\EMS\Views\Home\Details.cshtml"
           Write(Model.Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t<div>Email : ");
#nullable restore
#line 10 "C:\Users\Admin\source\repos\EMS\EMS\Views\Home\Details.cshtml"
            Write(Model.Employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t<div>Department : ");
#nullable restore
#line 11 "C:\Users\Admin\source\repos\EMS\EMS\Views\Home\Details.cshtml"
                 Write(Model.Employee.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591