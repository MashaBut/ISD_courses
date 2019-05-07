namespace play
{
    public interface IManagerFile
    {
        bool FileExictance(string Path);

        void FileRead();

        string GetElement();
    }
}
