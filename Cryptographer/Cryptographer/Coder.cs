using System.Windows.Forms;

namespace Cryptographer
{
    class Coder
    {
        private string Text;
        private int[] keyCoder = { 4,1,3,2};
        private string rezult = null;
        private string RatioButton;
        public Coder(string Text,string RatioButton)
        {
            this.Text = Text;
            this.RatioButton = RatioButton;
        }
        public string Answer()
        {
            
            if (RatioButton == "Encrypt")
            {
                rezult = Encrypt(Text);
            }
            else
            {
                rezult = Decipher(Text);
            }
            return rezult;
        }
        private string Encrypt(string Text)
        {
            string result = null;
            for (int i = 0; i < Text.Length % keyCoder.Length; i++)
                Text += Text[i];
            char[] transposition = new char[keyCoder.Length];
            for (int i = 0; i < Text.Length; i += keyCoder.Length)
            {
                for (int j = 0; j < keyCoder.Length; j++)
                    transposition[keyCoder[j] - 1] = Text[i + j];

                for (int j = 0; j < keyCoder.Length; j++)
                    result += transposition[j];
            }
            return result;
        }
        private string Decipher(string Text)
        {
            string result = null;
            char[] transposition = new char[keyCoder.Length];
            for (int i = 0; i < Text.Length; i += keyCoder.Length)
            {
                try
                {
                    for (int j = 0; j < keyCoder.Length; j++)
                        transposition[j] = Text[i + keyCoder[j] - 1];
                    for (int j = 0; j < keyCoder.Length; j++)
                        result += transposition[j];
                }
                catch {
                    MessageBox.Show("Error in text");
                }
            }
            return result;
        }
    }
}
