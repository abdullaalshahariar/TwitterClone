namespace TwitterClone.Domain.Entities
{
    public class Tweet
    {
        private Guid _id;
        private Guid _userId;
        private string _content;
        private DateTime _createdAt;
        private DateTime?  _updateAt;

        public Tweet( Guid userId, string content)
        {
            _id = Guid.NewGuid();
            _userId = userId;
            _content = content;
            _createdAt = DateTime.UtcNow;
            _updateAt = _createdAt;
        }

        public Guid Id
        {
            get { return _id; }
        }
        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Content
        {
            set { _content = value; }
            get { return _content; }
        }
        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
    }
}
