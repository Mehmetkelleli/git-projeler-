#pragma checksum "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae505ceb7dfd9ee79ea5a2839dc02c3c753f3594"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Root_Setting), @"mvc.1.0.view", @"/Views/Root/Setting.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\_ViewImports.cshtml"
using myblog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\_ViewImports.cshtml"
using myblog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae505ceb7dfd9ee79ea5a2839dc02c3c753f3594", @"/Views/Root/Setting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7294f6c81f02ea6795bd0b77adfff5c5ec2ece81", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Root_Setting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MySettingViewmodel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/root/setting/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/root/UserSetting/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
  
    ViewData["Title"] = "Setting";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
     <div class=""card card-warning w-100"">
              <div class=""card-header"">
                <h3 class=""card-title"">Site Settings</h3>
              </div>
              <!-- /.card-header -->
              <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae505ceb7dfd9ee79ea5a2839dc02c3c753f35945177", async() => {
                WriteLiteral(@"
                  <div class=""row"">
                    <div class=""col-sm-6"">
                      <!-- text input -->
                      <div class=""form-group"">
                        <label>Site Logo</label>
                        <input class=""form-control"" type=""text"" name=""Logo""");
                BeginWriteAttribute("value", " value=\"", 725, "\"", 752, 1);
#nullable restore
#line 21 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
WriteAttributeValue("", 733, Model.setting.Logo, 733, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                      </div>
                    </div>
                  </div>
                  <div class=""row"">
                    <div class=""col-sm-6"">
                      <!-- text input -->
                      <div class=""form-group"">
                        <label>Home Page Title</label>
                        <input class=""form-control"" type=""text"" name=""HomePageTitle""");
                BeginWriteAttribute("value", "  value=\"", 1152, "\"", 1189, 1);
#nullable restore
#line 30 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
WriteAttributeValue("", 1161, Model.setting.HomePageTitle, 1161, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                      </div>
                    </div>
                  </div>
                  <div class=""row"">
                    <div class=""col-sm-6"">
                      <!-- textarea -->
                      <div class=""form-group"">
                        <label>Home Page Content</label>
                        <textarea class=""form-control"" rows=""3"" type=""text"" name=""HomePageContent""");
                BeginWriteAttribute("value", " value=\"", 1603, "\"", 1641, 1);
#nullable restore
#line 39 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
WriteAttributeValue("", 1611, Model.setting.HomePageContent, 1611, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 39 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
                                                                                                                                     Write(Model.setting.HomePageContent);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
                      </div>
                    </div>
                  </div>
                  <div class=""row"">
                    <div class=""col-sm-6"">
                      <!-- textarea -->
                      <div class=""form-group"">
                        <label>Meta Tags</label>
                        <textarea class=""form-control"" rows=""3"" type=""text"" name=""Meta""");
                BeginWriteAttribute("Value", " Value=\"", 2077, "\"", 2104, 1);
#nullable restore
#line 48 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
WriteAttributeValue("", 2085, Model.setting.Meta, 2085, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 48 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
                                                                                                               Write(Model.setting.Meta);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n                      </div>\r\n                    </div>\r\n                  </div>\r\n                  <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 2270, "\"", 2295, 1);
