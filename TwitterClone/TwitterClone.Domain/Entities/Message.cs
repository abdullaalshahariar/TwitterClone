namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        private Guid _id;
        private Guid _senderId;
        private Guid _receiverid;
        private string _content;
        private DateTime _createdAt;
        private bool _isRead;

        public Message(Guid senderId, Guid receiverId, string content)
        {
            _id = Guid.NewGuid();
            _senderId = senderId;
            _receiverid = receiverId;
            _content = content;
            _createdAt = DateTime.UtcNow;
            _isRead = false;
        }

        public Guid Id
        {
            get { return _id; }
        }
        public Guid SenderId
        {
            get { return _senderId; }
            set { _senderId = value; }
        }
        public Guid ReceiverId
        {
            set { _receiverid = value; }
            get { return _receiverid; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
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
