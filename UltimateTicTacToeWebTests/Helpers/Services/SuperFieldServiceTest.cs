using System;
using System.Collections.Generic;
using System.Text;
using UltimateTicTacToeWeb.Helpers.Services;
using UltimateTicTacToeWeb.Model;
using Xunit;

namespace UltimateTicTacToeWebTests.Helpers.Services
{
    public class SuperFieldServiceTest
    {
        [Fact]
        public void GelijkSpelField()
        {
            var superFieldService = new SuperFieldService();
            var superField = new SuperField();
            superFieldService.DoMove(superField, 0, 0, 0, 0);
            superField.TurnRestrictedToField = false;
            superFieldService.DoMove(superField, 0, 0, 0, 1);
            superField.TurnRestrictedToField = false;
            superFieldService.DoMove(superField, 0, 0, 0, 2);
            superField.TurnRestrictedToField = false;

            superFieldService.DoMove(superField, 0, 0, 1, 1);
            superField.TurnRestrictedToField = false;
            superFieldService.DoMove(superField, 0, 0, 1, 0);
            superField.TurnRestrictedToField = false;
            superFieldService.DoMove(superField, 0, 0, 2, 0);
            superField.TurnRestrictedToField = false;

            superFieldService.DoMove(superField, 0, 0, 1, 2);
            superField.TurnRestrictedToField = false;
            superFieldService.DoMove(superField, 0, 0, 2, 2);
            superField.TurnRestrictedToField = false;
            superFieldService.DoMove(superField, 0, 0, 2, 1);
            superField.TurnRestrictedToField = false;

            Assert.True(superField.Fields[0][0].winner == FieldState.Draw);
        }

        [Fact]
        public void GewonnenSpelField()
        {
            var superFieldService = new SuperFieldService();
            var superField = new SuperField();
            superFieldService.DoMove(superField, 0, 0, 0, 0);
            superField.TurnRestrictedToField = false;
            superFieldService.DoMove(superField, 0, 0, 0, 1);
            superField.TurnRestrictedToField = false;

            superFieldService.DoMove(superField, 0, 0, 1, 0);
            superField.TurnRestrictedToField = false;
            superFieldService.DoMove(superField, 0, 0, 1, 1);
            superField.TurnRestrictedToField = false;

            superFieldService.DoMove(superField, 0, 0, 2, 0);
            superField.TurnRestrictedToField = false;


            Assert.True(superField.Fields[0][0].winner == FieldState.X);
            Assert.True(superField.Winner == FieldState.None);
        }

        [Fact]
        public void GewonnenSpelSuperField()
        {
            var superFieldService = new SuperFieldService();
            var superField = new SuperField();

            //field 1
            superFieldService.DoMove(superField, 0, 0, 0, 0);
            superField.TurnRestrictedToField = false;
            superFieldService.DoMove(superField, 0, 0, 0, 1);
            superField.TurnRestrictedToField = false;

            superFieldService.DoMove(superField, 0, 0, 1, 0);
            superField.TurnRestrictedToField = false;
            superFieldService.DoMove(superField, 0, 0, 1, 1);
            superField.TurnRestrictedToField = false;

            superFieldService.DoMove(superField, 0, 0, 2, 0);
            superField.TurnRestrictedToField = false;
            superFieldService.DoMove(superField, 1, 0, 0, 0);
            superField.TurnRestrictedToField = false;

            //field 2

            superFieldService.DoMove(superField, 0, 1, 0, 0);
            superField.TurnRestrictedToField = false;
            superFieldService.DoMove(superField, 0, 1, 0, 1);
            superField.TurnRestrictedToField = false;

            superFieldService.DoMove(superField, 0, 1, 1, 0);
            superField.TurnRestrictedToField = false;
            superFieldService.DoMove(superField, 0, 1, 1, 1);
            superField.TurnRestrictedToField = false;

            superFieldService.DoMove(superField, 0, 1, 2, 0);
            superField.TurnRestrictedToField = false;
            superFieldService.DoMove(superField, 1, 1, 0, 0);
            superField.TurnRestrictedToField = false;

            //field 3
            superFieldService.DoMove(superField, 0, 2, 0, 0);
            superField.TurnRestrictedToField = false;
            superFieldService.DoMove(superField, 0, 2, 0, 1);
            superField.TurnRestrictedToField = false;
        
            superFieldService.DoMove(superField, 0, 2, 1, 0);
            superField.TurnRestrictedToField = false;
            superFieldService.DoMove(superField, 0, 2, 1, 1);
            superField.TurnRestrictedToField = false;

            superFieldService.DoMove(superField, 0, 2, 2, 0);
            superField.TurnRestrictedToField = false;

            Assert.True(superField.Winner == FieldState.X);
        }
    }
}
