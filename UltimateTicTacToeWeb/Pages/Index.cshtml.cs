using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UltimateTicTacToeWeb.Model;

namespace UltimateTicTacToeWeb.Pages
{
    public class IndexModel : PageModel
    {
        public SuperField superField { get; set; }

        public void OnGet()
        {
            superField = new SuperField();
            superField.fields[0][0].squares[0][0] = SquareState.O;
            superField.fields[0][0].squares[1][1] = SquareState.X;
            superField.fields[0][0].squares[1][2] = SquareState.O;

            superField.fields[1][0].squares[0][0] = SquareState.O;
            superField.fields[1][0].squares[1][1] = SquareState.X;
            superField.fields[1][0].squares[1][2] = SquareState.O;

            superField.fields[1][2].squares[0][0] = SquareState.O;
            superField.fields[1][2].squares[1][1] = SquareState.X;
            superField.fields[1][2].squares[1][2] = SquareState.O;
        }
    }
}