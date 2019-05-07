using System;
using System.Drawing;

namespace Hangman
{
    interface IHangman
    {
        event EventHandler ButtonClick;

        char ButtonElement { get; }

        Color Color { get; set; }

        void DrawText(string str);

        void MessageBoxShow(string str);

        void DrawPicture(Bitmap bitmap);

        void ClearContent();

        void ColorButtons();
    }
}
