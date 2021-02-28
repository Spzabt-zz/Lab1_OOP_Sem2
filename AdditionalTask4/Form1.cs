using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ContentAlignment = System.Drawing.ContentAlignment;

namespace AdditionalTask4
{
    public partial class Form1 : Form
    {
        private readonly VScrollBar _scrollBar = new VScrollBar();
        private int _iter = 1;
        private const int X = 3;
        private int _y = 7; // down += 23

        delegate void OnClick(string mess);
        private event OnClick Click;

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
            //splitContainer1.Panel2.AutoScroll = true;

            _scrollBar.Minimum = 0;
            _scrollBar.Value = 0;
            _scrollBar.Maximum = 1000;
            
            splitContainer1.Panel2.VerticalScroll.Maximum = _scrollBar.Maximum;

            _scrollBar.Scroll += scrollBar_Scroll;
            
            Controls.Add(_scrollBar);
        }

        private void ShowInfo(string mess)
        {
            //InformationalLabel.Text
        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            splitContainer1.Panel2.VerticalScroll.Value = _scrollBar.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Location = new Point(X, _y);
            label.TextAlign = ContentAlignment.TopLeft;
            label.Text = $"label{_iter}";
            var fontstyle = FontStyle.Bold | FontStyle.Italic;
            label.Font = new Font("Arial", 10f, fontstyle);
            splitContainer1.Panel2.Controls.Add(label);
            _iter++;
            _y += 23;
        }
    }
}