#pragma checksum "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5fb5c703b258074837208a8deae951277e41b05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Teacher_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Teacher/Details.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\_ViewImports.cshtml"
using EduHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\_ViewImports.cshtml"
using EduHome.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5fb5c703b258074837208a8deae951277e41b05", @"/Areas/Admin/Views/Teacher/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e98c5becdebf98bcd12e5fb9b6debed59b5ea534", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Teacher_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<div class=\"container my-5\">\r\n    <div class=\"row justify-content-center\">\r\n        <div class=\"col-md-7 col-lg-4 mb-5 mb-lg-0 wow fadeIn\">\r\n            <div class=\"card border-0 shadow\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b5fb5c703b258074837208a8deae951277e41b054294", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 351, "~/img/teacher/", 351, 14, true);
#nullable restore
#line 19 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
AddHtmlAttributeValue("", 365, Model.Image, 365, 12, false);

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
            WriteLiteral("\r\n                <div class=\"card-body p-1-9 p-xl-5\">\r\n                    <div class=\"mb-4\">\r\n                        <h3 class=\"h4 mb-0\">");
#nullable restore
#line 22 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                                                   Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <span class=""text-primary"">CEO &amp; Founder</span>
                    </div>
                    <ul class=""list-unstyled mb-4"">
                        <li class=""mb-3""><a class=""d-flex align-items-center text-decoration-none"" style=""font-weight: 600 !important; color: darkgreen !important;"" href=""#!""><i style=""width: 25px !important; height: 25px !important;"" class=""far fa-envelope display-25 me-3 text-secondary mr-3 d-flex justify-content-center""></i> ");
#nullable restore
#line 26 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                                                                                                                                                                                                                                                                                                                                     Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
                        <li class=""mb-3""><a class=""d-flex align-items-center text-decoration-none"" style=""font-weight: 600 !important; color: darkgreen !important;"" href=""#!""><i style=""width: 25px !important; height: 25px !important;"" class=""fas fa-mobile-alt display-25 me-3 text-secondary mr-3 d-flex justify-content-center""></i> ");
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                                                                                                                                                                                                                                                                                                                                       Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
                        <li><a class=""d-flex align-items-center text-decoration-none"" style=""font-weight: 600 !important; color: darkgreen !important;"" href=""#!""><i style=""width: 25px !important; height: 25px !important;"" class=""fab fa-skype display-25 me-3 text-secondary mr-3 d-flex justify-content-center""></i> ");
#nullable restore
#line 28 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                                                                                                                                                                                                                                                                                                                     Write(Model.Skype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                    </ul>\r\n                    <ul class=\"social-icon-style2 ps-0\">\r\n");
#nullable restore
#line 31 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                          
                            foreach (var s in Model.TeacherSocialToTeachers)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2025, "\"", 2053, 1);
#nullable restore
#line 34 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue("", 2032, s.TeacherSocial.Link, 2032, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded-3\"><i");
            BeginWriteAttribute("class", " class=\"", 2075, "\"", 2104, 1);
#nullable restore
#line 34 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue("", 2083, s.TeacherSocial.Icon, 2083, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a></li>\r\n");
#nullable restore
#line 35 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                       
                    </ul>
                </div>
            </div>
        </div>
        <div class=""col-lg-8"">
            <div class=""ps-lg-1-6 ps-xl-5"">
                <div class=""mb-5 wow fadeIn"">
                    <div class=""text-start mb-1-6 wow fadeIn"">
                        <h2 class=""h1 mb-0 text-primary"">#About Me</h2>
                    </div>
                    <p>");
#nullable restore
#line 49 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                  Write(Model.About);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    
                </div>
                <div class=""mb-5 wow fadeIn"">
                    <div class=""text-start mb-1-6 wow fadeIn"">
                        <h2 class=""mb-0 text-primary"">#Education</h2>
                    </div>
                    <div class=""row mt-n4"">
                        <div class=""col-sm-6 col-xl-6 mt-4"">
                            <div class=""card text-center border-0 rounded-3"">
                                <div class=""card-body"">
                                    <i class=""ti-bookmark-alt icon-box medium rounded-3 mb-4""></i>
                                    <h3 class=""h5 mb-3"">Faculity</h3>
                                    <p class=""mb-0"">");
#nullable restore
#line 62 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                                               Write(Model.Faculity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-6 col-xl-6 mt-4"">
                            <div class=""card text-center border-0 rounded-3"">
                                <div class=""card-body"">
                                    <i class=""ti-pencil-alt icon-box medium rounded-3 mb-4""></i>
                                    <h3 class=""h5 mb-3"">Degree</h3>
                                    <p class=""mb-0"">");
