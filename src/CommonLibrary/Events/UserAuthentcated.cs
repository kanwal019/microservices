namespace Library.Common.Events
{
    public class UserAuthentcated : IEvent
    {
        public string Email { get; }

        protected UserAuthentcated()
        {

        }

        public UserAuthentcated(string email)
        {
            this.Email = email;
        }
    }
}