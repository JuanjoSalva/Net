#pragma checksum "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6509bd8167594fe4840b4ee19f4d32e4b258fe9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6509bd8167594fe4840b4ee19f4d32e4b258fe9d", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MiprimeraVista.Controllers.Product>>
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
            BeginContext(121, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(132, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(159, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "536f7cd9f4f64b01bcdaaa0e92db1944", async() => {
                BeginContext(165, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
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
            BeginContext(259, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(261, 1222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fecebbf721974d8993ea18fe29fc048e", async() => {
                BeginContext(267, 87, true);
                WriteLiteral("\r\n    Hello from the Index view\r\n    <p>Uso de sentencias for en Razor</p>\r\n    <div>\r\n");
                EndContext();
#line 18 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
         for (int i = 0; i < 5; i++)
        {

#line default
#line hidden
                BeginContext(403, 18, true);
                WriteLiteral("            <div> ");
                EndContext();
                BeginContext(422, 1, false);
#line 20 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
             Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(423, 2, true);
                WriteLiteral("  ");
                EndContext();
                BeginContext(426, 9, true);
                WriteLiteral("@</div>\r\n");
                EndContext();
#line 21 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(446, 48, true);
                WriteLiteral("    </div>\r\n    <p>Uso de etiquetas \"text\"</p>\r\n");
                EndContext();
#line 24 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
     for (int i = 0; i < 2; i++)
    {
        

#line default
#line hidden
                BeginContext(549, 40, true);
                WriteLiteral("\r\n            i\r\n            i\r\n        ");
                EndContext();
#line 29 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
               
    }

#line default
#line hidden
                BeginContext(605, 76, true);
                WriteLiteral("    <p>An implicit code expresion</p>\r\n    <span>Price Including Sales Tax: ");
                EndContext();
                BeginContext(682, 13, false);
#line 32 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
                                Write(ViewBag.Price);

#line default
#line hidden
                EndContext();
                BeginContext(695, 116, true);
                WriteLiteral(" * 1.21</span>\r\n\r\n    <p>Using parentheses to explicit delimit expression</p>\r\n    <span>Price Including Sales Tax: ");
                EndContext();
                BeginContext(813, 20, false);
#line 35 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
                                 Write(ViewBag.Price * 1.21);

#line default
#line hidden
                EndContext();
                BeginContext(834, 53, true);
                WriteLiteral("</span>\r\n\r\n    <p>A Razor code block</p>\r\n    <div>\r\n");
                EndContext();
#line 39 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
          
            int a = 5;
            int j = 6;
            int z = a + j;

#line default
#line hidden
                BeginContext(975, 17, true);
                WriteLiteral("            <div>");
                EndContext();
                BeginContext(993, 1, false);
#line 43 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
            Write(z);

#line default
#line hidden
                EndContext();
                BeginContext(994, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
                BeginContext(1013, 14, true);
                WriteLiteral("    </div>\r\n\r\n");
                EndContext();
#line 47 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
      
        int b = 5;
        int w = 6;
        

#line default
#line hidden
#line 50 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
         if (b < w)
        {

#line default
#line hidden
                BeginContext(1107, 15, true);
                WriteLiteral("            <p>");
                EndContext();
                BeginContext(1123, 1, false);
#line 52 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
          Write(b);

#line default
#line hidden
                EndContext();
                BeginContext(1124, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 53 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1148, 41, true);
                WriteLiteral("\r\n    <p>A Razor forEach code block</p>\r\n");
                EndContext();
#line 57 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
     foreach (string name in ViewBag.Names)
    {

#line default
#line hidden
                BeginContext(1241, 14, true);
                WriteLiteral("        <span>");
                EndContext();
                BeginContext(1256, 4, false);
#line 59 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
         Write(name);

#line default
#line hidden
                EndContext();
                BeginContext(1260, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 60 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(1276, 47, true);
                WriteLiteral("\r\n    <p>Iterating a Model by using Razon</p>\r\n");
                EndContext();
                BeginContext(1383, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 65 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
                BeginContext(1429, 14, true);
                WriteLiteral("        <span>");
                EndContext();
                BeginContext(1444, 12, false);
#line 67 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
         Write(product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1456, 9, true);
                WriteLiteral("</span>\r\n");
                EndContext();
#line 68 "E:\JUANJO\CURSO2020\MODULO3_NET\Ejercicios\MiprimeraVista\Views\Home\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(1472, 4, true);
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
            BeginContext(1483, 9, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MiprimeraVista.Controllers.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
