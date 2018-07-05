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
    public class IndexModel : PageModel
    {
        private readonly static string SuperFieldKey = "superField";
        public SuperField superField { get; set; }
        public Score score { get; set; }
        public string errorMessage { get; set; }

        private readonly SuperFieldService superFieldService;
        private readonly SuperFieldEvalutionService superFieldEvalutionService;
        private Bot bot;

        public IndexModel(SuperFieldService superFieldService, SuperFieldEvalutionService superFieldEvalutionService, BotBuilderService botBuilderService)
        {
            this.superField = superField;
            this.superFieldService = superFieldService;
            this.superFieldEvalutionService = superFieldEvalutionService;
            this.bot = botBuilderService.CreateBasicBot(false);
        }

        public void OnGet()
        {
            superField = new SuperField();
            score = superFieldEvalutionService.EvaluateSuperField(superField, bot);
      
            HttpContext.Session.Set<SuperField>(SuperFieldKey, superField);
        }

        public void OnPostMove(int fieldY, int fieldX, int squareY,int squareX)
        {
            superField = HttpContext.Session.Get<SuperField>(SuperFieldKey);
            if (superField != null)
            {
                superFieldService.DoMove(superField, fieldY, fieldX, squareY, squareX);
                score = superFieldEvalutionService.EvaluateSuperField(superField, bot);
                HttpContext.Session.Set<SuperField>(SuperFieldKey, superField);
            }
            else
            {
                errorMessage = "Can't find superField";
            }
        }
    }
}