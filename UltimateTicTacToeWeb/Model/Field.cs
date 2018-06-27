using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UltimateTicTacToeWeb.Model
{
    public class Field
    {
        public SquareState[][] squares { get; set; } = {
           new SquareState[3],
           new SquareState[3],
           new SquareState[3]
        };

        public SquareState winner;

    }
}
