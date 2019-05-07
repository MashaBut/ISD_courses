namespace play
{

    public class MessageError:IMessageError
    {
        public string Winner()
        {
            return "Вы отгадали слово";
        }

        public string Losser(string str)
        {
            return $"Вы проиграли!!! Правильное слово: {str}";
        }

        public string ErrorFile(string str)
        {
            return $"Ошибка доступа к {str}";
        }
    }
}
