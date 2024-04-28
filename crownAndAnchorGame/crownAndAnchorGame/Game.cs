namespace crownAndAnchorGame
{
    internal class Game
    {
        private static Game instance;
        public static Game Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Game();
                }
                return instance;
            }
        }

        public List<Player> Players { get; private set; }

        public List<Dice> Dices { get; private set; }

        private int currentPlayerIndex = 0;

        private Game()
        {
            Players = new List<Player>();
            Dices = new List<Dice>() { new Dice(), new Dice(), new Dice()};
        }

        public List<Dice> GetDiceValues()
        {
            for(int i = 0; i < Dices.Count; i++)
            {
                Dices[i] = Dices[i].roll();
            }

            return Dices;
        }

        public int GetCurretPlayerIndex()
        {
            return currentPlayerIndex;
        }
        public void AddPlayers(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                Instance.Players.Add(new Player($"Игрок {i}"));
            }
        }

        public void MoveNextPlayer()
        {
            currentPlayerIndex++;
        }

        public bool SaveBets(int index)
        {
            var sumBet = 0;

            foreach (Bet bet in Instance.Players[index].Bets)
            {
                sumBet += bet.Value;
            }

            if (sumBet <= Instance.Players[index].Bank)
            {
                Players[index].RedactPlayerBank(Players[index].Bank, -sumBet);

                return true;

            }
            else
            {
                Players[index].ClearBets();

                return false;
            }
        }

        public void PayWinners(List<Dice> dices)
        {
            var winSum = 0;

            var coefWin = 0;

            foreach (Player player in Instance.Players)
            {
                foreach (Bet bet in player.Bets)
                {
                    coefWin = dices.Count(dice => dice.Symbol == bet.Symbol);

                    if (coefWin > 0)
                        winSum += bet.Value * coefWin + bet.Value;
                }

                player.RedactPlayerBank(player.Bank, winSum);
                player.ClearBets();

                winSum = 0;
                coefWin = 0;
                Instance.currentPlayerIndex = 0;
            }
        }

        public void DeleteLossers()
        {
            Instance.Players.RemoveAll(player => player.Bank == 0);
        }

        public string endGameResults()
        {
            string results = "";

            if(Instance.Players.Count > 0)
            {
                foreach (Player player in Instance.Players)
                {
                    results += $"{player.Name} {player.Bank}\n";
                }
            }
            else
            {
                results = "Все пользователи потеряли свой банк";
            }

            return results;
        }
    }
}
