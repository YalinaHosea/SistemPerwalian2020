#pragma checksum "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\IndexMakul.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57f447cf60c7eb1e967fd310ba79ca3d23942cf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Krs_IndexMakul), @"mvc.1.0.view", @"/Views/Krs/IndexMakul.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Krs/IndexMakul.cshtml", typeof(AspNetCore.Views_Krs_IndexMakul))]
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
#line 2 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\IndexMakul.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57f447cf60c7eb1e967fd310ba79ca3d23942cf3", @"/Views/Krs/IndexMakul.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"929561bf639084d874c7548f0653ce05f8e4257b", @"/Views/_ViewImports.cshtml")]
    public class Views_Krs_IndexMakul : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<SistemPerwalian2020.Models.MakulViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(91, 403, true);
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"">
        <table class=""table table-hover"">
            <tr>
                <th>Kode Makul</th>
                <th>Nama Makul</th>
                <th>SKS</th>
                <th>Harga</th>
                <th>Grup</th>
                <th>Jadwal dan Ruangan</th>
                <th>Dosen</th>
                <th></th>
            </tr>
");
            EndContext();
#line 18 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\IndexMakul.cshtml"
             foreach (var data in Model)
            {

#line default
#line hidden
            BeginContext(551, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(598, 16, false);
#line 21 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\IndexMakul.cshtml"
                   Write(data.Kode_Matkul);

#line default
#line hidden
            EndContext();
            BeginContext(614, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(646, 15, false);
#line 22 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\IndexMakul.cshtml"
                   Write(data.Nama_Makul);

#line default
#line hidden
            EndContext();
            BeginContext(661, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(693, 8, false);
#line 23 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\IndexMakul.cshtml"
                   Write(data.SKS);

#line default
#line hidden
            EndContext();
            BeginContext(701, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(733, 10, false);
#line 24 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\IndexMakul.cshtml"
                   Write(data.Harga);

#line default
#line hidden
            EndContext();
            BeginContext(743, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(775, 9, false);
#line 25 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\IndexMakul.cshtml"
                   Write(data.Grup);

#line default
#line hidden
            EndContext();
            BeginContext(784, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(816, 11, false);
#line 26 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\IndexMakul.cshtml"
                   Write(data.Jadwal);

#line default
#line hidden
            EndContext();
            BeginContext(827, 6, true);
            WriteLiteral(" Sesi ");
            EndContext();
            BeginContext(834, 9, false);
#line 26 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\IndexMakul.cshtml"
                                     Write(data.Sesi);

#line default
#line hidden
            EndContext();
            BeginContext(843, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(847, 12, false);
#line 26 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\IndexMakul.cshtml"
                                                  Write(data.Ruangan);

#line default
#line hidden
            EndContext();
            BeginContext(859, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(891, 9, false);
#line 27 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\IndexMakul.cshtml"
                   Write(data.Nama);

#line default
#line hidden
            EndContext();
            BeginContext(900, 80, true);
            WriteLiteral("</td>\r\n                    <td> <a class=\"DefaultEditBtn btn btn-success btn-sm\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 980, "\"", 1013, 3);
            WriteAttributeValue("", 990, "selectmakul(\'", 990, 13, true);
#line 28 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\IndexMakul.cshtml"
WriteAttributeValue("", 1003, data.id, 1003, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1011, "\')", 1011, 2, true);
            EndWriteAttribute();
            BeginContext(1014, 73, true);
            WriteLiteral("><span style=\"color:white\">Pilih</span></a></td>\r\n                </tr>\r\n");
            EndContext();
#line 30 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\IndexMakul.cshtml"
                
            }

#line default
#line hidden
            BeginContext(1120, 38, true);
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<SistemPerwalian2020.Models.MakulViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
