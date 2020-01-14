#pragma checksum "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0899f887cf828f22cf693c2c374f902e8cb1a0ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_News), @"mvc.1.0.view", @"/Views/Home/News.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/News.cshtml", typeof(AspNetCore.Views_Home_News))]
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
#line 1 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\_ViewImports.cshtml"
using PortfolioManager;

#line default
#line hidden
#line 2 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\_ViewImports.cshtml"
using PortfolioManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0899f887cf828f22cf693c2c374f902e8cb1a0ba", @"/Views/Home/News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"295a18029dcd8dc1afcbdeefa3038450df69024b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PortfolioManager.Models.ViewModels.NewsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\News.cshtml"
  
    Layout = "_Layout";
    ViewData["ActivePage"] = "News";

#line default
#line hidden
            BeginContext(140, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\News.cshtml"
 if (ViewBag.IsSuccess == true)
{

#line default
#line hidden
            BeginContext(178, 205, true);
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n        <strong>Success!</strong> The database has been adjusted.\r\n    </div>\r\n");
            EndContext();
#line 13 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\News.cshtml"
}
else if (ViewBag.IsSuccess == false)
{
    {

#line default
#line hidden
            BeginContext(434, 232, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n            <strong>Error!</strong> Something went wrong, please contact support.\r\n        </div>\r\n");
            EndContext();
#line 21 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\News.cshtml"
    }
}

#line default
#line hidden
            BeginContext(676, 419, true);
            WriteLiteral(@"

<div class=""col-8 mx-auto"">
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Title</th>
                <th scope=""col"">Publish Date</th>
                <th><button type=""button"" class=""btn btn-success create-news""><i class=""fas fa-plus""></i></button></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 36 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\News.cshtml"
             foreach (var news in Model)
            {

#line default
#line hidden
            BeginContext(1152, 58, true);
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
            EndContext();
            BeginContext(1211, 7, false);
#line 39 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\News.cshtml"
                               Write(news.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1218, 31, true);
            WriteLiteral("</th>\r\n                    <td>");
            EndContext();
            BeginContext(1250, 14, false);
#line 40 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\News.cshtml"
                   Write(news.NewsTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1264, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1296, 52, false);
#line 41 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\News.cshtml"
                   Write(news.NewsPublishDate.ToString("MM/dd/yyyy hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(1348, 78, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <button data-newsid=\"");
            EndContext();
            BeginContext(1427, 7, false);
#line 43 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\News.cshtml"
                                        Write(news.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1434, 18, true);
            WriteLiteral("\" data-newstitle=\"");
            EndContext();
            BeginContext(1453, 14, false);
#line 43 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\News.cshtml"
                                                                  Write(news.NewsTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1467, 20, true);
            WriteLiteral("\" data-newscontent=\"");
            EndContext();
            BeginContext(1488, 16, false);
#line 43 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\News.cshtml"
                                                                                                     Write(news.NewsContent);

#line default
#line hidden
            EndContext();
            BeginContext(1504, 133, true);
            WriteLiteral("\" type=\"button\" class=\"btn btn-primary edit-news\"><i class=\"fas fa-edit\"></i></button>\r\n                        <button data-newsid=\"");
            EndContext();
            BeginContext(1638, 7, false);
#line 44 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\News.cshtml"
                                        Write(news.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1645, 18, true);
            WriteLiteral("\" data-newstitle=\"");
            EndContext();
            BeginContext(1664, 14, false);
#line 44 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\News.cshtml"
                                                                  Write(news.NewsTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1678, 144, true);
            WriteLiteral("\" type=\"button\" class=\"btn btn-danger delete-news\"><i class=\"far fa-trash-alt\"></i></button>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 47 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\News.cshtml"
            }

#line default
#line hidden
            BeginContext(1837, 802, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>

<!-- Delete Modal -->
<div class=""modal fade"" id=""delete-news-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Delete News</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Are you sure you want to delete <strong id=""newsTitle""></strong>?
            </div>
            <div class=""modal-footer"">
                ");
            EndContext();
            BeginContext(2639, 413, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "452b9e58eae94d048e8071d69e280d0d", async() => {
                BeginContext(2699, 346, true);
                WriteLiteral(@"
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <input name=""Id"" type=""hidden"" id=""newsId"" />
                    <input name=""Action"" type=""hidden"" value=""delete"" />
                    <button type=""submit"" class=""btn btn-danger"">Delete</button>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3052, 635, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<!-- Create Modal -->
<div class=""modal fade"" id=""create-news-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Create News</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            EndContext();
            BeginContext(3687, 949, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "681f202ae11746778c5f0e1c2d04a8c2", async() => {
                BeginContext(3747, 882, true);
                WriteLiteral(@"
                <input name=""Action"" type=""hidden"" value=""create"" />

                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label name=""NewsTitle"">News Title</label>
                        <input type=""text"" name=""NewsTitle"" class=""form-control"" />
                    </div>
                    <div class=""form-group"">
                        <label>News Content</label>
                        <textarea class=""form-control"" name=""NewsContent"" rows=""3"" id=""create-news-editor""></textarea>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""submit"" class=""btn btn-success"">Create</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4636, 609, true);
            WriteLiteral(@"
        </div>
    </div>
</div>

<!-- Edit Modal -->
<div class=""modal fade"" id=""edit-news-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Edit Post</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            EndContext();
            BeginContext(5245, 1035, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4341cf6e40a4f2d8deeb0be40126290", async() => {
                BeginContext(5305, 968, true);
                WriteLiteral(@"
                <input name=""Action"" type=""hidden"" value=""edit"" />
                <input name=""Id"" type=""hidden"" id=""edit-news-id"" />

                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label name=""NewsName"">News Title</label>
                        <input type=""text"" name=""NewsTitle"" class=""form-control"" id=""edit-news-title"" />
                    </div>
                    <div class=""form-group"">
                        <label>News Content</label>
                        <textarea class=""form-control"" name=""NewsContent"" rows=""3"" id=""edit-news-content""></textarea>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""submit"" class=""btn btn-success"">Update</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6280, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6337, 2547, true);
                WriteLiteral(@"
    <script>
        $("".delete-news"").on('click',
            function () {
                var t = $(this);
                var newsId = t.data(""newsid"");
                var newsTitle = t.data(""newstitle"");

                $('#newsId').val(newsId);
                $('#newsTitle').text(newsTitle);

                $(""#delete-news-modal"").modal({ show: true, keyboard: false, backdrop: 'static' });
            });
        $("".create-news"").on('click',
            function () {
                $(""#create-news-modal"").modal({ show: true, keyboard: false, backdrop: 'static' });
            });
        $("".edit-news"").on('click',
            function () {
                var t = $(this);
                var newsId = t.data(""newsid"");
                var newsTitle = t.data(""newstitle"");
                var newsContent = t.data(""newscontent"");

                $('#edit-news-id').val(newsId);
                $('#edit-news-title').val(newsTitle);
                $('#edit-news-content').val");
                WriteLiteral(@"(newsContent);

                // First we need to destroy summernote in order to reset the text value
                $('#edit-news-content').summernote('destroy');

                // Init SummerNote
                $('#edit-news-content').summernote({
                    tabsize: 2,
                    height: 100,
                    toolbar: [
                        ['style', ['style']],
                        ['font', ['bold', 'underline', 'clear']],
                        ['color', ['color']],
                        ['para', ['ul', 'ol', 'paragraph']],
                        ['table', ['table']],
                        ['insert', ['link', 'picture', 'video']],
                        ['view', ['fullscreen', 'codeview', 'help', 'undo', 'redo']]
                    ]
                });

                $(""#edit-news-modal"").modal({ show: true, keyboard: false, backdrop: 'static' });
            });

        $('#create-news-editor').summernote({
            placeholder: 'Yo");
                WriteLiteral(@"ur content',
            tabsize: 2,
            height: 100,
            toolbar: [
                ['style', ['style']],
                ['font', ['bold', 'underline', 'clear']],
                ['color', ['color']],
                ['para', ['ul', 'ol', 'paragraph']],
                ['table', ['table']],
                ['insert', ['link', 'picture', 'video']],
                ['view', ['fullscreen', 'codeview', 'help', 'undo', 'redo']]
            ]
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PortfolioManager.Models.ViewModels.NewsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
