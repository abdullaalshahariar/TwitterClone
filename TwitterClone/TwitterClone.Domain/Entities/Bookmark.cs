namespace TwitterClone.Domain.Entities
{
    public class Bookmark:BaseEntity
    {
        public Guid TweetId { get; private set; }

        public Bookmark(Guid userId, Guid tweetId):base(userId)
        {
            TweetId = tweetId;
        }

    }
}
