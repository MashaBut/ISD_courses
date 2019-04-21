namespace play
{
    public interface IMessageError
    {
        string MessageWinner();
        string MessageLosser(string str);
        string MessageErrorFile(string str);
    }
    public class MessageError:IMessageError
    {
        public string MessageWinner()
        {
            return "Вы отгадали слово";
        }

        public string MessageLosser(string str)
        {
            return $"Вы проиграли!!! Правильное слово: {str}";
        }

        public string MessageErrorFile(string str)
        {
            return $"Ошибка доступа к {str}";
        }
    }
}
