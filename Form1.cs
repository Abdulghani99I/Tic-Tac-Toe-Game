using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        int CounterSteps = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;

            g = this.CreateGraphics();

            Pen myPen = new Pen(Color.White);

            myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            myPen.Width = 8;

            g.DrawLine(myPen, 570, 70, 570, 420);
            g.DrawLine(myPen, 695, 70, 695, 420);


            g.DrawLine(myPen, 820, 180, 450, 180);
            g.DrawLine(myPen, 820, 300, 450, 300);
        }

        bool isTurnPlayer1()
        {
            return (labTurn.Text == "Player1");
        }

        bool AreTheySimilar(string str1, string str2, string str3)
        {
            if (str1 == "?") return false;

            return ((str1 == str2) && (str2 == str3));
        }

        void EndGame(Button buttonOne, Button buttonTwo, Button buttonThree)
        {
            // Always player Number 1 use 'X'
            string TheWinner = (buttonOne.Tag.ToString() == "X" ? "Player1" : "Player2");

            MessageBox.Show("The Winner: " + TheWinner, "Game End", MessageBoxButtons.OK, MessageBoxIcon.Information);
            labTheWinner.Text = TheWinner;

            btnOne.Enabled = false;
            btnTwo.Enabled = false;
            btnThree.Enabled = false;
            btnFour.Enabled = false;
            btnFive.Enabled = false;
            btnSix.Enabled = false;
            btnSeven.Enabled = false;
            btnEight.Enabled = false;
            btnNine.Enabled = false;

            buttonOne.Enabled = true;
            buttonTwo.Enabled = true;
            buttonThree.Enabled = true;

            buttonOne.BackColor = Color.Yellow;
            buttonTwo.BackColor = Color.Yellow;
            buttonThree.BackColor = Color.Yellow;

            buttonOne.FlatAppearance.MouseOverBackColor = Color.Black;
            buttonTwo.FlatAppearance.MouseOverBackColor = Color.Black;
            buttonThree.FlatAppearance.MouseOverBackColor = Color.Black;
        }

        void EndGame()
        {
            MessageBox.Show("Game End", "The Winner: Nobody", MessageBoxButtons.OK, MessageBoxIcon.Information);

            labTheWinner.Text = "Draw";

            btnOne.Enabled = false;
            btnTwo.Enabled = false;
            btnThree.Enabled = false;
            btnFour.Enabled = false;
            btnFive.Enabled = false;
            btnSix.Enabled = false;
            btnSeven.Enabled = false;
            btnEight.Enabled = false;
            btnNine.Enabled = false;
        }

        bool CheckWinner()
        {
            // Line row 1
            if (AreTheySimilar(btnOne.Tag.ToString(), btnTwo.Tag.ToString(), btnThree.Tag.ToString()))
            {
                EndGame(btnOne, btnTwo, btnThree);
                return true;
            }

            // Line row 2
            if (AreTheySimilar(btnFour.Tag.ToString(), btnFive.Tag.ToString(), btnSix.Tag.ToString()))
            {
                EndGame(btnFour, btnFive, btnSix);
                return true;
            }

            // Line row 3
            if (AreTheySimilar(btnSeven.Tag.ToString(), btnEight.Tag.ToString(), btnNine.Tag.ToString()))
            {
                EndGame(btnSeven, btnEight, btnNine);
                return true;
            }

            // Line Colom 1
            if (AreTheySimilar(btnOne.Tag.ToString(), btnFour.Tag.ToString(), btnSeven.Tag.ToString()))
            {
                EndGame(btnOne, btnFour, btnSeven);
                return true;
            }

            // Line Colom 2
            if (AreTheySimilar(btnTwo.Tag.ToString(), btnFive.Tag.ToString(), btnEight.Tag.ToString()))
            {
                EndGame(btnTwo, btnFive, btnEight);
                return true;
            }

            // Line Colom 3
            if (AreTheySimilar(btnThree.Tag.ToString(), btnSix.Tag.ToString(), btnNine.Tag.ToString()))
            {
                EndGame(btnThree, btnSix, btnNine);
                return true;
            }

            // Line 1 Diagonal
            if (AreTheySimilar(btnOne.Tag.ToString(), btnFive.Tag.ToString(), btnNine.Tag.ToString()))
            {
                EndGame(btnOne, btnFive, btnNine);
                return true;
            }

            // Line 2 Diagonal
            if (AreTheySimilar(btnThree.Tag.ToString(), btnFive.Tag.ToString(), btnSeven.Tag.ToString()))
            {
                EndGame(btnThree, btnFive, btnSeven);
                return true;
            }

            // CounterSteps equel 9 then be is Draw
            if (CounterSteps == 9)
            {
                EndGame();
                return true;
            }

            return false;
        }

        void UpdatePlayWithFriend(Button button)
        {

            if (button.Tag.ToString() == "?")
            {
                CounterSteps++;
                if (isTurnPlayer1())
                {
                    button.Image = Resources.X;
                    button.Tag = "X";
                    labTurn.Text = "Player2";
                }
                else
                {
                    button.Image = Resources.O;
                    button.Tag = "O";
                    labTurn.Text = "Player1";
                }

                CheckWinner();

            }
            else
            {
                MessageBox.Show("Error", "Error Choice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Button ChoiceRandomButton()
        {
            short Count = -1;
            int NumberOfButtonsRemaining = 9 - CounterSteps;

            object[] Buttons = new object[NumberOfButtonsRemaining];

            if (btnOne.Tag.ToString() == "?")
            {
                Count++;
                Buttons[Count] = btnOne;
            }

            if (btnTwo.Tag.ToString() == "?")
            {
                Count++;
                Buttons[Count] = btnTwo;
            }

            if (btnThree.Tag.ToString() == "?")
            {
                Count++;
                Buttons[Count] = btnThree;
            }

            if (btnFour.Tag.ToString() == "?")
            {
                Count++;
                Buttons[Count] = btnFour;
            }

            if (btnFive.Tag.ToString() == "?")
            {
                Count++;
                Buttons[Count] = btnFive;
            }

            if (btnSix.Tag.ToString() == "?")
            {
                Count++;
                Buttons[Count] = btnSix;
            }

            if (btnSeven.Tag.ToString() == "?")
            {
                Count++;
                Buttons[Count] = btnSeven;
            }

            if (btnEight.Tag.ToString() == "?")
            {
                Count++;
                Buttons[Count] = btnEight;
            }

            if (btnNine.Tag.ToString() == "?")
            {
                Count++;
                Buttons[Count] = btnNine;
            }


            Random rand = new Random();

            return ((Button)Buttons[rand.Next(0, Count)]);

        }

        void UpdatePlayWithComputer(Button button)
        {
            if (button.Tag.ToString() == "?")
            {
                button.Image = Resources.X;
                button.Tag = "X";
                labTurn.Text = "Player2";
                CounterSteps++;

                if (CheckWinner()) return;

                Button RandomButton = ChoiceRandomButton();
                RandomButton.Image = Resources.O;
                RandomButton.Tag = "O";
                labTurn.Text = "Player1";
                CounterSteps++;
                CheckWinner();
            }
            else
            {
                MessageBox.Show("Error", "Error Choice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UpdateGame(Button button)
        {
            // play with Friend
            if (cbChoice.SelectedIndex == 0)
            {
                UpdatePlayWithFriend(button);
            }
            // play with computer (Random)
            else if (cbChoice.SelectedIndex == 1)
            {
                UpdatePlayWithComputer(button);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            UpdateGame((Button)sender);
        }

        void ResetGame()
        {
            labTurn.Text = "Player1";
            labTheWinner.Text = "Unknown";
            CounterSteps = 0;

            btnOne.Enabled = true;
            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            btnSeven.Enabled = true;
            btnEight.Enabled = true;
            btnNine.Enabled = true;

            btnOne.BackColor = Color.Black;
            btnTwo.BackColor = Color.Black;
            btnThree.BackColor = Color.Black;
            btnFour.BackColor = Color.Black;
            btnFive.BackColor = Color.Black;
            btnSix.BackColor = Color.Black;
            btnSeven.BackColor = Color.Black;
            btnEight.BackColor = Color.Black;
            btnNine.BackColor = Color.Black;

            btnOne.Image = Resources.question_mark_96;
            btnTwo.Image = Resources.question_mark_96;
            btnThree.Image = Resources.question_mark_96;
            btnFour.Image = Resources.question_mark_96;
            btnFive.Image = Resources.question_mark_96;
            btnSix.Image = Resources.question_mark_96;
            btnSeven.Image = Resources.question_mark_96;
            btnEight.Image = Resources.question_mark_96;
            btnNine.Image = Resources.question_mark_96;

            btnOne.Tag = "?";
            btnTwo.Tag = "?";
            btnThree.Tag = "?";
            btnFour.Tag = "?";
            btnFive.Tag = "?";
            btnSix.Tag = "?";
            btnSeven.Tag = "?";
            btnEight.Tag = "?";
            btnNine.Tag = "?";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbChoice.SelectedIndex = 0;
        }

        private void cbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

            ResetGame();

        }

     
    }
}