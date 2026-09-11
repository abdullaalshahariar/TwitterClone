namespace TwitterClone.Domain.Entities
{
    internal class Comment:BaseEntity
    {   
        public string Content { get; private set; }
        public Comment(Guid userId, string content) : base(userId)
        {
            Content = content;
        }
    }
}