#nullable restore
#line 71 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                                               Write(Model.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-6 col-xl-6 mt-4"">
                            <div class=""card text-center border-0 rounded-3"">
                                <div class=""card-body"">
                                    <i class=""ti-medall-alt icon-box medium rounded-3 mb-4""></i>
                                    <h3 class=""h5 mb-3"">Experience</h3>
                                    <p class=""mb-0"">About ");
#nullable restore
#line 80 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                                                     Write(Model.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" and professional in signage</p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-6 col-xl-6 mt-4"">
                            <div class=""card text-center border-0 rounded-3"">
                                <div class=""card-body"">
                                    <i class=""ti-medall-alt icon-box medium rounded-3 mb-4""></i>
                                    <h3 class=""h5 mb-3"">Position</h3>
                                    <p class=""mb-0"">");
#nullable restore
#line 89 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                                               Write(Model.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""wow fadeIn"">
                    <div class=""text-start mb-1-6 wow fadeIn"">
                        <h2 class=""mb-0 text-primary"">#Skills &amp; Experience</h2>
                    </div>
                    <div class=""progress-style1"">
                        <div class=""progress-text"">
                            <div class=""row"">
                                <div class=""col-6 fw-bold"" style=""font-weight: 700 !important; color: darkgreen !important;"">Language</div>
                                <div class=""col-6 text-end"" style=""font-weight: 700 !important; color: darkgreen !important;"">");
#nullable restore
#line 103 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                                                                                                                         Write(Model.Teacherskills.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"custom-progress progress rounded-3 mb-4\">\r\n                            <div class=\"animated custom-bar progress-bar slideInLeft\"");
            BeginWriteAttribute("style", " style=\"", 6111, "\"", 6194, 6);
            WriteAttributeValue("", 6119, "background-color:", 6119, 17, true);
            WriteAttributeValue(" ", 6136, "#007bff", 6137, 8, true);
            WriteAttributeValue(" ", 6144, "!important;", 6145, 12, true);
            WriteAttributeValue(" ", 6156, "width:", 6157, 7, true);
#nullable restore
#line 107 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue(" ", 6163, Model.Teacherskills.Language, 6164, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6193, "%", 6193, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" aria-valuemax=""100"" aria-valuemin=""0"" aria-valuenow=""10"" role=""progressbar""></div>
                        </div>
                        <div class=""progress-text"">
                            <div class=""row"">
                                <div class=""col-6 fw-bold"" style=""font-weight: 700 !important; color: darkgreen !important;"">Development</div>
                                <div class=""col-6 text-end"" style=""font-weight: 700 !important; color: darkgreen !important;"">");
#nullable restore
#line 112 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                                                                                                                         Write(Model.Teacherskills.Development);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"custom-progress progress rounded-3 mb-4\">\r\n                            <div class=\"animated custom-bar progress-bar bg-secondary slideInLeft\"");
            BeginWriteAttribute("style", " style=\"", 6968, "\"", 7055, 6);
            WriteAttributeValue(" ", 6976, "background-color:", 6977, 18, true);
            WriteAttributeValue(" ", 6994, "#007bff", 6995, 8, true);
            WriteAttributeValue(" ", 7002, "!important;", 7003, 12, true);
            WriteAttributeValue(" ", 7014, "width:", 7015, 7, true);
#nullable restore
#line 116 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue(" ", 7021, Model.Teacherskills.Development, 7022, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7054, "%", 7054, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" aria-valuemax=""100"" aria-valuemin=""0"" aria-valuenow=""70"" role=""progressbar""></div>
                        </div>
                        <div class=""progress-text"">
                            <div class=""row"">
                                <div class=""col-6 fw-bold"" style=""font-weight: 700 !important; color: darkgreen !important;"">Design</div>
                                <div class=""col-6 text-end"" style=""font-weight: 700 !important; color: darkgreen !important;"">");
#nullable restore
#line 121 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                                                                                                                         Write(Model.Teacherskills.Design);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"custom-progress progress rounded-3 mb-4\">\r\n                            <div class=\"animated custom-bar progress-bar bg-dark slideInLeft\"");
            BeginWriteAttribute("style", " style=\"", 7814, "\"", 7896, 6);
            WriteAttributeValue(" ", 7822, "background-color:", 7823, 18, true);
            WriteAttributeValue(" ", 7840, "#007bff", 7841, 8, true);
            WriteAttributeValue(" ", 7848, "!important;", 7849, 12, true);
            WriteAttributeValue(" ", 7860, "width:", 7861, 7, true);
