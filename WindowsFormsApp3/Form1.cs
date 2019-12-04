using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class TicTacToe : Form
    {
        private string name1;
        private string name2;
        private bool gameOver = false;

        
        public TicTacToe()
        {
            InitializeComponent();

            initializeListBox();           
        }

        private void initializeListBox()
        {
            ListBox listBox1 = leaderboard;
            
            // Set the ListBox to display items in multiple columns.
            listBox1.MultiColumn = true;

            listBox1.Enabled = true;

            // Shutdown the painting of the ListBox as items are added.
            listBox1.BeginUpdate();
            // Loop through and add 50 items to the ListBox.
            for (int x = 1; x <= 10; x++)
            {
                listBox1.Items.Add(x.ToString() + " John");
            }
            // Allow the ListBox to repaint and display the new items.
            listBox1.EndUpdate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            onTurn(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            onTurn(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            onTurn(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            onTurn(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            onTurn(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(currentPlayerName.Text))
            {
                newGame();
            } else
            {
                MessageBox.Show("A game is already in progress.", "Continue", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }   
        }

        private void newGame()
        {
            if (!gameOver && (String.IsNullOrEmpty(playerName1.Text) || String.IsNullOrEmpty(playerName2.Text
            ) || playerName1.Text == playerName2.Text ))
            {
                MessageBox.Show("Player1 Name and Player2 Name should not be empty.", "Null Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                name1 = playerName1.Text;
                name2 = playerName2.Text;

                // int x = Int32.Parse(playerName1.Text);

                currentPlayerName.Text = name1;

                enableBoxes();

                startButton.Visible = !startButton.Visible;
                newButton.Visible = !newButton.Visible;

                gameOver = false;
            }
        }

        private void enableBoxes()
        {
            Button[] boxes = { box1, box2, box3, box4, box5, box6, box7, box8, box9 };
            for (int i = 0; i<boxes.Length; i++)
            {
                enableBox(boxes[i]);
            }
        }

        private void enableBox(Button box)
        {
            box.Enabled = true;
        }

        private void disableBoxes()
        {
            Button[] boxes = { box1, box2, box3, box4, box5, box6, box7, box8, box9 };
            for (int i = 0; i < boxes.Length; i++)
            {
                disableBox(boxes[i]);
            }
        }

        private void disableBox(Button box)
        {
            box.Enabled = false;
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            onTurn(sender);
        }

        private void box1_Click(object sender, EventArgs e)
        {
            onTurn(sender);
        }

        private void onTurn(object sender)
        {
            if (! gameOver) 
            {
                Button box = (Button)sender;


                if (currentPlayerName.Text == name1)
                {
                    box.BackColor = Color.Red;
                    box.Text = "X"; 

                    if (checkWinner())
                        showResult();
                    else
                        currentPlayerName.Text = name2;
                }
                else
                {
                    box.BackColor = Color.Yellow;
                    box.Text = "0";

                    if (checkWinner())
                    {
                        showResult();
                    }
                    else
                        currentPlayerName.Text = name1;
                }

                box.Enabled = false;
            } else
            {
                gameOverTasks();
            } 
        }

        private void gameOverTasks()
        {

            MessageBox.Show("Please start a new game.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool checkWinner()
        {
            Color color = Color.Red;


            if (currentPlayerName.Text == name1)
                color = Color.Red;
            else if (currentPlayerName.Text == name2)
                color = Color.Yellow;
            
            if (checkPattern(color))
            {
                gameOver = true;

                if (currentPlayerName.Text == name1)
                    score1.Text = Int32.Parse(score1.Text) + 1 + "";
                else
                    score2.Text = Int32.Parse(score2.Text) + 1 + "";

                disableBoxes();

                return true;
            }
            return false;
        }

        private bool checkPattern(Color color)
        {
            return (box1.BackColor == color && box2.BackColor == color && box3.BackColor == color ||
            box4.BackColor == color && box5.BackColor == color && box6.BackColor == color ||
            box7.BackColor == color && box8.BackColor == color && box9.BackColor == color ||
            box1.BackColor == color && box5.BackColor == color && box9.BackColor == color ||
            box3.BackColor == color && box5.BackColor == color && box7.BackColor == color ||
            box1.BackColor == color && box4.BackColor == color && box7.BackColor == color ||
            box2.BackColor == color && box5.BackColor == color && box8.BackColor == color ||
            box3.BackColor == color && box6.BackColor == color && box9.BackColor == color);
        }
 
        private void showResult()
        {
            result.Text = currentPlayerName.Text + " " + "wins";
        }

        private void box2_Click(object sender, EventArgs e)
        {
            onTurn(sender);
        }

        private void box3_Click(object sender, EventArgs e)
        {
            onTurn(sender);
        }

        private void playerName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gameOver)
            {
                resetControls();
                disableBoxes();
            }

            newGame();
        }

        private void resetControls()
        {
            resetTextBox(playerName1);
            resetTextBox(playerName2);
            resetTextBox(currentPlayerName);
            resetTextBox(result);

            resetBoxes();
        }

        private void resetTextBox(TextBox textBox)
        {
            textBox.ResetText();
        }

        private void resetTextBox(RichTextBox textBox)
        {
            textBox.ResetText();
        }

        private void resetBoxes()
        {
            Button[] boxes = { box1, box2, box3, box4, box5, box6, box7, box8, box9 };

            for (int i = 0; i < boxes.Length; i++)
            {
                resetBox(boxes[i]);
            }
        }

        private void resetBox(Button box)
        {
            box.BackColor = SystemColors.ControlLight;
            box.Text = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void score1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void loginButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 newForm = new Form4(this);
            newForm.Show();
            this.Hide();
        }

        private void signUpButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 newForm = new Form3(this);
            newForm.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
