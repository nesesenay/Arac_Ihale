#pragma checksum "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleEkle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b2b33e6be9dede66053191f580d21a4522d3ad5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AracIlanlari_IhaleEkle), @"mvc.1.0.view", @"/Views/AracIlanlari/IhaleEkle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b2b33e6be9dede66053191f580d21a4522d3ad5", @"/Views/AracIlanlari/IhaleEkle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75497794503deef5f944dd4f9cb18ea53568c275", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AracIlanlari_IhaleEkle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DBAracIhaleDTO>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IhaleListele", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AracIlanlari", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<div class=""container-fluid pb-5 pt-4"">

    <!-- Page Heading -->
    <div class=""mx-auto mb-4"">
        <h1 class=""h3 mb-0 text-center"">İhale Ekle</h1>
    </div>

    <!-- Content Row -->

    <div class=""row"">

        <!-- Area Chart -->
        <div class=""col-lg-12 col-md-12 mx-auto"">
            <div class=""card shadow mb-4"">
             
                <!-- Card Body -->
                <div class=""card-body mx-auto"">

");
#nullable restore
#line 26 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleEkle.cshtml"
                     using (Html.BeginForm("IhaleEkle", "AracIlanlari", FormMethod.Post))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleEkle.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""mt-3"">

                            <div class=""card shadow mb-4"">
                                <div class=""card-header py-3"">
                                    <h6 class=""m-0 font-weight-bold text-primary"">İhale Bilgilerini Ekle</h6>
                                </div>
                                <div class=""card-body"">


                                    <div class=""row justify-content-center align-items-center py-2"">
                                        <div class=""col-4"">
                                            <div class=""d-flex flex-column p-2"">
                                                <span class=""text-dark mb-2 text-center font-weight-bold"">İhale Adı</span>
                                                ");
#nullable restore
#line 43 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleEkle.cshtml"
                                           Write(Html.TextBoxFor(a => a.IhaleAdi, new { @class = "mx-auto p-1 form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <div class=""col-4"">
                                            <div class=""d-flex flex-column p-2"">
                                                <span class=""text-dark mb-2 mx-auto text-center font-weight-bold"">Bireysel/Kurumsal</span>
                                                ");
#nullable restore
#line 49 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleEkle.cshtml"
                                           Write(Html.DropDownListFor(a => a.RolID, Model.Roller, "Seçiniz", new { @class = "btn btn-outline-dark  mx-auto form-control w-100", @type = "button" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <div class=""col-4"">
                                            <div class=""d-flex flex-column p-2"">
                                                <span class=""text-dark mb-2 text-center font-weight-bold mx-auto"">Şirketler</span>
                                                ");
#nullable restore
#line 55 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleEkle.cshtml"
                                           Write(Html.DropDownListFor(a => a.SirketID, Model.Sirketler, "Seçiniz", new { @class = "btn btn-outline-dark  mx-auto form-control w-100", @type = "button" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>


                                    <div class=""row justify-content-center align-items-center py-2"">
                                        <div class=""col-4"">
                                            <div class=""d-flex flex-column p-2"">
                                                <span class=""text-dark mb-2 text-center font-weight-bold mx-auto"">Statü</span>
                                                ");
#nullable restore
#line 65 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleEkle.cshtml"
                                           Write(Html.DropDownListFor(a => a.IhaleStatuID, Model.IhaleStatuleri, "Seçiniz", new { @class = "btn btn-outline-dark  mx-auto form-control w-100", @type = "button" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                         <div class=""col-4"">
                                            <div class=""d-flex flex-column p-2"">
                                                <span class=""text-dark mb-2 text-center font-weight-bold"">İhale Başlangıç Tarihi</span>
                                                ");
#nullable restore
#line 71 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleEkle.cshtml"
                                           Write(Html.TextBoxFor(a => a.IhaleBaslangicTarihi, new { @class = "mx-auto p-1 form-control", type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <div class=""col-4"">
                                            <div class=""d-flex flex-column p-2"">
                                                <span class=""text-dark mb-2 text-center font-weight-bold"">İhale Başlangıç Saati</span>
                                                ");
#nullable restore
#line 77 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleEkle.cshtml"
                                           Write(Html.TextBoxFor(a => a.IhaleBaslangicSaati, new { @class = "mx-auto p-1 form-control", type = "time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>

                                    <div class=""row justify-content-start align-items-center py-2"">
                                        <div class=""col-4"">
                                            <div class=""d-flex flex-column p-2"">
                                                <span class=""text-dark mb-2 text-center font-weight-bold"">İhale Bitiş Tarihi</span>
                                                ");
#nullable restore
#line 86 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleEkle.cshtml"
                                           Write(Html.TextBoxFor(a => a.IhaleBitisTarihi, new { @class = "mx-auto p-1 form-control", type = "date"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                            <div class=""col-4"">
                                            <div class=""d-flex flex-column p-2"">
                                                <span class=""text-dark mb-2 text-center font-weight-bold"">İhale Bitiş Saat</span>
                                                ");
#nullable restore
#line 92 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleEkle.cshtml"
                                           Write(Html.TextBoxFor(a => a.IhaleBitisSaati, new { @class = "mx-auto p-1 form-control", type = "time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                      <div class=""text-right d-flex"">
                            <input type=""submit"" class=""btn btn-success ms-auto font-weight-bold me-4"" value=""Kaydet"" />
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b2b33e6be9dede66053191f580d21a4522d3ad513771", async() => {
                WriteLiteral("Geri Dön");
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
            WriteLiteral("\r\n                      </div>\r\n");
#nullable restore
#line 103 "C:\Users\neses\Desktop\AracIhaleWebApi\AracIhale.UI\AracIhale.UI\Views\AracIlanlari\IhaleEkle.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DBAracIhaleDTO> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
