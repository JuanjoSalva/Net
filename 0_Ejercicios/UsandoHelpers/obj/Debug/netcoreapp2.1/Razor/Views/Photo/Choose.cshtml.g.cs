#pragma checksum "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\UsandoHelpers\Views\Photo\Choose.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf29ec494f69f7f6a68034350d39031aac97694f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Photo_Choose), @"mvc.1.0.view", @"/Views/Photo/Choose.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Photo/Choose.cshtml", typeof(AspNetCore.Views_Photo_Choose))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf29ec494f69f7f6a68034350d39031aac97694f", @"/Views/Photo/Choose.cshtml")]
    public class Views_Photo_Choose : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(130, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(159, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5dce33db0344d42ad7d3529e22fa9da", async() => {
                BeginContext(165, 86, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Some</title>\r\n");
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
            BeginContext(258, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(260, 514, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "044d858c4e314211b71ff9eb3099651e", async() => {
                BeginContext(266, 21, true);
                WriteLiteral("\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(288, 72, false);
#line 16 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\UsandoHelpers\Views\Photo\Choose.cshtml"
   Write(Html.ActionLink("Click here to view photo 1", "Display", new { id = 1 }));

#line default
#line hidden
                EndContext();
                BeginContext(360, 36, true);
                WriteLiteral(";\r\n    </div>\r\n\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(397, 72, false);
#line 20 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\UsandoHelpers\Views\Photo\Choose.cshtml"
   Write(Html.ActionLink("Click here to view photo 2", "Display", new { id = 2 }));

#line default
#line hidden
                EndContext();
                BeginContext(469, 36, true);
                WriteLiteral(";\r\n    </div>\r\n\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(506, 72, false);
#line 24 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\UsandoHelpers\Views\Photo\Choose.cshtml"
   Write(Html.ActionLink("Click here to view photo 3", "Display", new { id = 3 }));

#line default
#line hidden
                EndContext();
                BeginContext(578, 37, true);
                WriteLiteral(";\r\n    </div>\r\n\r\n    <p>LIstado</p>\r\n");
                EndContext();
#line 28 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\UsandoHelpers\Views\Photo\Choose.cshtml"
     for (int i = 1; i < 8; i++)
    {

#line default
#line hidden
                BeginContext(656, 13, true);
                WriteLiteral("        <div>");
                EndContext();
                BeginContext(670, 77, false);
#line 30 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\UsandoHelpers\Views\Photo\Choose.cshtml"
        Write(Html.ActionLink($"Click here to view photo {@i}", "Display", new { id = @i }));

#line default
#line hidden
                EndContext();
                BeginContext(747, 9, true);
                WriteLiteral(";</div>\r\n");
                EndContext();
#line 31 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\UsandoHelpers\Views\Photo\Choose.cshtml"
    }

#line default
#line hidden
                BeginContext(763, 4, true);
                WriteLiteral("\r\n\r\n");
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
            BeginContext(774, 9, true);
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