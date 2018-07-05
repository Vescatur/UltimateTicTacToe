using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UltimateTicTacToeWeb.Model.Bot
{
    public class Bot
    {
        /// <summary>
        /// The SquareState is used as index
        /// </summary>
        public int[,,] fieldRowsEdge;
        public int[,,] fieldRowsMiddle;
        public int[,,] fieldRowsDiagonal;

        /// <summary>
        /// The FieldScoreState is used as index
        /// </summary>
        public int[,,] superFieldRowsEdge;
        public int[,,] superFieldRowsMiddle;
        public int[,,] superFieldRowsDiagonal;
        
        public bool winnerReversed;
        
        public Bot()
        {
            fieldRowsEdge = new int[3, 3, 3];
            fieldRowsMiddle = new int[3, 3, 3];
            fieldRowsDiagonal = new int[3, 3, 3];

            superFieldRowsEdge = new int[12, 12, 12];
            superFieldRowsMiddle = new int[12, 12, 12];
            superFieldRowsDiagonal = new int[12, 12, 12];
        }


        public Bot(Bot bot,bool reverse)
        {
            if (reverse)
            {
                winnerReversed = !bot.winnerReversed;
                fieldRowsEdge = ReverseCloneFieldArray(bot.fieldRowsEdge);
                fieldRowsMiddle = ReverseCloneFieldArray(bot.fieldRowsMiddle);
                fieldRowsDiagonal = ReverseCloneFieldArray(bot.fieldRowsDiagonal);

                superFieldRowsEdge = ReverseCloneSuperFieldArray(bot.superFieldRowsEdge);
                superFieldRowsMiddle = ReverseCloneSuperFieldArray(bot.superFieldRowsMiddle);
                superFieldRowsDiagonal = ReverseCloneSuperFieldArray(bot.superFieldRowsDiagonal);
            }
            else
            {
                fieldRowsEdge = bot.fieldRowsEdge.Clone() as int[,,];
                fieldRowsMiddle = bot.fieldRowsMiddle.Clone() as int[,,];
                fieldRowsDiagonal = bot.fieldRowsDiagonal.Clone() as int[,,];

                superFieldRowsEdge = bot.superFieldRowsEdge.Clone() as int[,,];
                superFieldRowsMiddle = bot.superFieldRowsMiddle.Clone() as int[,,];
                superFieldRowsDiagonal = bot.superFieldRowsDiagonal.Clone() as int[,,];
            }
        }

        private int ReverseFieldScoreState(FieldScoreState squareState)
        {
            if (squareState == FieldScoreState.Empty)
                return (int)FieldScoreState.Empty;
            if (squareState == FieldScoreState.Draw)
                return (int)FieldScoreState.Draw;

            if (squareState == FieldScoreState.X5)
                return (int)FieldScoreState.O5;
            if (squareState == FieldScoreState.X4)
                return (int)FieldScoreState.O4;
            if (squareState == FieldScoreState.X3)
                return (int)FieldScoreState.O3;
            if (squareState == FieldScoreState.X2)
                return (int)FieldScoreState.O2;
            if (squareState == FieldScoreState.X1)
                return (int)FieldScoreState.O1;


            if (squareState == FieldScoreState.O5)
                return (int)FieldScoreState.X5;
            if (squareState == FieldScoreState.O4)
                return (int)FieldScoreState.X4;
            if (squareState == FieldScoreState.O3)
                return (int)FieldScoreState.X3;
            if (squareState == FieldScoreState.O2)
                return (int)FieldScoreState.X2;
            if (squareState == FieldScoreState.O1)
                return (int)FieldScoreState.X1;

            return (int)FieldScoreState.Empty;
        }

        private int[,,] ReverseCloneSuperFieldArray(int[,,] array)
        {
            var newArray = new int[12, 12, 12];
            foreach (FieldScoreState FieldScoreState1 in (FieldScoreState[])Enum.GetValues(typeof(FieldScoreState)))
            {
                foreach (FieldScoreState FieldScoreState2 in (FieldScoreState[])Enum.GetValues(typeof(FieldScoreState)))
                {
                    foreach (FieldScoreState FieldScoreState3 in (FieldScoreState[])Enum.GetValues(typeof(FieldScoreState)))
                    {
                        newArray[ReverseFieldScoreState(FieldScoreState1), ReverseFieldScoreState(FieldScoreState2), ReverseFieldScoreState(FieldScoreState3)] =
                            array[(int)FieldScoreState1, (int)FieldScoreState2, (int)FieldScoreState3];
                    }
                }
            }
            return newArray;
        }

        private int ReverseSquareState(SquareState squareState)
        {
            if (squareState == SquareState.Empty)
                return (int)SquareState.Empty;
            if (squareState == SquareState.O)
                return (int)SquareState.X;

            return (int)SquareState.O;
        }

        private int[,,] ReverseCloneFieldArray(int[,,] array)
        {
            var newArray = new int[3, 3, 3];
            foreach (SquareState SquareState1 in (SquareState[])Enum.GetValues(typeof(SquareState)))
            {
                foreach (SquareState SquareState2 in (SquareState[])Enum.GetValues(typeof(SquareState)))
                {
                    foreach (SquareState SquareState3 in (SquareState[])Enum.GetValues(typeof(SquareState)))
                    {
                        newArray[ReverseSquareState(SquareState1), ReverseSquareState(SquareState2), ReverseSquareState(SquareState3)] =
                            array[(int)SquareState1, (int)SquareState2, (int)SquareState3];
                    }
                }
            }
            return newArray;
        }

    }
}
