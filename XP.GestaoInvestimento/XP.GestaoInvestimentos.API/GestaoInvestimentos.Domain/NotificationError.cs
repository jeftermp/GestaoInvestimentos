namespace GestaoInvestimentos.Domain
{
    public class NotificationError
    {
        public NotificationError(string message)
        {
            this.Message = message;
        }

        public string Message { get; private set; }
    }
}