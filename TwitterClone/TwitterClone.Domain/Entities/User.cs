namespace TwitterClone.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; }
        public string Username { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime ModifiedAt { get; private set; }
        //user class does not inherit BaseEntity
        //because BaseEntity has a field called CreatedBy
        //The user is created by the user itself

        public User(string username, string email, string passwordHash)
        {
            Id = Guid.NewGuid();
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            CreatedAt = DateTime.UtcNow;
        }
        
        public void Modified()
        {
            ModifiedAt= DateTime.UtcNow;
        }
    }
}
