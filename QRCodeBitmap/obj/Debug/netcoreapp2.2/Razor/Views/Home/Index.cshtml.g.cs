#pragma checksum "D:\JT\CoreProgramm\Blog\.NET Core\QRCodeBitmap\QRCodeBitmap\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa73bbf9966816b121c5dbda28500be6b15432d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\JT\CoreProgramm\Blog\.NET Core\QRCodeBitmap\QRCodeBitmap\Views\_ViewImports.cshtml"
using QRCodeBitmap;

#line default
#line hidden
#line 2 "D:\JT\CoreProgramm\Blog\.NET Core\QRCodeBitmap\QRCodeBitmap\Views\_ViewImports.cshtml"
using QRCodeBitmap.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa73bbf9966816b121c5dbda28500be6b15432d2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"497fd34fe7e64418777337c6b8b27a0eef03b494", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Byte[]>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\JT\CoreProgramm\Blog\.NET Core\QRCodeBitmap\QRCodeBitmap\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";


#line default
#line hidden
            BeginContext(116, 196, true);
            WriteLiteral("<!DOCTYPE html>\r\n<meta name=\"viewport\" content=\"width=device-width\" />\r\n<title>Index</title>\r\n<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css\">\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(383, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(390, 1831, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa73bbf9966816b121c5dbda28500be6b15432d24525", async() => {
                BeginContext(460, 1027, true);
                WriteLiteral(@"
    <div class=""container"">
        <div class=""panel-group"">
            <div class=""panel panel-info"">
                <div class=""panel-heading"">Generate QR Code</div>
                <div class=""panel-body"">

                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""col-md-3"">Type text to generate QR Code</div>
                            <div class=""col-md-9""><input type=""text"" class=""form-control"" id=""txtQRCode"" name=""txtQRCode"" /></div>
                        </div>
                    </div>
                    <div class=""row mt-3"">
                        <div class=""col-md-12"">
                            <div class=""col-md-3""></div>
                            <div class=""col-md-9"">
                                <input type=""submit"" class=""btn btn-primary"" id=""btnSubmit"" value=""Generate QR Code"" autocomplete=""off"" />
                            </div>
                        </div>
                    </div");
                WriteLiteral(">\r\n");
                EndContext();
#line 36 "D:\JT\CoreProgramm\Blog\.NET Core\QRCodeBitmap\QRCodeBitmap\Views\Home\Index.cshtml"
                      
                        if (Model != null)
                        {

#line default
#line hidden
                BeginContext(1582, 279, true);
                WriteLiteral(@"                            <div class=""row mt-3"">
                                <div class=""col-md-12"">
                                    <div class=""col-md-3""></div>
                                    <div class=""col-md-9"">
                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1861, "\"", 1941, 1);
#line 43 "D:\JT\CoreProgramm\Blog\.NET Core\QRCodeBitmap\QRCodeBitmap\Views\Home\Index.cshtml"
WriteAttributeValue("", 1867, String.Format("data:image/png;base64,{0}", Convert.ToBase64String(Model)), 1867, 74, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1942, 150, true);
                WriteLiteral("  height=\"300\" width=\"300\"/>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
                EndContext();
#line 47 "D:\JT\CoreProgramm\Blog\.NET Core\QRCodeBitmap\QRCodeBitmap\Views\Home\Index.cshtml"
                        }
                    

#line default
#line hidden
                BeginContext(2142, 72, true);
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 15 "D:\JT\CoreProgramm\Blog\.NET Core\QRCodeBitmap\QRCodeBitmap\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2221, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Byte[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
