#pragma checksum "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89b1074f4d5b690797f13035e01e5285226f863c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jadwal_Index), @"mvc.1.0.view", @"/Views/Jadwal/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Jadwal/Index.cshtml", typeof(AspNetCore.Views_Jadwal_Index))]
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
#line 2 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89b1074f4d5b690797f13035e01e5285226f863c", @"/Views/Jadwal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"929561bf639084d874c7548f0653ce05f8e4257b", @"/Views/_ViewImports.cshtml")]
    public class Views_Jadwal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemPerwalian2020.Models.Jadwal>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(89, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(179, 150, true);
            WriteLiteral("\r\n<div class=\"container body-content\" >\r\n    <br>\r\n    <h2 style=\"text-align: center; color:#061a23 ;\">Jadwal Perwalian</h2>\r\n    <hr>\r\n    <br>\r\n    ");
            EndContext();
            BeginContext(330, 23, false);
#line 14 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
Write(Html.Raw(ViewBag.Pesan));

#line default
#line hidden
            EndContext();
            BeginContext(353, 108, true);
            WriteLiteral("\r\n\r\n    <section class=\"blog_area\">\r\n        <div class=\"container col-lg-12\" style=\"margin-bottom:100px\">\r\n");
            EndContext();
#line 18 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
             if (@Context.Session.GetString("role") == "dosen" || @Context.Session.GetString("role") == "superadmin")
            {

#line default
#line hidden
            BeginContext(595, 43, true);
            WriteLiteral("                <p>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 638, "\"", 676, 1);
#line 21 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
WriteAttributeValue("", 645, Url.Action("Create", "Jadwal"), 645, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(677, 66, true);
            WriteLiteral(" class=\"btn btn-success\">Tambah Jadwal</a>\r\n                </p>\r\n");
            EndContext();
#line 23 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(758, 48, true);
            WriteLiteral("            <div class=\"row\">\r\n               \r\n");
            EndContext();
#line 26 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                         foreach (var item in Model)
                        {
                            if(Context.Session.GetString("user") == null || Context.Session.GetString("user") == "" || item.Angkatan == Context.Session.GetString("angkatan") 
                            || item.Dosen == Context.Session.GetString("user") || Context.Session.GetString("role") == "superadmin")
                        {

#line default
#line hidden
            BeginContext(1224, 170, true);
            WriteLiteral("                            <div class=\"card\" style=\"padding: 20px;margin-right: 20px;margin-bottom: 20px;\">\r\n                                <h4 style=\"color: #061a23;\">");
            EndContext();
            BeginContext(1395, 40, false);
#line 32 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Waktu));

#line default
#line hidden
            EndContext();
            BeginContext(1435, 87, true);
            WriteLiteral("\r\n                                </h4>\r\n                                <i>Periode <b>");
            EndContext();
            BeginContext(1523, 42, false);
#line 34 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.Periode));

#line default
#line hidden
            EndContext();
            BeginContext(1565, 10, true);
            WriteLiteral("</b> | <b>");
            EndContext();
            BeginContext(1576, 40, false);
#line 34 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                                                                              Write(Html.DisplayFor(modelItem => item.Prodi));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 17, true);
            WriteLiteral("</b> angkatan <b>");
            EndContext();
            BeginContext(1634, 43, false);
#line 34 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                                                                                                                                        Write(Html.DisplayFor(modelItem => item.Angkatan));

#line default
#line hidden
            EndContext();
            BeginContext(1677, 142, true);
            WriteLiteral("</b>\r\n                                </i>\r\n                               \r\n                                <span style=\"font-weight: bold;\">");
            EndContext();
            BeginContext(1820, 40, false);
#line 37 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.Dosen));

#line default
#line hidden
            EndContext();
            BeginContext(1860, 120, true);
            WriteLiteral("\r\n                                </span>\r\n                                <br>\r\n                                <div>\r\n");
            EndContext();
#line 41 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                     if (@Context.Session.GetString("role") == "dosen" || @Context.Session.GetString("role") == "superadmin")
                                {
                                        

#line default
#line hidden
            BeginContext(2199, 147, false);
#line 43 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                   Write(Html.ActionLink("Edit", "Edit", new { id = item.Kode_jadwal }, new { @class = "btn btn-warning btn-sm", @style = "margin-right:10px;color: white"}));

#line default
#line hidden
            EndContext();
            BeginContext(2389, 138, false);
#line 44 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                   Write(Html.ActionLink("Delete", "Delete", new { id = item.Kode_jadwal }, new { @class = "btn btn-danger btn-sm", @style = "margin-right:10px" }));

#line default
#line hidden
            EndContext();
#line 44 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                                                                                                                                                                   


                                    
                                }

#line default
#line hidden
            BeginContext(2606, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 49 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                 if (@Context.Session.GetString("role") == "dosen")
                                {
                               

#line default
#line hidden
            BeginContext(2758, 169, false);
#line 51 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                          Write(Html.ActionLink("Presensi", "Presensi", new { id = item.Kode_jadwal, angkatan = item.Angkatan }, new { @class = "btn btn-primary btn-sm", @style = "margin-right:10px" }));

#line default
#line hidden
            EndContext();
            BeginContext(2966, 137, false);
#line 52 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                               Write(Html.ActionLink("Catatan", "Catatan", new { id = item.Kode_jadwal, angkatan = item.Angkatan }, new { @class = "btn btn-success btn-sm" }));

#line default
#line hidden
            EndContext();
#line 52 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                                                                                                                                                              
                                }

#line default
#line hidden
            BeginContext(3140, 189, true);
            WriteLiteral("                                </div>\r\n                            </div>\r\n                            <!-- <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3330, 42, false);
#line 58 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Periode));

#line default
#line hidden
            EndContext();
            BeginContext(3372, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3488, 40, false);
#line 61 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Prodi));

#line default
#line hidden
            EndContext();
            BeginContext(3528, 41, true);
            WriteLiteral("\r\n                                </td>\r\n");
            EndContext();
            BeginContext(3730, 75, true);
            WriteLiteral("                                 <td>\r\n                                    ");
            EndContext();
            BeginContext(3806, 43, false);
#line 67 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Angkatan));

#line default
#line hidden
            EndContext();
            BeginContext(3849, 116, true);
            WriteLiteral("\r\n                                </td>\r\n                                 <td>\r\n                                    ");
            EndContext();
            BeginContext(3966, 40, false);
#line 70 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Dosen));

#line default
#line hidden
            EndContext();
            BeginContext(4006, 118, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                </td>\r\n");
            EndContext();
#line 74 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                 if (@Context.Session.GetString("role") == "dosen" || @Context.Session.GetString("role") == "superadmin")
                                {

#line default
#line hidden
            BeginContext(4298, 82, true);
            WriteLiteral("                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4381, 105, false);
#line 77 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                   Write(Html.ActionLink("Edit", "Edit", new { id = item.Kode_jadwal }, new { @class = "btn btn-warning btn-sm" }));

#line default
#line hidden
            EndContext();
            BeginContext(4486, 44, true);
            WriteLiteral(" |\r\n                                        ");
            EndContext();
            BeginContext(4531, 108, false);
#line 78 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                   Write(Html.ActionLink("Delete", "Delete", new { id = item.Kode_jadwal }, new { @class = "btn btn-danger btn-sm" }));

#line default
#line hidden
            EndContext();
            BeginContext(4639, 47, true);
            WriteLiteral("\r\n\r\n                                    </td>\r\n");
            EndContext();
#line 81 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"

                                    
                                }

#line default
#line hidden
            BeginContext(4761, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 84 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                 if (@Context.Session.GetString("role") == "dosen")
                                {

#line default
#line hidden
            BeginContext(4881, 37, true);
            WriteLiteral("                                <td> ");
            EndContext();
            BeginContext(4919, 139, false);
#line 86 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                Write(Html.ActionLink("Presensi", "Presensi", new { id = item.Kode_jadwal, angkatan = item.Angkatan }, new { @class = "btn btn-primary btn-sm" }));

#line default
#line hidden
            EndContext();
            BeginContext(5058, 48, true);
            WriteLiteral("</td>\r\n                                    <td> ");
            EndContext();
            BeginContext(5107, 137, false);
#line 87 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                    Write(Html.ActionLink("Catatan", "Catatan", new { id = item.Kode_jadwal, angkatan = item.Angkatan }, new { @class = "btn btn-success btn-sm" }));

#line default
#line hidden
            EndContext();
            BeginContext(5244, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 88 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(5286, 39, true);
            WriteLiteral("                            </tr> -->\r\n");
            EndContext();
#line 90 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Jadwal\Index.cshtml"
                        }
                        }

#line default
#line hidden
            BeginContext(5379, 84, true);
            WriteLiteral("                   \r\n            </div>\r\n        </div>\r\n    </section>\r\n   \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemPerwalian2020.Models.Jadwal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
