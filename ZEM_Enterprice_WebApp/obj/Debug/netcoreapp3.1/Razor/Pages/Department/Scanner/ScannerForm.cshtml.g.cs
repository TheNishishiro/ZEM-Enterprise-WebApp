#pragma checksum "D:\Programming\C_sharp\ZEM_Enterprice_WebApp_Release\ZEM_Enterprice_WebApp\Pages\Department\Scanner\ScannerForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d4a73e91903ffdfc2a4619edffe6610a513a252"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ZEM_Enterprice_WebApp.Pages.Department.Scanner.Pages_Department_Scanner_ScannerForm), @"mvc.1.0.razor-page", @"/Pages/Department/Scanner/ScannerForm.cshtml")]
namespace ZEM_Enterprice_WebApp.Pages.Department.Scanner
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
#line 1 "D:\Programming\C_sharp\ZEM_Enterprice_WebApp_Release\ZEM_Enterprice_WebApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\C_sharp\ZEM_Enterprice_WebApp_Release\ZEM_Enterprice_WebApp\Pages\_ViewImports.cshtml"
using ZEM_Enterprice_WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programming\C_sharp\ZEM_Enterprice_WebApp_Release\ZEM_Enterprice_WebApp\Pages\_ViewImports.cshtml"
using ZEM_Enterprice_WebApp.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d4a73e91903ffdfc2a4619edffe6610a513a252", @"/Pages/Department/Scanner/ScannerForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf1f4c0c739ce8e5d7c0354cc5cfc29853d8ad6b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Department_Scanner_ScannerForm : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/customjs/api.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/customjs/ScanCommunicate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Programming\C_sharp\ZEM_Enterprice_WebApp_Release\ZEM_Enterprice_WebApp\Pages\Department\Scanner\ScannerForm.cshtml"
  
    ViewData["Title"] = "Skanuj kable";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""/assets/customcss/StyleSheet.css"">

