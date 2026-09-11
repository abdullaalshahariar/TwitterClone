namespace TwitterClone.Domain.Entities
{
    public class ReTweet:BaseEntity
    {
        public Guid TweetId { get; private set; }
        public string ExtraContent { get; private set; }

        public ReTweet(Guid tweetId, string extraContent, Guid userId):base(userId)
        {
            TweetId = tweetId;
            ExtraContent = extraContent;
        }
    }
}