namespace TwitterClone.Domain.Entities
{
    public class User
    {
        private Guid _id;
        private string _username;
        private string _email;
        private string _passwordHash;
        private DateTime _createdAt;

        public User(string username, string email, string passwordHash)
        {
            _id = Guid.NewGuid();
            _username = username;
            _email = email;
            _passwordHash = passwordHash;
            _createdAt = DateTime.UtcNow;
        }
        public Guid Id
        {
            get { return _id;  }
        }
        public string Username{
            set { _username = value; }
            get { return _username;  }
        }
        public string Email
        {
            set { _email = value; }
            get { return _email;  }
        }
        public string PasswordHash
        {
            set { _passwordHash = value; }
            get { return _passwordHash; }
        }
        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
    }
}
