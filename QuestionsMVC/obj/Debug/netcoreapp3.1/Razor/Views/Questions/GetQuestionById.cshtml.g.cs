#pragma checksum "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestionById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a47ca3b0a731dc1b2cf9e4456b4208691f402e22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_GetQuestionById), @"mvc.1.0.view", @"/Views/Questions/GetQuestionById.cshtml")]
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
#line 1 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\_ViewImports.cshtml"
using QuestionsMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\_ViewImports.cshtml"
using QuestionsMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a47ca3b0a731dc1b2cf9e4456b4208691f402e22", @"/Views/Questions/GetQuestionById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c370c7e632d27da47731bfbecf5788b35d7233", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_GetQuestionById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionsDataAccess.Models.QuestionEntity>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetQuestions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestionById.cshtml"
  
    ViewData["Title"] = "GetQuestionById";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div>\r\n");
            WriteLiteral("    <hr />\r\n    <br />\r\n    <dl class=\"row\">\r\n");
            WriteLiteral("        <dd class = \"col-sm-10\">\r\n            <strong>");
#nullable restore
#line 25 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestionById.cshtml"
               Write(Html.DisplayFor(model => model.QuestionString));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        </dd>\r\n");
            WriteLiteral("    </dl>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a47ca3b0a731dc1b2cf9e4456b4208691f402e224611", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 73 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestionById.cshtml"
     foreach (var item in Model.AnswerChoices)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\r\n            <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 2352, "\"", 2399, 1);
#nullable restore
#line 76 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestionById.cshtml"
WriteAttributeValue("", 2357, Html.DisplayFor(modelItem => item.Choice), 2357, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"choices\"");
                BeginWriteAttribute("value", " value=\"", 2415, "\"", 2465, 1);
#nullable restore
#line 76 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestionById.cshtml"
WriteAttributeValue("", 2423, Html.DisplayFor(modelItem => item.Choice), 2423, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <label");
                BeginWriteAttribute("for", " for=\"", 2489, "\"", 2537, 1);
#nullable restore
#line 77 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestionById.cshtml"
WriteAttributeValue("", 2495, Html.DisplayFor(modelItem => item.Choice), 2495, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 77 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestionById.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.Choice));

#line default
#line hidden
#nullable disable
                WriteLiteral(".) <span>");
#nullable restore
#line 77 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestionById.cshtml"
                                                                                                                  Write(Html.DisplayFor(modelItem => item.Details));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></label><br />\r\n        </div>\r\n");
#nullable restore
#line 79 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestionById.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<br />\r\n<br />\r\n<div>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-1\">\r\n            Bookmark Question\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestionById.cshtml"
       Write(Html.DisplayFor(model => model.IsBookmarked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a47ca3b0a731dc1b2cf9e4456b4208691f402e228879", async() => {
                WriteLiteral("Back to Questions List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionsDataAccess.Models.QuestionEntity> Html { get; private set; }
    }
}
#pragma warning restore 1591
