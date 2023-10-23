namespace SocialNetwork.BLL.Models
{
    internal class MessageSendingData
    {
        public string Content { get; set; }
        public int SenderId { get; set; }
        public string RecipientEmail { get; set; }
    }
}
