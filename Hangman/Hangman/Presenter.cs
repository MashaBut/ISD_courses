using System;
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
        private int countImage;
        private string elem;
        private static Color[] c = { Color.Red, Color.Green,Color.LightGray };

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
            elem = this.managerFile.GetElement();

            this.hangman.DrawText(this.managerString.SecretString(elem));//secretString display
            countImage = managerPicture.CountImage();
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
                    hangman.Color = c[2];
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
                else if(i==countImage)
                {
                    hangman.MessageBoxShow(messageError.Losser(managerString.CorrectLetter));
                    hangman.Color = c[2];
                    Run();
                }
            }
        }

        public void Run()
        {
            i = 1;
            managerString.Clear();
            hangman.ClearContent();
            elem = this.managerFile.GetElement();
            this.hangman.DrawText(this.managerString.SecretString(elem));//secretString display
            this.hangman.DrawPicture(this.managerPicture.GetElement(0));//image display
            hangman.ColorButtons();
        }
    }
}
