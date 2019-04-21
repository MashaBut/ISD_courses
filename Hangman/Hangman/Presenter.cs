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

        int i = 1;
        Color[] c = { Color.Red, Color.Green };

        public Presenter(IHangman hangman, IManagerFile managerFile, IManagerPicture managerPicture, IMessageError messageError,IManagerString managerString)
        {
            this.hangman = hangman;
            this.managerFile = managerFile;
            this.managerPicture = managerPicture;
            this.messageError = messageError;
            this.managerString = managerString;
                 
            this.hangman.ButtonClick += this.Hangman_ButtonClick;
            //system pathname indicates bin \ Debug
            string pathToPicture = @"C:\Users\Мария\Documents\GitHub\ISD_courses\Hangman\Hangman\Resources";
            string pathToText = @"C:\Users\Мария\Documents\GitHub\ISD_courses\Hangman\Hangman\Resources\dictionary.txt";

            bool isFileExist = this.managerFile.FileExictance(pathToText);
            bool isPictureExist = this.managerPicture.FileExictance(pathToPicture);

            if (!isFileExist && !isPictureExist)
            {
                this.hangman.MessageBoxPrint(this.messageError.MessageErrorFile("данным"));
                return;
            }

            this.managerFile.FileRead();
            string elem = this.managerFile.GetElement();

            this.hangman.DrawText(Convert.ToString(this.managerString.SecretString(elem)));//secretString display

            this.managerPicture.FileRead();
            this.hangman.DrawPicture(this.managerPicture.GetElement(0));//image display
        }

        private void Hangman_ButtonClick(object sender, EventArgs e)
        {
            
            string str = managerString.CheckElement(hangman.ButtonElement).ToString();
            hangman.DrawText(str);
            if (managerString.GetChangeSumbol)
            {
                if(managerString.CheckTrueString())
                {
                    hangman.MessageBoxPrint(messageError.MessageWinner());
                    Run();
                }
                hangman.color = c[1];
            }
            else
            {
                if(i<7)
                {
                    this.hangman.DrawPicture(this.managerPicture.GetElement(i++));
                    hangman.color = c[0];
                }
                else if(i==7)
                {
                    hangman.MessageBoxPrint(messageError.MessageLosser(managerString.TrueAns));
                    Run();
                }
            }
        }
       
        public void Run()
        {
            Application.Restart();
        }
    }
}
