using System;
using System.Linq;
using System.Windows.Forms;

namespace AdditionalTask
{
    public partial class Form3 : Form
    {
        private readonly Form2 _form2;
        
        public Form3(Form2 form2)
        {
            InitializeComponent();
            _form2 = form2;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            _form2.Close();
            this.Close();
        }
    }
}