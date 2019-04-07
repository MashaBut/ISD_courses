using System;
using System.Windows.Forms;

namespace File_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToPDF_Click(object sender, EventArgs e)
        {
            convertToPDF1.BringToFront();
        }

        private void ToDocx_Click(object sender, EventArgs e)
        {
            convertToDOCX1.BringToFront();
        }
    }
}
