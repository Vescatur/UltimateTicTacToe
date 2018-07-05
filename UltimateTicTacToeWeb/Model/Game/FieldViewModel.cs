using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UltimateTicTacToeWeb.Model
{
    public class FieldViewModel
    {
        public Field Field;
        public int FieldY;
        public int FieldX;
        public bool Interactable;
        public bool HighlightMove;
        public int HighlightMoveSquareY;
        public int HighlightMoveSquareX;

        public FieldViewModel(SuperField superField, int fieldY, int fieldX)
        {
            Field = superField.Fields[fieldY][fieldX];
            FieldY = fieldY;
            FieldX = fieldX;
            Interactable = IsInteractable(superField, fieldY, fieldX);
            if (superField.HighlightMove)
            {    
                if(fieldY == superField.HighlightMoveFieldY && fieldX == superField.HighlightMoveFieldX)
                {
                    HighlightMove = true;
                }
                else
                {
                    HighlightMove = false;
                }
            }
            else
            {
                HighlightMove = false;
            }

            HighlightMoveSquareY = superField.HighlightMoveSquareY;
            HighlightMoveSquareX = superField.HighlightMoveSquareX;
        }

        private bool IsInteractable(SuperField superField, int fieldY, int fieldX)
        {
            if (superField.Winner != FieldState.None)
                return false;

            if (superField.Fields[fieldY][fieldX].winner != FieldState.None)
                return false;

            if (!superField.TurnRestrictedToField)
                return true;

            if (superField.RestrictedToFieldY == fieldY && superField.RestrictedToFieldX == fieldX)
                return true;

            return false;
        }
    }
}
