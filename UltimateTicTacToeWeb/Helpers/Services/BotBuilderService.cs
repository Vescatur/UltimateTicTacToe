using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UltimateTicTacToeWeb.Model;
using UltimateTicTacToeWeb.Model.Bot;

namespace UltimateTicTacToeWeb.Helpers.Services
{
    public class BotBuilderService
    {

        public Bot CreateBasicBot(bool winnerReversed)
        {
            Bot bot = new Bot();
            BasicSettingsForFieldScores(bot.fieldRowsDiagonal);
            BasicSettingsForFieldScores(bot.fieldRowsEdge);
            BasicSettingsForFieldScores(bot.fieldRowsMiddle);

            BasicSettingsForSuperFieldScores(bot.superFieldRowsDiagonal);
            BasicSettingsForSuperFieldScores(bot.superFieldRowsEdge);
            BasicSettingsForSuperFieldScores(bot.superFieldRowsMiddle);

            if (winnerReversed)
            {
                bot = new Bot(bot, true);
            }
            return bot;
        }

        private int ScoreFromFieldScoreState(FieldScoreState state)
        {
            if (state == FieldScoreState.X5)
                return 300;
            if (state == FieldScoreState.X4)
                return 200;
            if (state == FieldScoreState.X3)
                return 100;
            if (state == FieldScoreState.X2)
                return 50;
            if (state == FieldScoreState.X1) 
                return 25;
            if (state == FieldScoreState.Empty)
                return 0;
            if (state == FieldScoreState.O1)
                return -25;
            if (state == FieldScoreState.O2)
                return -50;
            if (state == FieldScoreState.O3)
                return -100;
            if (state == FieldScoreState.O4)
                return -200;
            if (state == FieldScoreState.O5)
                return -300;
            return 0;
        }


        private int ScoreFromFieldScoreStates(FieldScoreState state1, FieldScoreState state2, FieldScoreState state3)
        {
            if (state1 == FieldScoreState.Draw || state2 == FieldScoreState.Draw || state3 == FieldScoreState.Draw)
                return 0;

            return ScoreFromFieldScoreState(state1) + ScoreFromFieldScoreState(state2) + ScoreFromFieldScoreState(state3);

        }

        private void BasicSettingsForSuperFieldScores(int[,,] array)
        {
            foreach (FieldScoreState fieldScoreState1 in (FieldScoreState[])Enum.GetValues(typeof(FieldScoreState)))
            {
                foreach (FieldScoreState fieldScoreState2 in (FieldScoreState[])Enum.GetValues(typeof(FieldScoreState)))
                {
                    foreach (FieldScoreState fieldScoreState3 in (FieldScoreState[])Enum.GetValues(typeof(FieldScoreState)))
                    {
                        array[(int)fieldScoreState1, (int)fieldScoreState2, (int)fieldScoreState3] = ScoreFromFieldScoreStates(fieldScoreState1, fieldScoreState2, fieldScoreState3);
                    }
                }
            }
        }

        private void BasicSettingsForFieldScores(int[,,] array)
        {
            SetArray(array, (int)SquareState.Empty, (int)SquareState.Empty, (int)SquareState.Empty, 0);
            SetArray(array, (int)SquareState.Empty, (int)SquareState.Empty, (int)SquareState.X, 100);
            SetArray(array, (int)SquareState.Empty, (int)SquareState.Empty, (int)SquareState.O, -100);

            SetArray(array, (int)SquareState.Empty, (int)SquareState.X, (int)SquareState.Empty, 100);
            SetArray(array, (int)SquareState.Empty, (int)SquareState.X, (int)SquareState.X, 1000);
            SetArray(array, (int)SquareState.Empty, (int)SquareState.X, (int)SquareState.O, 0);

            SetArray(array, (int)SquareState.Empty, (int)SquareState.O, (int)SquareState.Empty, -100);
            SetArray(array, (int)SquareState.Empty, (int)SquareState.O, (int)SquareState.X, 0);
            SetArray(array, (int)SquareState.Empty, (int)SquareState.O, (int)SquareState.O, -1000);

            SetArray(array, (int)SquareState.X, (int)SquareState.Empty, (int)SquareState.X, 1000);
            SetArray(array, (int)SquareState.X, (int)SquareState.Empty, (int)SquareState.O, 0);

            //SetArray(array, (int)SquareState.X, (int)SquareState.X, (int)SquareState.X, 1000);
            SetArray(array, (int)SquareState.X, (int)SquareState.X, (int)SquareState.O, 0);

            SetArray(array, (int)SquareState.X, (int)SquareState.O, (int)SquareState.X, 0);
            SetArray(array, (int)SquareState.X, (int)SquareState.O, (int)SquareState.O, 0);

            SetArray(array, (int)SquareState.O, (int)SquareState.Empty, (int)SquareState.O, -1000);

            SetArray(array, (int)SquareState.O, (int)SquareState.X, (int)SquareState.O, 0);

            //SetArray(array, (int)SquareState.O, (int)SquareState.O, (int)SquareState.O, -1000);
        }

        private void SetArray(int[,,] array, int index1, int index2, int index3, int value)
        {
            array[index1, index2, index3] = value;
            array[index3, index2, index1] = value;
        }

    }
}
