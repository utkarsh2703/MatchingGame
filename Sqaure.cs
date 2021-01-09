using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment4
{
    class Sqaure
    {
        
        
        //fields
        private int mSize;
        private Color mBackColour;
        private Color mBorderColor;
        private int mX, mY;
            

        //Properties
        public int Size
        {
            set { mSize = value; }
            get { return mSize; }
        }

        public Color BackColour
        {
            get { return mBackColour; }
            set { mBackColour = value; }
        }

        public Color BorderColour
        {
            get { return mBorderColor; }
            set { mBorderColor = value; }
        }
        
        public int X
        {
            get { return mX; }
            set { mX = value; }
        }
        public int Y
        {
            get { return mY; }
            set { mY = value; }
        }


        //Constructors

        public Sqaure (int Size, Color BackColour, Color BorderColour)
        {
            mSize = Size;
            mBackColour = BackColour;
            mBorderColor = BorderColour;
        }

        public void Draw(Graphics g, int X, int Y)
        {
            //create Pen and Brush
            Pen BorderPen = new Pen(mBorderColor);
            SolidBrush BackBrush = new SolidBrush(mBackColour);

            //draw cell
            g.FillRectangle(BackBrush, X, Y, mSize, mSize);
            g.DrawRectangle(BorderPen, X, Y, mSize, mSize);

            //dispose of drawing tools
            BorderPen.Dispose();
            BackBrush.Dispose();
        }
        public void GetPosition(int PosX, int PosY)
        {
            X = PosX;
            Y = PosY;
        }

        

        }
    }

