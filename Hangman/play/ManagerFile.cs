using System;
using System.Text;
using System.IO;

namespace play
{
    public class ManagerFile : IManagerFile
    {
        private Random rand = new Random();

        private readonly Encoding defaulfEncoding = Encoding.Default;
        /*
         utf
         There is no way to use it.Only one kryakozyably:(
         */
        private string Path { get; set; }

        private string[] text;

        public bool FileExictance(string Path)
        {
            bool isExist = File.Exists(Path);
            this.Path = Path;
            return isExist;
        }

        public void FileRead()
        {
            string content = File.ReadAllText(Path,defaulfEncoding);
            text = content.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public string GetElement()
        {
            int random = rand.Next(0, text.Length);
            return text[random];
        }
    }
}
