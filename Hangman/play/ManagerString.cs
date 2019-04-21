using System.Text;

namespace play
{
    public interface IManagerString
    {
        StringBuilder SecretString(string str);
        StringBuilder CheckElement(char sumbol);
        bool GetChangeSumbol{get; }
        bool CheckTrueString();
        string TrueAns { get; }
    }
    public class ManagerString : IManagerString
    {
        private string content;
        private StringBuilder changeString = new StringBuilder();
        private bool poz;

        public StringBuilder SecretString(string str)//replacing a string with characters
        {
            content = str;
            changeString.Insert(0, "*", str.Length);
            return changeString;
        }

        public StringBuilder CheckElement(char sumbol)//check letter
        {
            poz = false;
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i] == sumbol)
                {
                    changeString[i] = sumbol;
                    poz = true;
                }
            }
            return changeString;
        }
        public bool CheckTrueString()//checking all guessed letters
        {
            for(int i=0;i<content.Length;i++)
            {
                if(changeString[i]=='*')
                {
                    return false;
                }
            }
            return true;
        }

        public bool GetChangeSumbol => poz;

        public string TrueAns => content;
    }
}
