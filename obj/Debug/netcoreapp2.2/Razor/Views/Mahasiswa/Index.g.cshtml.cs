#pragma checksum "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Mahasiswa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "365a49f7cdd576f9d30675eedac4697afd486096"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mahasiswa_Index), @"mvc.1.0.view", @"/Views/Mahasiswa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mahasiswa/Index.cshtml", typeof(AspNetCore.Views_Mahasiswa_Index))]
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
#line 5 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Mahasiswa\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"365a49f7cdd576f9d30675eedac4697afd486096", @"/Views/Mahasiswa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"929561bf639084d874c7548f0653ce05f8e4257b", @"/Views/_ViewImports.cshtml")]
    public class Views_Mahasiswa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Mahasiswa\Index.cshtml"
  
    Layout = "_Layout";


#line default
#line hidden
            BeginContext(68, 106, true);
            WriteLiteral("\r\n<div class=\"container body-content\">\r\n    <br>\r\n    <h2> Daftar Mahasiswa</h2>\r\n    <br>\r\n    <br>\r\n    ");
            EndContext();
            BeginContext(175, 23, false);
#line 12 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Mahasiswa\Index.cshtml"
Write(Html.Raw(ViewBag.Pesan));

#line default
#line hidden
            EndContext();
            BeginContext(198, 589, true);
            WriteLiteral(@"
    <section class=""blog_area"">
        <div class=""container"" style=""margin-bottom:50px"">
            <div class=""row"">
                <table class=""table table-hover"">
                    <tr>
                        <th></th>
                        <th>NIM</th>
                        <th>Nama</th>
                        <th>Status</th>
                        <th>Grup</th>
                        <th>Angkatan</th>
                        <th>No.HP</th>
                        <th>No.HP Orangtua</th>
                        <th></th>
                    </tr>
");
            EndContext();
#line 28 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Mahasiswa\Index.cshtml"
                     foreach (var data in Model)
                    {
                        if(data.Grup == Context.Session.GetString("grup") || Context.Session.GetString("grup") == "" || Context.Session.GetString("grup") == null)
                        {
                        var src = "/Images/" + data.Nim + ".jpg";

#line default
#line hidden
            BeginContext(1118, 66, true);
            WriteLiteral("                        <tr>\r\n                            <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1184, "\"", 1194, 1);
#line 34 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Mahasiswa\Index.cshtml"
WriteAttributeValue("", 1190, src, 1190, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1195, 126, true);
            WriteLiteral(" class=\"rounded-circle\" style=\"height:50px;width:50px\" /></td>\r\n                            <td style=\"vertical-align:middle\">");
            EndContext();
            BeginContext(1322, 8, false);
#line 35 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Mahasiswa\Index.cshtml"
                                                         Write(data.Nim);

#line default
#line hidden
            EndContext();
            BeginContext(1330, 69, true);
            WriteLiteral("</td>\r\n                            <td style=\"vertical-align:middle\">");
            EndContext();
            BeginContext(1400, 13, false);
#line 36 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Mahasiswa\Index.cshtml"
                                                         Write(data.Nama_mhs);

#line default
#line hidden
            EndContext();
            BeginContext(1413, 69, true);
            WriteLiteral("</td>\r\n                            <td style=\"vertical-align:middle\">");
            EndContext();
            BeginContext(1483, 11, false);
#line 37 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Mahasiswa\Index.cshtml"
                                                         Write(data.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1494, 71, true);
            WriteLiteral("</td>\r\n                              <td style=\"vertical-align:middle\">");
            EndContext();
            BeginContext(1566, 9, false);
#line 38 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Mahasiswa\Index.cshtml"
                                                           Write(data.Grup);

#line default
#line hidden
            EndContext();
            BeginContext(1575, 70, true);
            WriteLiteral("</td>\r\n                             <td style=\"vertical-align:middle\">");
            EndContext();
            BeginContext(1646, 13, false);
#line 39 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Mahasiswa\Index.cshtml"
                                                          Write(data.Angkatan);

#line default
#line hidden
            EndContext();
            BeginContext(1659, 69, true);
            WriteLiteral("</td>\r\n                            <td style=\"vertical-align:middle\">");
            EndContext();
            BeginContext(1729, 14, false);
#line 40 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Mahasiswa\Index.cshtml"
                                                         Write(data.No_hp_mhs);

#line default
#line hidden
            EndContext();
            BeginContext(1743, 69, true);
            WriteLiteral("</td>\r\n                            <td style=\"vertical-align:middle\">");
            EndContext();
            BeginContext(1813, 15, false);
#line 41 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Mahasiswa\Index.cshtml"
                                                         Write(data.No_hp_ortu);

#line default
#line hidden
            EndContext();
            BeginContext(1828, 70, true);
            WriteLiteral("</td>\r\n                            <td style=\"vertical-align:middle\"> ");
            EndContext();
            BeginContext(1899, 108, false);
#line 42 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Mahasiswa\Index.cshtml"
                                                          Write(Html.ActionLink("Lihat Nilai", "Nilai", new { id = data.Nim }, new { @class = "btn btn-warning btn-round" }));

#line default
#line hidden
            EndContext();
            BeginContext(2007, 68, true);
            WriteLiteral("</td>\r\n                            \r\n                        </tr>\r\n");
            EndContext();
#line 45 "D:\SistemPerwalian\perwalian 2\SistemPerwalian2020\Views\Mahasiswa\Index.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(2125, 88, true);
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>  \r\n");
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
