#pragma checksum "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Blog\LeftSidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b94f1ef9ba6d52a70dfc0392d6e4186541087f32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_LeftSidebar), @"mvc.1.0.view", @"/Views/Blog/LeftSidebar.cshtml")]
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
#line 1 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\_ViewImports.cshtml"
using BackendProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\_ViewImports.cshtml"
using BackendProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\_ViewImports.cshtml"
using BackendProject.Models.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b94f1ef9ba6d52a70dfc0392d6e4186541087f32", @"/Views/Blog/LeftSidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32c18e2caa2a2b72724b0d8c3eda7e960334d7b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_LeftSidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-md-block d-lg-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("comment-form row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Blog\LeftSidebar.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Blog\LeftSidebar.cshtml"
  
    Html.RenderPartial("~/Views/Shared/Partials/_Hero.cshtml");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--blog section start-->
<div class=""module ptb-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-4"">
                <div class=""sidebar-left pr-4"">

                    <!-- Search widget-->
                    <aside class=""widget widget-search"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b94f1ef9ba6d52a70dfc0392d6e4186541087f325699", async() => {
                WriteLiteral("\r\n                            <input class=\"form-control\" type=\"search\" placeholder=\"Type Search Words\">\r\n                            <button class=\"search-button\" type=\"submit\"><span class=\"ti-search\"></span></button>\r\n                        ");
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
            WriteLiteral(@"
                    </aside>


                    <!-- Categories widget-->
                    <aside class=""widget widget-categories"">
                        <div class=""widget-title"">
                            <h6>Categories</h6>
                        </div>
                        <ul>
                            <li><a href=""#"">Journey <span class=""float-right"">112</span></a></li>
                            <li><a href=""#"">Development <span class=""float-right"">86</span></a></li>
                            <li><a href=""#"">Sport <span class=""float-right"">10</span></a></li>
                            <li><a href=""#"">Photography <span class=""float-right"">144</span></a></li>
                            <li><a href=""#"">Symphony <span class=""float-right"">18</span></a></li>
                        </ul>
                    </aside>

                    <!-- Recent entries widget-->
                    <aside class=""widget widget-recent-entries-custom"">
                        <div c");
            WriteLiteral(@"lass=""widget-title"">
                            <h6>Recent Posts</h6>
                        </div>
                        <ul>
                            <li class=""clearfix"">
                                <div class=""wi""><a href=""#""><img src=""../img/blog/1.jpg"" alt=""recent post"" class=""img-fluid rounded"" /></a></div>
                                <div class=""wb""><a href=""#"">Map where your photos were taken and discover local points.</a><span class=""post-date"">May 8, 2016</span></div>
                            </li>
                            <li class=""clearfix"">
                                <div class=""wi""><a href=""#""><img src=""../img/blog/2.jpg"" alt=""recent post"" class=""img-fluid rounded"" /></a></div>
                                <div class=""wb""><a href=""#"">Map where your photos were taken and discover local points.</a><span class=""post-date"">May 8, 2016</span></div>
                            </li>
                            <li class=""clearfix"">
                          ");
            WriteLiteral(@"      <div class=""wi""><a href=""#""><img src=""../img/blog/3.jpg"" alt=""recent post"" class=""img-fluid rounded"" /></a></div>
                                <div class=""wb""><a href=""#"">Map where your photos were taken and discover local points.</a><span class=""post-date"">May 8, 2016</span></div>
                            </li>
                        </ul>
                    </aside>

                    <!-- Subscribe widget-->
                    <aside class=""widget widget-categories"">
                        <div class=""widget-title"">
                            <h6>Newsletter</h6>
                        </div>
                        <p>Enter your email address below to subscribe to my newsletter</p>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b94f1ef9ba6d52a70dfc0392d6e4186541087f3210133", async() => {
                WriteLiteral(@"
                            <input type=""text"" class=""form-control input"" id=""email-footer"" name=""email""
                                   placeholder=""info@yourdomain.com"">
                            <button type=""submit"" class=""btn secondary-solid-btn btn-block btn-not-rounded mt-3"">Subscribe</button>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </aside>

                    <!-- Tags widget-->
                    <aside class=""widget widget-tag-cloud"">
                        <div class=""widget-title"">
                            <h6>Tags</h6>
                        </div>
                        <div class=""tag-cloud""><a href=""#"">e-commerce</a><a href=""#"">portfolio</a><a href=""#"">responsive</a><a href=""#"">bootstrap</a><a href=""#"">business</a><a href=""#"">corporate</a></div>
                    </aside>
                </div>
            </div>
            <div class=""col-lg-8 col-md-8"">
                <!-- Post-->
                <article class=""post"">
                    <div class=""post-preview""><img src=""../img/blog/1-w.jpg"" alt=""article"" class=""img-fluid"" /></div>
                    <div class=""post-wrapper"">
                        <div class=""post-header"">
                            <h1 class=""post-title"">Minimalist Chandelier</h1>
                            <ul class=""post-meta"">
                 ");
            WriteLiteral(@"               <li>November 18, 2016</li>
                                <li>In <a href=""#"">Branding</a>, <a href=""#"">Design</a></li>
                                <li><a href=""#"">3 Comments</a></li>
                            </ul>
                        </div>
                        <div class=""post-content"">
                            <p>Meh synth Schlitz, tempor duis single-origin coffee ea next level ethnic fingerstache fanny pack nostrud. Seitan High Life reprehenderit consectetur cupidatat kogi about me. Photo booth anim 8-bit hella, PBR 3 wolf moon beard Helvetica. Salvia esse nihil, flexitarian Truffaut synth art party deep v chillwave. Seitan High Life reprehenderit consectetur cupidatat kogi.</p>
                            <p>Exercitation photo booth stumptown tote bag Banksy, elit small batch freegan sed. Craft beer elit seitan exercitation, photo booth et 8-bit kale chips proident chillwave deep v laborum. Aliquip veniam delectus, Marfa eiusmod Pinterest in do umami readymade swag.");
            WriteLiteral(@" Selfies iPhone Kickstarter, drinking vinegar jean shorts fixie consequat flexitarian four loko.</p>
                            <blockquote class=""blockquote"">
                                <p>To be yourself in a world that is constantly trying to make you something else is the greatest accomplishment.</p>
                                <footer class=""blockquote-footer"">Amanda Pollock, Google Inc.</footer>
                            </blockquote>
                            <p>Meh synth Schlitz, tempor duis single-origin coffee ea next level ethnic fingerstache fanny pack nostrud. Seitan High Life reprehenderit consectetur cupidatat kogi about me. Photo booth anim 8-bit hella, PBR 3 wolf moon beard Helvetica.</p>
                            <p>Meh synth Schlitz, tempor duis single-origin coffee ea next level ethnic fingerstache fanny pack nostrud. Seitan High Life reprehenderit consectetur cupidatat kogi about me. Photo booth anim 8-bit hella, PBR 3 wolf moon beard Helvetica. Salvia esse nihil, fle");
            WriteLiteral(@"xitarian Truffaut synth art party deep v chillwave. Seitan High Life reprehenderit consectetur cupidatat kogi.</p>
                            <ol>
                                <li>Digital Strategy</li>
                                <li>Software Development</li>
                                <li>Interaction Design</li>
                            </ol>
                            <p>Meh synth Schlitz, tempor duis single-origin coffee ea next level ethnic fingerstache fanny pack nostrud. Seitan High Life reprehenderit consectetur cupidatat kogi about me. Photo booth anim 8-bit hella, PBR 3 wolf moon beard Helvetica.</p>
                            <p>Exercitation photo booth stumptown tote bag Banksy, elit small batch freegan sed. Craft beer elit seitan exercitation, photo booth et 8-bit kale chips proident chillwave deep v laborum. Aliquip veniam delectus, Marfa eiusmod Pinterest in do umami readymade swag. Selfies iPhone Kickstarter, drinking vinegar jean shorts fixie consequat flexitarian four");
            WriteLiteral(@" loko.</p>
                        </div>
                        <div class=""post-footer"">
                            <div class=""post-tags""><a href=""#"">Lifestyle</a><a href=""#"">Music</a><a href=""#"">News</a><a href=""#"">Travel</a></div>
                        </div>
                    </div>
                </article>
                <!-- Post end-->
                <!-- Comments area-->
                <div class=""comments-area mb-5"">
                    <h5 class=""comments-title"">3 Comments</h5>
                    <div class=""comment-list"">
                        <!-- Comment-->
                        <div class=""comment"">
                            <div class=""comment-author""><img class=""avatar img-fluid rounded-circle"" src=""../img/client-2.jpg"" alt=""comment"" /></div>
                            <div class=""comment-body"">
                                <div class=""comment-meta"">
                                    <div class=""comment-meta-author""><a href=""#"">Jason Ford</a></div>
 ");
            WriteLiteral(@"                                   <div class=""comment-meta-date""><a href=""#"">May 5, 2015 at 4:51 am</a></div>
                                </div>
                                <div class=""comment-content"">
                                    <p>Meh synth Schlitz, tempor duis single-origin coffee ea next level ethnic fingerstache fanny pack nostrud. Seitan High Life reprehenderit consectetur cupidatat kogi about me. Photo booth anim 8-bit hella, PBR 3 wolf moon beard Helvetica.</p>
                                </div>
                                <div class=""comment-reply""><a href=""#"">Reply</a></div>
                            </div>
                            <!-- Subcomment-->
                            <div class=""children"">
                                <div class=""comment"">
                                    <div class=""comment-author""><img class=""avatar img-fluid rounded-circle"" src=""../img/client-3.jpg"" alt=""comment"" /></div>
                                    <div class=""co");
            WriteLiteral(@"mment-body"">
                                        <div class=""comment-meta"">
                                            <div class=""comment-meta-author""><a href=""#"">Harry Benson</a></div>
                                            <div class=""comment-meta-date""><a href=""#"">May 5, 2015 at 4:51 am</a></div>
                                        </div>
                                        <div class=""comment-content"">
                                            <p>Meh synth Schlitz, tempor duis single-origin coffee ea next level ethnic fingerstache fanny pack nostrud. Seitan High Life reprehenderit consectetur cupidatat kogi about me. Photo booth anim 8-bit hella.</p>
                                        </div>
                                        <div class=""comment-reply""><a href=""#"">Reply</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- Comment-");
            WriteLiteral(@"->
                        <div class=""comment"">
                            <div class=""comment-author""><img class=""avatar img-fluid rounded-circle"" src=""../img/client-4.jpg"" alt=""comment"" /></div>
                            <div class=""comment-body"">
                                <div class=""comment-meta"">
                                    <div class=""comment-meta-author""><a href=""#"">Henry Cain</a></div>
                                    <div class=""comment-meta-date""><a href=""#"">May 5, 2015 at 4:51 am</a></div>
                                </div>
                                <div class=""comment-content"">
                                    <p>Meh synth Schlitz, tempor duis single-origin coffee ea next level ethnic fingerstache fanny pack nostrud. Seitan High Life reprehenderit consectetur cupidatat kogi about me. Photo booth anim 8-bit hella, PBR 3 wolf moon beard Helvetica.</p>
                                </div>
                                <div class=""comment-reply""><a href");
            WriteLiteral(@"=""#"">Reply</a></div>
                            </div>
                        </div>
                    </div>
                    <div class=""comment-respond"">
                        <h5 class=""comment-reply-title"">Leave a Reply</h5>
                        <p class=""comment-notes"">Your email address will not be published. Required fields are marked</p>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b94f1ef9ba6d52a70dfc0392d6e4186541087f3221075", async() => {
                WriteLiteral(@"
                            <div class=""form-group col-md-4"">
                                <input class=""form-control"" type=""text"" placeholder=""Name"">
                            </div>
                            <div class=""form-group col-md-4"">
                                <input class=""form-control"" type=""text"" placeholder=""Email"">
                            </div>
                            <div class=""form-group col-md-4"">
                                <input class=""form-control"" type=""url"" placeholder=""Website"">
                            </div>
                            <div class=""form-group col-md-12"">
                                <textarea class=""form-control"" rows=""8"" placeholder=""Comment""></textarea>
                            </div>
                            <div class=""form-submit col-md-12"">
                                <button class=""btn secondary-solid-btn"" type=""submit"">Post Comment</button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <!-- Comments area end-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!--blog section end-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
