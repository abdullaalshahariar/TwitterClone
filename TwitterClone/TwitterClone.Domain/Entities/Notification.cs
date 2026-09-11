namespace TwitterClone.Domain.Entities
{
    public enum NotificationType
    {
        Like,
        ReTweet,
        Message,
        Follow,
        System
    }
    public class Notification:BaseEntity
    {
        public NotificationType NotificationType { get; private set; }
        public Guid? ActorId { get; private set; }
        public Guid? TargetTweetId { get; private set; } //for likes, retweet, comments
        public string? MessageContent { get; private set; } // for system message
        public bool IsRead { get; private set; }
        //userId passed in the constuctor means the user
        //to whom the notification belongs
        //and actor id, is the user who caused it

        //Note: In the initial story there was no mention of ability to comment
        //but in HW, we were asked to make comment type notification
        //so, i added another Comment class which contains comment content
        
        //personally to me, defining enum for notification type mkakes more
        // sense than defining another calss for each notification type right now.
        //rather i will add nullable fields, which will be used for different
        //types of notifications. 
        
        //Follow does same thing as friend request, but with less options
        //(for exampl: cannot accept or reject or delete a request)


        public Notification(NotificationType notificationType, Guid userId, Guid? actorId=null, Guid? targetTweetId=null, string? messageContent=null):base(userId)
        {
            NotificationType = notificationType;
            ActorId = actorId;
            IsRead = false;
            TargetTweetId = targetTweetId;
            MessageContent = messageContent;
        }

       
    }
}
