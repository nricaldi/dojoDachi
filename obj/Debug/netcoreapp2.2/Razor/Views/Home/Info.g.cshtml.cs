#pragma checksum "/Users/nicolasricaldi/dojo/cSharp_stack/asp_core/dojoDachi/Views/Home/Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52261dc943140c28e74b3b5e9c4df5ec9b0acc71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Info), @"mvc.1.0.view", @"/Views/Home/Info.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Info.cshtml", typeof(AspNetCore.Views_Home_Info))]
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
#line 1 "/Users/nicolasricaldi/dojo/cSharp_stack/asp_core/dojoDachi/Views/_ViewImports.cshtml"
using dojoDachi;

#line default
#line hidden
#line 2 "/Users/nicolasricaldi/dojo/cSharp_stack/asp_core/dojoDachi/Views/_ViewImports.cshtml"
using dojoDachi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52261dc943140c28e74b3b5e9c4df5ec9b0acc71", @"/Views/Home/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9aef1bb5939ae43843ad92c26be50a6f5371068", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/nicolasricaldi/dojo/cSharp_stack/asp_core/dojoDachi/Views/Home/Info.cshtml"
  
    ViewData["Title"] = "Info Page";

#line default
#line hidden
            BeginContext(42, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(43, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52261dc943140c28e74b3b5e9c4df5ec9b0acc714140", async() => {
                BeginContext(49, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(54, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52261dc943140c28e74b3b5e9c4df5ec9b0acc714516", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(102, 1, true);
                WriteLiteral("\n");
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
            BeginContext(110, 1824, true);
            WriteLiteral(@"

<style>
    .main {
        text-align: left;
    }

    .choice {
        margin-left: 0;
        margin-top: 0;
        margin-bottom: 1rem;
    }

    p {
        margin: 0;
        margin-bottom: 1rem;
    }

    p:last-child {
        margin: 0;
    }

    .green {
        color: green;
    }   

    .red {
        color: red;
    }

</style>

<div class=""text-center"">
    <h1 class=""display-4"">DojoDachi</h1>
    <div class=""container"">

        <div class=""main"">
            <button class=""btn btn-primary choice"">Feed</button>
            <p>Feed your DojoDachi to receive Energy <span class=""green"">+5</span> , Fullness <span class=""green"">+5 - 10 </span>, and Meals <span class=""red"">-1</span>.</p>

            <button class=""btn btn-success choice"">Play</button>
            <p>Play with your DojoDachi to recieve Happiness <span class=""green"">+5 - 10 </span>, Energy <span class=""red"">-5</span>. Your Dojo Dachi must also have at least 5 Energy to play.</p>

            <button class=""btn btn-secondary c");
            WriteLiteral(@"hoice"">Work</button>
            <p>Work your DojoDachi to recieve Meals <span class=""green"">+1 - 3</span> and Energy <span class=""red"">-5</span>.</p>

            <button class=""btn btn-danger choice"">Sleep</button>
            <p> Have your DojoDachi sleep your DojoDachi to recieve Energy <span class=""green"">+15</span>, Fullness <span class=""red"">-5</span>, and Happiness <span class=""red"">-5</span>.</p>

            <h3>How to Win</h3>
            <p>You win if your DojoDachis Fullness, Happiness, and Energy all surpass 100.</p>

            <h3>How to Lose</h3>
            <p>You lose if your DojoDachis Fullness, Happiness, or Energy reach zero.</p>
            
        </div>
        
        <a href=""/restart""><button class=""btn btn-info"">Back home</button></a>     
    </div>
</div>
");
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