namespace Kitteh_s_Tic_Tac_Toe
{
    public partial class CoinFlip : Form
    {
        private Board mainBoard;
        private Random random = new Random();
        private int selectedTurn;

        public CoinFlip(Board mainBoard)
        {
            InitializeComponent();
            txtFlipCoin.Text = ""; //Clear Text
            this.mainBoard = mainBoard;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnFlipCoin_Click(object sender, EventArgs e)
        {
            this.selectedTurn = random.Next(1, 3);
            if (selectedTurn == 1) //User Turn First
            {
                btnContinue.Enabled = true;
                btnFlipCoin.Enabled = false;
                txtFlipCoin.Text = "You go first!";
            }
            else //Computer Turn First
            {
                btnContinue.Enabled = true;
                btnFlipCoin.Enabled = false;
                txtFlipCoin.Text = "Computer goes first!";
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            mainBoard.BeginNewGame(selectedTurn);
            Close();
        }
    }
}
