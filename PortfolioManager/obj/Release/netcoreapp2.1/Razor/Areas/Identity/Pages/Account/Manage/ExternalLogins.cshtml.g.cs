#pragma checksum "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e9aa95e3b31d2094c1c099bd0e149408d73c994"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PortfolioManager.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_ExternalLogins), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml", typeof(PortfolioManager.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage_ExternalLogins), null)]
namespace PortfolioManager.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 3 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\_ViewImports.cshtml"
using PortfolioManager.Areas.Identity;

#line default
#line hidden
#line 1 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using PortfolioManager.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using PortfolioManager.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e9aa95e3b31d2094c1c099bd0e149408d73c994", @"/Areas/Identity/Pages/Account/Manage/ExternalLogins.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e304cbc79f0d8bba0fa9dcc6dbecdb9207c0cb29", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f8b92ae5dc7b1880d037ed2fe8a4be3e289d74", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df5d95e07011fc14b99618e1f519b4548e7a37c5", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage_ExternalLogins : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ManageNav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LoginProvider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ProviderKey", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("remove-login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "RemoveLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("link-login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "LinkLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
  
    ViewData["Title"] = "Manage your external logins";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(123, 149, true);
            WriteLiteral("<div>\r\n    <h4 class=\"text-center\">Change your account settings</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(272, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "33d7aa0bbc064456a9fee0a217ce04b5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(301, 62, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            ");
            EndContext();
            BeginContext(364, 51, false);
#line 15 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
       Write(Html.Partial("_StatusMessage", Model.StatusMessage));

#line default
#line hidden
            EndContext();
            BeginContext(415, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
             if (Model.CurrentLogins?.Count > 0)
            {

#line default
#line hidden
            BeginContext(482, 112, true);
            WriteLiteral("                <h4>Registered Logins</h4>\r\n                <table class=\"table\">\r\n                    <tbody>\r\n");
            EndContext();
#line 21 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                     foreach (var login in Model.CurrentLogins)
                    {

#line default
#line hidden
            BeginContext(682, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(745, 19, false);
#line 24 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                           Write(login.LoginProvider);

#line default
#line hidden
            EndContext();
            BeginContext(764, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 26 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                 if (Model.ShowRemoveButton)
                                {

#line default
#line hidden
            BeginContext(902, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(938, 619, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0ba8b7742aa4728a417ed68a9252310", async() => {
                BeginContext(1007, 93, true);
                WriteLiteral("\r\n                                        <div>\r\n                                            ");
                EndContext();
                BeginContext(1100, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "edc4e4d230964e6d9e9b3c5ee710e006", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 30 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.LoginProvider);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1175, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(1221, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "703f9350e03d41499a81694f72ee3ba1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 31 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.ProviderKey);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1292, 91, true);
                WriteLiteral("\r\n                                            <button type=\"submit\" class=\"btn btn-default\"");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 1383, "\"", 1447, 7);
                WriteAttributeValue("", 1391, "Remove", 1391, 6, true);
                WriteAttributeValue(" ", 1397, "this", 1398, 5, true);
#line 32 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 1402, login.LoginProvider, 1403, 20, false);

#line default
#line hidden
                WriteAttributeValue(" ", 1423, "login", 1424, 6, true);
                WriteAttributeValue(" ", 1429, "from", 1430, 5, true);
                WriteAttributeValue(" ", 1434, "your", 1435, 5, true);
                WriteAttributeValue(" ", 1439, "account", 1440, 8, true);
                EndWriteAttribute();
                BeginContext(1448, 102, true);
                WriteLiteral(">Remove</button>\r\n                                        </div>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1557, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1667, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(1705, 9, true);
            WriteLiteral(" &nbsp;\r\n");
            EndContext();
#line 39 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                }

#line default
#line hidden
            BeginContext(1749, 66, true);
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 42 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                    }

#line default
#line hidden
            BeginContext(1838, 56, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
            EndContext();
#line 45 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
            }

#line default
#line hidden
            BeginContext(1909, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 46 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
             if (Model.OtherLogins?.Count > 0)
            {

#line default
#line hidden
            BeginContext(1972, 97, true);
            WriteLiteral("                <h4>Add another service to log in.</h4>\r\n                <hr />\r\n                ");
            EndContext();
            BeginContext(2069, 618, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85d8c1d16f994699bf04df90a6e128be", async() => {
                BeginContext(2163, 79, true);
                WriteLiteral("\r\n                    <div id=\"socialLoginList\">\r\n                        <p>\r\n");
                EndContext();
#line 53 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                             foreach (var provider in Model.OtherLogins)
                            {

#line default
#line hidden
                BeginContext(2347, 116, true);
                WriteLiteral("                                <button id=\"link-login-button\" type=\"submit\" class=\"btn btn-default\" name=\"provider\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2463, "\"", 2485, 1);
#line 55 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue("", 2471, provider.Name, 2471, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 2486, "\"", 2541, 6);
                WriteAttributeValue("", 2494, "Log", 2494, 3, true);
                WriteAttributeValue(" ", 2497, "in", 2498, 3, true);
                WriteAttributeValue(" ", 2500, "using", 2501, 6, true);
                WriteAttributeValue(" ", 2506, "your", 2507, 5, true);
#line 55 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 2511, provider.DisplayName, 2512, 21, false);

#line default
#line hidden
                WriteAttributeValue(" ", 2533, "account", 2534, 8, true);
                EndWriteAttribute();
                BeginContext(2542, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2544, 20, false);
#line 55 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                                                                                                                                                                                               Write(provider.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(2564, 11, true);
                WriteLiteral("</button>\r\n");
                EndContext();
#line 56 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
                            }

#line default
#line hidden
                BeginContext(2606, 74, true);
                WriteLiteral("                        </p>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2687, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 60 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Areas\Identity\Pages\Account\Manage\ExternalLogins.cshtml"
            }

#line default
#line hidden
            BeginContext(2704, 40, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExternalLoginsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExternalLoginsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExternalLoginsModel>)PageContext?.ViewData;
        public ExternalLoginsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
