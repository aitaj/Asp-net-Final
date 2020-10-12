#pragma checksum "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60a323d66f0833bf9f2fdb503c71e6eea95447e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a323d66f0833bf9f2fdb503c71e6eea95447e0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32c18e2caa2a2b72724b0d8c3eda7e960334d7b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--body content wrap start-->\r\n<div class=\"main\">\r\n\r\n    <!--hero section start-->\r\n  \r\n    <section class=\"hero-equal-height pt-165 pb-100 gradient-overly-right-light\"");
            BeginWriteAttribute("style", " style=\"", 240, "\"", 350, 8);
            WriteAttributeValue("", 248, "background:", 248, 11, true);
            WriteAttributeValue(" ", 259, "url(\'../img/", 260, 13, true);
#nullable restore
#line 12 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 272, Model.HomeHeroSliders.FirstOrDefault().Image, 272, 45, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 317, "\')no-repeat", 317, 11, true);
            WriteAttributeValue(" ", 328, "center", 329, 7, true);
            WriteAttributeValue(" ", 335, "center", 336, 7, true);
            WriteAttributeValue(" ", 342, "/", 343, 2, true);
            WriteAttributeValue(" ", 344, "cover", 345, 6, true);
            EndWriteAttribute();
            WriteLiteral(@">

       
            <div class=""container"">
                <div class=""row"">

                    <div class=""col-md-7 col-lg-6"">

                        <div class=""hero-slider-content"">

                            <span class=""text-uppercase"">Total Business Solutions</span>
                            <h1>");
#nullable restore
#line 23 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
                           Write(Model.HomeHeroSliders.FirstOrDefault().Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <p class=\"lead\">");
#nullable restore
#line 24 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
                                       Write(Model.HomeHeroSliders.FirstOrDefault().Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                            <div class=""action-btns mt-3"">
                                <a href=""#"" class=""btn secondary-solid-btn"">Get Start Now</a>
                            </div>

                        </div>


                    </div>


                </div>
            </div>
        

    </section>
    
        <!--hero section end-->
        <!--promo section start-->
        <section class=""promo-block ptb-100 mt--165 z-index position-relative"">
            <div class=""container"">
               
                <div class=""row"">
");
#nullable restore
#line 48 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
                     foreach (var item in Model.PromoBlocks)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-md-4 col-lg-4"">
                            <div class=""single-promo-block promo-hover-bg-1 hover-image shadow-lg p-5 custom-radius white-bg"">


                                <div class=""promo-block-icon mb-3"">
                                    <span");
            BeginWriteAttribute("class", " class=\"", 1788, "\"", 1828, 3);
#nullable restore
#line 55 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 1796, item.Icon, 1796, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1806, "icon-md", 1807, 8, true);
            WriteAttributeValue(" ", 1814, "color-primary", 1815, 14, true);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                                </div>\r\n                                <div class=\"promo-block-content\">\r\n                                    <h5>");
#nullable restore
#line 58 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
                                   Write(item.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <p>");
#nullable restore
#line 59 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
                                  Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 63 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
      
                </div>
            </div>
        </section>
        <!--promo section end-->
        <section class=""about-us-section pb-100"">
            <div class=""container"">
                <div class=""row justify-content-between align-items-center"">
                    <div class=""col-md-12 col-lg-6"">
                        <div class=""video-promo-content mb-md-4 mb-lg-0"">
                            <h2>");
#nullable restore
#line 75 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
                           Write(Model.AboutUsText.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p class=\"lead\">\r\n                               ");
#nullable restore
#line 77 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
                          Write(Model.AboutUsText.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                           \r\n                            <ul class=\"list-unstyled tech-feature-list\">\r\n                               \r\n");
#nullable restore
#line 82 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
                                 foreach (var s in Model.Services.Take(4))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"py-1\"><span class=\"ti-control-forward mr-2 color-secondary\"></span><strong>");
#nullable restore
#line 84 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
                                                                                                                     Write(s.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> </li>\r\n");
#nullable restore
#line 85 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
                                    
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </ul>
                            <div class=""action-btns mt-4"">
                                <a href=""#"" class=""btn primary-solid-btn mr-2"">View Our Services</a>
                                <a href=""#"" class=""btn outline-btn"">Contact Us</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-12 col-lg-6"">
                        <div class=""image-wrap"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 3777, "\"", 3811, 2);
            WriteAttributeValue("", 3783, "img/", 3783, 4, true);
#nullable restore
#line 97 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 3787, Model.AboutUsText.Photo, 3787, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"video\" class=\"img-fluid rounded\">\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n");
#nullable restore
#line 103 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
          
            Html.RenderPartial("~/Views/Shared/Partials/_Services.cshtml",model:Model.ServicesCards);
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!--promo section start-->\r\n");
#nullable restore
#line 107 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
          
            Html.RenderPartial("~/Views/Shared/Partials/_PromoSection.cshtml");
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!--promo section end-->\r\n");
#nullable restore
#line 111 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
          
            Html.RenderPartial("~/Views/Shared/Partials/_OurPortfolio.cshtml");
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
          
            Html.RenderPartial("~/Views/Shared/Partials/_OurBlog.cshtml");
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
          
            Html.RenderPartial("~/Views/Shared/Partials/_Testimonial.cshtml");
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!--team two section start-->\r\n");
#nullable restore
#line 121 "C:\Users\Lenovo Legion\source\repos\BackendProject\BackendProject\Views\Home\Index.cshtml"
          
            Html.RenderPartial("~/Views/Shared/Partials/_TeamTwo.cshtml");
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <!--team two section end-->
        <!--call to action section start-->
        <section class=""call-to-action py-5"">
            <div class=""container"">
                <div class=""row justify-content-around align-items-center"">
                    <div class=""col-md-7"">
                        <div class=""subscribe-content"">
                            <h3 class=""mb-1"">Consulting Agency for Your Business</h3>
                            <p>Rapidiously engage fully tested e-commerce with progressive architectures.</p>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""action-btn text-lg-right text-sm-left"">
                            <a href=""#"" class=""btn secondary-solid-btn"">Contact With Us</a>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!--call to action section end-->

    </div>
<!--body content wrap end--");
            WriteLiteral(">\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
