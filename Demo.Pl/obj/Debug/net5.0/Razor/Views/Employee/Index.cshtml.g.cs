#pragma checksum "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3171b7722e2b989dca10eaedec92f60db54df95c25882935f0f315c2761b67e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3171b7722e2b989dca10eaedec92f60db54df95c25882935f0f315c2761b67e1", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f98528534122105b8cbf84005133f278429c0abb18fe3696f779b4c8c6527930", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row offset-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(" Employee Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "All Employees";
    

#line default
#line hidden
#nullable disable

#nullable restore
#line 6 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
 if (TempData["Message"] is not null)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"alert alert-success\">\r\n        ");
            Write(
#nullable restore
#line 9 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
         TempData["Message"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 11 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
}


#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3171b7722e2b989dca10eaedec92f60db54df95c25882935f0f315c2761b67e18753", async() => {
                WriteLiteral(" Create New Employee");
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
            WriteLiteral("\r\n");
#nullable restore
#line 25 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <h1>All Employees</h1>\r\n    <br/>\r\n    <div class=\"m-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3171b7722e2b989dca10eaedec92f60db54df95c25882935f0f315c2761b67e110351", async() => {
                WriteLiteral(@"
            <div class=""col-8"">
                <input class="" form-control"" type=""text"" name=""SearchValue"" placeholder=""Employee,s Name "" />
            </div>
            <div class=""col-4"">
                <input type=""submit"" class=""btn btn-info"" value=""Search"" />
            </div>

        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n     </div>\r\n");
            WriteLiteral("    <table class=\"table table-striped table-hover mt-3\">\r\n        <thead>\r\n            \r\n                <tr>\r\n                  <td>");
            Write(
#nullable restore
#line 46 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                       Html.DisplayNameFor(M=>M.ImageName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 47 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         Html.DisplayNameFor(D => D.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 48 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         Html.DisplayNameFor(D => D.Age)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 49 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         Html.DisplayNameFor(D => D.Salary)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 50 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         Html.DisplayNameFor(D => D.Department)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 51 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         Html.DisplayNameFor(D => D.Address)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 52 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         Html.DisplayNameFor(D => D.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 53 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         Html.DisplayNameFor(D => D.Phone)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 54 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         Html.DisplayNameFor(D => D.HireDate)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 55 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         Html.DisplayNameFor(D => D.IsActive)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                   \r\n                    <td> Details</td>\r\n                    <td> Update</td>\r\n                    <td> Delete</td>\r\n                </tr>\r\n            \r\n\r\n\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 66 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
             foreach (var employee in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <tr>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3171b7722e2b989dca10eaedec92f60db54df95c25882935f0f315c2761b67e116374", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2028, "~/Files/Images/", 2028, 15, true);
            AddHtmlAttributeValue("", 2043, 
#nullable restore
#line 69 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                                                  employee.ImageName

#line default
#line hidden
#nullable disable
            , 2043, 19, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 70 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         employee.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 71 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         employee.Age

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 72 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         Html.DisplayFor(E => employee.Salary)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td >\r\n                    <td>");
            Write(
#nullable restore
#line 73 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         Html.DisplayFor(E => employee.Department.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        \r\n                    <td>");
            Write(
#nullable restore
#line 75 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         employee.Address

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 76 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         Html.DisplayFor(E => employee.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 77 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         employee.Phone

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 78 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                         employee.HireDate

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                   \r\n                     <td>\r\n");
#nullable restore
#line 81 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                           if( employee.IsActive==true)
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <i class=\"fa-solid fa-circle\" style=\"color:green\"></i>\r\n");
#nullable restore
#line 84 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable

            WriteLiteral("                            <i class=\"fa-solid fa-circle\" style=\"color:red\"></i>\r\n");
#nullable restore
#line 88 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n                     </td>\r\n");
            WriteLiteral("                    <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3171b7722e2b989dca10eaedec92f60db54df95c25882935f0f315c2761b67e122193", async() => {
                WriteLiteral(" <i class=\"fas fa-eye\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 92 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                                                                employee.Id

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
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3171b7722e2b989dca10eaedec92f60db54df95c25882935f0f315c2761b67e124498", async() => {
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 93 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                                                            employee.Id

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3171b7722e2b989dca10eaedec92f60db54df95c25882935f0f315c2761b67e126802", async() => {
                WriteLiteral("<i class=\"fas fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 94 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
                                                              employee.Id

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
            WriteLiteral("</td>\r\n                   \r\n\r\n                </tr>\r\n");
#nullable restore
#line 98 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 102 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\" mt-5 alert alert-warning\">\r\n        <h2>\r\n            There Is No Employee\r\n        </h2>\r\n\r\n    </div>\r\n");
#nullable restore
#line 111 "F:\Route\Route C42\Cycle42\05 MVC\G03\Session 03\Demo.MVC.Group03\Demo.Pl\Views\Employee\Index.cshtml"

}

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
