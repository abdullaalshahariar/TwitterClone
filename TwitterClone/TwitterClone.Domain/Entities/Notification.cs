namespace TwitterClone.Domain.Entities
{
    public enum NotificationType
    {
        Like,
        ReTweet,
        Message,
        Follow
    }
    public class Notification
    {
        private Guid _id;
        private NotificationType _notificationType;
        private Guid _userId;
        private Guid? _actorId;
        private DateTime _createdAt;
        private bool _isRead;

        public Notification(NotificationType notificationType, Guid userId, Guid? actorId)
        {
            _id = Guid.NewGuid();
            _notificationType = notificationType;
            _userId = userId;
            _actorId = actorId;
            _createdAt = DateTime.UtcNow;
            _isRead = false;
        }

        public Guid Id{
            get { return _id; }
        }
        public NotificationType NotificationType { 
            get { return _notificationType; }
            set { _notificationType = value; }
        }

        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public Guid? ActorId
        {
            get { return _actorId; }
            set { _actorId = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }
        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }



    }
}
