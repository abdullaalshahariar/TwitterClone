namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        private Guid _id;
        private Guid _followerId;
        private Guid _followingId;
        private DateTime _createdAt;

        public Follow(Guid followerId, Guid followingId)
        {
            _id = Guid.NewGuid();
            _followerId = followerId;
            _followingId = followingId;
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id
        {
            get { return _id; }
        }
        public Guid FollowerID
        {
            get { return _followerId; }
            set { _followerId = value; }
        }
        public Guid FollowingId
        {
            get { return _followingId; }
            set { _followingId = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
    }
}
