

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UltimateTicTacToeWeb.Model
{
    public class SuperField
    {
        public SquareState PlayersTurn = SquareState.X;

        public bool TurnRestrictedToField = false;
        public int RestrictedToFieldY = 0;
        public int RestrictedToFieldX = 0;

        public bool HighlightMove = false;
        public int HighlightMoveFieldY = 0;
        public int HighlightMoveFieldX = 0;
        public int HighlightMoveSquareY = 0;
        public int HighlightMoveSquareX = 0;

        public Field[][] Fields { get; set; } = {
           new Field[] { new Field(),new Field(),new Field()},
           new Field[] { new Field(),new Field(),new Field()},
           new Field[] { new Field(),new Field(),new Field()}
        };

        public FieldState Winner;

        public SuperField()
        {

        }

        public SuperField(SuperField superField)
        {
            Winner = superField.Winner;

            PlayersTurn = superField.PlayersTurn;

            TurnRestrictedToField = superField.TurnRestrictedToField;
            RestrictedToFieldY = superField.RestrictedToFieldY;
            RestrictedToFieldX = superField.RestrictedToFieldX;

            HighlightMove = superField.HighlightMove;
            HighlightMoveFieldY = superField.HighlightMoveFieldY;
            HighlightMoveFieldX = superField.HighlightMoveFieldX;
            HighlightMoveSquareY = superField.HighlightMoveSquareY;
            HighlightMoveSquareX = superField.HighlightMoveSquareX;

            Fields = new Field[][]{
                new Field[] { new Field(superField.Fields[0][0]), new Field(superField.Fields[0][1]), new Field(superField.Fields[0][2]) },
                new Field[] { new Field(superField.Fields[1][0]), new Field(superField.Fields[1][1]), new Field(superField.Fields[1][2]) },
                new Field[] { new Field(superField.Fields[2][0]), new Field(superField.Fields[2][1]), new Field(superField.Fields[2][2]) }
            };
        }
    }
}
