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
        private bool _state;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_state)
                MessageBox.Show("There is nothing left to delete!");

            int labelCount = 0;
            Control[] findLabels;

            for (int i = 0; i < Controls.Count; i++)
            {
                findLabels = Controls.Find($"label{(i+1).ToString()}", true);
                if (findLabels.Length == Decimal.Zero)
                    break;
                labelCount++;
            }
            
            var labels = new Label[labelCount];
            
            for (int i = 0; i < labelCount; i++)
            {
                /*Control[] */findLabels = Controls.Find($"label{(i+1).ToString()}", true);
                labels[i] = (Label) findLabels[0];
            }

            foreach (var label in labels)
            {
                label.Dispose();
                _state = true;
            }

            labelCount = 0;
        }
    }
}