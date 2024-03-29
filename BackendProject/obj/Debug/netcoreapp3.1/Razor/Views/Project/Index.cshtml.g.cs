#pragma checksum "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Project\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aa2a540ab443894f788c369388b59f39fc59fc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Index), @"mvc.1.0.view", @"/Views/Project/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aa2a540ab443894f788c369388b59f39fc59fc0", @"/Views/Project/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32c18e2caa2a2b72724b0d8c3eda7e960334d7b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Project\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--our work or portfolio section start-->\r\n");
#nullable restore
#line 6 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Project\Index.cshtml"
  
    Html.RenderPartial("~/Views/Shared/Partials/_OurPortfolio.cshtml");

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--our work or portfolio section end-->\r\n<!--counter section start-->\r\n");
#nullable restore
#line 11 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Project\Index.cshtml"
  
    Html.RenderPartial("~/Views/Shared/Partials/_CallToAction.cshtml");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--counter section end-->
<!--our pricing section start-->
<section class=""pricing-section ptb-100 gray-light-bg"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-md-8"">
                <div class=""section-heading text-center mb-5"">
                    <h2>Affordable Pricing and Packages</h2>
                    <p CLASS=""lead"">
                        Efficiently aggregate end-to-end core competencies without maintainable ideas. Dynamically
                        foster tactical solutions without enabled value.
                    </p>
                </div>
            </div>
        </div>
        <div class=""row justify-content-center"">
            <div class=""col-lg-4 col-md"">
                <div class=""card text-center single-pricing-pack"">
                    <div class=""pt-4""><h5>Basic</h5></div>
                    <div class=""pricing-img mt-4"">
                        <img src=""../img/basic.svg"" alt=""pricing img"" class=""");
            WriteLiteral(@"img-fluid"">
                    </div>
                    <div class=""card-header py-4 border-0 pricing-header"">
                        <div class=""h1 text-center mb-0"">$<span class=""price font-weight-bolder"">29</span></div>
                    </div>
                    <div class=""card-body"">
                        <ul class=""list-unstyled text-sm mb-4 pricing-feature-list"">
                            <li>Push Notifications</li>
                            <li>Data Transfer</li>
                            <li>SQL Database</li>
                            <li>Search &amp; SEO Analytics</li>
                            <li>24/7 Phone Support</li>
                            <li>2 months technical support</li>
                            <li>2+ profitable keyword</li>
                        </ul>
                        <a href=""#"" class=""btn outline-btn mb-3"" target=""_blank"">Purchase now</a>
                    </div>
                </div>
            </div>
            <div class=""c");
            WriteLiteral(@"ol-lg-4 col-md"">
                <div class=""card popular-price text-center single-pricing-pack"">
                    <div class=""pt-4""><h5>Standard</h5></div>
                    <div class=""pricing-img mt-4"">
                        <img src=""../img/standard.svg"" alt=""pricing img"" class=""img-fluid"">
                    </div>
                    <div class=""card-header py-4 border-0 pricing-header"">
                        <div class=""h1 text-center mb-0"">$<span class=""price font-weight-bolder"">149</span></div>

                    </div>
                    <div class=""card-body"">
                        <ul class=""list-unstyled text-sm mb-4 pricing-feature-list"">
                            <li>Push Notifications</li>
                            <li>Data Transfer</li>
                            <li>SQL Database</li>
                            <li>Search &amp; SEO Analytics</li>
                            <li>24/7 Phone Support</li>
                            <li>1 Year technical suppo");
            WriteLiteral(@"rt</li>
                            <li>50+ profitable keyword</li>
                        </ul>
                        <a href=""#"" class=""btn secondary-solid-btn mb-3"" target=""_blank"">Purchase now</a>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md"">
                <div class=""card text-center single-pricing-pack"">
                    <div class=""pt-4""><h5>Unlimited</h5></div>
                    <div class=""pricing-img mt-4"">
                        <img src=""../img/unlimited.svg"" alt=""pricing img"" class=""img-fluid"">
                    </div>
                    <div class=""card-header py-4 border-0 pricing-header"">
                        <div class=""h1 text-center mb-0"">$<span class=""price font-weight-bolder"">39</span></div>
                    </div>
                    <div class=""card-body"">
                        <ul class=""list-unstyled text-sm mb-4 pricing-feature-list"">
                            <li>Push Notificat");
            WriteLiteral(@"ions</li>
                            <li>Data Transfer</li>
                            <li>SQL Database</li>
                            <li>Search &amp; SEO Analytics</li>
                            <li>24/7 Phone Support</li>
                            <li>6 months technical support</li>
                            <li>10+ profitable keyword</li>
                        </ul>
                        <a href=""#"" class=""btn outline-btn mb-3"" target=""_blank"">Purchase now</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!--our pricing section end-->
");
#nullable restore
#line 104 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Project\Index.cshtml"
  
    Html.RenderPartial("~/Views/Shared/Partials/_Testimonial.cshtml");

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Project\Index.cshtml"
  
    Html.RenderPartial("~/Views/Shared/Partials/_Services.cshtml");

#line default
#line hidden
#nullable disable
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
