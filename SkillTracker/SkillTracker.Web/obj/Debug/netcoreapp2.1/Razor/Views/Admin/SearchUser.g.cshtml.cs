#pragma checksum "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60ef3397bc048bca03f43f5c69be89e7a7fcca92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_SearchUser), @"mvc.1.0.view", @"/Views/Admin/SearchUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/SearchUser.cshtml", typeof(AspNetCore.Views_Admin_SearchUser))]
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
#line 1 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\_ViewImports.cshtml"
using SkillTracker.Web;

#line default
#line hidden
#line 2 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\_ViewImports.cshtml"
using SkillTracker.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60ef3397bc048bca03f43f5c69be89e7a7fcca92", @"/Views/Admin/SearchUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"658683c35201882e49be2989cbc26aa4dd6ea3d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_SearchUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SkillTracker.Entities.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml"
  
    ViewData["Title"] = "SearchUser";

#line default
#line hidden
            BeginContext(81, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(92, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98286a52a3324ddd9b43ebc7636b99e9", async() => {
                BeginContext(136, 12, true);
                WriteLiteral("Back to home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(152, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
            BeginContext(160, 3831, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee4ad103a9c843a1b6643977d7c3aac7", async() => {
                BeginContext(168, 2016, true);
                WriteLiteral(@"
    <label class=""control-label"">Search By :</label>
    <div class=""row "">
        
        <div class=""col-lg-3"">
            <div >
                <label class=""control-label"">First Name</label>
                <input id=""FirstName"" name=""FirstName"" class=""form-control"" title=""First Name"" placeholder=""First Name""  />
               <input type=""submit"" value=""First Name"" class=""btn btn-primary"" formaction=""/Admin/InspectUserByFirstName"" formmethod=""post"" />
            </div>
        </div>



        <div class=""col-lg-3"">

            <div class=""form-group"">
                <label class=""control-label"">Email</label>
                <input id=""email"" name=""email"" class=""form-control"" placeholder=""Email"" />
                <input type=""submit"" value="" Email"" class=""btn  btn-primary"" formaction=""/Admin/InspectUserByEmail"" formmethod=""post"" />
            </div>
        </div>



        <div class=""col-lg-3"">
            <div class=""search-container"">
                <label cla");
                WriteLiteral(@"ss=""control-label"">Mobile Number</label>
                <input id=""mobilenumber"" name=""mobilenumber"" class=""form-control"" placeholder=""Mobile Number"" />
                <br />
                <input type=""submit"" value=""Mobile Number"" class=""btn btn-primary"" formaction=""/Admin/InspectUserByMobile"" formmethod=""post"" />
            </div>
        </div>



        <div class=""col-lg-3"">
            <div class=""sea"">
                <label class=""control-label"">Skill Range</label>
                <input type=""range"" id=""start"" name=""start"" class=""form-control"" placeholder=""Start Value"" />&nbsp;&nbsp;&nbsp;
               <br />
                <input type=""submit"" value=""Skill Range"" class=""btn btn-primary"" formaction=""/Admin/InspectUserBySkillRange"" formmethod=""post"" />
            </div>
        </div>
    </div>

    <div class=""row"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        ");
                EndContext();
                BeginContext(2185, 45, false);
#line 60 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(2230, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(2310, 44, false);
#line 63 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(2354, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(2434, 41, false);
#line 66 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2475, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(2555, 42, false);
#line 69 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.Mobile));

#line default
#line hidden
                EndContext();
                BeginContext(2597, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(2677, 45, false);
#line 72 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml"
                   Write(Html.DisplayNameFor(model => model.MapSkills));

#line default
#line hidden
                EndContext();
                BeginContext(2722, 126, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
                EndContext();
#line 78 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml"
                 if ( Model !=null)
                {



#line default
#line hidden
                BeginContext(2908, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2981, 45, false);
#line 84 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml"
                   Write(Html.DisplayFor(modelItem => Model.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(3026, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(3106, 44, false);
#line 87 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml"
                   Write(Html.DisplayFor(modelItem => Model.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(3150, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(3230, 41, false);
#line 90 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml"
                   Write(Html.DisplayFor(modelItem => Model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(3271, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(3351, 42, false);
#line 93 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml"
                   Write(Html.DisplayFor(modelItem => Model.Mobile));

#line default
#line hidden
                EndContext();
                BeginContext(3393, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(3473, 45, false);
#line 96 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml"
                   Write(Html.DisplayFor(modelItem => Model.MapSkills));

#line default
#line hidden
                EndContext();
                BeginContext(3518, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(3598, 65, false);
#line 99 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(3663, 28, true);
                WriteLiteral(" |\r\n                        ");
                EndContext();
                BeginContext(3692, 71, false);
#line 100 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(3763, 28, true);
                WriteLiteral(" |\r\n                        ");
                EndContext();
                BeginContext(3792, 69, false);
#line 101 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
                EndContext();
                BeginContext(3861, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 104 "F:\varsha_Kone\IIHT\CaseStudy\Junior FSE PA\CodeTemplate\SkillTracker\SkillTracker\SkillTracker.Web\Views\Admin\SearchUser.cshtml"
                }

#line default
#line hidden
                BeginContext(3932, 52, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SkillTracker.Entities.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
