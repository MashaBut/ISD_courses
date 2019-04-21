using System;
using System.Text;
using System.IO;

namespace play
{
    public interface IManagerFile
    {
        bool FileExictance(string Path);
        void FileRead();
        string GetElement();
    }
    public class ManagerFile : IManagerFile
    {
        Random rand = new Random();

        private readonly Encoding defaulfEncoding = Encoding.GetEncoding(1251);
        private string Path { get; set; }
        string[] text;

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
