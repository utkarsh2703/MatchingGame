using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        //global variables
        Grid oGrid;
        int Player1Score = 0;
        int Player2Score = 0;
        int Turns = 2;
        
        Sqaure Square1;
        Sqaure Square2;
        bool IsPlayer1 = true;
        public Form1()
        {
            InitializeComponent();
            lblP1Score.Visible = false;
            lblP2Score.Visible = false;
            lblTurns.Visible = false;
            lblWhichPlayer.Visible = false;
            lblReset.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartGame();
            }

            if (e.KeyCode == Keys.ShiftKey)
            {
                ResetGame();
            }
        }
        
        private void StartGame()
        {
            lblBegin.Visible = false;
            lblinstructions.Visible = false;
            lblP1Score.Visible = true;
            lblP2Score.Visible = true;
            lblTurns.Visible = true;
            lblWhichPlayer.Visible = true;
            oGrid = new Grid(5, 4);
            oGrid.Shuffle();
            oGrid.Shuffle();
            oGrid.Shuffle();
        }

        private void ResetGame()
        {
            oGrid = null;
            Player1Score = 0;
            Player2Score = 0;
            IsPlayer1 = true;
            oGrid = new Grid(5, 4);
            oGrid.Shuffle();
            oGrid.Shuffle();
            oGrid.Shuffle();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (oGrid != null)
            {

                oGrid.Draw(this.CreateGraphics(), 0,0);

            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
            int X = e.X;
            int Y = e.Y;
            
            if (X < 341 && Y < 426)
            {


                int Column = X / 85;
                int Row = Y / 85;
                

                //oGrid.GetSquare(Row, Column).BackColour = Color.Red;
                if (Turns == 2 && oGrid.GetSquare(Row, Column).BackColour != Color.Gray)
                {
                    lblContinue.Visible = false;
                    Square1 = oGrid.GetColorSquare(Row, Column);
                    Square1.GetPosition(Row, Column);
                    oGrid.GetSquare(Row, Column).BackColour = Square1.BackColour;
                    Turns--;
                    lblTurns.Text = "Turns Left: " + Turns;
                   
                }
                else if (Turns == 1 && oGrid.GetSquare(Row, Column).BackColour != Color.Gray)
                {
                    Square2 = oGrid.GetColorSquare(Row, Column);
                    Square2.GetPosition(Row, Column);
                    oGrid.GetSquare(Row, Column).BackColour = Square2.BackColour;
                    Turns--;
                    lblTurns.Text = "Turn Left: " + Turns;
                }
                else if (Turns == 0)
                {
                    if (Square1.BackColour != Square2.BackColour) // if the colors do not match
                    {
                        oGrid.GetSquare(Square1.X, Square1.Y).BackColour = Color.White;
                        oGrid.GetSquare(Square2.X, Square2.Y).BackColour = Color.White;
                        lblTurns.Text = Turns.ToString();
                        lblContinue.Visible = true;
                        lblWhichPlayer.Text = "Player Turn: Player 1";
                        lblWhichPlayer.Text = "Player Turn: Player 2";
                    }
                    if (oGrid.GetSquare(Square1.X, Square1.Y) != oGrid.GetSquare(Square2.X, Square2.Y))
                    {
                        if (IsPlayer1 == true)
                        {
                            if (Square1.BackColour == Square2.BackColour) //If colors match
                            {
                                if (Square1.BackColour == Color.Red && Square2.BackColour == Color.Red)
                                {
                                    Player1Score++;
                                    lblP1Score.Text = "Player 1 score: " + Player1Score;

                                }
                                else if (Square1.BackColour == Color.Blue && Square2.BackColour == Color.Blue)
                                {
                                    Player1Score++;
                                    lblP1Score.Text = "Player 1 score: " + Player1Score;
                                }
                                else if (Square1.BackColour == Color.Yellow && Square2.BackColour == Color.Yellow)
                                {
                                    Player1Score++;
                                    lblP1Score.Text = "Player 1 score: " + Player1Score;
                                }
                                else if (Square1.BackColour == Color.Green && Square2.BackColour == Color.Green)
                                {
                                    Player1Score++;
                                    lblP1Score.Text = "Player 1 score: " + Player1Score;
                                }
                                else if (Square1.BackColour == Color.Black && Square2.BackColour == Color.Black)
                                {
                                    Player1Score++;
                                    lblP1Score.Text = "Player 1 score: " + Player1Score;
                                }
                                else if (Square1.BackColour == Color.FromArgb(124, 37, 41) && Square2.BackColour == Color.FromArgb(124, 37, 41)) // Maroon 
                                {
                                    Player1Score++;
                                    lblP1Score.Text = "Player 1 score: " + Player1Score;
                                }
                                else if (Square1.BackColour == Color.Brown && Square2.BackColour == Color.Brown)
                                {
                                    Player1Score++;
                                    lblP1Score.Text = "Player 1 score: " + Player1Score;
                                }
                                else if (Square1.BackColour == Color.Orange && Square2.BackColour == Color.Orange)
                                {
                                    Player1Score += 2;
                                    lblP1Score.Text = "Player 1 score: " + Player1Score;
                                }
                                else if (Square1.BackColour == Color.Aqua && Square2.BackColour == Color.Aqua)
                                {
                                    Player1Score += 5;
                                    lblP1Score.Text = "Player 1 score: " + Player1Score;
                                }
                                else if (Square1.BackColour == Color.Violet && Square2.BackColour == Color.Violet)
                                {
                                    Player1Score += 3;
                                    lblP1Score.Text = "Player 1 score: " + Player1Score;
                                }
                                //do this in the end
                                oGrid.GetSquare(Square1.X, Square1.Y).BackColour = Color.Gray;
                                oGrid.GetSquare(Square2.X, Square2.Y).BackColour = Color.Gray;
                                Turns = 2;
                                lblWhichPlayer.Text = "Player Turn: Player 1";
                            }
                            else
                            {
                                lblWhichPlayer.Text = "Player Turn: Player 2";
                                IsPlayer1 = false;
                                Turns = 2;
                            }
                            oGrid.CheckFinish();
                        }

                        else if (IsPlayer1 == false)
                        {
                            if (Square1.BackColour == Square2.BackColour) //If colors match
                            {
                                if (Square1.BackColour == Color.Red && Square2.BackColour == Color.Red)
                                {
                                    Player2Score++;
                                    lblP2Score.Text = "Player 2 score: " + Player2Score;

                                }
                                else if (Square1.BackColour == Color.Blue && Square2.BackColour == Color.Blue)
                                {
                                    Player2Score++;
                                    lblP2Score.Text = "Player 2 score: " + Player2Score;
                                }
                                else if (Square1.BackColour == Color.Yellow && Square2.BackColour == Color.Yellow)
                                {
                                    Player2Score++;
                                    lblP2Score.Text = "Player 2 score: " + Player2Score;
                                }
                                else if (Square1.BackColour == Color.Green && Square2.BackColour == Color.Green)
                                {
                                    Player2Score++;
                                    lblP2Score.Text = "Player 2 score: " + Player2Score;
                                }
                                else if (Square1.BackColour == Color.Black && Square2.BackColour == Color.Black)
                                {
                                    Player2Score++;
                                    lblP2Score.Text = "Player 2 score: " + Player2Score;
                                }
                                else if (Square1.BackColour == Color.FromArgb(124, 37, 41) && Square2.BackColour == Color.FromArgb(124, 37, 41)) // Maroon 
                                {
                                    Player2Score++;
                                    lblP2Score.Text = "Player 2 score: " + Player2Score;
                                }
                                else if (Square1.BackColour == Color.Brown && Square2.BackColour == Color.Brown)
                                {
                                    Player2Score++;
                                    lblP2Score.Text = "Player 2 score:  " + Player2Score;
                                }
                                else if (Square1.BackColour == Color.Orange && Square2.BackColour == Color.Orange)
                                {
                                    Player2Score += 2;
                                    lblP2Score.Text = "Player 2 score: " + Player2Score;
                                }
                                else if (Square1.BackColour == Color.Aqua && Square2.BackColour == Color.Aqua)
                                {
                                    Player2Score += 5;
                                    lblP2Score.Text = "Player 2 score: " + Player2Score;
                                }
                                else if (Square1.BackColour == Color.Violet && Square2.BackColour == Color.Violet)
                                {
                                    Player2Score += 3;
                                    lblP2Score.Text = "Player 2 score: " + Player2Score;
                                }
                                //do this in the end
                                oGrid.GetSquare(Square1.X, Square1.Y).BackColour = Color.Gray;
                                oGrid.GetSquare(Square2.X, Square2.Y).BackColour = Color.Gray;
                                oGrid.CheckFinish();
                                Turns = 2;
                                lblWhichPlayer.Text = "Player Turn: Player 2";
                            }
                            else
                            {
                                IsPlayer1 = true;
                                Turns = 2;
                                lblWhichPlayer.Text = "Player Turn: Player 1";
                            }



                            if (oGrid.mGameFinish == true)
                            {
                                if (Player1Score > Player2Score)
                                {
                                    MessageBox.Show("PLAYER 1 HAS WON");
                                }
                                else if (Player1Score < Player2Score)
                                {
                                    MessageBox.Show("PLAYER 2 HAS WON");
                                }
                            }
                            if (oGrid.mGameFinish == true)
                            {
                                lblReset.Visible = true;
                            }

                        }

                    }
                    else if (oGrid.GetSquare(Square1.X, Square1.Y) == oGrid.GetSquare(Square2.X, Square2.Y))
                    {
                        oGrid.GetSquare(Square1.X, Square1.Y).BackColour = Color.White;
                        oGrid.GetSquare(Square2.X, Square2.Y).BackColour = Color.White;
                        Turns = 2;
                    }
                }
                this.Refresh();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void lblContinue_Click(object sender, EventArgs e)
        {

        }
    }
}
                




