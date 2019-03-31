using System;
using System.Windows.Forms;

namespace Cryptographer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Ratio=null;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            OutputText.Clear();
            if (Ratio != null)
            {
                Coder coder = new Coder(SourceText.Text.ToString(), Ratio);
                OutputText.Text = coder.Answer();
            }
            else
                MessageBox.Show("Choose action");
        }
        private void Decipher_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                Ratio=radioButton.Text;
            }
        }

        private void Encrypt_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                Ratio = radioButton.Text;
            }
        }
    }
}
