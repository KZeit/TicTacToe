using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool playerTurn = true;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button xo = (Button)sender;

            if (playerTurn)
            {
                xo.Text = "X";
                xo.Enabled = false;
            }
            else
            {
                xo.Text = "O";
                xo.Enabled = false;
            }

            count++;
            playerTurn = !playerTurn;
            checkWinner();
        }

        private void checkWinner()
        {
            bool winner = false;

            if (A1.Text == A2.Text && A2.Text == A3.Text && !A2.Enabled ||
                B1.Text == B2.Text && B2.Text == B3.Text && !B2.Enabled ||
                C1.Text == C2.Text && C2.Text == C3.Text && !C2.Enabled ||
                A1.Text == B1.Text && B1.Text == C1.Text && !B1.Enabled ||
                A2.Text == B2.Text && B2.Text == C2.Text && !B2.Enabled ||
                A3.Text == B3.Text && B3.Text == C3.Text && !B3.Enabled ||
                A1.Text == B2.Text && B2.Text == C3.Text && !B2.Enabled ||
                A3.Text == B2.Text && B2.Text == C1.Text && !B2.Enabled)
            {
                winner = true;
            }

            if (winner == true)
            {
                string youWin = "";

                if (playerTurn)
                {
                    youWin = "O";
                    MessageBox.Show($"{youWin} Wins!");
                    ResetGame();
                }

                else
                {
                    youWin = "X";
                    MessageBox.Show($"{youWin} Wins!");
                    ResetGame();
                }
            }
            else
            {
                if (count == 9)
                {
                    MessageBox.Show("Tie!");
                    ResetGame();
                }
            }
        }

        private void ResetGame()
        {
            Application.Restart();
        }
    }
}
