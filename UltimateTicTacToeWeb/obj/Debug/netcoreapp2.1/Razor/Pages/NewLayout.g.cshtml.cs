#pragma checksum "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\NewLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6890f577563217e5446df1b8aa790adf68653dc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_NewLayout), @"mvc.1.0.razor-page", @"/Pages/NewLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/NewLayout.cshtml", typeof(AspNetCore.Pages_NewLayout), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6890f577563217e5446df1b8aa790adf68653dc3", @"/Pages/NewLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_NewLayout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site2.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-gr-c-s-loaded", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\NewLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(84, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(113, 156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc339a444685410a99d650fe77b14207", async() => {
                BeginContext(119, 65, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
                EndContext();
                BeginContext(184, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "af580e648afd4c9b832eb4c3253837c4", async() => {
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
                BeginContext(230, 32, true);
                WriteLiteral("\r\n    <title>NewLayout</title>\r\n");
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
            BeginContext(269, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(271, 9618, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2f217d6cfef43ba89d208958e0b4989", async() => {
                BeginContext(312, 9570, true);
                WriteLiteral(@"
    <div class=""header"">
        <a href=""/ttt"">leave</a>
        <span id=""version"">
            <a title=""Change colors!"" href=""javascript:togglecolors();"">paint!</a><br>
        </span>
        <h1 id=""uttt_title"" style=""display: none;"">Ultimate Tic Tac Toe</h1>
        <h1 id=""win_title"">
            <span></span>
        </h1><h1 id=""names_title"" style=""display: block;"">
            <span id=""p1name"">ivan</span>
            &nbsp;vs&nbsp;
            <span id=""p2name"">michael</span>
        </h1>
    </div>

    <div class=""big_field field"" id=""big_field"" style=""width: 550px; height: 550px;"">
        <div class=""big_cell cell top left player1"">
            <div class=""small_field field"">
                <div class=""small_cell cell top left"" data-fieldnr=""0""></div>
                <div class=""small_cell cell top center"" data-fieldnr=""1""></div>
                <div class=""small_cell cell top right"" data-fieldnr=""2""></div>
                <br>
                <div class=""small_cell c");
                WriteLiteral(@"ell middle left"" data-fieldnr=""3""></div>
                <div class=""small_cell cell middle center"" data-fieldnr=""4""></div>
                <div class=""small_cell cell middle right"" data-fieldnr=""5""></div>
                <br>
                <div class=""small_cell cell bottom left player1"" data-fieldnr=""6""></div>
                <div class=""small_cell cell bottom center player1"" data-fieldnr=""7""></div>
                <div class=""small_cell cell bottom right player1"" data-fieldnr=""8""></div>
            </div>
        </div>
        <div class=""big_cell cell top center"">
            <div class=""small_field field"">
                <div class=""small_cell cell top left"" data-fieldnr=""9""></div>
                <div class=""small_cell cell top center"" data-fieldnr=""10""></div>
                <div class=""small_cell cell top right player1"" data-fieldnr=""11""></div>
                <br>
                <div class=""small_cell cell middle left"" data-fieldnr=""12""></div>
                <div class=""small_ce");
                WriteLiteral(@"ll cell middle center"" data-fieldnr=""13""></div>
                <div class=""small_cell cell middle right"" data-fieldnr=""14""></div>
                <br>
                <div class=""small_cell cell bottom left"" data-fieldnr=""15""></div>
                <div class=""small_cell cell bottom center"" data-fieldnr=""16""></div>
                <div class=""small_cell cell bottom right"" data-fieldnr=""17""></div>
            </div>
        </div>
        <div class=""big_cell cell top right"">
            <div class=""small_field field"">
                <div class=""small_cell cell top left"" data-fieldnr=""18""></div>
                <div class=""small_cell cell top center"" data-fieldnr=""19""></div>
                <div class=""small_cell cell top right"" data-fieldnr=""20""></div>
                <br>
                <div class=""small_cell cell middle left"" data-fieldnr=""21""></div>
                <div class=""small_cell cell middle center"" data-fieldnr=""22""></div>
                <div class=""small_cell cell middle right");
                WriteLiteral(@""" data-fieldnr=""23""></div>
                <br>
                <div class=""small_cell cell bottom left"" data-fieldnr=""24""></div>
                <div class=""small_cell cell bottom center"" data-fieldnr=""25""></div>
                <div class=""small_cell cell bottom right player2"" data-fieldnr=""26""><div class=""animator""></div></div>
            </div>
        </div>
        <br>
        <div class=""big_cell cell middle left"">
            <div class=""small_field field"">
                <div class=""small_cell cell top left"" data-fieldnr=""27""></div>
                <div class=""small_cell cell top center"" data-fieldnr=""28""></div>
                <div class=""small_cell cell top right"" data-fieldnr=""29""></div>
                <br>
                <div class=""small_cell cell middle left"" data-fieldnr=""30""></div>
                <div class=""small_cell cell middle center"" data-fieldnr=""31""></div>
                <div class=""small_cell cell middle right"" data-fieldnr=""32""></div>
                <br>
   ");
                WriteLiteral(@"             <div class=""small_cell cell bottom left"" data-fieldnr=""33""></div>
                <div class=""small_cell cell bottom center"" data-fieldnr=""34""></div>
                <div class=""small_cell cell bottom right"" data-fieldnr=""35""></div>
            </div>
        </div>
        <div class=""big_cell cell middle center"">
            <div class=""small_field field"">
                <div class=""small_cell cell top left"" data-fieldnr=""36""></div>
                <div class=""small_cell cell top center"" data-fieldnr=""37""></div>
                <div class=""small_cell cell top right"" data-fieldnr=""38""></div>
                <br>
                <div class=""small_cell cell middle left"" data-fieldnr=""39""></div>
                <div class=""small_cell cell middle center"" data-fieldnr=""40""></div>
                <div class=""small_cell cell middle right"" data-fieldnr=""41""></div>
                <br>
                <div class=""small_cell cell bottom left"" data-fieldnr=""42""></div>
                <div ");
                WriteLiteral(@"class=""small_cell cell bottom center"" data-fieldnr=""43""></div>
                <div class=""small_cell cell bottom right"" data-fieldnr=""44""></div>
            </div>
        </div>
        <div class=""big_cell cell middle right"">
            <div class=""small_field field"">
                <div class=""small_cell cell top left"" data-fieldnr=""45""></div>
                <div class=""small_cell cell top center"" data-fieldnr=""46""></div>
                <div class=""small_cell cell top right"" data-fieldnr=""47""></div>
                <br>
                <div class=""small_cell cell middle left"" data-fieldnr=""48""></div>
                <div class=""small_cell cell middle center"" data-fieldnr=""49""></div>
                <div class=""small_cell cell middle right"" data-fieldnr=""50""></div>
                <br>
                <div class=""small_cell cell bottom left"" data-fieldnr=""51""></div>
                <div class=""small_cell cell bottom center"" data-fieldnr=""52""></div>
                <div class=""small_cell");
                WriteLiteral(@" cell bottom right"" data-fieldnr=""53""></div>
            </div>
        </div>
        <br>
        <div class=""big_cell cell bottom left"">
            <div class=""small_field field"">
                <div class=""small_cell cell top left player2"" data-fieldnr=""54""><div class=""animator""></div></div>
                <div class=""small_cell cell top center"" data-fieldnr=""55""></div>
                <div class=""small_cell cell top right"" data-fieldnr=""56""></div>
                <br>
                <div class=""small_cell cell middle left"" data-fieldnr=""57""></div>
                <div class=""small_cell cell middle center"" data-fieldnr=""58""></div>
                <div class=""small_cell cell middle right"" data-fieldnr=""59""></div>
                <br>
                <div class=""small_cell cell bottom left"" data-fieldnr=""60""></div>
                <div class=""small_cell cell bottom center"" data-fieldnr=""61""></div>
                <div class=""small_cell cell bottom right"" data-fieldnr=""62""></div>
       ");
                WriteLiteral(@"     </div>
        </div>
        <div class=""big_cell cell bottom center"">
            <div class=""small_field field"">
                <div class=""small_cell cell top left player2"" data-fieldnr=""63""><div class=""animator""></div></div>
                <div class=""small_cell cell top center"" data-fieldnr=""64""></div>
                <div class=""small_cell cell top right"" data-fieldnr=""65""></div>
                <br>
                <div class=""small_cell cell middle left"" data-fieldnr=""66""></div>
                <div class=""small_cell cell middle center"" data-fieldnr=""67""></div>
                <div class=""small_cell cell middle right"" data-fieldnr=""68""></div>
                <br>
                <div class=""small_cell cell bottom left"" data-fieldnr=""69""></div>
                <div class=""small_cell cell bottom center"" data-fieldnr=""70""></div>
                <div class=""small_cell cell bottom right"" data-fieldnr=""71""></div>
            </div>
        </div>
        <div class=""big_cell cell bo");
                WriteLiteral(@"ttom right"">
            <div class=""small_field field"">
                <div class=""small_cell cell top left player2"" data-fieldnr=""72""><div class=""animator""></div></div>
                <div class=""small_cell cell top center yellow interactive"" data-fieldnr=""73""></div>
                <div class=""small_cell cell top right yellow interactive"" data-fieldnr=""74""></div>
                <br>
                <div class=""small_cell cell middle left yellow interactive"" data-fieldnr=""75""></div>
                <div class=""small_cell cell middle center yellow interactive"" data-fieldnr=""76""></div>
                <div class=""small_cell cell middle right yellow interactive"" data-fieldnr=""77""></div>
                <br>
                <div class=""small_cell cell bottom left yellow interactive"" data-fieldnr=""78""></div>
                <div class=""small_cell cell bottom center yellow interactive"" data-fieldnr=""79""></div>
                <div class=""small_cell cell bottom right yellow interactive"" data-fieldnr");
                WriteLiteral(@"=""80""></div>
            </div>
        </div>
    </div>

    <div id=""header_infos"">
        Move-Nr:
        <span id=""move_nr"">8</span>&nbsp;&nbsp;&nbsp;
        <span id=""whoseturn"">It is your turn.</span>
    </div>

    <div id=""info_box"">Seems your opponent has lost his connection. Keep the URL to resume the game later.</div>
    
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9889, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UltimateTicTacToeWeb.Pages.NewLayoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UltimateTicTacToeWeb.Pages.NewLayoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UltimateTicTacToeWeb.Pages.NewLayoutModel>)PageContext?.ViewData;
        public UltimateTicTacToeWeb.Pages.NewLayoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
