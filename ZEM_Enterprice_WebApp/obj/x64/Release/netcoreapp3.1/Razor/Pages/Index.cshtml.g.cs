#pragma checksum "D:\Programming\C_sharp\ZEM_Enterprice_WebApp_Release\ZEM_Enterprice_WebApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfb78df2b0f94e2f04cfcf6ce1184fcb0fe4257e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ZEM_Enterprice_WebApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ZEM_Enterprice_WebApp.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfb78df2b0f94e2f04cfcf6ce1184fcb0fe4257e", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf1f4c0c739ce8e5d7c0354cc5cfc29853d8ad6b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Programming\C_sharp\ZEM_Enterprice_WebApp_Release\ZEM_Enterprice_WebApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "Strona powitalna";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"highlight-blue\" style=\"font-family: \'Exo 2\', sans-serif;\">\r\n    <div class=\"container\">\r\n        <div class=\"intro\">\r\n            <h3>");
#nullable restore
#line 9 "D:\Programming\C_sharp\ZEM_Enterprice_WebApp_Release\ZEM_Enterprice_WebApp\Pages\Index.cshtml"
           Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            <h2 class=""text-center"">Witaj!</h2>
            <p class=""text-center"">
                Znajdujesz się w aplikacji ZEM Enterprise obsługującej część zakładuj odpowiadającą za zarządzanie przewodami.<br><br>Aby kontynuować musisz posiadać konto.<br>Jeśli posiadasz konto użyj przycisku ""Zaloguj"" u góry strony.<br><br>Wszelkie zastrzeżenia
                i uwagi proszę kierować do osób odpowiedzialnych za ten projekt.
            </p>
        </div>
        <div class=""buttons""></div>
    </div>
</div>
<script src=""/assets/js/jquery.min.js?h=83e266cb1712b47c265f77a8f9e18451""></script>
<script src=""/assets/bootstrap/js/bootstrap.min.js?h=e46528792882c54882f660b60936a0fc""></script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
