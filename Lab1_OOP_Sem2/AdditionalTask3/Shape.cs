using System;
using System.Windows.Forms;

namespace AdditionalTask3
{
    public abstract class Shape
    {
        protected int X { get; }
        protected int Y { get; }
        protected int Height { get; }
        protected int Width { get; }

        protected Shape(int x, int y, int height,int width)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }

        public abstract void Draw(PictureBox pictureBox, String color);
    }
}