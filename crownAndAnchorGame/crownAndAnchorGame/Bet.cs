using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crownAndAnchorGame
{
    internal class Bet
    {
        public int Value { get; private set; }
        public Symbols Symbol { get; private set; }

        public Bet(int value, Symbols symbol)
        {
            Value = value;
            Symbol = symbol;
        }
    }
}
