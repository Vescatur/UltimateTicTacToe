using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UltimateTicTacToeWeb.Model;

namespace UltimateTicTacToeWeb.Helpers.Services
{
    public class SuperFieldService
    {
        public bool IsMovePossible(SuperField superField, int fieldY, int fieldX, int squareY, int squareX)
        {
            //check of veld vol is
            if (superField.Winner != FieldState.None)
                return false;

            if (superField.Fields[fieldY][fieldX].winner != FieldState.None)
                return false;

            if (superField.Fields[fieldY][fieldX].Squares[squareY][squareX] != SquareState.Empty)
                return false;

            if (superField.TurnRestrictedToField)
            {
                if (fieldY != superField.RestrictedToFieldY)
                    return false;
                if (fieldX != superField.RestrictedToFieldX)
                    return false;
            }
            return true;
        }

        public void DoMove(SuperField superField, int fieldY, int fieldX, int squareY, int squareX)
        {
            if (IsMovePossible(superField, fieldY, fieldX, squareY, squareX))
            {
                superField.Fields[fieldY][fieldX].Squares[squareY][squareX] = superField.PlayersTurn;

                if (HasFieldThreeInARow(superField.Fields[fieldY][fieldX]))
                {
                    superField.Fields[fieldY][fieldX].winner = SquareStateToFieldState(superField.PlayersTurn);
                    if (HasSuperFieldThreeInARow(superField))
                    {
                        superField.Winner = SquareStateToFieldState(superField.PlayersTurn);
                    }
                }
                else
                {
                    if (IsFieldFull(superField.Fields[fieldY][fieldX]))
                    {
                        superField.Fields[fieldY][fieldX].winner = FieldState.Draw;
                        if (IsSuperFieldFull(superField))
                        {
                            superField.Winner = FieldState.Draw;
                        }
                    }
                }
                
                if (superField.Fields[squareY][squareX].winner != FieldState.None)
                {
                    superField.TurnRestrictedToField = false;
                }
                else
                {
                    superField.TurnRestrictedToField = true;
                    superField.RestrictedToFieldY = squareY;
                    superField.RestrictedToFieldX = squareX;
                }

                superField.HighlightMove = true;
                superField.HighlightMoveFieldY = fieldY;
                superField.HighlightMoveFieldX = fieldX;
                superField.HighlightMoveSquareY = squareY;
                superField.HighlightMoveSquareX = squareX;

                if (superField.PlayersTurn == SquareState.X)
                {
                    superField.PlayersTurn = SquareState.O;
                }
                else
                {
                    superField.PlayersTurn = SquareState.X;
                }

            }
            else
            {
                superField.HighlightMove = false;
            }
        }

        private bool IsSuperFieldFull(SuperField superField)
        {
            foreach (var fieldRow in superField.Fields)
            {
                foreach (var field in fieldRow)
                {
                    if (field.winner == FieldState.None)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool HasSuperFieldThreeInARow(SuperField superField)
        {
            foreach (var fieldRow in superField.Fields)
            {
                if (AreThreeInARowField(fieldRow[0], fieldRow[1], fieldRow[2]))
                    return true;
            }

            for (int i = 0; i < 3; i++)
            {
                if (AreThreeInARowField(superField.Fields[0][i], superField.Fields[1][i], superField.Fields[2][i]))
                    return true;

            }
            if (AreThreeInARowField(superField.Fields[0][0], superField.Fields[1][1], superField.Fields[2][2]))
                return true;
            if (AreThreeInARowField(superField.Fields[2][0], superField.Fields[1][1], superField.Fields[0][2]))
                return true;

            return false;
        }

        private bool AreThreeInARowField(Field field1, Field field2, Field field3)
        {
            if (field1.winner == field2.winner && field2.winner == field3.winner)
            {
                if (field1.winner == FieldState.O || field1.winner == FieldState.X)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsFieldFull(Field field)
        {
            foreach(var squareRow in field.Squares)
            {
                foreach (var square in squareRow)
                {
                    if(square == SquareState.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private FieldState SquareStateToFieldState(SquareState playersTurn)
        {
            if(playersTurn == SquareState.O)
            {
                return FieldState.O;
            }
            return FieldState.X;
        }


        private bool HasFieldThreeInARow(Field field)
        {
            foreach (var squareRow in field.Squares)
            {
                if (AreThreeInARow(squareRow[0], squareRow[1], squareRow[2]))
                    return true;
            }

            for (int i=0; i<3;i++)
            {
                if (AreThreeInARow(field.Squares[0][i], field.Squares[1][i], field.Squares[2][i]))
                    return true;

            }
            if (AreThreeInARow(field.Squares[0][0], field.Squares[1][1], field.Squares[2][2]))
                return true;
            if (AreThreeInARow(field.Squares[2][0], field.Squares[1][1], field.Squares[0][2]))
                return true;

            return false;
        }

        private bool AreThreeInARow(SquareState squareState1, SquareState squareState2, SquareState squareState3)
        {
            if(squareState1 == squareState2 && squareState2 == squareState3)
            {
                if(squareState1 != SquareState.Empty)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
