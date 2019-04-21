using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hangman
{
    interface IHangman
    {
        event EventHandler ButtonClick;

        char ButtonElement { get; }
        Color color { get; set; }

        void DrawText(string str);
        void MessageBoxPrint(string str);
        void DrawPicture(Bitmap bitmap);
    }
    public partial class Hangman : Form, IHangman
    {
        public Hangman()
        {
            InitializeComponent();
            BiuldButton(); //dynamic button creation
        }  

        Button[] buttons = new Button[32];

        string[] alphabet = { "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
        char sumbol;

        public Color color { get; set; }

        private void BiuldButton()
        {
            GenerateButton(0, 8, 280, 200);
            GenerateButton(8, 16, -200, 270);
            GenerateButton(16, 24, -680, 340);
            GenerateButton(24, 32, -1160, 410);
        }

        private void GenerateButton(int a,int b,int x,int y)
        {
            for (int i = a; i < b; i++)
            {
                buttons[i] = new Button();
                buttons[i].Width = 60;
                buttons[i].Height = 60;
                buttons[i].Location = new Point(buttons[i].Width * i + x, y);
                buttons[i].Text = string.Format(alphabet[i]);
                buttons[i].Tag = i;
                buttons[i].Font = new Font("Calibri", 28);
                this.Controls.Add(buttons[i]);
                buttons[i].Click += Button_Click;
            }
        }

        public char ButtonElement => sumbol; //property to get the character of the current row

        private void Button_Click(object sender, EventArgs eventArgs)
        {
            Button letterButton = (sender as Button);
            sumbol = Convert.ToChar(letterButton.Text);
            ButtonClick?.Invoke(this, EventArgs.Empty);
            ColorButton(letterButton);
        }

        public void DrawText(string str)
        {
            Content.Clear();
            Content.Text = str;
        }

        public void ColorButton(object sender)
        {
            Button button = (sender as Button);
            button.BackColor = color ;
        }

        public void DrawPicture(Bitmap bitmap)
        {
            Picture.BackgroundImage = bitmap;
        }

        public void MessageBoxPrint(string str)
        {
            MessageBox.Show(str);
        }

        public event EventHandler ButtonClick;
    }
}
