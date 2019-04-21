using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hangman
{
    interface IHangman
    {
        Bitmap Element { set; }
        string content { set; }
        event EventHandler ButtonClick;
        event EventHandler ContentChanged;
        void Change(string str);
    }
    public partial class Hangman : Form, IHangman
    {
        public Hangman()
        {
            InitializeComponent();
            BiuldButton();
            Content.TextChanged += Content_TextChanged;
        }

        Button[] buttons = new Button[32];
        string[] alphabet = { "А", "Б", "В", "Г", "Д", "Е", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };

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
                this.Controls.Add(buttons[i]);
                buttons[i].Click += Button_Click;
            }
        }

        private void Button_Click(object sender, EventArgs eventArgs)
        {
            ButtonClick?.Invoke(this, EventArgs.Empty);
        }

        public void Content_TextChanged(object sender, EventArgs e)
        {
            ContentChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Change(string str)
        {
            Content.Clear();
            Content.Text = str;
        }
        public Bitmap Element { set => Picture.Image = value; }
        public string content { set => Content.Text = value; }
        public event EventHandler ButtonClick;
        public event EventHandler ContentChanged;
       
    }
}
