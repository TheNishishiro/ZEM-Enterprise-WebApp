#pragma checksum "D:\Programming\C_sharp\ZEM_Enterprice_WebApp\ZEM_Enterprice_WebApp\Pages\Manager\AdminManager\DumpDatabase.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d86e62a9b7387d08e8299efb2c8d76c587905ece"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ZEM_Enterprice_WebApp.Pages.Manager.AdminManager.Pages_Manager_AdminManager_DumpDatabase), @"mvc.1.0.razor-page", @"/Pages/Manager/AdminManager/DumpDatabase.cshtml")]
namespace ZEM_Enterprice_WebApp.Pages.Manager.AdminManager
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
#line 1 "D:\Programming\C_sharp\ZEM_Enterprice_WebApp\ZEM_Enterprice_WebApp\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programming\C_sharp\ZEM_Enterprice_WebApp\ZEM_Enterprice_WebApp\Pages\_ViewImports.cshtml"
using ZEM_Enterprice_WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programming\C_sharp\ZEM_Enterprice_WebApp\ZEM_Enterprice_WebApp\Pages\_ViewImports.cshtml"
using ZEM_Enterprice_WebApp.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d86e62a9b7387d08e8299efb2c8d76c587905ece", @"/Pages/Manager/AdminManager/DumpDatabase.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf1f4c0c739ce8e5d7c0354cc5cfc29853d8ad6b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Manager_AdminManager_DumpDatabase : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Programming\C_sharp\ZEM_Enterprice_WebApp\ZEM_Enterprice_WebApp\Pages\Manager\AdminManager\DumpDatabase.cshtml"
  
    ViewData["Title"] = "Zrzut bazy danych";
    Layout = "~/Pages/Shared/_ProfileLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Baza danych zrzucona do pliku</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ZEM_Enterprice_WebApp.Pages.Manager.AdminManager.DumpDatabaseModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ZEM_Enterprice_WebApp.Pages.Manager.AdminManager.DumpDatabaseModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ZEM_Enterprice_WebApp.Pages.Manager.AdminManager.DumpDatabaseModel>)PageContext?.ViewData;
        public ZEM_Enterprice_WebApp.Pages.Manager.AdminManager.DumpDatabaseModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
