namespace Kitteh_s_Tic_Tac_Toe.src.classes
{
    internal class Game
    {
        //Fields
        private Random random;

        //Properties
        public bool UserTurn { get; private set; }
        public int AiChoice { get; private set; }

        //Constructor - Game starts with coin flip to determine if user goes first [Handled by CoinFlip form]
        public Game(int selectedTurn)
        {
            this.random = new Random();
            if (selectedTurn == 1) //User goes first
            {
                UserTurn = true;
            }
            else
            {
                UserTurn = false;
            }
        }

        //Method processes computer's turn | At the moment the AI selects a random button
        public void ProcessComputer()
        {
            AiChoice = random.Next(0, 9);
        }

    }
}
