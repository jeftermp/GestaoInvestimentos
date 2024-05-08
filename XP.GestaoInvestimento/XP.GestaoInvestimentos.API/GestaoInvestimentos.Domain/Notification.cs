namespace GestaoInvestimentos.Domain
{
    public class Notification
    {
        public Notification()
        {
            this.Errors = new List<NotificationError>();
        }

        public List<NotificationError> Errors { get; set; }

        public bool HasErrors()
        {
            return this.Errors.Any();
        }

        public void AddError(string message)
        {
            NotificationError error = new NotificationError(message);
            this.AddError(error);
        }

        public void AddError(NotificationError error)
        {
            this.Errors.Add(error);
        }

        public void AddErrors(List<string> messages)
        {
            foreach (string message in messages)
            {
                this.AddError(message);
            }
        }

        public void AddErrors(List<NotificationError> errors)
        {
            foreach (NotificationError error in errors)
            {
                this.AddError(error);
            }
        }
    }
}
