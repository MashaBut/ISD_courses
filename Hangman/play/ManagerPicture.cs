using System.Drawing;
using System.IO;

namespace play
{
    public class ManagerPicture:IManagerPicture
    {
        private const int countImage= 7;
        private Bitmap[] images= new Bitmap[countImage];

        private string Path { get; set; }

        public bool FileExictance(string Path)
        {
            bool isExist = File.Exists(Path);
            this.Path = Path;
            return isExist;
        }

        public void FileRead()
        {
            int j = 1;
            for (int i = 0; i < countImage; i++)
            {
                try
                {
                    images[i] = new Bitmap($"{Path}\\виселица{j}.jpg");
                    j++;
                }
                catch { break; }
            }
        }

        public Bitmap GetElement(int index)
        {
            if (index >= 0 && index <= countImage)
                return images[index];
            else
                return null;
        }

        public string GetElement()
        {
            throw new System.NotImplementedException();
        }
    }
}
