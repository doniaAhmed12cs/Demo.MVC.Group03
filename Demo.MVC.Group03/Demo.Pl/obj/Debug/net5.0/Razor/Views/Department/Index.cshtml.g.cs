#pragma checksum "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a80498fcbeb2ef2d49a08bfc450d6b03215cb4eef085f747f78849f1e0a4d9ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\_ViewImports.cshtml"
using Demo.Pl

#nullable disable
    ;
#nullable restore
#line 2 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\_ViewImports.cshtml"
using Demo.Pl.Models

#nullable disable
    ;
#nullable restore
#line 3 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\_ViewImports.cshtml"
using Demo.DAL.Models

#nullable disable
    ;
#nullable restore
#line 4 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\_ViewImports.cshtml"
using Demo.Pl.ViewModels

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a80498fcbeb2ef2d49a08bfc450d6b03215cb4eef085f747f78849f1e0a4d9ba", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f98528534122105b8cbf84005133f278429c0abb18fe3696f779b4c8c6527930", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Department>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "All Departments";
    string ViewDataMessage = ViewData["Message"] as string;
     //  Enforce Type Safty => Strongly Typed
    string ViewBagMessage = ViewBag.Message;
     // Doesnot Enforce Type Saftey => Weakly Typed 


#line default
#line hidden
#nullable disable

            WriteLiteral("<div class=\"alert alert-success\">\r\n    ");
            Write(
#nullable restore
#line 11 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml"
     TempData["Message"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</div>\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a80498fcbeb2ef2d49a08bfc450d6b03215cb4eef085f747f78849f1e0a4d9ba6056", async() => {
                WriteLiteral(" Create New Department");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 24 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml"
 if (Model.Count() > 0)

{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <h1> All Departments</h1>\r\n    <br />\r\n    <table class=\" table table-striped table-hover mt-3\">\r\n        <thead>\r\n        <td> ");
            Write(
#nullable restore
#line 31 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml"
              Html.DisplayNameFor(D => D.Code)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n        <td> ");
            Write(
#nullable restore
#line 32 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml"
              Html.DisplayNameFor(D => D.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n        <td> ");
            Write(
#nullable restore
#line 33 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml"
              Html.DisplayNameFor(D => D.DateOfCreation)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n        <td> Details</td>\r\n        <td> Update</td>\r\n        <td> Delete</td>\r\n\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 40 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml"
             foreach (var department in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <tr>\r\n                    <td>");
            Write(
#nullable restore
#line 43 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml"
                         department.Code

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 44 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml"
                         department.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 45 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml"
                         department.DateOfCreation

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a80498fcbeb2ef2d49a08bfc450d6b03215cb4eef085f747f78849f1e0a4d9ba10143", async() => {
                WriteLiteral("<i class=\"fas fa-eye\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 47 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml"
                                                               department.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a80498fcbeb2ef2d49a08bfc450d6b03215cb4eef085f747f78849f1e0a4d9ba12454", async() => {
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 49 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml"
                                                            department.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("   </td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a80498fcbeb2ef2d49a08bfc450d6b03215cb4eef085f747f78849f1e0a4d9ba14762", async() => {
                WriteLiteral("<i class=\"fas fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 50 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml"
                                                              department.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 54 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 58 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"mt-5 alert alert-warning\">\r\n        <h3>  There Is No Department</h3>\r\n\r\n    </div>\r\n");
#nullable restore
#line 65 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Department\Index.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Department>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
