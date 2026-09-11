namespace TwitterClone.Domain.Entities
{
    public class ReTweet
    {
        private Guid _id;
        private Guid _tweetId;
        private String _extraContent;
        private DateTime _createdAt;

        public ReTweet(Guid tweetId, String extraContent)
        {
            _id = Guid.NewGuid();
            _tweetId = tweetId;
            _extraContent = extraContent;
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }
        public Guid TweetId
        {
            get { return _tweetId; }
            set { _tweetId = value; }
        }

        public string ExtraContent
        {
            get { return _extraContent; }
            set { _extraContent = value; }
        }
        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
    }
}
