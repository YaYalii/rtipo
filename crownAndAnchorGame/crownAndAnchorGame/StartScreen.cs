namespace crownAndAnchorGame
{

    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            InputPlayersScreen newForm = new InputPlayersScreen();
            newForm.Show();
            this.Hide();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }
    }
}