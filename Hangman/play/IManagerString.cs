using System.Text;

namespace play
{
    public interface IManagerString
    {
        string SecretString(string str);

        string CheckElementForChange(char symbol);

        bool GetChangingSymbol { get; }

        bool CheckTrueString();

        string CorrectLetter { get; }
    }
}
