using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UltimateTicTacToeWeb.Model;
using UltimateTicTacToeWeb.Helpers.Extensions;
using UltimateTicTacToeWeb.Helpers.Services;
using UltimateTicTacToeWeb.Model.Bot;

namespace UltimateTicTacToeWeb.Pages
{
    public class AiModel : PageModel
    {
        private readonly static string SuperFieldKey = "superField";
        public SuperField superField { get; set; }
        public Score score { get; set; }
        public string errorMessage { get; set; }

        private readonly SuperFieldService superFieldService;
        private readonly SuperFieldEvalutionService superFieldEvalutionService;
        private readonly BotService botService;
        private Bot bot;

        public AiModel(SuperFieldService superFieldService, SuperFieldEvalutionService superFieldEvalutionService, BotBuilderService botBuilderService, BotService botService)
        {
            this.superField = superField;
            this.superFieldService = superFieldService;
            this.superFieldEvalutionService = superFieldEvalutionService;
            this.bot = botBuilderService.CreateBasicBot(true);
            this.botService = botService;
        }

        public void OnGet()
        {
            superField = new SuperField();
            score = superFieldEvalutionService.EvaluateSuperField(superField, bot);

            HttpContext.Session.Set<SuperField>(SuperFieldKey, superField);
        }

        public void OnPostMove(int fieldY, int fieldX, int squareY, int squareX)
        {
            superField = HttpContext.Session.Get<SuperField>(SuperFieldKey);
            if (superField != null)
            {
                if (superFieldService.IsMovePossible(superField, fieldY, fieldX, squareY, squareX))
                {
                    superFieldService.DoMove(superField, fieldY, fieldX, squareY, squareX);
                    botService.DoMove(superField, bot);
                    HttpContext.Session.Set<SuperField>(SuperFieldKey, superField);
                }
                score = superFieldEvalutionService.EvaluateSuperField(superField, bot);
            }
            else
            {
                errorMessage = "Can't find superField";
            }
        }
    }
}