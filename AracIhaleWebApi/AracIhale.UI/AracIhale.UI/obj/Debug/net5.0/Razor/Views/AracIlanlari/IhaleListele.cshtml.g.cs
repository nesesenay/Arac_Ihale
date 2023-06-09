#pragma checksum "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleListele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18bc8eb9ca881f54f8df69d9c817d5360987de16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AracIlanlari_IhaleListele), @"mvc.1.0.view", @"/Views/AracIlanlari/IhaleListele.cshtml")]
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
#line 1 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\_ViewImports.cshtml"
using AracIhale.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\_ViewImports.cshtml"
using AracIhale.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\_ViewImports.cshtml"
using AracIhale.UI.Models.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\_ViewImports.cshtml"
using AracIhale.UI.Models.VM.Arac;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\_ViewImports.cshtml"
using AracIhale.UI.Models.VM.AracIhaleEkle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\_ViewImports.cshtml"
using AracIhale.UI.Models.VM.Kullanici;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18bc8eb9ca881f54f8df69d9c817d5360987de16", @"/Views/AracIlanlari/IhaleListele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75497794503deef5f944dd4f9cb18ea53568c275", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AracIlanlari_IhaleListele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<IhaleListeleDTO>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IhaleEkle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AracIlanlari", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mx-auto w-25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IhaleDetay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


    <!-- Page Heading -->
    <div class=""mx-auto mb-4 mt-2"">
        <h1 class=""h3 mb-0 text-center"">İhale Listesi</h1>
    </div>

    <!-- Content Row -->

    <div class=""row pb-5 mb-4"">

        <!-- Area Chart -->
        <div class=""col-lg-12 col-md-12 mx-auto"">

            <div class=""mt-3"">

            <div class=""card shadow mb-4"">
                <div class=""card-header py-3"">
                    <h6 class=""m-0 font-weight-bold text-primary"">İhale Listesi</h6>
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">

                        <div class=""text-center mb-4 d-flex"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18bc8eb9ca881f54f8df69d9c817d5360987de166443", async() => {
                WriteLiteral("Yeni");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>

                        <table class=""table table-bordered"" width=""100%"" cellspacing=""0"">
                            <thead>
                                <tr>
                                    <th>Araç İhale ID</th>
                                    <th>İhalenin Adı</th>
                                    <th>Sirket</th>
                                    <th>Bireysel/Kurumsal</th>
                                    <th>Kullanıcı</th>
                                    <th>İhalenin Statüsü</th>
                                    <th>İhale Başlangıç Tarihi</th>
                                    <th>İhale Bitiş Tarihi</th>
                                    <th>İhale Başlangıç Saati</th>
                                    <th>İhale Bitiş Saati</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 52 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleListele.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 55 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleListele.cshtml"
                                       Write(item.AracIhaleID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 56 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleListele.cshtml"
                                       Write(item.IhaleAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 57 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleListele.cshtml"
                                       Write(item.Sirket);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 58 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleListele.cshtml"
                                       Write(item.Rol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 59 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleListele.cshtml"
                                       Write(item.Kullanici);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 60 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleListele.cshtml"
                                       Write(item.IhaleStatu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 61 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleListele.cshtml"
                                       Write(item.IhaleBaslangicTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 62 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleListele.cshtml"
                                       Write(item.IhaleBitisTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 63 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleListele.cshtml"
                                       Write(item.IhaleBaslangicSaati);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 64 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleListele.cshtml"
                                       Write(item.IhaleBitisSaati);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18bc8eb9ca881f54f8df69d9c817d5360987de1612668", async() => {
                WriteLiteral("Detay");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-aracIhaleID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleListele.cshtml"
                                                                                                                WriteLiteral(item.AracIhaleID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["aracIhaleID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-aracIhaleID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["aracIhaleID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 69 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleListele.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>  \r\n        </div>\r\n    </div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<IhaleListeleDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
