using System;
using play;

namespace Hangman
{
    class Presenter
    {
        private readonly IHangman hangman;
        private readonly IManagerFile managerFile;
        private readonly IManagerPicture managerPicture;
        private readonly IMessageError messageError;

        public Presenter(IHangman hangman, IManagerFile managerFile, IManagerPicture managerPicture, IMessageError messageError)
        {
            this.hangman = hangman;
            this.managerFile = managerFile;
            this.managerPicture = managerPicture;
            this.messageError = messageError;

            this.hangman.ContentChanged += this.Hangman_ContentChanged;
            this.hangman.ButtonClick += this.Hangman_ButtonClick;

            string pathToText = @"C:\Users\Мария\Documents\GitHub\ISD_courses\Hangman\Hangman\Resources\dictionary.txt";
            string pathToPicture = @"C:\Users\Мария\Documents\GitHub\ISD_courses\Hangman\Hangman\Resources";

            bool varToText =this.managerFile.FileExictance(pathToText);
            bool varToPicture = this.managerPicture.FileExictance(pathToPicture);

            if (!varToText && !varToPicture)
            {
                this.messageError.MessageErrorFile("данным");
                return;
            }
            this.managerFile.FileRead();
            string elem=this.managerFile.GetElement();
            this.hangman.content = elem;
        }

        private void Hangman_ContentChanged(object sender, EventArgs e)
        {

        }

        private void Hangman_ButtonClick(object sender, EventArgs e)
        {
            messageError.MessageErrorFile("данным");
        }
    }
}
