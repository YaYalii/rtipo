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
    public partial class InputPlayersScreen : Form
    {
        public InputPlayersScreen()
        {
            InitializeComponent();
        }

        private void AddPlayers_Click(object sender, EventArgs e)
        {
            var countPlayers = (int)numericUpDown1.Value;

            Game.Instance.AddPlayers(countPlayers);

            GameScreen gameScreen = new GameScreen();
            gameScreen.Show();
            Hide();
        }

        private void InputPlayersScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
