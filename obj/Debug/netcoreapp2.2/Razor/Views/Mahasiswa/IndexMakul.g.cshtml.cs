#pragma checksum "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Mahasiswa\IndexMakul.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1aa669bafeedc1d497e24f53ea903a358a799a8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mahasiswa_IndexMakul), @"mvc.1.0.view", @"/Views/Mahasiswa/IndexMakul.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mahasiswa/IndexMakul.cshtml", typeof(AspNetCore.Views_Mahasiswa_IndexMakul))]
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
#line 2 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Mahasiswa\IndexMakul.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aa669bafeedc1d497e24f53ea903a358a799a8a", @"/Views/Mahasiswa/IndexMakul.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"929561bf639084d874c7548f0653ce05f8e4257b", @"/Views/_ViewImports.cshtml")]
    public class Views_Mahasiswa_IndexMakul : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemPerwalian2020.Models.MakulViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(101, 378, true);
            WriteLiteral(@"    
    
    <div class=""container"">
        <div class=""row"">
            <table class=""table table-hover"">
                <tr>
                    <th>Kode Makul</th>
                    <th>Nama Makul</th>
                    <th>SKS</th>
                    <th>Grup</th>
                    <th>Dosen</th>
                    <th></th>
                </tr>
");
            EndContext();
#line 16 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Mahasiswa\IndexMakul.cshtml"
                 foreach (var data in Model)
                {

#line default
#line hidden
            BeginContext(544, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(599, 16, false);
#line 19 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Mahasiswa\IndexMakul.cshtml"
                       Write(data.Kode_Matkul);

#line default
#line hidden
            EndContext();
            BeginContext(615, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(651, 15, false);
#line 20 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Mahasiswa\IndexMakul.cshtml"
                       Write(data.Nama_Makul);

#line default
#line hidden
            EndContext();
            BeginContext(666, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(702, 8, false);
#line 21 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Mahasiswa\IndexMakul.cshtml"
                       Write(data.SKS);

#line default
#line hidden
            EndContext();
            BeginContext(710, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(746, 9, false);
#line 22 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Mahasiswa\IndexMakul.cshtml"
                       Write(data.Grup);

#line default
#line hidden
            EndContext();
            BeginContext(755, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(791, 9, false);
#line 23 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Mahasiswa\IndexMakul.cshtml"
                       Write(data.Nama);

#line default
#line hidden
            EndContext();
            BeginContext(800, 109, true);
            WriteLiteral("</td>\r\n                       \r\n                        <td> <a class=\"DefaultEditBtn btn btn-success btn-sm\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 909, "\"", 1010, 15);
            WriteAttributeValue("", 919, "selectmakul(\'", 919, 13, true);
#line 25 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Mahasiswa\IndexMakul.cshtml"
WriteAttributeValue("", 932, data.Kode_Matkul, 932, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 949, "\',", 949, 2, true);
            WriteAttributeValue(" ", 951, "\'", 952, 2, true);
#line 25 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Mahasiswa\IndexMakul.cshtml"
WriteAttributeValue("", 953, data.Nama_Makul, 953, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 969, "\',", 969, 2, true);
            WriteAttributeValue(" ", 971, "\'", 972, 2, true);
#line 25 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Mahasiswa\IndexMakul.cshtml"
WriteAttributeValue("", 973, data.SKS, 973, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 982, "\',", 982, 2, true);
            WriteAttributeValue(" ", 984, "\'", 985, 2, true);
#line 25 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Mahasiswa\IndexMakul.cshtml"
WriteAttributeValue("", 986, data.Grup, 986, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 996, "\',", 996, 2, true);
            WriteAttributeValue(" ", 998, "\'", 999, 2, true);
#line 25 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Mahasiswa\IndexMakul.cshtml"
WriteAttributeValue("", 1000, data.id, 1000, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1008, "\')", 1008, 2, true);
            EndWriteAttribute();
            BeginContext(1011, 77, true);
            WriteLiteral("><span style=\"color:white\">Pilih</span></a></td>\r\n                    </tr>\r\n");
            EndContext();
#line 27 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Mahasiswa\IndexMakul.cshtml"
                
                }

#line default
#line hidden
            BeginContext(1125, 54, true);
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemPerwalian2020.Models.MakulViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
