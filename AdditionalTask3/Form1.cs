using System;
using System.Windows.Forms;

namespace AdditionalTask3
{
    public partial class Form1 : Form
    {
        private string _selectedColor = "Green";

        public Form1()
        {
            InitializeComponent();

            string[] colorStrings = {"Red", "Yellow", "Blue"};
            listBox1.Items.AddRange(colorStrings);

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            pictureBox1.MouseMove += pictureBox1_OnMouseMove;
            pictureBox1.MouseLeave += PictureBox1_OnMouseLeave;
            
            DrawRectangle(_selectedColor);
        }

        private void PictureBox1_OnMouseLeave(object sender, EventArgs e)
        {
            DrawRectangle("Green");
        }

        private void pictureBox1_OnMouseMove(object sender, MouseEventArgs e)
        {
            DrawRectangle(_selectedColor);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedColor = listBox1.SelectedItem.ToString();
        }

        private void DrawRectangle(string col)
        {
            Shape shape = new Rectangle(pictureBox1.Location.X, pictureBox1.Location.Y, pictureBox1.Height,
                pictureBox1.Width);
            shape.Draw(pictureBox1, col);
        }
    }
}