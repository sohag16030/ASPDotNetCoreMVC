#pragma checksum "H:\ASP.netCoreMVC\ASPDotNetMVC\MBSTU.LibrarySystem\MBSTU.LibrarySystem.WEB\Areas\User\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5664671eeee267e8868d79b37b3e2a0c760aa54c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/User/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/User/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Areas_User_Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5664671eeee267e8868d79b37b3e2a0c760aa54c", @"/Areas/User/Views/Shared/_Layout.cshtml")]
    public class Areas_User_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 765, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5664671eeee267e8868d79b37b3e2a0c760aa54c3025", async() => {
                BeginContext(41, 752, true);
                WriteLiteral(@"
    <title>Industrial &mdash; Website Template by Colorlin</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">


    <link href=""https://fonts.googleapis.com/css?family=Montserrat:400,700|Oxygen:400,700"" rel=""stylesheet"">

    <link rel=""stylesheet"" href=""/user/css/animate.css"">
    <link rel=""stylesheet"" href=""/user/css/owl.carousel.min.css"">
    <link rel=""stylesheet"" href=""/user/css/jquery.fancybox.min.css"">

    <link rel=""stylesheet"" href=""/user/fonts/ionicons/css/ionicons.min.css"">
    <link rel=""stylesheet"" href=""/user/fonts/fontawesome/css/font-awesome.min.css"">

    <!-- Theme Style -->
    <link rel=""stylesheet"" href=""/user/css/style.css"">

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(800, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(802, 26712, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5664671eeee267e8868d79b37b3e2a0c760aa54c4992", async() => {
                BeginContext(808, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(815, 12, false);
#line 23 "H:\ASP.netCoreMVC\ASPDotNetMVC\MBSTU.LibrarySystem\MBSTU.LibrarySystem.WEB\Areas\User\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(827, 26680, true);
                WriteLiteral(@";
    <header role=""banner"">
        <nav class=""navbar navbar-expand-lg navbar-dark bg-dark"">
            <div class=""container-fluid"">
                <a class=""navbar-brand "" href=""index.html"">Industrial</a>
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarsExample05"" aria-controls=""navbarsExample05"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>

                <div class=""collapse navbar-collapse"" id=""navbarsExample05"">
                    <ul class=""navbar-nav pl-md-5 ml-auto"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" href=""index.html"">Home</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""about.html"">About</a>
                        </li>
                        <li class=""nav-item"">
          ");
                WriteLiteral(@"                  <a class=""nav-link"" href=""projects.html"">Projects</a>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle"" href=""services.html"" id=""dropdown04"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">Services</a>
                            <div class=""dropdown-menu"" aria-labelledby=""dropdown04"">
                                <a class=""dropdown-item"" href=""services.html"">Architectural Design</a>
                                <a class=""dropdown-item"" href=""services.html"">Interior</a>
                                <a class=""dropdown-item"" href=""services.html"">Building</a>
                            </div>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link"" href=""blog.html"">Blog</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-");
                WriteLiteral(@"link"" href=""contact.html"">Contact</a>
                        </li>
                    </ul>

                    <div class=""navbar-nav ml-auto"">
                        <form method=""post"" class=""search-form"">
                            <span class=""icon ion ion-search""></span>
                            <input type=""text"" class=""form-control"" placeholder=""Search..."">
                        </form>
                    </div>

                </div>
            </div>
        </nav>
    </header>
    <!-- END header -->

    <div class=""top-shadow""></div>

    <section class=""home-slider owl-carousel"">
        <div class=""slider-item"" style=""background-image: url('/user/images/industrial_hero_1.jpg');"">
            <div class=""container"">
                <div class=""row slider-text align-items-center justify-content-center"">
                    <div class=""col-lg-7 text-center col-sm-12 element-animate"">
                        <div class=""btn-play-wrap mx-auto""><p class=""mb-4""><a");
                WriteLiteral(@" href=""https://vimeo.com/59256790"" data-fancybox data-ratio=""2"" class=""btn-play""><span class=""ion ion-ios-play""></span></a></p></div>
                        <h1 class=""mb-4""><span>We Are Industrial Company</span></h1>
                        <p class=""mb-5 w-75"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Alias iste ipsa excepturi nostrum sequi molestias?</p>
                    </div>
                </div>
            </div>
        </div>

        <div class=""slider-item"" style=""background-image: url('/user/images/industrial_hero_2.jpg');"">
            <div class=""container"">
                <div class=""row slider-text align-items-center justify-content-center"">
                    <div class=""col-lg-7 text-center col-sm-12 element-animate"">
                        <div class=""btn-play-wrap mx-auto""><p class=""mb-4""><a href=""https://vimeo.com/59256790"" data-fancybox data-ratio=""2"" class=""btn-play""><span class=""ion ion-ios-play""></span></a></p></div>
                        <h1><s");
                WriteLiteral(@"pan>The Best Level of Excellence in Steel Fabrication</span></h1>
                        <p class=""mb-5 w-75"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Molestiae fuga, hic quae molestias aperiam deserunt!</p>
                    </div>
                </div>
            </div>

        </div>

    </section>
    <!-- END slider -->
    </div>


    <section class=""section"">
        <div class=""container"">
            <div class=""row mb-5"">
                <div class=""col-12 text-center"">
                    <h2>We'll Handle Any Probles and Solve Them</h2>
                </div>
            </div>
            <div class=""row align-items-stretch"">
                <div class=""col-lg-4 order-lg-2"">
                    <div class=""scaling-image h-100""><div class=""frame h-100""><div class=""feature-img-bg h-100"" style=""background-image: url('/user/images/industrial_feature_1.jpg');""></div></div></div>
                </div>

                <div class=""col-md-6 col-lg-4 featu");
                WriteLiteral(@"re-1-wrap d-md-flex flex-md-column order-lg-1"">

                    <div class=""feature-1 d-md-flex"">
                        <div class=""align-self-center"">
                            <span class=""ion ion-easel display-4 text-primary""></span>
                            <h3>Ducting Design</h3>
                            <p>Even the all-powerful Pointing has no control about the blind texts.</p>
                        </div>
                    </div>

                    <div class=""feature-1 d-md-flex"">
                        <div class=""align-self-center"">
                            <span class=""ion ion-hammer display-4 text-primary""></span>
                            <h3>Stacks Design</h3>
                            <p>Even the all-powerful Pointing has no control about the blind texts.</p>
                        </div>
                    </div>

                </div>

                <div class=""col-md-6 col-lg-4 feature-1-wrap d-md-flex flex-md-column order-lg-3"">

     ");
                WriteLiteral(@"               <div class=""feature-1 d-md-flex"">
                        <div class=""align-self-center"">
                            <span class=""ion ion-cube display-4 text-primary""></span>
                            <h3>Tanks Design</h3>
                            <p>Even the all-powerful Pointing has no control about the blind texts.</p>
                        </div>
                    </div>

                    <div class=""feature-1 d-md-flex"">
                        <div class=""align-self-center"">
                            <span class=""ion ion-clipboard display-4 text-primary""></span>
                            <h3>Structural Design</h3>
                            <p>Even the all-powerful Pointing has no control about the blind texts.</p>
                        </div>
                    </div>

                </div>

            </div>
        </div>
    </section>

    <section class=""section bg-light"">
        <div class=""container"">
            <div class=""row"">
 ");
                WriteLiteral(@"               <div class=""col-md-6 col-lg-4 element-animate "">
                    <div class=""media block-6 d-block text-center"">
                        <div class=""icon mb-3""><span class=""ion-android-notifications text-primary""></span></div>
                        <div class=""media-body"">
                            <h3 class=""heading"">Modern Design</h3>
                            <p>Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic.</p>
                        </div>
                    </div>

                </div>
                <div class=""col-md-6 col-lg-4 element-animate "">
                    <div class=""media block-6 d-block text-center"">
                        <div class=""icon mb-3""><span class=""ion-heart text-primary""></span></div>
                        <div class=""media-body"">
                            <h3 class=""heading"">Built With Passion</h3>
                            <p>Even the all-powerful Pointing has no control a");
                WriteLiteral(@"bout the blind texts it is an almost unorthographic.</p>
                        </div>
                    </div>

                </div>
                <div class=""col-md-6 col-lg-4 element-animate "">
                    <div class=""media block-6 d-block text-center"">
                        <div class=""icon mb-3""><span class=""ion-flash text-primary""></span></div>
                        <div class=""media-body"">
                            <h3 class=""heading"">Fast Loading</h3>
                            <p>Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic.</p>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </section>
    <!-- END section -->
    <section class=""section element-animate"">
        <div class=""container"">
            <div class=""row align-items-center mb-5"">
                <div class=""col-lg-7 order-md-2"">
                    <div class=""scaling-ima");
                WriteLiteral(@"ge""><div class=""frame""><img src=""/user/images/industrial_featured_img_1.jpg"" alt=""Free template by Free-Template.co"" class=""img-fluid""></div></div>
                </div>
                <div class=""col-md-5 pr-md-5 mb-5"">
                    <div class=""block-41"">
                        <h2 class=""block-41-heading mb-5"">Let's Build Together</h2>
                        <div class=""block-41-text"">
                            <p>Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.</p>
                            <p><a href=""#"" class=""readmore"">Read More <span class=""ion-android-arrow-dropright-circle""></span></a></p>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </section>

    <section class=""section element-animate bg-light"">
        <div class=""container"">");
                WriteLiteral(@"
            <div class=""row align-items-center mb-5"">
                <div class=""col-lg-7 order-md-1"">
                    <div class=""scaling-image""><div class=""frame""><img src=""/user/images/industrial_featured_img_2.jpg"" alt=""Free template by Free-Template.co"" class=""img-fluid""></div></div>
                </div>
                <div class=""col-md-5 pl-md-5 mb-5 order-md-2"">
                    <div class=""block-41"">
                        <h2 class=""block-41-heading mb-5"">We'll handle any intercate custom design</h2>
                        <div class=""block-41-text"">
                            <p>A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth.</p>
                            <p><a href=""#"" class=""readmore"">Read More <span class=""ion-android-arrow-dropright-circle""></span></a></p>
                        </div>
                    </div>
                </div");
                WriteLiteral(@">

            </div>
        </div>
    </section>


    <section class=""section border-t pb-0"">
        <div class=""container"">
            <div class=""row justify-content-center mb-5 element-animate"">
                <div class=""col-md-8 text-center"">
                    <h2 class="" heading mb-4"">Projects</h2>
                    <p class=""mb-5 lead"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.</p>
                </div>
            </div>
        </div>
        <div class=""container-fluid"">
            <div class=""row no-gutters"">
                <div class=""col-md-4 element-animate"">
                    <a href=""project-single.html"" class=""link-thumbnail"">
                        <h3>Ducting Design in Colorado</h3>
                        <span class=""ion-plus icon""></span>
                        <img src=""/user/i");
                WriteLiteral(@"mages/industrial_img_1.jpg"" alt=""Free template by Free-Template.co"" class=""img-fluid"">
                    </a>
                </div>
                <div class=""col-md-4 element-animate"">
                    <a href=""project-single.html"" class=""link-thumbnail"">
                        <h3>Tanks Project In California</h3>
                        <span class=""ion-plus icon""></span>
                        <img src=""/user/images/industrial_img_2.jpg"" alt=""Free template by Free-Template.co"" class=""img-fluid"">
                    </a>
                </div>
                <div class=""col-md-4 element-animate"">
                    <a href=""project-single.html"" class=""link-thumbnail"">
                        <h3>Structural Design in New York</h3>
                        <span class=""ion-plus icon""></span>
                        <img src=""/user/images/industrial_img_3.jpg"" alt=""Free template by Free-Template.co"" class=""img-fluid"">
                    </a>
                </div>
                <d");
                WriteLiteral(@"iv class=""col-md-4 element-animate"">
                    <a href=""project-single.html"" class=""link-thumbnail"">
                        <h3>Stacks Design</h3>
                        <span class=""ion-plus icon""></span>
                        <img src=""/user/images/industrial_img_4.jpg"" alt=""Free template by Free-Template.co"" class=""img-fluid"">
                    </a>
                </div>
                <div class=""col-md-4 element-animate"">
                    <a href=""project-single.html"" class=""link-thumbnail"">
                        <h3>Intercate Custom</h3>
                        <span class=""ion-plus icon""></span>
                        <img src=""/user/images/industrial_img_5.jpg"" alt=""Free template by Free-Template.co"" class=""img-fluid"">
                    </a>
                </div>
                <div class=""col-md-4 element-animate"">
                    <a href=""project-single.html"" class=""link-thumbnail"">
                        <h3>Banker Design</h3>
                      ");
                WriteLiteral(@"  <span class=""ion-plus icon""></span>
                        <img src=""/user/images/industrial_img_6.jpg"" alt=""Free template by Free-Template.co"" class=""img-fluid"">
                    </a>
                </div>
            </div>

        </div>
    </section>
    <!-- END section -->

    <section class=""section bg-light block-11"">
        <div class=""container"">
            <div class=""row justify-content-center mb-5"">
                <div class=""col-md-8 text-center"">
                    <h2 class="" heading mb-4"">Testimonial</h2>
                </div>
            </div>
            <div class=""nonloop-block-11 owl-carousel"">
                <div class=""item"">
                    <div class=""block-33 h-100"">
                        <div class=""vcard d-flex mb-3"">
                            <div class=""image align-self-center""><img src=""/user/images/person_3.jpg"" alt=""Person here""></div>
                            <div class=""name-text align-self-center"">
                        ");
                WriteLiteral(@"        <h2 class=""heading"">John Smith</h2>
                                <span class=""meta"">Free-Template.co Client</span>
                            </div>
                        </div>
                        <div class=""text"">
                            <blockquote>
                                <p>&rdquo; The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. &ldquo;</p>
                            </blockquote>
                        </div>
                    </div>
                </div>

                <div class=""item"">
                    <div class=""block-33 h-100"">
                        <div class=""vcard d-flex mb-3"">
                            <div class=""image align-self-center""><img src=""/user/images/person_2.jpg"" alt=""Person here""></div>
                            <");
                WriteLiteral(@"div class=""name-text align-self-center"">
                                <h2 class=""heading"">Joshua Darren</h2>
                                <span class=""meta"">Free-Template.co Client</span>
                            </div>
                        </div>
                        <div class=""text"">
                            <blockquote>
                                <p>&rdquo; Even the all-powerful Pointing has no control about the blind texts it is an almost unorthographic life One day however a small line of blind text by the name of Lorem Ipsum decided to leave for the far World of Grammar. &ldquo;</p>
                            </blockquote>
                        </div>
                    </div>
                </div>

                <div class=""item"">
                    <div class=""block-33 h-100"">
                        <div class=""vcard d-flex mb-3"">
                            <div class=""image align-self-center""><img src=""/user/images/person_3.jpg"" alt=""Person here""></di");
                WriteLiteral(@"v>
                            <div class=""name-text align-self-center"">
                                <h2 class=""heading"">John Smith</h2>
                                <span class=""meta"">Free-Template.co Client</span>
                            </div>
                        </div>
                        <div class=""text"">
                            <blockquote>
                                <p>&rdquo; A small river named Duden flows by their place and supplies it with the necessary regelialia. It is a paradisematic country, in which roasted parts of sentences fly into your mouth. &ldquo;</p>
                            </blockquote>
                        </div>
                    </div>
                </div>

                <div class=""item"">
                    <div class=""block-33 h-100"">
                        <div class=""vcard d-flex mb-3"">
                            <div class=""image align-self-center""><img src=""/user/images/person_3.jpg"" alt=""Person here""></div>
     ");
                WriteLiteral(@"                       <div class=""name-text align-self-center"">
                                <h2 class=""heading"">John Smith</h2>
                                <span class=""meta"">Free-Template.co Client</span>
                            </div>
                        </div>
                        <div class=""text"">
                            <blockquote>
                                <p>&rdquo; Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean. &ldquo;</p>
                            </blockquote>
                        </div>
                    </div>
                </div>

            </div>
        </div>
        </div>
        <!-- END .block-4 -->
    </section>

    <section class=""section blog"">
        <div class=""container"">

            <div class=""row justify-content-center mb-5 element-animate"">
    ");
                WriteLiteral(@"            <div class=""col-md-8 text-center"">
                    <h2 class="" heading mb-4"">Blog Posts</h2>
                    <p class=""mb-5 lead"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. Separated they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.</p>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-md-6"">

                    <div class=""media mb-4 d-md-flex d-block element-animate"">
                        <a href=""#"" class=""mr-5""><img src=""/user/images/industrial_blog_1.jpg"" alt=""Free website template by Free-Template.co"" class=""img-fluid""></a>
                        <div class=""media-body"">
                            <span class=""post-meta"">Feb 26th, 2018</span>
                            <h3 class=""mt-2 text-black""><a href=""#"">How to handle any intercate custom design</a></h3>
                            <p>Separated");
                WriteLiteral(@" they live in Bookmarksgrove right at the coast of the Semantics, a large language ocean.</p>
                            <p><a href=""#"" class=""readmore"">Read More <span class=""ion-android-arrow-dropright-circle""></span></a></p>
                        </div>
                    </div>



                </div>
                <div class=""col-md-6"">
                    <div class=""media mb-4 d-md-flex d-block element-animate"">
                        <a href=""#"" class=""mr-5""><img src=""/user/images/industrial_blog_2.jpg"" alt=""Free website template by Free-Template.co"" class=""img-fluid""></a>
                        <div class=""media-body"">
                            <span class=""post-meta"">Feb 26th, 2018</span>
                            <h3 class=""mt-2 text-black""><a href=""#"">How to handle any intercate custom design</a></h3>
                            <p><a href=""#"" class=""readmore"">Read More <span class=""ion-android-arrow-dropright-circle""></span></a></p>
                        </div>
   ");
                WriteLiteral(@"                 </div>

                    <div class=""media mb-4 d-md-flex d-block element-animate"">
                        <a href=""#"" class=""mr-5""><img src=""/user/images/industrial_blog_3.jpg"" alt=""Free website template by Free-Template.co"" class=""img-fluid""></a>
                        <div class=""media-body"">
                            <span class=""post-meta"">Feb 26th, 2018</span>
                            <h3 class=""mt-2 text-black""><a href=""#"">How to handle any intercate custom design</a></h3>
                            <p><a href=""#"" class=""readmore"">Read More <span class=""ion-android-arrow-dropright-circle""></span></a></p>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </section>
    <section class=""section bg-primary"">
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-lg-8"">
                    <h2 class=""text-white mb-0"">Get Started With I");
                WriteLiteral(@"ndustrial Free Template</h2>
                    <p class=""text-white lead"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. .</p>
                </div>
                <div class=""col-lg-4 text-lg-right"">
                    <a href=""https://free-template.co/"" class=""btn btn-outline-white px-4 py-3"">Download This Template</a>
                </div>
            </div>
        </div>
    </section>
    <footer class=""site-footer"" role=""contentinfo"">
        <div class=""container"">
            <div class=""row mb-5"">
                <div class=""col-md-4 mb-5"">
                    <h3>About The Industrial</h3>
                    <p class=""mb-5"">Far far away, behind the word mountains, far from the countries Vokalia and Consonantia, there live the blind texts. .</p>
                    <ul class=""list-unstyled footer-link d-flex footer-social"">
                        <li><a href=""#"" class=""p-2""><span class=""fa fa-twitter""></span");
                WriteLiteral(@"></a></li>
                        <li><a href=""#"" class=""p-2""><span class=""fa fa-facebook""></span></a></li>
                        <li><a href=""#"" class=""p-2""><span class=""fa fa-linkedin""></span></a></li>
                        <li><a href=""#"" class=""p-2""><span class=""fa fa-instagram""></span></a></li>
                    </ul>

                </div>
                <div class=""col-md-5 mb-5 pl-md-5"">
                    <h3>Contact Info</h3>
                    <ul class=""list-unstyled footer-link"">
                        <li class=""d-block"">
                            <span class=""d-block"">Address:</span>
                            <span>34 Street Name, City Name Here, United States</span>
                        </li>
                        <li class=""d-block""><span class=""d-block"">Telephone:</span><span>+1 242 4942 290</span></li>
                        <li class=""d-block""><span class=""d-block"">Email:</span><span>info@yourdomain.com</span></li>
                    </ul>
          ");
                WriteLiteral(@"      </div>
                <div class=""col-md-3 mb-5"">
                    <h3>Quick Links</h3>
                    <ul class=""list-unstyled footer-link"">
                        <li><a href=""#"">About</a></li>
                        <li><a href=""#"">Terms of Use</a></li>
                        <li><a href=""#"">Disclaimers</a></li>
                        <li><a href=""#"">Contact</a></li>
                    </ul>
                </div>
                <div class=""col-md-3"">

                </div>
            </div>
            <div class=""row"">
                <div class=""col-12 text-md-center text-left"">
                    <p class=""copyright"">
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        Copyright &copy;
                        <script>document.write(new Date().getFullYear());</script> All rights reserved | This template is made with <i class=""fa fa-heart text-danger"" aria-hidden=""true""></i> by <a");
                WriteLiteral(@" href=""https://colorlib.com"" target=""_blank"">Colorlib</a>
                        <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                    </p>
                </div>
            </div>
        </div>
    </footer>
    <!-- END footer -->
    <!-- loader -->
    <div id=""loader"" class=""show fullscreen""><svg class=""circular"" width=""48px"" height=""48px""><circle class=""path-bg"" cx=""24"" cy=""24"" r=""22"" fill=""none"" stroke-width=""4"" stroke=""#eeeeee"" /><circle class=""path"" cx=""24"" cy=""24"" r=""22"" fill=""none"" stroke-width=""4"" stroke-miterlimit=""10"" stroke=""#f4b214"" /></svg></div>

    <script src=""/user/js/jquery-3.2.1.min.js""></script>
    <script src=""/user/js/popper.min.js""></script>
    <script src=""/user/js/bootstrap.min.js""></script>
    <script src=""/user/js/owl.carousel.min.js""></script>
    <script src=""/user/js/jquery.waypoints.min.js""></script>
    <script src=""/user/js/jquery.fancybox.min.js""></script>
    <script src=""/user/js/main.js""></scr");
                WriteLiteral("ipt>\r\n\r\n    <script src=\"/user/js/main.js\"></script>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(27514, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
