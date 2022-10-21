using Kitteh_s_Tic_Tac_Toe.src.classes;

namespace Kitteh_s_Tic_Tac_Toe
{
    public partial class Board : Form
    {
        private Game? game;
        private readonly Control[] buttons;
        private string[,] boardLocations;
        public Board()
        {
            InitializeComponent();

            //Store Button objects into array to be used for the game
            buttons = new Button[panelMainBoard.Controls.Count];
            for (int i = 0; i < panelMainBoard.Controls.Count; i++)
            {
                buttons[i] = panelMainBoard.Controls[i]; //All Controls in panel will be of type Button
                buttons[i].Text = "";
            }
            boardLocations = new string[3, 3];
            GenerateBoard();

            //Call CoinFlip Form
            CoinFlip formCoinFlip = new(this);
            formCoinFlip.ShowDialog();
            //btnTopLeft.Text = panelMainBoard.Controls.Count.ToString(); //Expected Output: 9 | DEBUG ONLY

        }

        //Fill boardLocations array manually for now until I can figure out a way to dynamically do it
        private void GenerateBoard()
        {
            boardLocations[0, 0] = buttons[8].Tag.ToString()!;
            boardLocations[0, 1] = buttons[7].Tag.ToString()!;
            boardLocations[0, 2] = buttons[6].Tag.ToString()!;
            boardLocations[1, 0] = buttons[5].Tag.ToString()!;
            boardLocations[1, 1] = buttons[4].Tag.ToString()!;
            boardLocations[1, 2] = buttons[3].Tag.ToString()!;
            boardLocations[2, 0] = buttons[2].Tag.ToString()!;
            boardLocations[2, 1] = buttons[1].Tag.ToString()!;
            boardLocations[2, 2] = buttons[0].Tag.ToString()!;
        }

        internal void BeginNewGame(int selectedTurn)
        {
            this.game = new(selectedTurn); //Create a new Game object
            if (!game.UserTurn) //Computer first turn
            {
                MessageBox.Show("The computer will select a square.", "Computer Turn!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                game.ProcessComputer();
                this.buttons[game.AiChoice].Text = "X";
                this.buttons[game.AiChoice].Enabled = false;
                return;
            }
            MessageBox.Show("Please select an available square.", "Your Turn!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Board Buttons
        private void btnTopLeft_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender as Button);
            CheckWin(sender as Button);
            AiCheck();
        }

        private void btnTopMiddle_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender as Button);
            CheckWin(sender as Button);
            AiCheck();
        }

        private void btnTopRight_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender as Button);
            CheckWin(sender as Button);
            AiCheck();
        }

        private void btnMiddleLeft_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender as Button);
            AiCheck();
        }

        private void btnMiddleCenter_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender as Button);
            AiCheck();
        }

        private void btnMiddleRight_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender as Button);
            AiCheck();
        }

        private void btnBottomLeft_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender as Button);
            AiCheck();
        }

        private void btnBottomMiddle_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender as Button);
            AiCheck();
        }

        private void btnBottomRight_Click(object sender, EventArgs e)
        {
            PlayerTurn(sender as Button);
            AiCheck();
        }

        //Checks if computer or player won
        private void CheckWin(Button? button)
        {

        }

        private void PlayerTurn(Button? button)
        {
            button!.Text = "O";
            button.Enabled = false;

            MessageBox.Show("The computer will select a square.", "Computer Turn!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AiCheck()
        {
            bool isValid = false; //Bool will check if the AI choice was valid
            int timeoutInterval = 0; //Prevents program hangup
            while (!isValid)
            {
                if (!buttons[game!.AiChoice].Enabled && timeoutInterval < 10) //Check if Button is enabled with timeout
                {
                    game.ProcessComputer(); //Re-generate random number
                    timeoutInterval++;
                }
                else if (timeoutInterval < 10)
                {
                    isValid = true;
                    timeoutInterval = 0; //Reset counter
                    buttons[game.AiChoice].Text = "X";
                    buttons[game.AiChoice].Enabled = false;
                }
                else //Must be no more spaces to choose
                {
                    MessageBox.Show("Game has ended in a tie!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
    }
}