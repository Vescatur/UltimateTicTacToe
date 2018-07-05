using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UltimateTicTacToeWeb.Model.Game
{
    public class SquarePosition
    {
        public int FieldY {get;set; }
        public int FieldX { get; set; }
        public int SquareY { get; set; }
        public int SquareX { get; set; }

        public SquarePosition(int fieldY, int fieldX, int squareY, int squareX)
        {
            FieldY = fieldY;
            FieldX = fieldX;
            SquareY = squareY;
            SquareX = squareX;
        }
    }
}