#nullable restore
#line 125 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue(" ", 7867, Model.Teacherskills.Design, 7868, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7895, "%", 7895, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" aria-valuemax=""100"" aria-valuemin=""0"" aria-valuenow=""70"" role=""progressbar""></div>
                        </div>
                        <div class=""progress-text"">
                            <div class=""row"">
                                <div class=""col-6 fw-bold"" style=""font-weight: 700 !important; color: darkgreen !important;"">Communication</div>
                                <div class=""col-6 text-end"" style=""font-weight: 700 !important; color: darkgreen !important;"">");
#nullable restore
#line 130 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                                                                                                                         Write(Model.Teacherskills.Communication);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"custom-progress progress rounded-3 mb-4\">\r\n                            <div class=\"animated custom-bar progress-bar bg-dark slideInLeft\"");
            BeginWriteAttribute("style", " style=\"", 8669, "\"", 8758, 6);
            WriteAttributeValue(" ", 8677, "background-color:", 8678, 18, true);
            WriteAttributeValue(" ", 8695, "#007bff", 8696, 8, true);
            WriteAttributeValue(" ", 8703, "!important;", 8704, 12, true);
            WriteAttributeValue(" ", 8715, "width:", 8716, 7, true);
#nullable restore
#line 134 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue(" ", 8722, Model.Teacherskills.Communication, 8723, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8757, "%", 8757, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" aria-valuemax=""100"" aria-valuemin=""0"" aria-valuenow=""70"" role=""progressbar""></div>
                        </div>
                        <div class=""progress-text"">
                            <div class=""row"">
                                <div class=""col-6 fw-bold"" style=""font-weight: 700 !important; color: darkgreen !important;"">Innovation</div>
                                <div class=""col-6 text-end"" style=""font-weight: 700 !important; color: darkgreen !important;"">");
#nullable restore
#line 139 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                                                                                                                         Write(Model.Teacherskills.Inovation);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"custom-progress progress rounded-3 mb-4\">\r\n                            <div class=\"animated custom-bar progress-bar bg-dark slideInLeft\"");
            BeginWriteAttribute("style", " style=\"", 9524, "\"", 9609, 6);
            WriteAttributeValue(" ", 9532, "background-color:", 9533, 18, true);
            WriteAttributeValue(" ", 9550, "#007bff", 9551, 8, true);
            WriteAttributeValue(" ", 9558, "!important;", 9559, 12, true);
            WriteAttributeValue(" ", 9570, "width:", 9571, 7, true);
#nullable restore
#line 143 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue(" ", 9577, Model.Teacherskills.Inovation, 9578, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9608, "%", 9608, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" aria-valuemax=""100"" aria-valuemin=""0"" aria-valuenow=""70"" role=""progressbar""></div>
                        </div>
                        <div class=""progress-text"">
                            <div class=""row"">
                                <div class=""col-6 fw-bold"" style=""font-weight: 700 !important; color: darkgreen !important;"">Team Leader</div>
                                <div class=""col-6 text-end"" style=""font-weight: 700 !important; color: darkgreen !important;"">");
#nullable restore
#line 148 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
                                                                                                                         Write(Model.Teacherskills.TeamLeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"custom-progress progress rounded-3 mb-4\">\r\n                            <div class=\"animated custom-bar progress-bar bg-dark slideInLeft\"");
            BeginWriteAttribute("style", " style=\"", 10377, "\"", 10463, 6);
            WriteAttributeValue(" ", 10385, "background-color:", 10386, 18, true);
            WriteAttributeValue(" ", 10403, "#007bff", 10404, 8, true);
            WriteAttributeValue(" ", 10411, "!important;", 10412, 12, true);
            WriteAttributeValue(" ", 10423, "width:", 10424, 7, true);
#nullable restore
#line 152 "C:\Users\ASUS\Desktop\Tasks\EduHome_Orkhan\EduHome\EduHome\Areas\Admin\Views\Teacher\Details.cshtml"
WriteAttributeValue(" ", 10430, Model.Teacherskills.TeamLeader, 10431, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10462, "%", 10462, 1, true);
            EndWriteAttribute();
            WriteLiteral(" aria-valuemax=\"100\" aria-valuemin=\"0\" aria-valuenow=\"70\" role=\"progressbar\"></div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
