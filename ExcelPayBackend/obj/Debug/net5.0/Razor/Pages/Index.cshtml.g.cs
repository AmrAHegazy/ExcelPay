#pragma checksum "E:\ExcelPayBackend\ExcelPayBackend\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "765b51f3c108147af82f8bec9c2ffe9478f3e862"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"765b51f3c108147af82f8bec9c2ffe9478f3e862", @"/Pages/Index.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("    <div style=\"box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);transition: 0.3s;width: 40%;\">\r\n          <div style=\"padding: 2px 16px;\">\r\n              <h4><b>");
#nullable restore
#line 7 "E:\ExcelPayBackend\ExcelPayBackend\Pages\Index.cshtml"
                Write(Model.merch);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h4>\r\n              <p>");
#nullable restore
#line 8 "E:\ExcelPayBackend\ExcelPayBackend\Pages\Index.cshtml"
            Write(Model.intent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n              <p>");
#nullable restore
#line 9 "E:\ExcelPayBackend\ExcelPayBackend\Pages\Index.cshtml"
            Write(Model.ifram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n          </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExcelPayBackend.Views.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExcelPayBackend.Views.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExcelPayBackend.Views.IndexModel>)PageContext?.ViewData;
        public ExcelPayBackend.Views.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
