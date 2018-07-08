using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UltimateTicTacToeWeb.Model;
using UltimateTicTacToeWeb.Model.Bot;

namespace UltimateTicTacToeWeb.Helpers.Services
{
    public class SuperFieldEvalutionService
    {
        public Score EvaluateSuperField(SuperField superField, Bot bot)
        {
            int[][] fieldScore = new int[3][]{
                new int[3],
                new int[3],
                new int[3],
            };
            int superFieldScore = 0;

            for(int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    fieldScore[y][x] = EvaluateField(superField.Fields[y][x], bot);
                    if(y==1 && x== 1)
                    {
                        fieldScore[y][x] = fieldScore[y][x] * bot.fieldCenterMultiplier;
                    }else if((x+y)%2 == 0)
                    {
                        fieldScore[y][x] = fieldScore[y][x] * bot.fieldCornerMultiplier;
                    }
                    else
                    {
                        fieldScore[y][x] = fieldScore[y][x] * bot.fieldMiddleMultiplier;
                    }
                }
            }

            superFieldScore = EvaluateSuperFieldScore(superField, fieldScore, bot)*bot.superFieldMultiplier;

            return new Score(fieldScore, superFieldScore);
        }

        private int EvaluateSuperFieldScore(SuperField superField, int[][] fieldScore, Bot bot)
        {
            if (superField.Winner == FieldState.Draw)
                return 0;
            if (superField.Winner == FieldState.O)
                return bot.winnerReversed ? 8000 : -8000;
            if (superField.Winner == FieldState.X)
                return bot.winnerReversed ? -8000 : 8000;
            var score = 0;

            FieldScoreState[][] fieldScoreStates = new FieldScoreState[][]
            {
                new FieldScoreState[3],
                new FieldScoreState[3],
                new FieldScoreState[3],
            };

            for(int y = 0; y<3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    fieldScoreStates[y][x] = FieldScoreStateFromfield(superField.Fields[y][x], fieldScore[y][x], bot);
                }
            }

            score += bot.superFieldRowsEdge[(int)fieldScoreStates[0][0], (int)fieldScoreStates[0][1], (int)fieldScoreStates[0][2]];
            score += bot.superFieldRowsMiddle[(int)fieldScoreStates[1][0], (int)fieldScoreStates[1][1], (int)fieldScoreStates[1][2]];
            score += bot.superFieldRowsEdge[(int)fieldScoreStates[2][0], (int)fieldScoreStates[2][1], (int)fieldScoreStates[2][2]];

            score += bot.superFieldRowsEdge[(int)fieldScoreStates[0][0], (int)fieldScoreStates[1][0], (int)fieldScoreStates[2][0]];
            score += bot.superFieldRowsMiddle[(int)fieldScoreStates[0][1], (int)fieldScoreStates[1][1], (int)fieldScoreStates[2][1]];
            score += bot.superFieldRowsEdge[(int)fieldScoreStates[0][2], (int)fieldScoreStates[1][2], (int)fieldScoreStates[2][2]];

            score += bot.superFieldRowsDiagonal[(int)fieldScoreStates[0][0], (int)fieldScoreStates[1][1], (int)fieldScoreStates[2][2]];
            score += bot.superFieldRowsDiagonal[(int)fieldScoreStates[2][0], (int)fieldScoreStates[1][1], (int)fieldScoreStates[0][2]];

            return score;
        }

        private FieldScoreState FieldScoreStateFromfield(Field field, int score, Bot bot)
        {
            if (field.winner == FieldState.Draw)
                return FieldScoreState.Draw;

            if (score == 8000)
                return bot.winnerReversed ? FieldScoreState.O5 : FieldScoreState.X5;
            if (score >= 2000)
                return bot.winnerReversed ? FieldScoreState.O4 : FieldScoreState.X4;
            if (score >= 500)
                return bot.winnerReversed ? FieldScoreState.O3 : FieldScoreState.X3;
            if (score >= 125)
                return bot.winnerReversed ? FieldScoreState.O2 : FieldScoreState.X2;
            if (score >= 1)
                return bot.winnerReversed ? FieldScoreState.O1 : FieldScoreState.X1;

            if (score == 0)
                return FieldScoreState.Empty;

            if (score == -8000)
                return bot.winnerReversed ? FieldScoreState.X5 : FieldScoreState.O5;
            if (score <= -2000)
                return bot.winnerReversed ? FieldScoreState.X4 : FieldScoreState.O4;
            if (score <= -500)
                return bot.winnerReversed ? FieldScoreState.X3 : FieldScoreState.O3;
            if (score <= -125)
                return bot.winnerReversed ? FieldScoreState.X2 : FieldScoreState.O2;
            if (score <= -1)
                return bot.winnerReversed ? FieldScoreState.X1 : FieldScoreState.O1;

            return FieldScoreState.Empty;
        }

        private int EvaluateField(Field field, Bot bot)
        {
            if (field.winner == FieldState.O)
            {
                return bot.winnerReversed ? 8000 : -8000;
            }
            else if (field.winner == FieldState.X)
            {
                return bot.winnerReversed ? -8000 : 8000;
            }
            else if(field.winner == FieldState.Draw)
            {
                return 0;
            }

            var score = 0;
            var squares = field.Squares;

            score += bot.fieldRowsEdge[(int)squares[0][0], (int)squares[0][1], (int)squares[0][2]];
            score += bot.fieldRowsMiddle[(int)squares[1][0], (int)squares[1][1], (int)squares[1][2]];
            score += bot.fieldRowsEdge[(int)squares[2][0], (int)squares[2][1], (int)squares[2][2]];

            score += bot.fieldRowsEdge[(int)squares[0][0], (int)squares[1][0], (int)squares[2][0]];
            score += bot.fieldRowsMiddle[(int)squares[0][1], (int)squares[1][1], (int)squares[2][1]];
            score += bot.fieldRowsEdge[(int)squares[0][2], (int)squares[1][2], (int)squares[2][2]];

            score += bot.fieldRowsDiagonal[(int)squares[0][0], (int)squares[1][1], (int)squares[2][2]];
            score += bot.fieldRowsDiagonal[(int)squares[2][0], (int)squares[1][1], (int)squares[0][2]];

            return score;
        }
    }
}
