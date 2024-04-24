using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crownAndAnchorGame
{
    public partial class GameScreen : Form
    {

        private Dictionary<NumericUpDown, Symbols> NumericsUpDown {get; set;}
        public GameScreen()
        {
            InitializeComponent();
        }


        private void GameScreen_Load(object sender, EventArgs e)
        {
            NumericsUpDown = new Dictionary<NumericUpDown, Symbols>
            {
                { crossesValue, Symbols.CROSSES },
                { crownValue, Symbols.CROWN },
                { anchorValue, Symbols.ANCHOR },
                { spadesValue, Symbols.SPADES },
                { boobyValue, Symbols.BOOBY },
                { heartsValue, Symbols.HEARTS }
            };

            for (int i = 0; i < Game.Instance.Players.Count; i++)
            {
                dataGridView1.Rows.Add(Game.Instance.Players[i].Name, Game.Instance.Players[i].Bank);
            }

            foreach(NumericUpDown item in NumericsUpDown.Keys)
            {
                item.Hide();
            }

            startRound.Hide();
            rollDicesButton.Hide();
            betsValues.Hide();
            saveBets.Hide();
            diceValues.Hide();
        }


        private void SaveBanksButton_Click(object sender, EventArgs e)
        {
            bool errorBank = false;

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                int bank = Convert.ToInt32(row.Cells[playerBank.Index].Value);
                if(bank > 0) 
                    Game.Instance.ChangePlayerBank(row.Index, bank);
                else
                {
                    MessageBox.Show("Банк должен быть больше 0", "Ошибка");
                    errorBank = true;
                }
            }

            if(!errorBank)
            {
                dataGridView1.Columns[playerBank.Index].ReadOnly = true;

                saveBanksButton.Hide();
                textChangeBets.Hide();
                startRound.Show();
            }
        }

        private void StartRound_Click(object sender, EventArgs e)
        {

            betsValues.Show();
            saveBets.Show();

            foreach(NumericUpDown item in NumericsUpDown.Keys)
            {
                item.Show();
            }

            crossesBox.Image = Image.FromFile(Path.Combine("images", "CROSSES.jpg"));
            crownBox.Image = Image.FromFile(Path.Combine("images", "CROWN.jpg"));
            heartsBox.Image = Image.FromFile(Path.Combine("images", "HEARTS.jpg"));
            spadesBox.Image = Image.FromFile(Path.Combine("images", "SPADES.jpg"));
            anchorBox.Image = Image.FromFile(Path.Combine("images", "ANCHOR.jpg"));
            boobyBox.Image = Image.FromFile(Path.Combine("images", "BOOBY.jpg"));

            startRound.Hide();

            UpdatePlayerBanksTable(dataGridView1, Game.Instance.Players);

            Game.Instance.DeleteLossers();

            if (Game.Instance.Players.Count == 0) EndGame();

            betsValues.Text = $"{Game.Instance.Players[Game.Instance.GetCurretPlayerIndex()].Name}";
        }

        private void SaveBets_Click(object sender, EventArgs e)
        {
            bool nextPlayer = false;

            foreach (NumericUpDown item in NumericsUpDown.Keys)
            {
                if (item.Value > 0 && item != null)
                {
                    Game.Instance.Players[Game.Instance.GetCurretPlayerIndex()]
                        .MakeBet((int)item.Value, NumericsUpDown[item]);
                }
            }

            if (Game.Instance.SaveBets(Game.Instance.GetCurretPlayerIndex()))
                nextPlayer = true;
            else
                MessageBox.Show("У пользователя не хватает банка на эти ставки", "Ошибка");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == Game.Instance.Players[Game.Instance.GetCurretPlayerIndex()].Name)
                {
                    row.Cells[1].Value = Game.Instance.Players[Game.Instance.GetCurretPlayerIndex()].Bank;
                    break;
                }
            }

            foreach (var item in NumericsUpDown.Keys)
            {
                item.Value = 0;
            }

            if (Game.Instance.GetCurretPlayerIndex() >= Game.Instance.Players.Count-1)
            {
                saveBets.Hide();
                rollDicesButton.Show();
                betsValues.Hide();
                return;
            }

            if (nextPlayer)
            {
                Game.Instance.MoveNextPlayer();
                betsValues.Text = $"{Game.Instance.Players[Game.Instance.GetCurretPlayerIndex()].Name}";
            }    
        }

        private void RollDicesButton_Click(object sender, EventArgs e)
        {
            diceValues.Show();

            List<Dice> dices = Game.Instance.GetDiceValues();

            pictureBox1.Image = Image.FromFile(Path.Combine("images", dices[0].Symbol.ToString() + ".jpg"));
            pictureBox2.Image = Image.FromFile(Path.Combine("images", dices[1].Symbol.ToString() + ".jpg"));
            pictureBox3.Image = Image.FromFile(Path.Combine("images", dices[2].Symbol.ToString() + ".jpg"));

            Game.Instance.PayWinners(dices);

            UpdatePlayerBanksTable(dataGridView1, Game.Instance.Players);

            rollDicesButton.Hide();
            startRound.Show();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы действительно хотите выйти?",
                                             "Выход из программы",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (res == DialogResult.Yes) EndGame();
            else return;
        }
        private void UpdatePlayerBanksTable(DataGridView table, List<Player> players)
        {
            foreach (DataGridViewRow row in table.Rows)
            {
                foreach (Player player in players)
                {
                    if (row.Cells[0].Value.ToString() == player.Name)
                    {
                        row.Cells[1].Value = player.Bank;
                    }
                }
            }
        }

        private void EndGame()
        {
            /*string results = Game.Instance.endGameResults();*/

            /*if (results.Length == 0)
                MessageBox.Show("Все пользователи потеряли свой банк", "Результаты");
            else*/
            MessageBox.Show(Game.Instance.endGameResults(), "Результаты");
            Environment.Exit(0);
        }
    }
}
