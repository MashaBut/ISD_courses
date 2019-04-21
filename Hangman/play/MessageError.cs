using System.Windows.Forms;

namespace play
{
    public interface IMessageError
    {
        void MessageWinner();
        void MessageLosser(string str);
        void MessageErrorFile(string str);
    }
    public class MessageError:IMessageError
    {
        public void MessageWinner()
        {
            MessageBox.Show("Вы отгадали слово");
        }
        public void MessageLosser(string str)
        {
            MessageBox.Show($"Вы проиграли!!! Правильное слово: {str}");
        }
        public void MessageErrorFile(string str)
        {
            MessageBox.Show($"Ошибка доступа к {str}");
        }
    }
}
