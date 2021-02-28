using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalTask3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            string[] countries = { "Red", "Yellow", "Blue" };
            listBox1.Items.AddRange(countries);
         
            //listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = listBox1.SelectedItem.ToString();
            MessageBox.Show(selectedCountry);
        }
    }
}