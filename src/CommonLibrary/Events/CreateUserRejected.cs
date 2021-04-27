namespace Library.Common.Events
{
    public class CreateUserRejected : IRejectedEvent
    {
        protected CreateUserRejected()
        {

        }

        public CreateUserRejected(string email, string reason, string code)
        {
            this.Email = email;
            this.Reason = reason;
            this.Code = code;
        }

        public string Email { get; }
        public string Reason { get; }
        public string Code { get; }
    }
}