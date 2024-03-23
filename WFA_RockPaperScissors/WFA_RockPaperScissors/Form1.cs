namespace WFA_RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string[] moves = ["rock", "paper", "scissors"];
        Random rnd = new Random();
        string winner;

        int playerScore = 0, pcScore = 0;

        private void btnScissors_Click(object sender, EventArgs e)
        {
            RoundControl("scissors");
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            RoundControl("rock");

        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            RoundControl("paper");
        }

        private void btnLuck_Click(object sender, EventArgs e)
        {
            RoundControl(moves[rnd.Next(0, 3)]);
        }

        private void RoundControl(string playerChoice)
        {
            string pcChoice = moves[rnd.Next(0, 3)];

            if (playerChoice == pcChoice)
                winner = "It's a tie! Nobody wins this round.";
            else if ((playerChoice == "rock" && pcChoice == "scissors") ||
                     (playerChoice == "paper" && pcChoice == "rock") ||
                     (playerChoice == "scissors" && pcChoice == "paper"))
            {
                winner = "You win this round!";
                playerScore++;
                lblPlayerScore.Text = playerScore.ToString();
            }
            else
            {
                winner = "Computer wins this round! ";
                pcScore++;
                lblPcScore.Text = pcScore.ToString();
            }
            
            lblWin.Text = winner;

            WinControl(playerScore, pcScore);
        }

        private void WinControl(int playerScore, int pcScore)
        {
            if (playerScore == 3 && playerScore > pcScore)
            {
                btnPaper.Enabled = false;
                btnLuck.Enabled = false;
                btnRock.Enabled = false;
                btnScissors.Enabled = false;

                lblWin.Text = $"Congratulations! You've won the game!! Your score {playerScore}, Computer score {pcScore}";
            }
            else if (pcScore == 3 && pcScore > playerScore)
            {
                btnPaper.Enabled = false;
                btnLuck.Enabled = false;
                btnRock.Enabled = false;
                btnScissors.Enabled = false;

                lblWin.Text = $"Computer wins! Better luck next time. Your score {playerScore}, Computer score {pcScore}";
            }


        }

    }
}
