#pragma checksum "D:\Program S1\Semester 6\PETERPAN\SistemPerwalian2020\Views\Jadwal\CatatanMahasiswa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa64173d1bd50477875e709a46e75e075f7201c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jadwal_CatatanMahasiswa), @"mvc.1.0.view", @"/Views/Jadwal/CatatanMahasiswa.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Jadwal/CatatanMahasiswa.cshtml", typeof(AspNetCore.Views_Jadwal_CatatanMahasiswa))]
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
#line 1 "D:\Program S1\Semester 6\PETERPAN\SistemPerwalian2020\Views\_ViewImports.cshtml"
using SistemPerwalian2020;

#line default
#line hidden
#line 2 "D:\Program S1\Semester 6\PETERPAN\SistemPerwalian2020\Views\_ViewImports.cshtml"
using SistemPerwalian2020.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa64173d1bd50477875e709a46e75e075f7201c1", @"/Views/Jadwal/CatatanMahasiswa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"929561bf639084d874c7548f0653ce05f8e4257b", @"/Views/_ViewImports.cshtml")]
    public class Views_Jadwal_CatatanMahasiswa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<SistemPerwalian2020.Models.CatatanPerwalian>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Program S1\Semester 6\PETERPAN\SistemPerwalian2020\Views\Jadwal\CatatanMahasiswa.cshtml"
  
    Layout = "_Layout";


#line default
#line hidden
            BeginContext(93, 411, true);
            WriteLiteral(@"<div class=""container body-content"">
    <br>
    <h2> Catatan </h2>
    <hr />
    <section class=""blog_area"">
        <div class=""container"">
            <div class=""row"">

                <table class=""table table-hover"">
                    <tr>
                        <th>Waktu</th>
                        <th>Periode</th>
                        <th>Catatan</th>
                    </tr>
");
            EndContext();
#line 20 "D:\Program S1\Semester 6\PETERPAN\SistemPerwalian2020\Views\Jadwal\CatatanMahasiswa.cshtml"
                     foreach (var data in Model)
                    {

#line default
#line hidden
            BeginContext(577, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(674, 35, false);
#line 24 "D:\Program S1\Semester 6\PETERPAN\SistemPerwalian2020\Views\Jadwal\CatatanMahasiswa.cshtml"
                           Write(data.Waktu.ToString("dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(709, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(813, 27, false);
#line 27 "D:\Program S1\Semester 6\PETERPAN\SistemPerwalian2020\Views\Jadwal\CatatanMahasiswa.cshtml"
                           Write(data.Waktu.ToString("yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(840, 108, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <i>\" ");
            EndContext();
            BeginContext(949, 12, false);
#line 30 "D:\Program S1\Semester 6\PETERPAN\SistemPerwalian2020\Views\Jadwal\CatatanMahasiswa.cshtml"
                                Write(data.Catatan);

#line default
#line hidden
            EndContext();
            BeginContext(961, 74, true);
            WriteLiteral(" \"</i>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 33 "D:\Program S1\Semester 6\PETERPAN\SistemPerwalian2020\Views\Jadwal\CatatanMahasiswa.cshtml"
                    }

#line default
#line hidden
            BeginContext(1058, 88, true);
            WriteLiteral("                </table>\r\n            </div>\r\n\r\n        </div>\r\n    </section>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<SistemPerwalian2020.Models.CatatanPerwalian>> Html { get; private set; }
    }
}
#pragma warning restore 1591
