namespace TwitterClone.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id {  get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? ModifiedAt {  get; private set; }
        public Guid CreatedBy { get; private set; }
        public Guid? ModifiedBy { get; private set; }
        //ModifiedAt and ModifiedBy are private set
        //as they can get modified later, we will
        //implement a protected function so that
        //only child class can modify ModifiedBy later

        public BaseEntity(Guid userId)
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            ModifiedAt = null;
            CreatedBy = userId;
            ModifiedBy = null;
        }

        protected void Modified(Guid userId)
        {
            ModifiedAt = DateTime.UtcNow;
            ModifiedBy = userId;
        }
    }
}
