#pragma checksum "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09ab5bf46e125ed5caceea4b37d8371731fe7af2"
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
#line 1 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
using FrontToBack.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09ab5bf46e125ed5caceea4b37d8371731fe7af2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d659c7348d4e555fb20961613876c08c8148db9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/h3-video-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/h1-custom-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
  
    var sums = sum.Sum(1, 2);

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- SLIDER START -->\r\n\r\n\r\n<h1>sums</h1>\r\n        <section id=\"slider\">\r\n            <div class=\"owl-carousel slider\">\r\n");
#nullable restore
#line 13 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                 foreach (var item in Model.SliderImages)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "09ab5bf46e125ed5caceea4b37d8371731fe7af26502", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 331, "~/img/", 331, 6, true);
#nullable restore
#line 15 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 337, item.ImageUrl, 337, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 16 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </div>\r\n            <div class=\"container context pl-lg-5 ml-lg-3\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-5\">\r\n                        <div class=\"text\">\r\n                            <h1>");
#nullable restore
#line 23 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                           Write(Html.Raw(Model.SliderContent.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                            <p class=\"text-black-50 d-none d-sm-block\">");
#nullable restore
#line 24 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                                  Write(Model.SliderContent.Main);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"img\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "09ab5bf46e125ed5caceea4b37d8371731fe7af29323", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 899, "~/img/", 899, 6, true);
#nullable restore
#line 27 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 905, Model.SliderContent.ImageUrl, 905, 29, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- SLIDER END -->

       <!-- PRODUCTS START -->

        <section id=""products"">
            <div class=""container"">
                <div class=""row pt-5"">
                    <div class=""col-12 d-flex justify-content-between"">
                        <ul class=""category-mobile d-md-none list-unstyled"">
                            <li>
                                <a");
            BeginWriteAttribute("href", " href=\"", 1465, "\"", 1472, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                                <i class=\"fas fa-caret-down\"></i>\r\n                                <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1715, "\"", 1722, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 48 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                     foreach (var item in Model.Categories)
                                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1909, "\"", 1916, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 50 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                        Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 50 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 51 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                       
                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                  \r\n                                </ul>\r\n                            </li>\r\n                        </ul>\r\n                        <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2308, "\"", 2315, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 60 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                             foreach (var item in Model.Categories)
                                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 2494, "\"", 2501, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 62 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                        Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 62 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 63 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                       
                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                        <ul class=\"list-unstyled\">\r\n                            <li>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2789, "\"", 2796, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">Filter</a>\r\n                                <i class=\"fas fa-caret-down\"></i>\r\n                            </li>\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n\r\n              ");
