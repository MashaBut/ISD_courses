using System.Windows.Forms;

namespace File_Converter
{
    class ToDOCX:IFileDialog
    {
        public string Path { get; private set; }
        private string SavePath = string.Empty;
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        public void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "pdf files (*.pdf)|*.pdf";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Path = openFileDialog.FileName;
                }
            }
        }
        public void SaveFile()
        {
            saveFileDialog1.Filter = "docx files (*.docx)|*.docx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SavePath = saveFileDialog1.FileName;
                SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
                f.OpenPdf(Path);
                if (f.PageCount > 0)
                {
                    f.WordOptions.Format = SautinSoft.PdfFocus.CWordOptions.eWordDocument.Docx;
                    int result = f.ToWord(SavePath);
                    if (result == 0)
                    {
                        System.Diagnostics.Process.Start(SavePath);
                    }
                }
                MessageBox.Show("Conversion completed");
            }
        }
    }
}
