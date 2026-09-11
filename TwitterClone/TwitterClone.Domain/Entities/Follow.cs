namespace TwitterClone.Domain.Entities
{
    public class Follow:BaseEntity
    {
        public Guid FollowingId { get; private set; }

        public Follow(Guid userId, Guid followingId):base(userId)
        {
            FollowingId = followingId;
        }
    }
}
