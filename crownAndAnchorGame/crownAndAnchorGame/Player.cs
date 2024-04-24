using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crownAndAnchorGame
{
    internal class Player
    {
        public string Name { get; private set; }

        public int Bank { get; set; }

        public List<Bet> Bets { get; private set; }

        public Player(string name, int bank = 100)
        {
            Name = name;
            Bank = bank;
            Bets = new List<Bet>();
        }

        public void MakeBet(int value, Symbols symbol)
        {
            Bets.Add(new Bet(value, symbol));
        }
    }
}
