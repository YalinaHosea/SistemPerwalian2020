#pragma checksum "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a19781b792c37ba26e80af45deba822e3950c4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Krs_CreateNilai), @"mvc.1.0.view", @"/Views/Krs/CreateNilai.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Krs/CreateNilai.cshtml", typeof(AspNetCore.Views_Krs_CreateNilai))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a19781b792c37ba26e80af45deba822e3950c4a", @"/Views/Krs/CreateNilai.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"929561bf639084d874c7548f0653ce05f8e4257b", @"/Views/_ViewImports.cshtml")]
    public class Views_Krs_CreateNilai : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemPerwalian2020.Models.Krs>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("data_Nilai"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("hiddenid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
  
    Layout = "_Layout";


#line default
#line hidden
            BeginContext(75, 159, true);
            WriteLiteral("\r\n\r\n<div class=\"container body-content\">\r\n    <br>\r\n    <div style=\"display:flex;align-items:center\">\r\n        <div style=\"margin-left:20px\">\r\n            <h2>");
            EndContext();
            BeginContext(235, 15, false);
#line 13 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
           Write(ViewBag.namamhs);

#line default
#line hidden
            EndContext();
            BeginContext(250, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(254, 9, false);
#line 13 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
                              Write(Model.Nim);

#line default
#line hidden
            EndContext();
            BeginContext(263, 61, true);
            WriteLiteral("</h2>\r\n            <p style=\"margin-bottom:0\">Tahun Akademik ");
            EndContext();
            BeginContext(325, 13, false);
#line 14 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
                                                 Write(Model.Periode);

#line default
#line hidden
            EndContext();
            BeginContext(338, 10, true);
            WriteLiteral(" Semester ");
            EndContext();
            BeginContext(349, 14, false);
#line 14 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
                                                                         Write(Model.Semester);

#line default
#line hidden
            EndContext();
            BeginContext(363, 53, true);
            WriteLiteral("</p>\r\n            <input type=\"hidden\" id=\"hiddennim\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 416, "\"", 434, 1);
#line 15 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
WriteAttributeValue("", 424, Model.Nim, 424, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(435, 56, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"hiddenperiode\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 491, "\"", 513, 1);
#line 16 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
WriteAttributeValue("", 499, Model.Periode, 499, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(514, 57, true);
            WriteLiteral(" />\r\n            <input type=\"hidden\" id=\"hiddensemester\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 571, "\"", 594, 1);
#line 17 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
WriteAttributeValue("", 579, Model.Semester, 579, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(595, 499, true);
            WriteLiteral(@" />

        </div>
    </div>
    <br />
    <section class=""blog_area"">
        <div class=""container"" style=""margin-bottom:50px"">
            <div class=""row"">
                <table id=""tabeldetail"" class=""table table-hover"">
                    <tr>
                        <th>Kode Makul</th>
                        <th>Nama Makul</th>
                        <th>SKS</th>
                        <th>Grup</th>
                        <th>Nilai</th>
                    </tr>
");
            EndContext();
#line 33 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
                     foreach (var data in Model.detail)
                    {

#line default
#line hidden
            BeginContext(1174, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1259, 16, false);
#line 37 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
                       Write(data.Kode_Matkul);

#line default
#line hidden
            EndContext();
            BeginContext(1275, 68, true);
            WriteLiteral("\r\n                            <input class=\"kodemakul\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1343, "\"", 1368, 1);
#line 38 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
WriteAttributeValue("", 1351, data.Kode_Matkul, 1351, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1369, 69, true);
            WriteLiteral(" />\r\n                            <input class=\"idmakul\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1438, "\"", 1454, 1);
#line 39 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
WriteAttributeValue("", 1446, data.id, 1446, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1455, 96, true);
            WriteLiteral(" />\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1552, 15, false);
#line 43 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
                       Write(data.Nama_Makul);

#line default
#line hidden
            EndContext();
            BeginContext(1567, 68, true);
            WriteLiteral("\r\n                            <input class=\"namamakul\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1635, "\"", 1659, 1);
#line 44 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
WriteAttributeValue("", 1643, data.Nama_Makul, 1643, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1660, 96, true);
            WriteLiteral(" />\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1757, 8, false);
#line 48 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
                       Write(data.SKS);

#line default
#line hidden
            EndContext();
            BeginContext(1765, 62, true);
            WriteLiteral("\r\n                            <input class=\"sks\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1827, "\"", 1844, 1);
#line 49 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
WriteAttributeValue("", 1835, data.SKS, 1835, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1845, 94, true);
            WriteLiteral(" />\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1940, 9, false);
#line 52 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
                       Write(data.Grup);

#line default
#line hidden
            EndContext();
            BeginContext(1949, 63, true);
            WriteLiteral("\r\n                            <input class=\"grup\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2012, "\"", 2030, 1);
#line 53 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
WriteAttributeValue("", 2020, data.Grup, 2020, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2031, 96, true);
            WriteLiteral(" />\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2127, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a19781b792c37ba26e80af45deba822e3950c4a13151", async() => {
                BeginContext(2233, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2267, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6a19781b792c37ba26e80af45deba822e3950c4a13570", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2293, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 57 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => data.Nilai);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 57 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.nilai,"Value","Text"));

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2332, 62, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 63 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
                    }

#line default
#line hidden
            BeginContext(2417, 69, true);
            WriteLiteral("                </table>\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(2486, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a19781b792c37ba26e80af45deba822e3950c4a17139", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 66 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Id_krs);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 66 "D:\Program S1\Semester 7\Peterpan\SistemPerwalian2020\Views\Krs\CreateNilai.cshtml"
                                                                          WriteLiteral(Model.Id_krs);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2569, 359, true);
            WriteLiteral(@"

                </div>
                <div class=""row"" style=""text-align: center;"">
                    <div class=""col-md-12"">
                        <input type=""button"" id=""btnsimpan"" value=""Simpan"" class=""btn btn-primary"" />
                    </div>
                </div>
            </div>
        </div>
    </section>
    
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2945, 1623, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(document).ready(function () {

             $('#btnsimpan').click(function () {
                var listmakul = [];
                $('#tabeldetail tbody tr').each(function (index, ele) {
                    var makulitem = {
                        id_makul:  $('.idmakul', this).val(),
                        Kode_matkul: $('.kodemakul', this).val(),
                        Nama_makul: $('.namamakul', this).val(),
                        SKS: parseInt($('.sks', this).val()),
                        Grup: $('.grup', this).val(),
                        Nilai: $('#data_Nilai', this).val(),
                    };
                    console.log(makulitem);
                    if (makulitem.Kode_matkul !== undefined) {
                        listmakul.push(makulitem);
                    }
                });

                var nim = $(""#hiddennim"").val();
                var periode = $(""#hiddenperiode"").val();
                var semest");
                WriteLiteral(@"er = $(""#hiddensemester"").val();

                $.ajax({
                    type: 'POST',
                    url: '/Krs/CreatePost',
                    data: { detail: listmakul, nim: nim, periode: periode, semester: semester },
                    dataType: 'json',
                    success: function (data) {

                        window.location.href = data.url;
                    },
                    error: function (error) {
                        alert(error.statusText);
                    }
                });
            });

        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(4571, 2, true);
            WriteLiteral("\r\n");
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
