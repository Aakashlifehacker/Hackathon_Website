#pragma checksum "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Faq/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dc3a35a1c9192afec10b7163f1021ad85d024f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faq_Edit), @"mvc.1.0.view", @"/Views/Faq/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Faq/Edit.cshtml", typeof(AspNetCore.Views_Faq_Edit))]
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
#line 1 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/_ViewImports.cshtml"
using HackAtCewitManagementSystem;

#line default
#line hidden
#line 3 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/_ViewImports.cshtml"
using HackAtCewitManagementSystem.Models;

#line default
#line hidden
#line 4 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/_ViewImports.cshtml"
using HackAtCewitManagementSystem.Models.AccountViewModels;

#line default
#line hidden
#line 5 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/_ViewImports.cshtml"
using HackAtCewitManagementSystem.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dc3a35a1c9192afec10b7163f1021ad85d024f2", @"/Views/Faq/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9850bc5e39616953c51bc9b6b6e6fb4dca3609eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Faq_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Faq>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Faq/Edit.cshtml"
  
    ViewData["Title"] = "Edit Faq";

#line default
#line hidden
            BeginContext(52, 397, true);
            WriteLiteral(@"<section>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 my-auto"">
                <div class=""container-fluid text-center"">
                    <h3>Edit Faq</h3>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12 my-auto"">
                <div class=""container-fluid"">
                    ");
            EndContext();
            BeginContext(449, 1372, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e86453a75b62490db0f4c371c8460a2c", async() => {
                BeginContext(469, 174, true);
                WriteLiteral("\n                        <table id=\"add\">\n                            <tbody>\n                                <tr>\n                                    <td style=\"width:30%;\">");
                EndContext();
                BeginContext(644, 30, false);
#line 21 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Faq/Edit.cshtml"
                                                      Write(Html.LabelFor(m => m.Question));

#line default
#line hidden
                EndContext();
                BeginContext(674, 106, true);
                WriteLiteral("</td>\n                                    <td style=\"width:70%;\">\n                                        ");
                EndContext();
                BeginContext(781, 57, false);
#line 23 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Faq/Edit.cshtml"
                                   Write(Html.TextBoxFor(m => m.Question, new { @class = "text" }));

#line default
#line hidden
                EndContext();
                BeginContext(838, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(880, 74, false);
#line 24 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Faq/Edit.cshtml"
                                   Write(Html.ValidationMessage("Question", "", new { @class = "text-danger" }, ""));

#line default
#line hidden
                EndContext();
                BeginContext(954, 177, true);
                WriteLiteral("\n                                    </td>\n                                </tr>\n                                <tr>\n                                    <td style=\"width:30%;\">");
                EndContext();
                BeginContext(1132, 28, false);
#line 28 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Faq/Edit.cshtml"
                                                      Write(Html.LabelFor(m => m.Answer));

#line default
#line hidden
                EndContext();
                BeginContext(1160, 106, true);
                WriteLiteral("</td>\n                                    <td style=\"width:70%;\">\n                                        ");
                EndContext();
                BeginContext(1267, 56, false);
#line 30 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Faq/Edit.cshtml"
                                   Write(Html.TextAreaFor(m => m.Answer, new { @class = "text" }));

#line default
#line hidden
                EndContext();
                BeginContext(1323, 41, true);
                WriteLiteral("\n                                        ");
                EndContext();
                BeginContext(1365, 72, false);
#line 31 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Faq/Edit.cshtml"
                                   Write(Html.ValidationMessage("Answer", "", new { @class = "text-danger" }, ""));

#line default
#line hidden
                EndContext();
                BeginContext(1437, 377, true);
                WriteLiteral(@"
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan=""2"" style=""margin: auto;""><input class=""button"" type=""submit"" value=""Edit"" /></td>
                                </tr>
                            </tbody>
                        </table>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1821, 80, true);
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</section>\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(1918, 10, true);
                WriteLiteral("\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1928, "\"", 1969, 1);
#line 46 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Faq/Edit.cshtml"
WriteAttributeValue("", 1935, Url.Content("~/css/Faq/Edit.css"), 1935, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1970, 37, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\n");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(2027, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(2033, 52, false);
#line 49 "/Users/chaitanyakalantri/Desktop/CEVIT/Rohan_Latest/HackAtCewitManagementSystem/HackAtCewitManagementSystem/Views/Faq/Edit.cshtml"
Write(await Html.PartialAsync("_ValidationScriptsPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(2085, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Faq> Html { get; private set; }
    }
}
#pragma warning restore 1591
