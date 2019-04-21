using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using play;

namespace Hangman
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Hangman hangman = new Hangman();
            ManagerFile managerFile = new ManagerFile();
            ManagerPicture managerPicture = new ManagerPicture();
            MessageError messageError = new MessageError();
            Presenter presenter = new Presenter(hangman, managerFile, managerPicture, messageError);
            Application.Run(new Hangman());
        }
    }
}