#nullable restore
#line 52 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
WriteAttributeValue("", 2278, Model.setting.Id, 2278, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                  <button type=\"submit\" class=\"btn btn-danger\">Update</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
              </div>
              <!-- /.card-body -->
            </div>
                        <!--Bu alan kullanıcı ayar kısımı-->
            <div class=""card card-warning w-100 ml-3"">
              <div class=""card-header"">
                <h3 class=""card-title"">User Setting</h3>
              </div>
              <!-- /.card-header -->
              <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae505ceb7dfd9ee79ea5a2839dc02c3c753f359411572", async() => {
                WriteLiteral(@"
                  <div class=""row"">
                    <div class=""col-sm-6"">
                      <!-- text input -->
                      <div class=""form-group"">
                        <label>User Name</label>
                        <input class=""form-control"" type=""text"" name=""Name""");
                BeginWriteAttribute("value", " value=\"", 3161, "\"", 3183, 1);
#nullable restore
#line 71 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
WriteAttributeValue("", 3169, Model.my.Name, 3169, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                      </div>
                    </div>
                  </div>
                  <div class=""row"">
                    <div class=""col-sm-6"">
                      <!-- text input -->
                      <div class=""form-group"">
                        <label>School</label>
                        <input class=""form-control"" type=""text"" name=""School""");
                BeginWriteAttribute("value", " value=\"", 3567, "\"", 3591, 1);
#nullable restore
#line 80 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
WriteAttributeValue("", 3575, Model.my.School, 3575, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                      </div>
                    </div>
                  </div>
                  <div class=""row"">
                    <div class=""col-sm-6"">
                      <!-- text input -->
                      <div class=""form-group"">
                        <label>Job</label>
                        <input class=""form-control"" type=""text"" name=""Job""");
                BeginWriteAttribute("value", " value=\"", 3969, "\"", 3990, 1);
#nullable restore
#line 89 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
WriteAttributeValue("", 3977, Model.my.Job, 3977, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                      </div>
                    </div>
                  </div>
                  <div class=""row"">
                    <div class=""col-sm-6"">
                      <!-- text input -->
                      <div class=""form-group"">
                        <label>Facebook Url</label>
                        <input class=""form-control"" type=""text"" name=""Facebook""");
                BeginWriteAttribute("value", " value=\"", 4382, "\"", 4408, 1);
#nullable restore
#line 98 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
WriteAttributeValue("", 4390, Model.my.Facebook, 4390, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                      </div>
                    </div>
                  </div>
                  <div class=""row"">
                    <div class=""col-sm-6"">
                      <!-- text input -->
                      <div class=""form-group"">
                        <label>Whatsapp Api</label>
                        <input class=""form-control"" type=""text"" name=""Wp""");
                BeginWriteAttribute("value", " value=\"", 4794, "\"", 4814, 1);
#nullable restore
#line 107 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
WriteAttributeValue("", 4802, Model.my.Wp, 4802, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                      </div>
                    </div>
                  </div>
                  <div class=""row"">
                    <div class=""col-sm-6"">
                      <!-- text input -->
                      <div class=""form-group"">
                        <label>İnstagram Url</label>
                        <input class=""form-control"" type=""text"" name=""İnstagram""");
                BeginWriteAttribute("value", " value=\"", 5208, "\"", 5235, 1);
#nullable restore
#line 116 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
WriteAttributeValue("", 5216, Model.my.İnstagram, 5216, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                      </div>
                    </div>
                  </div>
                  <div class=""row"">
                    <div class=""col-sm-6"">
                      <!-- text input -->
                      <div class=""form-group"">
                        <label>İnstagram Url</label>
                        <input class=""form-control"" type=""text"" name=""İnstagram""");
                BeginWriteAttribute("value", " value=\"", 5629, "\"", 5656, 1);
#nullable restore
#line 125 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
WriteAttributeValue("", 5637, Model.my.İnstagram, 5637, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                      </div>
                    </div>
                  </div>
                  <div class=""row"">
                    <div class=""col-sm-6"">
                      <!-- text input -->
                      <div class=""form-group"">
                        <label>Profile İmg Url</label>
                        <input class=""form-control"" type=""text"" name=""İmgurl""");
                BeginWriteAttribute("value", " value=\"", 6049, "\"", 6073, 1);
#nullable restore
#line 134 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
WriteAttributeValue("", 6057, Model.my.İmgUrl, 6057, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                      </div>\r\n                    </div>\r\n                  </div>\r\n                  <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 6209, "\"", 6229, 1);
#nullable restore
#line 138 "C:\Users\Mehmet Kelleli\Desktop\myblog\myblog\myblog\Views\Root\Setting.cshtml"
WriteAttributeValue("", 6217, Model.my.Id, 6217, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                  <button type=\"submit\" class=\"btn btn-danger\">Update</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n              </div>\r\n              <!-- /.card-body -->\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MySettingViewmodel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
