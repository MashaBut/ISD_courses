using System.Drawing;
using System.IO;

namespace play
{
    public interface IManagerPicture
    {
        bool FileExictance(string Path);
        void FileRead();
        Bitmap GetElement(int index);
    }

    public class ManagerPicture:IManagerPicture
    {
        Bitmap[] image;

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
            for (int i = 0; i < 7; i++)
            {//?
                image[i] = new Bitmap($"{Path}виселица{j}");
                j++;
            }
        }
        public Bitmap GetElement(int index)
        {
            return image[index];
        }
    }
}
