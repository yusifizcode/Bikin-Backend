#pragma checksum "C:\Users\Ravana\Desktop\BikinBackEnd\Bikin\Bikin\Areas\Manage\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47054bdb6c423b6b3c47a32be147cfd6f62fd00e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Service_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Service/Index.cshtml")]
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
#line 1 "C:\Users\Ravana\Desktop\BikinBackEnd\Bikin\Bikin\Areas\Manage\Views\_ViewImports.cshtml"
using Bikin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47054bdb6c423b6b3c47a32be147cfd6f62fd00e", @"/Areas/Manage/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc2e2909392ec59d5e8d175626a72324e3bbf57", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Service>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ravana\Desktop\BikinBackEnd\Bikin\Bikin\Areas\Manage\Views\Service\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">First</th>
            <th scope=""col"">Last</th>
            <th scope=""col"">Handle</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th scope=""row"">1</th>
            <td>Mark</td>
            <td>Otto</td>
        </tr>
        <tr>
            <th scope=""row"">2</th>
            <td>Jacob</td>
            <td>Thornton</td>
        </tr>
        <tr>
            <th scope=""row"">3</th>
            <td colspan=""2"">Larry the Bird</td>
            <td>");
#nullable restore
#line 29 "C:\Users\Ravana\Desktop\BikinBackEnd\Bikin\Bikin\Areas\Manage\Views\Service\Index.cshtml"
           Write(twitter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Service> Html { get; private set; }
    }
}
#pragma warning restore 1591