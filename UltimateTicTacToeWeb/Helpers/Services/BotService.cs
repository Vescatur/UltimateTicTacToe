using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UltimateTicTacToeWeb.Model;
using UltimateTicTacToeWeb.Model.Bot;
using UltimateTicTacToeWeb.Model.Game;

namespace UltimateTicTacToeWeb.Helpers.Services
{

    public class BotService
    {
        public SuperFieldService superFieldService;
        public SuperFieldEvalutionService superFieldEvalutionService;

        public BotService(SuperFieldService superFieldService, SuperFieldEvalutionService superFieldEvalutionService)
        {
            this.superFieldService = superFieldService;
            this.superFieldEvalutionService = superFieldEvalutionService;
        }

        public int findScoreForBestMove(SuperField superField, Bot bot, int iterations, int step)
        {
            if (step >= iterations)
            {
                return superFieldEvalutionService.EvaluateSuperField(superField, bot).Totaal();
            }
            else
            {
                var isScorePositive = step % 2 == 0;
                var bestScore = isScorePositive ? -100000000 : 100000000;
                SquarePosition bestPosition = new SquarePosition(0, 0, 0, 0);

                for (int fieldY = 0; fieldY < 3; fieldY++)
                {
                    for (int fieldX = 0; fieldX < 3; fieldX++)
                    {
                        for (int squareY = 0; squareY < 3; squareY++)
                        {
                            for (int squareX = 0; squareX < 3; squareX++)
                            {
                                if (superFieldService.IsMovePossible(superField, fieldY, fieldX, squareY, squareX))
                                {
                                    var tempSuperField = new SuperField(superField);
                                    superFieldService.DoMove(tempSuperField, fieldY, fieldX, squareY, squareX);
                                    var newIterations = iterations;
                                    if (!tempSuperField.TurnRestrictedToField)
                                    {
                                        newIterations--;
                                    }
                                    var score = findScoreForBestMove(tempSuperField, bot, newIterations, step+1);
                                    if (isScorePositive && score >= bestScore || !isScorePositive && score <= bestScore)
                                    {
                                        bestScore = score;
                                    }
                                }
                            }
                        }
                    }
                }
                if(bestScore == (isScorePositive ? -100000000 : 100000000))
                {
                    return superFieldEvalutionService.EvaluateSuperField(superField, bot).Totaal();
                }
                else
                {
                    return bestScore;
                }
            }
        }

        public SquarePosition FindMove(SuperField superField,Bot bot,int iterations)
        {
            var bestScore = -100000000;
            SquarePosition bestPosition = new SquarePosition(0,0,0,0);

            for (int fieldY = 0; fieldY < 3; fieldY++)
            {
                for (int fieldX = 0; fieldX < 3; fieldX++)
                {
                    for (int squareY = 0; squareY < 3; squareY++)
                    {
                        for (int squareX = 0; squareX < 3; squareX++)
                        {
                            if (superFieldService.IsMovePossible(superField, fieldY, fieldX, squareY, squareX))
                            {
                                var tempSuperField = new SuperField(superField);
                                superFieldService.DoMove(tempSuperField, fieldY, fieldX, squareY, squareX);
                                var score = findScoreForBestMove(tempSuperField, bot, iterations, 1);
                                if(score >= bestScore)
                                {
                                    bestScore = score;
                                    bestPosition = new SquarePosition(fieldY, fieldX, squareY, squareX);
                                }
                            }
                        }
                    }
                }
            }
            return bestPosition;
        }
        
        public SuperField DoMove(SuperField superField, Bot bot)
        {
            var squarePosition = FindMove(superField, bot, 6);
            superFieldService.DoMove(superField, squarePosition.FieldY, squarePosition.FieldX, squarePosition.SquareY, squarePosition.SquareX);
            return superField;
        }
    }
}
