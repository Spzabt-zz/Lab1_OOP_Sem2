using System;
using System.Drawing;
using System.Windows.Forms;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace AdditionalTask4
{
    public partial class Form1 : Form
    {
        private Label _label;
        private readonly LabelClicker _clicker;
        private readonly VScrollBar _scrollBar = new VScrollBar();
        private int _iter = 1;
        private const int X = 3;
        private int _y = 7; // down += 23

        public Form1()
        {
            InitializeComponent();

            _scrollBar.Dock = DockStyle.Right;
            _scrollBar.Height = splitContainer1.Panel2.Height;
            _scrollBar.Width = 20;

            splitContainer1.Panel2.AutoScroll = false;

            splitContainer1.Panel2.VerticalScroll.Enabled = false;
            splitContainer1.Panel2.VerticalScroll.Visible = false;
            splitContainer1.Panel2.VerticalScroll.Maximum = 0;

            splitContainer1.Panel2.HorizontalScroll.Enabled = false;
            splitContainer1.Panel2.HorizontalScroll.Visible = false;
            splitContainer1.Panel2.HorizontalScroll.Maximum = 0;

            _scrollBar.Minimum = 0;
            _scrollBar.Value = 0;
            _scrollBar.Maximum = 1000;

            splitContainer1.Panel2.VerticalScroll.Maximum = _scrollBar.Maximum;

            _clicker = new LabelClicker(this);

            _scrollBar.Scroll += scrollBar_Scroll;

            Controls.Add(_scrollBar);
        }

        public Label GetInformationalLabel()
        {
            return InformationalLabel;
        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            splitContainer1.Panel2.VerticalScroll.Value = _scrollBar.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _label = new Label();
            _label.Location = new Point(X, _y);
            _label.TextAlign = ContentAlignment.TopLeft;
            _label.Text = $"label{_iter}";
            _label.Font = new Font("Arial", 10f, FontStyle.Bold | FontStyle.Italic);
            splitContainer1.Panel2.Controls.Add(_label);
            _label.Click += _clicker.OnClick;
            _iter++;
            _y += 23;
        }
    }
}