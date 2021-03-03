using System.Drawing;
using System.Windows.Forms;
using Brush = System.Drawing.Brush;
using Color = System.Drawing.Color;

namespace AdditionalTask3
{
    public class Rectangle : Shape
    {
        public Rectangle(int x, int y, int height, int width) : base(x, y, height, width) { }

        public override void Draw(PictureBox pictureBox, string color)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = bmp;
            Graphics graphics = Graphics.FromImage(pictureBox.Image);
            Brush myBrush = new SolidBrush(Color.FromName(color));
            graphics.FillRectangle(myBrush, X, Y, Width, Height);
        }
    }
}