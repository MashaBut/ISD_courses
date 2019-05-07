using System.Text;

namespace play
{
    public class ManagerString : IManagerString
    {
        private string content;
        private bool position;
        private StringBuilder changeString = new StringBuilder();

        public string SecretString(string str)//replacing a string with characters
        {
            content = str;
            changeString.Insert(0, "*", str.Length);
            return changeString.ToString();
        }

        public string CheckElementForChange(char sumbol)//check letter
        {
            position = false;
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i] == sumbol)
                {
                    changeString[i] = sumbol;
                    position = true;
                }
            }
            return changeString.ToString();
        }
        public bool CheckTrueString()//checking all guessed letters
        {
            return !changeString.ToString().Contains("*");
        }

        public bool GetChangingSymbol => position;

        public string CorrectLetter => content;
    }
}
