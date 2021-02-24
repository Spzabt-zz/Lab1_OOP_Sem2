using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Sem2_Var7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetSettings()
        {
            Random rand = new Random();

            /*label1.Text = rand.Next(10).ToString();
            label2.Text = rand.Next(10).ToString();
            label3.Text = rand.Next(10).ToString();
            label4.Text = rand.Next(10).ToString();*/

            var firstColorSet = label1.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256),
                rand.Next(256));
            var secondColorSet = label2.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256),
                rand.Next(256));
            var thirdColorSet = label3.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256),
                rand.Next(256));
            var fourthColorSet = label4.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256),
                rand.Next(256));

            label1.ForeColor = firstColorSet;
            label2.ForeColor = secondColorSet;
            label3.ForeColor = thirdColorSet;
            label4.ForeColor = fourthColorSet;
        }

        private void SetButtonColor(Button b)
        {
            Random rand = new Random();

            b.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256),
                rand.Next(256));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetButtonColor(button1);

            label1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetButtonColor(button2);

            label1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetButtonColor(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetButtonColor(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetSettings();
        }
    }
}