#nullable restore
#line 75 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
         Write(await Component.InvokeAsync("Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </section>

        <!-- PRODUCTS END -->

        <!-- ABOUT START -->

        <section id=""about"">
            <div class=""container py-5"">
                <div class=""row py-5"">
                    <div class=""col-lg-6"">
                        <div class=""img"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "09ab5bf46e125ed5caceea4b37d8371731fe7af216319", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <div
                                class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                                <i class=""fas fa-play fa-lg""></i>
                            </div>
                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                            <h1>Suprise Your <span>Valentine!</span> Let us arrange a smile.</h1>
                            <p class=""py-3"">Where flowers are our inspiration to create lasting memories. Whatever the
                                occasion...</p>
                            <ul class=""list-unstyled"">
                                <li class=""mt-3"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "09ab5bf46e125ed5caceea4b37d8371731fe7af218346", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" Hand picked just\r\n                                    for you.</li class=\"mt-3\">\r\n                                <li class=\"mt-3\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "09ab5bf46e125ed5caceea4b37d8371731fe7af219680", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" Unique flower\r\n                                    arrangements</li>\r\n                                <li class=\"mt-3\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "09ab5bf46e125ed5caceea4b37d8371731fe7af221000", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" Best way to say
                                    you care.</li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </section>

        <!-- ABOUT END -->

        <!-- EXPERTS START -->

        <section id=""experts"">
            <div class=""container"">
                <div class=""row py-5"">
                    <div class=""offset-lg-3 col-lg-6"">
                        <div class=""section-title"">
                            <h1>Flower Experts</h1>
                            <p class=""text-black-50"">A perfect blend of creativity, energy, communication, happiness and
                                love. Let us arrange
                                a smile for you.</p>
                        </div>
                    </div>
                </div>
                <div class=""row pb-5"">
");
#nullable restore
#line 131 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                     foreach (var item in Model.FlowerExperts)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-6 col-lg-3\">\r\n                        <div class=\"item text-center\">\r\n                            <div class=\"img\">\r\n                              \r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "09ab5bf46e125ed5caceea4b37d8371731fe7af223650", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5936, "~/img/", 5936, 6, true);
#nullable restore
#line 137 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 5942, item.ImageUrl, 5942, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"text mt-3\">\r\n                                <h6>");
#nullable restore
#line 140 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <p class=\"text-black-50\">\r\n");
#nullable restore
#line 142 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                      foreach (var expertProfessionFlowerExpert in item.ExpertProfessionFlowerExperts)
                                {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                       Write(expertProfessionFlowerExpert.ExpertProfession.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n");
#nullable restore
#line 145 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    \r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 151 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   
                  
                  
                    <div class=""col-lg-3""></div>
                    <div class=""col-lg-3""></div>
                    <div class=""col-lg-3""></div>
                </div>
            </div>
        </section>

        <!-- EXPERTS END -->

        <!-- SUBSCRIBE START -->

        <section id=""subscribe"">
            <div class=""container py-5"">
                <div class=""row py-5"">
                    <div class=""col-12"">
                        <div class=""content text-center py-5"">
                            <h3>Join The Colorful Bunch!</h3>
                            <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                                <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                                <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                            </div>
                        <");
            WriteLiteral(@"/div>
                    </div>
                </div>
            </div>
        </section>

        <!-- SUBSCRIBE END -->

        <!-- BLOG START -->

        <section id=""blog"">
            <div class=""container"">
                <div class=""row py-5"">
                    <div class=""offset-lg-3 col-lg-6"">
                        <div class=""section-title"">
                            <h1>From our Blog</h1>
                            <p class=""text-black-50"">A perfect blend of creativity, energy, communication, happiness and
                                love. Let us arrange
                                a smile for you.</p>
                        </div>
                    </div>
                </div>
                <div class=""row pb-5"">
");
#nullable restore
#line 199 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                     foreach (var item in Model.Blogs)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                         <div class=\"col-md-6 col-lg-4\">\r\n                        <div class=\"item\">\r\n                            <div class=\"img position-relative\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "09ab5bf46e125ed5caceea4b37d8371731fe7af229396", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8773, "~/img/", 8773, 6, true);
#nullable restore
#line 204 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 8779, item.ImageUrl, 8779, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"date rounded bg-light position-absolute py-1 px-2\">\r\n                                    <span>");
#nullable restore
#line 206 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                     Write(item.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"text mt-3 text-center px-5\">\r\n                                <h5>");
#nullable restore
#line 210 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"text-black-50\">");
#nullable restore
#line 211 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                    Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 215 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                  
                   
                </div>
            </div>
        </section>

        <!-- BLOG END -->

        <!-- SAY START -->

       <section id=""say"">
            <div class=""container"">
                <div class=""row py-5 justify-content-center"">
                    <div class=""col-md-8 col-xl-6"">
                        <div class=""owl-carousel say"">
");
#nullable restore
#line 231 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                             foreach (var item in Model.BlogSliders)
                           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <div>\r\n                                <div class=\"item text-center\">\r\n                                    <div class=\"img d-flex justify-content-center\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 10126, "\"", 10150, 2);
            WriteAttributeValue("", 10132, "img/", 10132, 4, true);
#nullable restore
#line 236 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
WriteAttributeValue("", 10136, item.ImageUrl, 10136, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 10151, "\"", 10157, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"text text-muted pt-3 pb-5\">\r\n                                        <i>");
#nullable restore
#line 239 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                      Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </i>\r\n                                    </div>\r\n                                    <div class=\"author\">\r\n                                        <h6>");
#nullable restore
#line 242 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                       Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <p class=\"text-black-50\">");
#nullable restore
#line 243 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                                                            Write(item.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 247 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                           
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    
                        </div>
                    </div>
                </div>
            </div>
        </section>


        <!-- SAY END -->

        <!-- INSTAGRAM START -->

        <section id=""instagram"">
            <div class=""owl-carousel instagram"">
");
#nullable restore
#line 263 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                 foreach (var item in Model.InstagramImagesSliders)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "09ab5bf46e125ed5caceea4b37d8371731fe7af236287", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 11192, "~/img/", 11192, 6, true);
#nullable restore
#line 265 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 11198, item.ImageUrl, 11198, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 266 "C:\Users\Lenovo\Desktop\FrontToBack\FrontToBack\FrontToBack\Views\Home\Index.cshtml"
                   
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </div>\r\n            <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n                #FIORELLO\r\n            </div>\r\n        </section>\r\n\r\n        <!-- INSTAGRAM END -->\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ISum sum { get; private set; } = default!;
        #nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
