#pragma checksum "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "570e33cd4a32c472603824839f5ab9908e8e9457"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Posts), @"mvc.1.0.view", @"/Views/Home/Posts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Posts.cshtml", typeof(AspNetCore.Views_Home_Posts))]
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
#line 1 "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\_ViewImports.cshtml"
using PortfolioManager;

#line default
#line hidden
#line 2 "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\_ViewImports.cshtml"
using PortfolioManager.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"570e33cd4a32c472603824839f5ab9908e8e9457", @"/Views/Home/Posts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"295a18029dcd8dc1afcbdeefa3038450df69024b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Posts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PortfolioManager.Models.ViewModels.PostViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
  
    Layout = "_Layout";
    ViewData["ActivePage"] = "Posts";

#line default
#line hidden
            BeginContext(141, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
 if (ViewBag.IsSuccess == true)
{

#line default
#line hidden
            BeginContext(179, 205, true);
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n        <strong>Success!</strong> The database has been adjusted.\r\n    </div>\r\n");
            EndContext();
#line 13 "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
}
else if (ViewBag.IsSuccess == false)
{
    {

#line default
#line hidden
            BeginContext(435, 232, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n            <strong>Error!</strong> Something went wrong, please contact support.\r\n        </div>\r\n");
            EndContext();
#line 21 "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
    }
}

#line default
#line hidden
            BeginContext(677, 419, true);
            WriteLiteral(@"

<div class=""col-8 mx-auto"">
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Title</th>
                <th scope=""col"">Publish Date</th>
                <th><button type=""button"" class=""btn btn-success create-post""><i class=""fas fa-plus""></i></button></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 36 "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
             foreach (var post in Model)
            {

#line default
#line hidden
            BeginContext(1153, 58, true);
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
            EndContext();
            BeginContext(1212, 7, false);
#line 39 "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                               Write(post.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1219, 31, true);
            WriteLiteral("</th>\r\n                    <td>");
            EndContext();
            BeginContext(1251, 13, false);
#line 40 "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                   Write(post.PostName);

#line default
#line hidden
            EndContext();
            BeginContext(1264, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1296, 48, false);
#line 41 "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                   Write(post.PublishDate.ToString("MM/dd/yyyy hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(1344, 78, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <button data-postid=\"");
            EndContext();
            BeginContext(1423, 7, false);
#line 43 "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                                        Write(post.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1430, 17, true);
            WriteLiteral("\" data-postname=\"");
            EndContext();
            BeginContext(1448, 13, false);
#line 43 "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                                                                 Write(post.PostName);

#line default
#line hidden
            EndContext();
            BeginContext(1461, 17, true);
            WriteLiteral("\" data-postdesc=\"");
            EndContext();
            BeginContext(1479, 12, false);
#line 43 "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                                                                                                Write(post.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1491, 133, true);
            WriteLiteral("\" type=\"button\" class=\"btn btn-primary edit-post\"><i class=\"fas fa-edit\"></i></button>\r\n                        <button data-postid=\"");
            EndContext();
            BeginContext(1625, 7, false);
#line 44 "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                                        Write(post.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1632, 17, true);
            WriteLiteral("\" data-postname=\"");
            EndContext();
            BeginContext(1650, 13, false);
#line 44 "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                                                                 Write(post.PostName);

#line default
#line hidden
            EndContext();
            BeginContext(1663, 144, true);
            WriteLiteral("\" type=\"button\" class=\"btn btn-danger delete-post\"><i class=\"far fa-trash-alt\"></i></button>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 47 "C:\Users\Thomas\source\repos\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
            }

#line default
#line hidden
            BeginContext(1822, 801, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>

<!-- Delete Modal -->
<div class=""modal fade"" id=""delete-post-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Delete Post</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Are you sure you want to delete <strong id=""postName""></strong>?
            </div>
            <div class=""modal-footer"">
                ");
            EndContext();
            BeginContext(2623, 414, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dc520403a6c48019467e0bd891396bc", async() => {
                BeginContext(2684, 346, true);
                WriteLiteral(@"
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <input name=""Id"" type=""hidden"" id=""postId"" />
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
            BeginContext(3037, 635, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<!-- Create Modal -->
<div class=""modal fade"" id=""create-post-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Create Post</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            EndContext();
            BeginContext(3672, 969, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bd50178fcbd42aea7045f10d23263fb", async() => {
                BeginContext(3733, 901, true);
                WriteLiteral(@"
                <input name=""Action"" type=""hidden"" value=""create"" />

                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label name=""PostName"">Post Title</label>
                        <input type=""text"" name=""PostName"" class=""form-control"" />
                    </div>
                    <div class=""form-group"">
                        <label>Post Description</label>
                        <textarea class=""form-control"" style=""height: auto"" name=""Content"" rows=""3"" id=""create-post-editor""></textarea>
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
            BeginContext(4641, 609, true);
            WriteLiteral(@"
        </div>
    </div>
</div>

<!-- Edit Modal -->
<div class=""modal fade"" id=""edit-post-modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
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
            BeginContext(5250, 1030, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88461afbbba54871a4f3328477bbe9b9", async() => {
                BeginContext(5311, 962, true);
                WriteLiteral(@"
                <input name=""Action"" type=""hidden"" value=""edit"" />
                <input name=""Id"" type=""hidden"" id=""edit-post-id"" />

                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label name=""PostName"">Post Title</label>
                        <input type=""text"" name=""PostName"" class=""form-control"" id=""edit-post-name""/>
                    </div>
                    <div class=""form-group"">
                        <label>Post Description</label>
                        <textarea class=""form-control"" name=""Content"" rows=""3"" id=""edit-post-desc""></textarea>
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
            BeginContext(6280, 42, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6340, 2521, true);
                WriteLiteral(@"
    <script>
        $("".delete-post"").on('click',
            function () {
                var t = $(this);
                var postId = t.data(""postid"");
                var postName = t.data(""postname"");

                $('#postId').val(postId);
                $('#postName').text(postName);

                $(""#delete-post-modal"").modal({ show: true, keyboard: false, backdrop: 'static' });
            });
        $("".create-post"").on('click',
            function () {
                $(""#create-post-modal"").modal({ show: true, keyboard: false, backdrop: 'static' });
            });
        $("".edit-post"").on('click',
            function () {
                var t = $(this);
                var postId = t.data(""postid"");
                var postName = t.data(""postname"");
                var postDesc = t.data(""postdesc"");

                $('#edit-post-id').val(postId);
                $('#edit-post-name').val(postName);
                $('#edit-post-desc').val(postDesc);

  ");
                WriteLiteral(@"              // First we need to destroy summernote in order to reset the text value
                $('#edit-post-desc').summernote('destroy');

                //Init Summer note
                $('#edit-post-desc').summernote({
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

                $(""#edit-post-modal"").modal({ show: true, keyboard: false, backdrop: 'static' });
            });

        $('#create-post-editor').summernote({
            placeholder: 'Your content',
            ");
                WriteLiteral(@"tabsize: 2,
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PortfolioManager.Models.ViewModels.PostViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
