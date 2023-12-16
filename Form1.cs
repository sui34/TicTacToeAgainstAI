namespace TicTacToeAgainstAI
{
    public partial class Form1 : Form
    {

        // enum : sort of custom data type. not need to determine like int or string.
        public enum Player
        {
            x, o
        }

        Player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int aiWinCount = 0;
        List<Button> buttons;

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AIMove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count); // generate a random number within the number of buttons available
                buttons[index].Enabled = false; // assign the number to the button
                currentPlayer = Player.o;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.DarkSalmon;
                buttons.RemoveAt(index); // removeAt : remove ethe specific data  from the list
                CheckGame();
                Timer.Stop();
            }
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender; // indentify the button which was clicked by sender

            currentPlayer = Player.x;
            button.Text = currentPlayer.ToString();
            button.Enabled = false; //dont want the player to click the button twice.
            button.BackColor = Color.Cyan;
            buttons.Remove(button); // remove the clicked button from the list
            CheckGame(); // check any of the three button match or not
            Timer.Start(); // let AI start its trun
        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void CheckGame()
        {
            if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x" ||
                button4.Text == "x" && button5.Text == "x" && button6.Text == "x" ||
                button7.Text == "x" && button8.Text == "x" && button9.Text == "x" ||
                button1.Text == "x" && button4.Text == "x" && button7.Text == "x" ||
                button2.Text == "x" && button5.Text == "x" && button8.Text == "x" ||
                button3.Text == "x" && button6.Text == "x" && button9.Text == "x" ||
                button1.Text == "x" && button5.Text == "x" && button9.Text == "x" ||
                button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
            {
                Timer.Stop();
                MessageBox.Show("Player Wins", "The Game decides");
                playerWinCount++;
                label1.Text = "Player Wins : " + playerWinCount;
                RestartGame();
            }
            else if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o" ||
                button4.Text == "o" && button5.Text == "o" && button6.Text == "o" ||
                button7.Text == "o" && button8.Text == "o" && button9.Text == "o" ||
                button1.Text == "o" && button4.Text == "o" && button7.Text == "o" ||
                button2.Text == "o" && button5.Text == "o" && button8.Text == "o" ||
                button3.Text == "o" && button6.Text == "o" && button9.Text == "o" ||
                button1.Text == "o" && button5.Text == "o" && button9.Text == "o" ||
                button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
            {
                Timer.Stop();
                MessageBox.Show("AI Wins", "The Game decides");
                aiWinCount++;
                label2.Text = "AI Wins : " + aiWinCount;
                RestartGame();
            }



        }

        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            foreach (Button b in buttons)
            {
                //if any button exist
                b.Enabled = true;
                b.Text = "?";
                b.BackColor = DefaultBackColor;
            }
        }
    }
}