using System;
using System.Windows.Forms;

namespace File_Converter
{
    public partial class ConvertToPDF : UserControl
    {
        public ConvertToPDF()
        {
            InitializeComponent();
        }
        ToPDF toPDF = new ToPDF();

        private void OpenFile_Click(object sender, EventArgs e)
        {
            toPDF.OpenFile();
            Path.Clear();
            Path.Text = toPDF.Path;
        }

        private void SaveCoonvertFileToPDF_Click(object sender, EventArgs e)
        {
            toPDF.SaveFile();
        }
    }
}
