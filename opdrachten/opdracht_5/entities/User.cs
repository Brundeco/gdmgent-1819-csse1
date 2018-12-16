namespace entities
{
    public class User
    {

        protected string password;
        public string Username
        {
            get;
            set;
        }

        public virtual string CreatePassword()
        {
            return "Password created";
        }
        public void CreateUsername()
        {

        }
        public User()
        {

            this.password = CreatePassword();
        }
    }
}