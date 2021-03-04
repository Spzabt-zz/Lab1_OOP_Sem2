using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondTask
{
    public partial class Form1 : Form
    {
        private bool _isSubmited;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                button1.Text = "Thank you " + textBox1.Text;
                _isSubmited = true;
            }
            else
                MessageBox.Show("Enter your personal information!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "";

            int checkedCount = 0;
            int sum = 0;

            CheckBox[] checkBoxes = {checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6};
            int[] prise = {54, 345, 123, 71, 500, 66};

            foreach (var checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                    break;
                if (checkBox.Checked == false)
                    checkedCount++;
            }

            if (checkedCount == checkBoxes.Length && _isSubmited == false || _isSubmited == false ||
                checkedCount == checkBoxes.Length)
            {
                MessageBox.Show("Before calculate, please submit your personal information and choose recvired service!");
            }
            else
            {
                for (int i = 0; i < checkBoxes.Length; i++)
                {
                    if (checkBoxes[i].Checked)
                    {
                        sum += prise[i];
                    }
                }

                label5.Text = sum + "$";
            }

            checkedCount = 0;
            sum = 0;
        }
    }
}