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

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

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

        private void Calculate(Label l1, Label l2)
        {
            Random random = new Random();

            switch (random.Next(4))
            {
                case 0:
                    l1.Visible = false;
                    break;
                case 1:
                    l1.Visible = true;
                    break;
                case 2:
                    l1.Visible = false;
                    l2.Visible = true;
                    break;
                case 3:
                    l1.Visible = true;
                    l2.Visible = false;
                    break;
                default:
                    MessageBox.Show("???");
                    break;
            }

            if (label1.Visible == false && label2.Visible == false
                                        && label3.Visible == false && label4.Visible == false)
                MessageBox.Show("You won, press restart button or exit!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetSettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetButtonColor(button1);
            Calculate(label3, label2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetButtonColor(button2);
            Calculate(label4, label1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetButtonColor(button3);
            Calculate(label2, label4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetButtonColor(button4);
            Calculate(label1, label3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetSettings();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}