using System;
using System.Windows.Forms;

namespace AdditionalTask4
{
    public delegate void LabelClickEvent(object sender, EventArgs e);

    class LabelClicker
    {
        private readonly Form1 _form1;

        public LabelClicker(Form1 form1)
        {
            _form1 = form1;
        }

        public event LabelClickEvent Click;

        public void OnClick(object sender, EventArgs e)
        {
            Click?.Invoke(sender, e);

            var label = (Label) sender;

            string str = label.Text;
            string emptyStr = string.Empty;
            int value = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                    emptyStr += str[i];
            }

            if (emptyStr.Length > 0)
                value = int.Parse(emptyStr);

            _form1.GetInformationalLabel().Text = value.ToString();
        }
    }
}