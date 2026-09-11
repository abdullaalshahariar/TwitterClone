namespace TwitterClone.Domain.Entities
{
    public class Message:BaseEntity
    {
        public Guid ReceiverId { get; private set; }
        public string Content { get; private set; }
        public bool IsRead { get; private set; }

        public Message(Guid senderId, Guid receiverId, string content):base(senderId)
        {
            ReceiverId = receiverId;
            Content = content;
            IsRead = false;
        }
    }
}
