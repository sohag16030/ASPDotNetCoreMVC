#pragma checksum "H:\ASPDotNetMVC\DailyExpense\DailyExpense.Web\Controllers\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca24f7ef6d9dc6c0c81ce93a86455ff7f42351d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Controllers_Register), @"mvc.1.0.view", @"/Controllers/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca24f7ef6d9dc6c0c81ce93a86455ff7f42351d6", @"/Controllers/Register.cshtml")]
    public class Controllers_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DailyExpense.Web.Models.RegisterModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "H:\ASPDotNetMVC\DailyExpense\DailyExpense.Web\Controllers\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "H:\ASPDotNetMVC\DailyExpense\DailyExpense.Web\Controllers\Register.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <form");
            BeginWriteAttribute("asp-route-returnUrl", " asp-route-returnUrl=\"", 185, "\"", 223, 1);
#nullable restore
#line 11 "H:\ASPDotNetMVC\DailyExpense\DailyExpense.Web\Controllers\Register.cshtml"
WriteAttributeValue("", 207, Model.ReturnUrl, 207, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" method=""post"">
            <h4>Create a new account.</h4>
            <hr />
            <div asp-validation-summary=""All"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Input.Email""></label>
                <input asp-for=""Input.Email"" class=""form-control"" />
                <span asp-validation-for=""Input.Email"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Input.Password""></label>
                <input asp-for=""Input.Password"" class=""form-control"" />
                <span asp-validation-for=""Input.Password"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Input.ConfirmPassword""></label>
                <input asp-for=""Input.ConfirmPassword"" class=""form-control"" />
                <span asp-validation-for=""Input.ConfirmPassword"" class=""text-danger""></span>
            </div>
            <button type=""sub");
            WriteLiteral("mit\" class=\"btn btn-primary\">Register</button>\r\n        </form>\r\n    </div>\r\n    <div class=\"col-md-6 col-md-offset-2\">\r\n        <section>\r\n            <h4>Use another service to register.</h4>\r\n            <hr />\r\n");
#nullable restore
#line 37 "H:\ASPDotNetMVC\DailyExpense\DailyExpense.Web\Controllers\Register.cshtml"
              
                if ((Model.ExternalLogins?.Count ?? 0) == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div>
                        <p>
                            There are no external authentication services configured. See <a href=""https://go.microsoft.com/fwlink/?LinkID=532715"">this article</a>
                            for details on setting up this ASP.NET application to support logging in via external services.
                        </p>
                    </div>
");
#nullable restore
#line 46 "H:\ASPDotNetMVC\DailyExpense\DailyExpense.Web\Controllers\Register.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <form id=\"external-account\" asp-page=\"./ExternalLogin\"");
            BeginWriteAttribute("asp-route-returnUrl", " asp-route-returnUrl=\"", 2098, "\"", 2136, 1);
#nullable restore
#line 49 "H:\ASPDotNetMVC\DailyExpense\DailyExpense.Web\Controllers\Register.cshtml"
WriteAttributeValue("", 2120, Model.ReturnUrl, 2120, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" method=\"post\" class=\"form-horizontal\">\r\n                        <div>\r\n                            <p>\r\n");
#nullable restore
#line 52 "H:\ASPDotNetMVC\DailyExpense\DailyExpense.Web\Controllers\Register.cshtml"
                                 foreach (var provider in Model.ExternalLogins)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <button type=\"submit\" class=\"btn btn-primary\" name=\"provider\"");
            BeginWriteAttribute("value", " value=\"", 2455, "\"", 2477, 1);
#nullable restore
#line 54 "H:\ASPDotNetMVC\DailyExpense\DailyExpense.Web\Controllers\Register.cshtml"
WriteAttributeValue("", 2463, provider.Name, 2463, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2478, "\"", 2533, 6);
            WriteAttributeValue("", 2486, "Log", 2486, 3, true);
            WriteAttributeValue(" ", 2489, "in", 2490, 3, true);
            WriteAttributeValue(" ", 2492, "using", 2493, 6, true);
            WriteAttributeValue(" ", 2498, "your", 2499, 5, true);
#nullable restore
#line 54 "H:\ASPDotNetMVC\DailyExpense\DailyExpense.Web\Controllers\Register.cshtml"
WriteAttributeValue(" ", 2503, provider.DisplayName, 2504, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2525, "account", 2526, 8, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 54 "H:\ASPDotNetMVC\DailyExpense\DailyExpense.Web\Controllers\Register.cshtml"
                                                                                                                                                                            Write(provider.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 55 "H:\ASPDotNetMVC\DailyExpense\DailyExpense.Web\Controllers\Register.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </p>\r\n                        </div>\r\n                    </form>\r\n");
#nullable restore
#line 59 "H:\ASPDotNetMVC\DailyExpense\DailyExpense.Web\Controllers\Register.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </section>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <partial name=\"_ValidationScriptsPartial\" />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DailyExpense.Web.Models.RegisterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