<div class=""row text-center"">
    <div class=""col-4"">
        <div>
            <div class=""col"">
                <div class=""text-left""><label>Numer dostawy:</label><input type=""text"" id=""nr-dostawy-field""></div>
            </div>
            <div class=""col text-left"" style=""padding-top: 20px;padding-bottom: 0px;""><label>Data dostawy:</label><input id=""data-scanned-field"" type=""date""></div>
        </div>
    </div>
    <div class=""col"">
        <label>Kod kabla</label>
        <input type=""hidden"" id=""username-field""");
            BeginWriteAttribute("value", " value=\"", 774, "\"", 812, 1);
#nullable restore
#line 21 "D:\Programming\C_sharp\ZEM_Enterprice_WebApp_Release\ZEM_Enterprice_WebApp\Pages\Department\Scanner\ScannerForm.cshtml"
WriteAttributeValue("", 782, UserManager.GetUserName(User), 782, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input onkeyup=\"manualEntry(event)\" type=\"text\" id=\"kod-kabla-field\" style=\"padding: 0px;width: 50%;\"");
            BeginWriteAttribute("autofocus", " autofocus=\"", 927, "\"", 939, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <br>
        <div class=""row"">
            <div class=""col"">
                <input type=""checkbox"" id=""Manual-Input"" name=""manual-checkbox"" value=""manual"">
                <label for=""Manual-Input""> Wpisz ręcznie</label>
            </div>
            <div class=""col"">
                <input type=""checkbox"" id=""AddBack-field"" value=""manual"" checked>
                <label for=""AddBack-field""> Dopisuj do końca</label><br>
            </div>
        </div>
    </div>
</div>
<div class=""row"" style=""padding-top: 20px;"" id=""window-div"">
    <div class=""col"">
        <div class=""text-left"">
            <h3>Kod cięty:</h3>
            <div class=""text-center"">
                <h1 id=""kod-ciety-field"">KOD CIĘTY</h1>
            </div>
        </div>
        <div class=""text-left"">
            <h3>BIN:</h3>
            <div class=""text-center"">
                <h1 id=""bin-field"">BIN</h1>
            </div>
        </div>
        <div class=""text-left"">
            <h3>Kod wiązki");
            WriteLiteral(@":</h3>
            <div class=""text-center"">
                <h1 id=""kod-wiazki-field"">KOD WIĄZKI</h1>
            </div>
        </div>
        <div class=""text-left"">
            <h3>Data dostawy, deklarowana:</h3>
            <div class=""text-center"">
                <h1 id=""data-dostawy-stara-field"">DATA DOSTAWY</h1>
            </div>
        </div>
        <div class=""text-left"">
            <h3>Zeskanowanych/Komplet:</h3>
            <div class=""text-center"">
                <h1 id=""zeskanowanych-field"">Zeskanowanych/ile</h1>
            </div>
        </div>
    </div>
    <div class=""col"">
        <div></div>
        <div class=""text-left"">
            <h3>Litera rodziny:</h3>
            <div class=""text-center"">
                <h1 id=""litera-field"">Litera</h1>
            </div>
        </div>
        <div class=""text-left"">
            <h3>Ilość:</h3>
            <div class=""text-center"">
                <h1 id=""ilosc-field"">Ilość</h1>
            </div>
        </d");
            WriteLiteral(@"iv>
        <div class=""text-left"">
            <h3>Numer kompletu:</h3>
            <div class=""text-center"">
                <h1 id=""SetId-field"">Numer Kompletu</h1>
            </div>
        </div>
        <div class=""text-left"">
            <h3>Data dostawy, dopis:</h3>
            <div class=""text-center"">
                <h1 id=""data-dostawy-nowa-field"">Data dostawy nowa</h1>
            </div>
        </div>
    </div>
</div>

<div style=""display: none"" id=""print-div"">
    <div style=""width:100%; padding-top: 20px; writing-mode: tb-rl;"">
        <div>
            <h1 id=""rodzina-print"" style=""font-size: 56px;"">Rear Lights (FL)</h1>
            <div class=""row text-center"">
                <div class=""col"">
                    <h3>Kod literowy:</h3>
                    <h1 id=""kod-literowy-print"" style=""font-size: 60px;"">BF</h1>
                </div>
                <div class=""col"">
                    <h3>Kod cyfrowy:</h3>
                    <h1 id=""kod-cyfrowy-print"" sty");
            WriteLiteral(@"le=""font-size: 60px;"">175</h1>
                </div>
                <div class=""col"">
                    <h3>Kabli/Wiązkę</h3>
                    <h1 id=""kabli-wiazke-print"">16</h1>
                </div>
                <div class=""col"">
                    <h3>Nr. Kompletu</h3>
                    <h1 id=""nr-kompletu-print"">16</h1>
                </div>
            </div>
        </div>
        <h1 id=""wiazka-print"" style=""font-size: 63px;"">23419083A</h1>
        <div class=""row"">
            <div class=""col-2 text-right align-self-center"">
                <h1>BIN:</h1>
            </div>
            <div class=""col align-self-center"">
                <h1 id=""bin-print"">K06-A31</h1>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-3 text-left align-self-center"">
                <h3>Data dostawy:</h3>
            </div>
            <div class=""col align-self-center"">
                <h2 class=""text-left"" id=""data-dostawy-print"">02.07.2020<");
            WriteLiteral(@"/h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-3 text-left align-self-center"">
                <h3>Ilość w dostawie:</h3>
            </div>
            <div class=""col align-self-center"">
                <h2 class=""text-left"" id=""ilosc-w-dostawie-print"">17</h2>
            </div>
            <div class=""col-3 text-left align-self-center"">
                <h3>Przykładowy kod:</h3>
            </div>
            <div class=""col align-self-center"">
                <h2 class=""text-left"" id=""przykladowy-kod-kabla-print"">AEB17510</h2>
            </div>
        </div>
    </div>
</div>

<div class=""row text-center"" style=""padding-top: 50px"">
    <div class=""col"">
        <h1 id=""komplet-field"">Komplet</h1>
    </div>
    <div class=""col"">
        <h1 id=""zalegle-field"" style=""color: rgb(255,46,33);"">Zaległe</h1>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d4a73e91903ffdfc2a4619edffe6610a513a25211173", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d4a73e91903ffdfc2a4619edffe6610a513a25212213", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<MyUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZEM_Enterprice_WebApp.Pages.Department.Scanner.ScannerFormModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ZEM_Enterprice_WebApp.Pages.Department.Scanner.ScannerFormModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ZEM_Enterprice_WebApp.Pages.Department.Scanner.ScannerFormModel>)PageContext?.ViewData;
        public ZEM_Enterprice_WebApp.Pages.Department.Scanner.ScannerFormModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
