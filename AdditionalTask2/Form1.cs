using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalTask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Label[] _labels = new Label[Controls.];
            for (int i = 0; i < 16; i++)
            {
                _labels[i] = 
            }
            
            int f = Controls.Count;
            if (Controls.Contains(this.))
            MessageBox.Show(f.ToString());*/
            Label[] labels = new Label[Controls.Count - 1];
            for (int i = 0; i < Controls.Count - 1; i++)
            {
                Control[] findLabels = Controls.Find($"label{(i+1).ToString()}", true);
                labels[i] = (Label) findLabels[i];
            }
            /*Control[] labels = Controls.Find("label", true);*/
        }
    }
}