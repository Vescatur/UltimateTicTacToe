#pragma checksum "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8796960be1a3b6f8c04be8e1f16d2ade844753b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(AspNetCore.Pages_Index), null)]
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
#line 3 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
using UltimateTicTacToeWeb.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8796960be1a3b6f8c04be8e1f16d2ade844753b", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(154, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(458, 354, true);
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
");
            EndContext();
#line 35 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
         if (Model.superField.PlayersTurn == SquareState.O)
        {

#line default
#line hidden
            BeginContext(884, 47, true);
            WriteLiteral("            <span id=\"p1name\">player O</span>\r\n");
            EndContext();
#line 38 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(967, 35, true);
            WriteLiteral("            <span>player O</span>\r\n");
            EndContext();
#line 42 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1013, 24, true);
            WriteLiteral("        &nbsp;vs&nbsp;\r\n");
            EndContext();
#line 44 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
         if (Model.superField.PlayersTurn == SquareState.X)
        {

#line default
#line hidden
            BeginContext(1109, 47, true);
            WriteLiteral("            <span id=\"p2name\">player X</span>\r\n");
            EndContext();
#line 47 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1192, 35, true);
            WriteLiteral("            <span>player X</span>\r\n");
            EndContext();
#line 51 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1238, 21, true);
            WriteLiteral("    </h1>\r\n</div>\r\n\r\n");
            EndContext();
#line 55 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
 if (Model.errorMessage != null)
{
    

#line default
#line hidden
            BeginContext(1301, 18, false);
#line 57 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
Write(Model.errorMessage);

#line default
#line hidden
            EndContext();
#line 57 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
                       ;
}
else
{


#line default
#line hidden
            BeginContext(1336, 99, true);
            WriteLiteral("    <div class=\"big_field field\" id=\"big_field\" style=\"width: 550px; height: 550px;\">\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1435, "\"", 1511, 4);
            WriteAttributeValue("", 1443, "big_cell", 1443, 8, true);
            WriteAttributeValue(" ", 1451, "top", 1452, 4, true);
            WriteAttributeValue(" ", 1455, "left", 1456, 5, true);
#line 63 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
WriteAttributeValue(" ", 1460, GetFieldCssClasses(Model.superField.Fields[0][0]), 1461, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1512, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(1528, 83, false);
#line 64 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
       Write(await Html.PartialAsync("Field.cshtml", new FieldViewModel(Model.superField, 0, 0)));

#line default
#line hidden
            EndContext();
            BeginContext(1611, 30, true);
            WriteLiteral("\r\n        </div>\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1641, "\"", 1719, 4);
            WriteAttributeValue("", 1649, "big_cell", 1649, 8, true);
            WriteAttributeValue(" ", 1657, "top", 1658, 4, true);
            WriteAttributeValue(" ", 1661, "center", 1662, 7, true);
#line 66 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
WriteAttributeValue(" ", 1668, GetFieldCssClasses(Model.superField.Fields[0][1]), 1669, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1720, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(1736, 83, false);
#line 67 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
       Write(await Html.PartialAsync("Field.cshtml", new FieldViewModel(Model.superField, 0, 1)));

#line default
#line hidden
            EndContext();
            BeginContext(1819, 30, true);
            WriteLiteral("\r\n        </div>\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1849, "\"", 1926, 4);
            WriteAttributeValue("", 1857, "big_cell", 1857, 8, true);
            WriteAttributeValue(" ", 1865, "top", 1866, 4, true);
            WriteAttributeValue(" ", 1869, "right", 1870, 6, true);
#line 69 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
WriteAttributeValue(" ", 1875, GetFieldCssClasses(Model.superField.Fields[0][2]), 1876, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1927, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(1943, 83, false);
#line 70 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
       Write(await Html.PartialAsync("Field.cshtml", new FieldViewModel(Model.superField, 0, 2)));

#line default
#line hidden
            EndContext();
            BeginContext(2026, 44, true);
            WriteLiteral("\r\n        </div>\r\n        <br>\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2070, "\"", 2149, 4);
            WriteAttributeValue("", 2078, "big_cell", 2078, 8, true);
            WriteAttributeValue(" ", 2086, "middle", 2087, 7, true);
            WriteAttributeValue(" ", 2093, "left", 2094, 5, true);
#line 73 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
WriteAttributeValue(" ", 2098, GetFieldCssClasses(Model.superField.Fields[1][0]), 2099, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2150, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(2166, 83, false);
#line 74 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
       Write(await Html.PartialAsync("Field.cshtml", new FieldViewModel(Model.superField, 1, 0)));

#line default
#line hidden
            EndContext();
            BeginContext(2249, 30, true);
            WriteLiteral("\r\n        </div>\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2279, "\"", 2360, 4);
            WriteAttributeValue("", 2287, "big_cell", 2287, 8, true);
            WriteAttributeValue(" ", 2295, "middle", 2296, 7, true);
            WriteAttributeValue(" ", 2302, "center", 2303, 7, true);
#line 76 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
WriteAttributeValue(" ", 2309, GetFieldCssClasses(Model.superField.Fields[1][1]), 2310, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2361, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(2377, 83, false);
#line 77 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
       Write(await Html.PartialAsync("Field.cshtml", new FieldViewModel(Model.superField, 1, 1)));

#line default
#line hidden
            EndContext();
            BeginContext(2460, 30, true);
            WriteLiteral("\r\n        </div>\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2490, "\"", 2570, 4);
            WriteAttributeValue("", 2498, "big_cell", 2498, 8, true);
            WriteAttributeValue(" ", 2506, "middle", 2507, 7, true);
            WriteAttributeValue(" ", 2513, "right", 2514, 6, true);
#line 79 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
WriteAttributeValue(" ", 2519, GetFieldCssClasses(Model.superField.Fields[1][2]), 2520, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2571, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(2587, 83, false);
#line 80 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
       Write(await Html.PartialAsync("Field.cshtml", new FieldViewModel(Model.superField, 1, 2)));

#line default
#line hidden
            EndContext();
            BeginContext(2670, 44, true);
            WriteLiteral("\r\n        </div>\r\n        <br>\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2714, "\"", 2793, 4);
            WriteAttributeValue("", 2722, "big_cell", 2722, 8, true);
            WriteAttributeValue(" ", 2730, "bottom", 2731, 7, true);
            WriteAttributeValue(" ", 2737, "left", 2738, 5, true);
#line 83 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
WriteAttributeValue(" ", 2742, GetFieldCssClasses(Model.superField.Fields[2][0]), 2743, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2794, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(2810, 83, false);
#line 84 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
       Write(await Html.PartialAsync("Field.cshtml", new FieldViewModel(Model.superField, 2, 0)));

#line default
#line hidden
            EndContext();
            BeginContext(2893, 30, true);
            WriteLiteral("\r\n        </div>\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2923, "\"", 3004, 4);
            WriteAttributeValue("", 2931, "big_cell", 2931, 8, true);
            WriteAttributeValue(" ", 2939, "bottom", 2940, 7, true);
            WriteAttributeValue(" ", 2946, "center", 2947, 7, true);
#line 86 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
WriteAttributeValue(" ", 2953, GetFieldCssClasses(Model.superField.Fields[2][1]), 2954, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3005, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(3021, 83, false);
#line 87 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
       Write(await Html.PartialAsync("Field.cshtml", new FieldViewModel(Model.superField, 2, 1)));

#line default
#line hidden
            EndContext();
            BeginContext(3104, 30, true);
            WriteLiteral("\r\n        </div>\r\n        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3134, "\"", 3214, 4);
            WriteAttributeValue("", 3142, "big_cell", 3142, 8, true);
            WriteAttributeValue(" ", 3150, "bottom", 3151, 7, true);
            WriteAttributeValue(" ", 3157, "right", 3158, 6, true);
#line 89 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
WriteAttributeValue(" ", 3163, GetFieldCssClasses(Model.superField.Fields[2][2]), 3164, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3215, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(3231, 83, false);
#line 90 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
       Write(await Html.PartialAsync("Field.cshtml", new FieldViewModel(Model.superField, 2, 2)));

#line default
#line hidden
            EndContext();
            BeginContext(3314, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(3346, 9, true);
            WriteLiteral("    <p>\r\n");
            EndContext();
#line 95 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
         if (Model.superField.Winner == FieldState.Draw)
        {

#line default
#line hidden
            BeginContext(3424, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(3438, 6, true);
            WriteLiteral("Draw\r\n");
            EndContext();
#line 98 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
        }
        else if (Model.superField.Winner == FieldState.X)
        {

#line default
#line hidden
            BeginContext(3525, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(3539, 14, true);
            WriteLiteral("Player X Won\r\n");
            EndContext();
#line 102 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
        }
        else if (Model.superField.Winner == FieldState.O)
        {

#line default
#line hidden
            BeginContext(3634, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(3648, 14, true);
            WriteLiteral("Player O Won\r\n");
            EndContext();
#line 106 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3673, 10, true);
            WriteLiteral("    </p>\r\n");
            EndContext();
            BeginContext(3685, 168, true);
            WriteLiteral("    <div id=\"header_infos\">\r\n        Move-Nr:\r\n        <span id=\"move_nr\">8</span>&nbsp;&nbsp;&nbsp;\r\n        <span id=\"whoseturn\">It is your turn.</span>\r\n    </div>\r\n");
            EndContext();
#line 114 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"

}

#line default
#line hidden
            BeginContext(3858, 150, true);
            WriteLiteral("\r\n<div id=\"info_box\">Seems your opponent has lost his connection. Keep the URL to resume the game later.</div>\r\n<table class=\"table table-bordered\">\r\n");
            EndContext();
#line 119 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
     foreach (var intRow in Model.score.FieldScores)
    {

#line default
#line hidden
            BeginContext(4069, 14, true);
            WriteLiteral("        <tr>\r\n");
            EndContext();
#line 122 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
             foreach (var number in intRow)
            {

#line default
#line hidden
            BeginContext(4143, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(4186, 6, false);
#line 125 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
               Write(number);

#line default
#line hidden
            EndContext();
            BeginContext(4192, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 127 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(4232, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 129 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(4254, 32, true);
            WriteLiteral("\r\n</table>\r\n<p>SuperFieldScore: ");
            EndContext();
            BeginContext(4287, 27, false);
#line 132 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
               Write(Model.score.SuperFieldScore);

#line default
#line hidden
            EndContext();
            BeginContext(4314, 17, true);
            WriteLiteral("</p>\r\n<p>Totaal: ");
            EndContext();
            BeginContext(4332, 20, false);
#line 133 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
      Write(Model.score.Totaal());

#line default
#line hidden
            EndContext();
            BeginContext(4352, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
#line 9 "C:\Users\Ivan\Documents\Develop\Visual Studio\UltimateTicTacToe\UltimateTicTacToeWeb\Pages\Index.cshtml"
           
    public string GetFieldCssClasses(Field field)
    {
        if (field.winner == FieldState.O)
        {
            return "player1";

        }
        else if (field.winner == FieldState.X)
        {
            return "player2";
        }
        return "";
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UltimateTicTacToeWeb.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UltimateTicTacToeWeb.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UltimateTicTacToeWeb.Pages.IndexModel>)PageContext?.ViewData;
        public UltimateTicTacToeWeb.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
