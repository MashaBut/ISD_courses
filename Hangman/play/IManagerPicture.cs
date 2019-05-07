using System.Drawing;

namespace play
{
    public interface IManagerPicture : IManagerFile
    {
        Bitmap GetElement(int index);
    }
}
