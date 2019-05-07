using System;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Drawing;
using play;

namespace Hangman
{
    class Presenter
    {
        private readonly IHangman hangman;
        private readonly IManagerFile managerFile;
        private readonly IManagerPicture managerPicture;
        private readonly IMessageError messageError;
        private readonly IManagerString managerString;

        private int i = 1;
        private static Color[] c = { Color.Red, Color.Green };

        public Presenter(IHangman hangman, IManagerFile managerFile, IManagerPicture managerPicture, IMessageError messageError,IManagerString managerString)
        {
            this.hangman = hangman;
            this.managerFile = managerFile;
            this.managerPicture = managerPicture;
            this.messageError = messageError;
            this.managerString = managerString;
                 
            this.hangman.ButtonClick += this.Hangman_ButtonClick;
            string pathToPicture = @"Resources";
            string pathToText = @"Resources\dictionary.txt";

            bool isFileExist = this.managerFile.FileExictance(pathToText);
            bool isPictureExist = this.managerPicture.FileExictance(pathToPicture);

            if (!isFileExist && !isPictureExist)
            {
                this.hangman.MessageBoxShow(this.messageError.ErrorFile("данным"));
                return;
            }

            this.managerFile.FileRead();
            string elem = this.managerFile.GetElement();

            this.hangman.DrawText(this.managerString.SecretString(elem));//secretString display

            this.managerPicture.FileRead();
            this.hangman.DrawPicture(this.managerPicture.GetElement(0));//image display
        }

        private void Hangman_ButtonClick(object sender, EventArgs e)
        {
            /*
             * 26. string str = managerString.CheckElement(hangman.ButtonElement).ToString(); => use EventArgs
             * Why is my way bad?
             */
            string str = managerString.CheckElementForChange(hangman.ButtonElement);
            hangman.DrawText(str);
            if (managerString.GetChangingSymbol)
            {
                if(managerString.CheckTrueString())
                {
                    hangman.MessageBoxShow(messageError.Winner());
                    Run();
                }
                hangman.Color = c[1];
            }
            else
            {
                if(i<7)
                {
                    this.hangman.DrawPicture(this.managerPicture.GetElement(i++));
                    hangman.Color = c[0];
                }
                else if(i==7)
                {
                    hangman.MessageBoxShow(messageError.Losser(managerString.CorrectLetter));
                    Run();
                }
            }
        }

        public void Run()
        {
            /*i don`t know other short options*/
            Application.Restart();
        }
    }
}
