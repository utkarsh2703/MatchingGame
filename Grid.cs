using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment4
{
    class Grid
    {
        //fields
        private Sqaure[,] mGrid;
        private Sqaure[,] mColorGrid;
        private int mRows;
        private int mColumns;
        private int mSize;
        public bool mGameFinish;
       

        //Constructors
        public Grid(int Rows, int Columns)
        {

            mRows = Rows;
            mColumns = Columns;
            mGrid = new Sqaure[mRows, mColumns];
            mColorGrid = new Sqaure[mRows, mColumns];

            //create each cell in the grid
            mSize = 85;
            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < mColumns; j++)
                {
                    mGrid[i, j] = new Sqaure(mSize, Color.White, Color.Black);
                    if (i == 0 && j < 2)                  
                        mColorGrid[i, j] = new Sqaure(mSize, Color.Red, Color.Black);                                    
                    else if (i == 0 && j >= 2)
                        mColorGrid[i, j] = new Sqaure(mSize, Color.Yellow, Color.Black);
                    else if (i == 1 && j < 2)
                        mColorGrid[i, j] = new Sqaure(mSize, Color.Green, Color.Black);
                    else if (i == 1 && j >= 2)
                        mColorGrid[i, j] = new Sqaure(mSize, Color.Black, Color.Black);
                    else if (i == 2 && j < 2)
                         mColorGrid[i, j] = new Sqaure(mSize, Color.Aqua, Color.Black);
                    else if (i == 2 && j >= 2) 
                        mColorGrid[i, j] = new Sqaure(mSize, Color.FromArgb(124,37,41), Color.Black); //Maroon 
                    else if (i == 3 && j < 2 )
                        mColorGrid[i, j] = new Sqaure(mSize, Color.Orange, Color.Black);
                    else if (i == 3 && j >= 2)
                        mColorGrid[i, j] = new Sqaure(mSize, Color.Violet, Color.Black);
                    else if (i == 4 && j < 2 )
                        mColorGrid[i, j] = new Sqaure(mSize, Color.Blue, Color.Black);
                    else if (i == 4 && j >= 2)
                        mColorGrid[i, j] = new Sqaure(mSize, Color.Brown, Color.Black);
                }
            }

        }


        //methods
        public Sqaure GetSquare(int RowIndex, int ColumnIndex)
        {
            return mGrid[RowIndex , ColumnIndex ];
        }
        public Sqaure GetColorSquare (int RowIndex, int ColumnIndex)
        {
            return mColorGrid[RowIndex, ColumnIndex];
        }// how to fix this issue 


        public void Draw(Graphics g, int X, int Y)
        {
            //co-ordinate values for looping
            int pX = X;
            int pY = Y;

            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < mColumns; j++)
                {
                    mGrid[i, j].Draw(g, pX, pY); 
                    pX += mSize;
                }
                pX = X;  //resets back to first column location
                pY += mSize; //goes down a row
            }


        }
        public void Shuffle()
        {
            Random Rand = new Random();
            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < mColumns; j++)
                {
                    int Rndi = Rand.Next(mRows - 1);
                    int Rndj = Rand.Next(mColumns - 1);
                    Sqaure mCopy = mColorGrid[i, j];
                    mColorGrid[i, j] = mColorGrid[Rndi, Rndj];
                    mColorGrid[Rndi, Rndj] = mCopy;

                }
                
            }

        }
        public void CheckFinish()
        {
            bool notfinished = false;
            if (notfinished == false)
            {
               for (int i = 0; i < mRows; i++)
                {
                    if (notfinished == true)
                        break;
                    for (int j = 0; j < mColumns; j++)
                    {
                        if (notfinished == true)
                            break;
                        if (i == mRows - 1 && j == mColumns - 1)
                        {
                            if (mGrid[i, j].BackColour == Color.Gray)
                            {
                                mGameFinish = true;
                            }
                        }
                        else if (mGrid[i, j].BackColour != Color.Gray)
                            notfinished = true;
                    }
                   
                }
            }
           
        }

    }
}

