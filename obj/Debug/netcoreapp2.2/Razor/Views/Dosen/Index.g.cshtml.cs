#pragma checksum "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Dosen\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "599ef8cb2a2db1d943b85fa0d2b33df541cdee23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dosen_Index), @"mvc.1.0.view", @"/Views/Dosen/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dosen/Index.cshtml", typeof(AspNetCore.Views_Dosen_Index))]
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
#line 1 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\_ViewImports.cshtml"
using SistemPerwalian2020;

#line default
#line hidden
#line 2 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\_ViewImports.cshtml"
using SistemPerwalian2020.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"599ef8cb2a2db1d943b85fa0d2b33df541cdee23", @"/Views/Dosen/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"929561bf639084d874c7548f0653ce05f8e4257b", @"/Views/_ViewImports.cshtml")]
    public class Views_Dosen_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Dosen\Index.cshtml"
  
    Layout = "_Layout";


#line default
#line hidden
            BeginContext(34, 319, true);
            WriteLiteral(@"<div class=""container body-content"">

<h2> Dosen</h2>
<br>
<br>
<section class=""blog_area"">
            <div class=""container"">
                <div class=""row"">
<table class=""table table-hover"">
    <tr>
        <th>Nik</th>
        <th>Nama</th>
        <th>Password</th>
        <th>Id</th>
    </tr>
");
            EndContext();
#line 20 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Dosen\Index.cshtml"
     foreach(var data in Model){

#line default
#line hidden
            BeginContext(387, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(410, 8, false);
#line 22 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Dosen\Index.cshtml"
       Write(data.Nik);

#line default
#line hidden
            EndContext();
            BeginContext(418, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(438, 9, false);
#line 23 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Dosen\Index.cshtml"
       Write(data.Nama);

#line default
#line hidden
            EndContext();
            BeginContext(447, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(467, 13, false);
#line 24 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Dosen\Index.cshtml"
       Write(data.Password);

#line default
#line hidden
            EndContext();
            BeginContext(480, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(500, 7, false);
#line 25 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Dosen\Index.cshtml"
       Write(data.Id);

#line default
#line hidden
            EndContext();
            BeginContext(507, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 27 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Dosen\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(532, 58, true);
            WriteLiteral("</table> \r\n </div>\r\n            </div>\r\n</section>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
