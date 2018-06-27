

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UltimateTicTacToeWeb.Model
{
    public class SuperField
    {
        public Field[][] fields { get; set; } = {
           new Field[] { new Field(),new Field(),new Field()},
           new Field[] { new Field(),new Field(),new Field()},
           new Field[] { new Field(),new Field(),new Field()}
        };

        public SquareState winner;
    }
}
