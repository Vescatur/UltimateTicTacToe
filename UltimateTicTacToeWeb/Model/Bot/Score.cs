using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UltimateTicTacToeWeb.Model
{
    public class Score
    {
        public int[][] FieldScores { get; set; }
        public int SuperFieldScore { get; set; }

        public Score(int[][] fieldScore, int superFieldScore)
        {
            FieldScores = fieldScore;
            SuperFieldScore = superFieldScore;
        }

        public int Totaal()
        {
            var score = SuperFieldScore;
            foreach (var fieldScoreRow in FieldScores)
            {
                foreach(var fieldScore in fieldScoreRow)
                {
                    score += fieldScore;
                }
            }
            return score;
        }
    }
}
