#pragma checksum "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36fb69965dcc5b64dbd9fdd0cc0dbb03fa25c3e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_GetQuestions), @"mvc.1.0.view", @"/Views/Questions/GetQuestions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36fb69965dcc5b64dbd9fdd0cc0dbb03fa25c3e4", @"/Views/Questions/GetQuestions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c370c7e632d27da47731bfbecf5788b35d7233", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_GetQuestions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuestionsDataAccess.Models.QuestionEntity>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
  
    ViewData["Title"] = "GetQuestions";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
           Write(Html.DisplayNameFor(model => model.Section));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <div id=accordion\">\r\n");
#nullable restore
#line 23 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
             foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td style=\"word-wrap: break-word\">\r\n                                <div class=\"card\">\r\n                                    <div class=\"card-header\"");
            BeginWriteAttribute("id", " id=\"", 688, "\"", 727, 2);
            WriteAttributeValue("", 693, "questionHeading-", 693, 16, true);
#nullable restore
#line 27 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
WriteAttributeValue("", 709, item.QuestionId, 709, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <button class=\"btn btn-link btn-block\" data-toggle=\"collapse\" data-target=\"#questionId-");
#nullable restore
#line 28 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
                                                                                                                           Write(item.QuestionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\">\r\n                                            ");
#nullable restore
#line 29 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.QuestionString));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </button>\r\n                                    </div>\r\n                                    \r\n                                    <div");
            BeginWriteAttribute("id", " id=\"", 1171, "\"", 1205, 2);
            WriteAttributeValue("", 1176, "questionId-", 1176, 11, true);
#nullable restore
#line 33 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
WriteAttributeValue("", 1187, item.QuestionId, 1187, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1223, "\"", 1275, 2);
            WriteAttributeValue("", 1241, "questionHeading-", 1241, 16, true);
#nullable restore
#line 33 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
WriteAttributeValue("", 1257, item.QuestionId, 1257, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 34 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
                                         foreach (var choice in item.AnswerChoices)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <button type=\"button\" class=\"btn btn-light btn-block\">\r\n                                                <input type=\"radio\"");
            BeginWriteAttribute("id", " id=\"", 1574, "\"", 1629, 4);
            WriteAttributeValue("", 1579, "choiceId-", 1579, 9, true);
#nullable restore
#line 37 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
WriteAttributeValue("", 1588, item.QuestionId, 1588, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1606, "-letter", 1606, 7, true);
#nullable restore
#line 37 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
WriteAttributeValue("", 1613, choice.Choice, 1613, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1630, "\"", 1670, 2);
            WriteAttributeValue("", 1637, "questionChoice-", 1637, 15, true);
#nullable restore
#line 37 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
WriteAttributeValue("", 1652, item.QuestionId, 1652, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                <label");
            BeginWriteAttribute("for", " for=\"", 1730, "\"", 1786, 4);
            WriteAttributeValue("", 1736, "choiceId-", 1736, 9, true);
#nullable restore
#line 38 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
WriteAttributeValue("", 1745, item.QuestionId, 1745, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1763, "-letter", 1763, 7, true);
#nullable restore
#line 38 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
WriteAttributeValue("", 1770, choice.Choice, 1770, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
                                                                                                           Write(Html.DisplayFor(modelItem => choice.Choice));

#line default
#line hidden
#nullable disable
            WriteLiteral(".) ");
#nullable restore
#line 38 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
                                                                                                                                                          Write(Html.DisplayFor(modelItem => choice.Details));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label><br />\r\n                                            </button>\r\n");
#nullable restore
#line 40 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 45 "C:\Users\jarel\DAT-App\QuestionModule\QuestionsMVC\Views\Questions\GetQuestions.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </tbody>\r\n</table>\r\n\r\n<br />\r\n");
            WriteLiteral("\r\n<button type=\"button\" class=\"btn btn-danger btn-lg btn-block\">\r\n    Finish Exam\r\n</button>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuestionsDataAccess.Models.QuestionEntity>> Html { get; private set; }
    }
}
#pragma warning restore 1591
