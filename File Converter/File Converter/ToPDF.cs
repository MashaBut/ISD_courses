using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace File_Converter
{
    class ToPDF : IFileDialog
    {
        public string Path {get; private set; }
        private string SavePath = string.Empty;
        Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        public void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "docx files (*.docx)|*.docx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Path = openFileDialog.FileName;
                }
            }
        }
        public void SaveFile()
        {
            saveFileDialog1.Filter = "pdf files (*.pdf)|*.pdf";
            Document file = word.Documents.Open(Path);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SavePath = saveFileDialog1.FileName;
                file.ExportAsFixedFormat(SavePath, WdExportFormat.wdExportFormatPDF);
                MessageBox.Show("Conversion completed");
            }
        }
    }
}
