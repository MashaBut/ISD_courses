using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hangman
{
    public partial class HangmanView : Form, IHangman
    {
        public HangmanView()
        {
            InitializeComponent();
            BuildButton(); //dynamic button creation
        }
        
        private static int countButton = 32;
        private Button[] buttons = new Button[countButton];

        private string[] alphabet = { "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
        private char sign;
        

        public Color Color { get; set; }

        private void BuildButton()
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

        public char ButtonElement => sign; //property to get the character of the current row

        private void Button_Click(object sender, EventArgs eventArgs)
        {
            Button letterButton = (sender as Button);
            sign = Convert.ToChar(letterButton.Text);
            ButtonClick?.Invoke(this, EventArgs.Empty);
            letterButton.BackColor = Color;
        }

        public void DrawText(string str)
        {
            Content.Text = str;
        }

        public void DrawPicture(Bitmap bitmap)
        {
            Picture.BackgroundImage = bitmap;
        }

        public void MessageBoxShow(string str)
        {
            MessageBox.Show(str);
        }

        public event EventHandler ButtonClick;
    }
}
