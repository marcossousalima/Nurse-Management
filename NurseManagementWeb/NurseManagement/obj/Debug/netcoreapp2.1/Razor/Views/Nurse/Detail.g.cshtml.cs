#pragma checksum "C:\Users\Marcos S L\Desktop\WEBNurse\NurseManagement\NurseManagement\Views\Nurse\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dedf0b13254620b25db111b54109a7fcd287e7a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nurse_Detail), @"mvc.1.0.view", @"/Views/Nurse/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Nurse/Detail.cshtml", typeof(AspNetCore.Views_Nurse_Detail))]
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
#line 1 "C:\Users\Marcos S L\Desktop\WEBNurse\NurseManagement\NurseManagement\Views\_ViewImports.cshtml"
using NurseManagement;

#line default
#line hidden
#line 2 "C:\Users\Marcos S L\Desktop\WEBNurse\NurseManagement\NurseManagement\Views\_ViewImports.cshtml"
using NurseManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dedf0b13254620b25db111b54109a7fcd287e7a1", @"/Views/Nurse/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8aa126ffe3580f29b2b0c076cb398ae215a3962", @"/Views/_ViewImports.cshtml")]
    public class Views_Nurse_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NurseManagement.Models.Nurse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-info col-md-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Marcos S L\Desktop\WEBNurse\NurseManagement\NurseManagement\Views\Nurse\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(81, 118, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <h2 class=\"text-center row col-md-10 col-md-offset-1 well alert-info\">Detalhes do Enfermeiro ");
            EndContext();
            BeginContext(200, 10, false);
#line 8 "C:\Users\Marcos S L\Desktop\WEBNurse\NurseManagement\NurseManagement\Views\Nurse\Detail.cshtml"
                                                                                            Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(210, 142, true);
            WriteLiteral("</h2>\r\n    <div class=\"col-md-10 col-md-offset-1 well\">\r\n        <div class=\"col-md-6\">\r\n            <strong>Nome</strong><br />\r\n            ");
            EndContext();
            BeginContext(353, 36, false);
#line 12 "C:\Users\Marcos S L\Desktop\WEBNurse\NurseManagement\NurseManagement\Views\Nurse\Detail.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(389, 102, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <strong>CPF</strong><br />\r\n            ");
            EndContext();
            BeginContext(492, 35, false);
#line 16 "C:\Users\Marcos S L\Desktop\WEBNurse\NurseManagement\NurseManagement\Views\Nurse\Detail.cshtml"
       Write(Html.DisplayFor(model => model.CPF));

#line default
#line hidden
            EndContext();
            BeginContext(527, 119, true);
            WriteLiteral("<br /><br />\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            <strong>N. Corem</strong><br />\r\n            ");
            EndContext();
            BeginContext(647, 37, false);
#line 20 "C:\Users\Marcos S L\Desktop\WEBNurse\NurseManagement\NurseManagement\Views\Nurse\Detail.cshtml"
       Write(Html.DisplayFor(model => model.Coren));

#line default
#line hidden
            EndContext();
            BeginContext(684, 117, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-3\">\r\n            <strong>Data de Nascimento</strong><br />\r\n            ");
            EndContext();
            BeginContext(802, 41, false);
#line 24 "C:\Users\Marcos S L\Desktop\WEBNurse\NurseManagement\NurseManagement\Views\Nurse\Detail.cshtml"
       Write(Html.DisplayFor(model => model.BirthDate));

#line default
#line hidden
            EndContext();
            BeginContext(843, 107, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <strong>Hospital</strong><br />\r\n            ");
            EndContext();
            BeginContext(951, 44, false);
#line 28 "C:\Users\Marcos S L\Desktop\WEBNurse\NurseManagement\NurseManagement\Views\Nurse\Detail.cshtml"
       Write(Html.DisplayFor(model => model.NameHospital));

#line default
#line hidden
            EndContext();
            BeginContext(995, 107, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"col-md-10 col-md-offset-1\">\r\n    <div class=\"\">\r\n        ");
            EndContext();
            BeginContext(1102, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "807c868a50914447be05da2cf9d9d7de", async() => {
                BeginContext(1155, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1165, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NurseManagement.Models.Nurse> Html { get; private set; }
    }
}
#pragma warning restore 1591
