#pragma checksum "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42795b883f263b330f6211f138868b7f86140d36"
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
#line 1 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\_ViewImports.cshtml"
using PortfolioManager;

#line default
#line hidden
#line 2 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\_ViewImports.cshtml"
using PortfolioManager.Models;

#line default
#line hidden
#line 1 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42795b883f263b330f6211f138868b7f86140d36", @"/Views/Home/Posts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"295a18029dcd8dc1afcbdeefa3038450df69024b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Posts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PortfolioManager.Models.ViewModels.PostViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Posts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
  
    Layout = "_Layout";
    ViewData["ActivePage"] = "Posts";

#line default
#line hidden
            BeginContext(175, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
 if (ViewBag.IsSuccess == true)
{

#line default
#line hidden
            BeginContext(213, 205, true);
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n        <strong>Success!</strong> The database has been adjusted.\r\n    </div>\r\n");
            EndContext();
#line 14 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
}
else if (ViewBag.IsSuccess == false)
{
    {

#line default
#line hidden
            BeginContext(469, 232, true);
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <a href=\"#\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">&times;</a>\r\n            <strong>Error!</strong> Something went wrong, please contact support.\r\n        </div>\r\n");
            EndContext();
#line 22 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
    }
}

#line default
#line hidden
            BeginContext(711, 468, true);
            WriteLiteral(@"

<div class=""col-8 mx-auto"">
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Main image</th>
                <th scope=""col"">Title</th>
                <th scope=""col"">Publish Date</th>
                <th><button type=""button"" class=""btn btn-success create-post""><i class=""fas fa-plus""></i></button></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 38 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
             foreach (var post in Model)
            {

#line default
#line hidden
            BeginContext(1236, 58, true);
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
            EndContext();
            BeginContext(1295, 7, false);
#line 41 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                               Write(post.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1302, 92, true);
            WriteLiteral("</th>\r\n                    <td><img height=\"150\" width=\"150\" style=\"object-fit: scale-down;\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1394, "\"", 1418, 1);
#line 42 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
WriteAttributeValue("", 1400, post.MainImageUrl, 1400, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1419, 33, true);
            WriteLiteral("/></td>\r\n                    <td>");
            EndContext();
            BeginContext(1453, 13, false);
#line 43 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                   Write(post.PostName);

#line default
#line hidden
            EndContext();
            BeginContext(1466, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1498, 48, false);
#line 44 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                   Write(post.PublishDate.ToString("MM/dd/yyyy hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(1546, 78, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        <button data-postid=\"");
            EndContext();
            BeginContext(1625, 7, false);
#line 46 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                                        Write(post.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1632, 17, true);
            WriteLiteral("\" data-postname=\"");
            EndContext();
            BeginContext(1650, 13, false);
#line 46 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                                                                 Write(post.PostName);

#line default
#line hidden
            EndContext();
            BeginContext(1663, 17, true);
            WriteLiteral("\" data-postdesc=\"");
            EndContext();
            BeginContext(1681, 12, false);
#line 46 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                                                                                                Write(post.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1693, 22, true);
            WriteLiteral("\" data-postmainimage=\"");
            EndContext();
            BeginContext(1716, 17, false);
#line 46 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                                                                                                                                   Write(post.MainImageUrl);

#line default
#line hidden
            EndContext();
            BeginContext(1733, 133, true);
            WriteLiteral("\" type=\"button\" class=\"btn btn-primary edit-post\"><i class=\"fas fa-edit\"></i></button>\r\n                        <button data-postid=\"");
            EndContext();
            BeginContext(1867, 7, false);
#line 47 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                                        Write(post.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1874, 17, true);
            WriteLiteral("\" data-postname=\"");
            EndContext();
            BeginContext(1892, 13, false);
#line 47 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
                                                                 Write(post.PostName);

#line default
#line hidden
            EndContext();
            BeginContext(1905, 144, true);
            WriteLiteral("\" type=\"button\" class=\"btn btn-danger delete-post\"><i class=\"far fa-trash-alt\"></i></button>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 50 "C:\Users\Thomas\Documents\GitHub\PortfolioManager\PortfolioManager\Views\Home\Posts.cshtml"
            }

#line default
#line hidden
            BeginContext(2064, 801, true);
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
            BeginContext(2865, 414, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "531a2a841b7249eebb9a0055c00c0aef", async() => {
                BeginContext(2926, 346, true);
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
            BeginContext(3279, 635, true);
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
            BeginContext(3914, 1656, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9b6e710d328408f932e155122d593d0", async() => {
                BeginContext(4005, 1558, true);
                WriteLiteral(@"
                <input name=""Action"" type=""hidden"" value=""create"" />

                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label name=""PostName"">Post Title</label>
                        <input type=""text"" name=""PostName"" class=""form-control"" />
                    </div>
                    <div class=""form-group"">

                        <div class=""custom-file"">
                            <label id=""create-file-label"" class=""custom-file-label"">Main post image</label>
                            <input id=""create-file-input"" name=""MainImage"" type=""file"" class=""custom-file-input"" accept=""image/*""/>
                        </div>
                        <br/>
                        <br/>
                        <div class=""text-center"">
                            <img id=""create-image-preview"" alt=""post-main-image"" width=""100"" height=""100""/>
                        </div>

                    </div>
                    <div c");
                WriteLiteral(@"lass=""form-group"">
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5570, 609, true);
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
            BeginContext(6179, 1606, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f84f6673cbd0429e9bb3f3ca86293e78", async() => {
                BeginContext(6270, 1508, true);
                WriteLiteral(@"
                <input name=""Action"" type=""hidden"" value=""edit"" />
                <input name=""Id"" type=""hidden"" id=""edit-post-id"" />

                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label name=""PostName"">Post Title</label>
                        <input type=""text"" name=""PostName"" class=""form-control"" id=""edit-post-name"" />
                    </div>

                    <div class=""custom-file"">
                        <label id=""edit-file-label"" class=""custom-file-label"">Profile Picture</label>
                        <input id=""edit-file-input"" name=""MainImage"" type=""file"" class=""custom-file-input"" accept=""image/*"" />
                    </div>
                    <br />
                    <br />
                    <div class=""text-center"">
                        <img id=""edit-image-preview"" alt=""post-main-image"" width=""100"" height=""100"" />
                    </div>

                    <div class=""form-group"">
     ");
                WriteLiteral(@"                   <label>Post Description</label>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7785, 42, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7845, 4084, true);
                WriteLiteral(@"
    <script>
        $("".delete-post"").on('click',
            function() {
                var t = $(this);
                var postId = t.data(""postid"");
                var postName = t.data(""postname"");

                $('#postId').val(postId);
                $('#postName').text(postName);

                $(""#delete-post-modal"").modal({ show: true, keyboard: false, backdrop: 'static' });
            });
        $("".create-post"").on('click',
            function() {
                $(""#create-post-modal"").modal({ show: true, keyboard: false, backdrop: 'static' });
            });
        $("".edit-post"").on('click',
            function() {
                var t = $(this);
                var postId = t.data(""postid"");
                var postName = t.data(""postname"");
                var postDesc = t.data(""postdesc"");
                var postMainImage = t.data(""postmainimage"");

                $('#edit-post-id').val(postId);
                $('#edit-post-name').val(postName);");
                WriteLiteral(@"
                $('#edit-post-desc').val(postDesc);

                $('#edit-image-preview').attr(""src"", `${postMainImage}`);
                $('#edit-image-preview').fadeIn(650);

                // First we need to destroy summernote in order to reset the text value
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

                $(""#edit-pos");
                WriteLiteral(@"t-modal"").modal({ show: true, keyboard: false, backdrop: 'static' });
            });

        $('#create-post-editor').summernote({
            placeholder: 'Your content',
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

        // EDIT Main Image Upload
        function readURLEdit(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function(e) {
                    $('#edit-image-preview').attr('src', e.target.result);
                    $('#edit-image-preview').hide();
                    $('#");
                WriteLiteral(@"edit-file-label').text(input.files[0].name);
                    $('#edit-image-preview').fadeIn(650);
                }
                reader.readAsDataURL(input.files[0]);
            }
        }

        $(""#edit-file-input"").change(function() {
            readURLEdit(this);
        });

        // Create Main Image Upload
        function readURLCreate(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function(e) {
                    $('#create-image-preview').attr('src', e.target.result);
                    $('#create-image-preview').hide();
                    $('#create-file-label').text(input.files[0].name);
                    $('#create-image-preview').fadeIn(650);
                }
                reader.readAsDataURL(input.files[0]);
            }
        }

        $(""#create-file-input"").change(function() {
            readURLCreate(this);
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
