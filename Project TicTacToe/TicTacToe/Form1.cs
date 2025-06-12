namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private bool isXTurn = true; // X starts first
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (button1.Text != "") return; // Skip if already clicked

            button1.Text = isXTurn ? "X" : "O";
            button1.Enabled = false;
            if (CheckWinner())
            {
                label2.Text = (isXTurn ? "X" : "O") + " wins!";
                DisableAllButtons();
            }
            else if (IsDraw())
            {
                label2.Text = "Draw!";
            }
            else
            {
                isXTurn = !isXTurn;
                label2.Text = (isXTurn ? "X" : "O") + "'s turn";
            }


        }
        


        private void button2_Click(object sender, EventArgs e)
        {
            

            if (button2.Text != "") return; // Skip if already clicked

            button2.Text = isXTurn ? "X" : "O";
            button2.Enabled = false;
            if (CheckWinner())
            {
                label2.Text = (isXTurn ? "X" : "O") + " wins!";
                DisableAllButtons();
            }
            else if (IsDraw())
            {
                label2.Text = "Draw!";
            }
            else
            {
                isXTurn = !isXTurn;
                label2.Text = (isXTurn ? "X" : "O") + "'s turn";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            if (button3.Text != "") return; // Skip if already clicked

            button3.Text = isXTurn ? "X" : "O";
            button3.Enabled = false;
            if (CheckWinner())
            {
                label2.Text = (isXTurn ? "X" : "O") + " wins!";
                DisableAllButtons();
            }
            else if (IsDraw())
            {
                label2.Text = "Draw!";
            }
            else
            {
                isXTurn = !isXTurn;
                label2.Text = (isXTurn ? "X" : "O") + "'s turn";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            if (button4.Text != "") return; // Skip if already clicked

            button4.Text = isXTurn ? "X" : "O";
            button4.Enabled = false;
            if (CheckWinner())
            {
                label2.Text = (isXTurn ? "X" : "O") + " wins!";
                DisableAllButtons();
            }
            else if (IsDraw())
            {
                label2.Text = "Draw!";
            }
            else
            {
                isXTurn = !isXTurn;
                label2.Text = (isXTurn ? "X" : "O") + "'s turn";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            if (button5.Text != "") return; // Skip if already clicked

            button5.Text = isXTurn ? "X" : "O";
            button5.Enabled = false;
            if (CheckWinner())
            {
                label2.Text = (isXTurn ? "X" : "O") + " wins!";
                DisableAllButtons();
            }
            else if (IsDraw())
            {
                label2.Text = "Draw!";
            }
            else
            {
                isXTurn = !isXTurn;
                label2.Text = (isXTurn ? "X" : "O") + "'s turn";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            

            if (button6.Text != "") return; // Skip if already clicked

            button6.Text = isXTurn ? "X" : "O";
            button6.Enabled = false;
            if (CheckWinner())
            {
                label2.Text = (isXTurn ? "X" : "O") + " wins!";
                DisableAllButtons();
            }
            else if (IsDraw())
            {
                label2.Text = "Draw!";
            }
            else
            {
                isXTurn = !isXTurn;
                label2.Text = (isXTurn ? "X" : "O") + "'s turn";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            

            if (button7.Text != "") return; // Skip if already clicked

            button7.Text = isXTurn ? "X" : "O";
            button7.Enabled = false;
            if (CheckWinner())
            {
                label2.Text = (isXTurn ? "X" : "O") + " wins!";
                DisableAllButtons();
            }
            else if (IsDraw())
            {
                label2.Text = "Draw!";
            }
            else
            {
                isXTurn = !isXTurn;
                label2.Text = (isXTurn ? "X" : "O") + "'s turn";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text != "") return; // Skip if already clicked

            button8.Text = isXTurn ? "X" : "O";
            button8.Enabled = false;
            if (CheckWinner())
            {
                label2.Text = (isXTurn ? "X" : "O") + " wins!";
                DisableAllButtons();
            }
            else if (IsDraw())
            {
                label2.Text = "Draw!";
            }
            else
            {
                isXTurn = !isXTurn;
                label2.Text = (isXTurn ? "X" : "O") + "'s turn";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {


            if (button9.Text != "") return; // Skip if already clicked

            button9.Text = isXTurn ? "X" : "O"; //
            button9.Enabled = false; //
            if (CheckWinner())
            {
                label2.Text = (isXTurn ? "X" : "O") + " wins!";
                DisableAllButtons();
            }
            else if (IsDraw())
            {
                label2.Text = "Draw!";
            }
            else
            {
                isXTurn = !isXTurn;
                label2.Text = (isXTurn ? "X" : "O") + "'s turn";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //reset button 
            foreach (Control c in Controls) 
            {
                if (c is Button && c != button10)
                {
                    c.Text = "";
                    c.Enabled = true;
                }
            }
            isXTurn = true;
            label2.Text = "X's turn";
        }



        private bool CheckWinner()
        {
            string[,] b = new string[3, 3]
            {
                { button1.Text, button2.Text, button3.Text },
                { button4.Text, button5.Text, button6.Text },
                { button7.Text, button8.Text, button9.Text }
            };

            for (int i = 0; i < 3; i++)
            {
                // Rows and columns
                if ((b[i, 0] == b[i, 1] && b[i, 1] == b[i, 2] && b[i, 0] != "") ||
                    (b[0, i] == b[1, i] && b[1, i] == b[2, i] && b[0, i] != ""))
                    return true;
            }

            // Diagonals
            if ((b[0, 0] == b[1, 1] && b[1, 1] == b[2, 2] && b[0, 0] != "") ||
                (b[0, 2] == b[1, 1] && b[1, 1] == b[2, 0] && b[0, 2] != ""))
                return true;

            return false;
        }
        private bool IsDraw()
        {
            foreach (Control c in Controls)
            {
                if (c is Button && c.Text == "" && c != button10)
                    return false;
            }
            return true;
        }

        private void DisableAllButtons()
        {
            foreach (Control c in Controls)
            {
                if (c is Button && c != button10)
                    c.Enabled = false;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
