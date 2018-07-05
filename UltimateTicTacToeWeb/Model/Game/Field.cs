using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UltimateTicTacToeWeb.Model
{
    public class Field
    {
        public SquareState[][] Squares { get; set; } = {
           new SquareState[3],
           new SquareState[3],
           new SquareState[3]
        };

        public FieldState winner;

        public Field(Field field)
        {
            for(int y=0; y<3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Squares[y][x] = field.Squares[y][x];
                }
            }
            winner = field.winner;
        }

        public Field()
        {
        }
    }
}
