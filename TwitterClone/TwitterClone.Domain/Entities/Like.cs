namespace TwitterClone.Domain.Entities
{
    public class Like
    {
        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _createdAt;

        public Like(Guid userId, Guid tweetId)
        {
            _id = Guid.NewGuid();
            _userId = userId;
            _tweetId = tweetId;
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }
        public Guid UserId
        {
            set { _userId = value; }
            get { return _userId; }
        }
        public Guid TweetId
        {
            set { _tweetId = value; }
            get { return _tweetId; }
        }
        public DateTime CreateAt
        {
            get { return _createdAt; }
        }
    }
}
