#pragma checksum "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b3833d7660724c03c827d08b749f16835af6418"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Krs_Index), @"mvc.1.0.view", @"/Views/Krs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Krs/Index.cshtml", typeof(AspNetCore.Views_Krs_Index))]
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
#line 1 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\_ViewImports.cshtml"
using SistemPerwalian2020;

#line default
#line hidden
#line 2 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\_ViewImports.cshtml"
using SistemPerwalian2020.Models;

#line default
#line hidden
#line 2 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b3833d7660724c03c827d08b749f16835af6418", @"/Views/Krs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"929561bf639084d874c7548f0653ce05f8e4257b", @"/Views/_ViewImports.cshtml")]
    public class Views_Krs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemPerwalian2020.Models.Krs>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
  
    Layout = "_Layout";


#line default
#line hidden
            BeginContext(109, 87, true);
            WriteLiteral("<div class=\"container body-content\" style=\"padding-bottom: 100px;\">\r\n    <br>\r\n    <h2>");
            EndContext();
            BeginContext(197, 9, false);
#line 10 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
   Write(Model.Nim);

#line default
#line hidden
            EndContext();
            BeginContext(206, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(208, 10, false);
#line 10 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
              Write(Model.Nama);

#line default
#line hidden
            EndContext();
            BeginContext(218, 26, true);
            WriteLiteral("</h2>\r\n    <h2>Semester : ");
            EndContext();
            BeginContext(245, 14, false);
#line 11 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
              Write(Model.Semester);

#line default
#line hidden
            EndContext();
            BeginContext(259, 13, true);
            WriteLiteral(" | Periode : ");
            EndContext();
            BeginContext(273, 13, false);
#line 11 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
                                          Write(Model.Periode);

#line default
#line hidden
            EndContext();
            BeginContext(286, 31, true);
            WriteLiteral("</h2>\r\n    <br>\r\n    <br>\r\n    ");
            EndContext();
            BeginContext(318, 23, false);
#line 14 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
Write(Html.Raw(ViewBag.Pesan));

#line default
#line hidden
            EndContext();
            BeginContext(341, 546, true);
            WriteLiteral(@"

    <section class=""blog_area"">
        <div class=""container"" style=""margin-bottom: 50px;"">
            <div class=""row"">
                <table class=""table table-hover"">
                    <tr>
                        <th>Kode Mata Kuliah</th>
                        <th>Nama Mata Kuliah</th>
                        <th>SKS</th>
                        <th>Harga</th>
                        <th>Grup</th>
                        <th>Jadwal dan Ruangan</th>
                        <th>Dosen</th>
                    </tr>
");
            EndContext();
#line 29 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
                     foreach (var data in Model.detail)
                    {

#line default
#line hidden
            BeginContext(967, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1030, 16, false);
#line 32 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
                           Write(data.Kode_Matkul);

#line default
#line hidden
            EndContext();
            BeginContext(1046, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1086, 15, false);
#line 33 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
                           Write(data.Nama_Makul);

#line default
#line hidden
            EndContext();
            BeginContext(1101, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1141, 8, false);
#line 34 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
                           Write(data.SKS);

#line default
#line hidden
            EndContext();
            BeginContext(1149, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1189, 10, false);
#line 35 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
                           Write(data.Harga);

#line default
#line hidden
            EndContext();
            BeginContext(1199, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1239, 9, false);
#line 36 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
                           Write(data.Grup);

#line default
#line hidden
            EndContext();
            BeginContext(1248, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1288, 11, false);
#line 37 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
                           Write(data.Jadwal);

#line default
#line hidden
            EndContext();
            BeginContext(1299, 6, true);
            WriteLiteral(" Sesi ");
            EndContext();
            BeginContext(1306, 9, false);
#line 37 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
                                             Write(data.Sesi);

#line default
#line hidden
            EndContext();
            BeginContext(1315, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1319, 12, false);
#line 37 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
                                                          Write(data.Ruangan);

#line default
#line hidden
            EndContext();
            BeginContext(1331, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1371, 9, false);
#line 38 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
                           Write(data.Nama);

#line default
#line hidden
            EndContext();
            BeginContext(1380, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 40 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1441, 50, true);
            WriteLiteral("\r\n\r\n                </table>\r\n            </div>\r\n");
            EndContext();
#line 45 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
             if (@Context.Session.GetString("role") == "mahasiswa")
            {

#line default
#line hidden
            BeginContext(1575, 62, true);
            WriteLiteral("                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1638, 211, false);
#line 48 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
               Write(Html.ActionLink("Ubah data KRS", "EditKrs", new { nim = @Model.Nim, periode = @Model.Periode, semester
                    = @Model.Semester }, new { @class = "btn btn-warning btn-sm", @style = "color:white" }));

#line default
#line hidden
            EndContext();
            BeginContext(1849, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 51 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1890, 38, true);
            WriteLiteral("        </div>\r\n    </section>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemPerwalian2020.Models.Krs> Html { get; private set; }
    }
}
#pragma warning restore 1591
