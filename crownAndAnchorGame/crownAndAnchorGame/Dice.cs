using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crownAndAnchorGame
{
    internal class Dice
    {
        public Symbols Symbol { get; private set; }

        public Dice()
        {
            Symbol = Symbols.HEARTS;
        }

        public Dice roll()
        {
            Dice dice = new Dice();

            Random random = new Random();
            Array symbols = Enum.GetValues(typeof(Symbols));

            dice.Symbol = (Symbols)symbols.GetValue(random.Next(symbols.Length))!;

            return dice;
        }
    }
}
