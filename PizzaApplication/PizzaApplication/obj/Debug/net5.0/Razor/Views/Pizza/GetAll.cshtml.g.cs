#pragma checksum "D:\LOCALREPOSITORY\Day30\PizzaApplication\PizzaApplication\Views\Pizza\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e13a2ac7c4b609bcda6d309358e7822d32e005c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_GetAll), @"mvc.1.0.view", @"/Views/Pizza/GetAll.cshtml")]
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
#line 1 "D:\LOCALREPOSITORY\Day30\PizzaApplication\PizzaApplication\Views\_ViewImports.cshtml"
using PizzaApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LOCALREPOSITORY\Day30\PizzaApplication\PizzaApplication\Views\_ViewImports.cshtml"
using PizzaApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e13a2ac7c4b609bcda6d309358e7822d32e005c8", @"/Views/Pizza/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ba295415eabbe47cee94bfd856e3b8f99d2f3b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaApplication.Models.PizzaDTO>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n");
#nullable restore
#line 11 "D:\LOCALREPOSITORY\Day30\PizzaApplication\PizzaApplication\Views\Pizza\GetAll.cshtml"
     foreach (var item in Model.Pizza)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 15 "D:\LOCALREPOSITORY\Day30\PizzaApplication\PizzaApplication\Views\Pizza\GetAll.cshtml"
           Write(Html.DisplayFor(m=>item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 18 "D:\LOCALREPOSITORY\Day30\PizzaApplication\PizzaApplication\Views\Pizza\GetAll.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaApplication.Models.PizzaDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
