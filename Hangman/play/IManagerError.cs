namespace play
{
    public interface IMessageError
    {
        string Winner();

        string Losser(string str);

        string ErrorFile(string str);
    }
}
