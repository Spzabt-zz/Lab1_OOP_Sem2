using System;
using System.Windows.Forms;

namespace AdditionalTask
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3(this);
            form3.Show();
        }
    }
}