using System;
using System.Windows.Forms;

namespace File_Converter
{
    public partial class ConvertToDOCX : UserControl
    {
        public ConvertToDOCX()
        {
            InitializeComponent();
        }
        ToDOCX toDOCX = new ToDOCX();

        private void OpenFile_Click(object sender, EventArgs e)
        {
            toDOCX.OpenFile();
            Path.Clear();
            Path.Text = toDOCX.Path;
        }

        private void SaveCoonvertFileToDOCX_Click(object sender, EventArgs e)
        {
            toDOCX.SaveFile();
        }
    }
}
