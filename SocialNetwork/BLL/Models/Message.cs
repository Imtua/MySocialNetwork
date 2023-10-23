namespace SocialNetwork.BLL.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int SenderId { get; set; }
        public int RecipientId { get; set; }

        public Message(int id,
            string content,
            int sender_id,
            int recipient_id)
        {
            Id= id;
            Content= content;
            SenderId= sender_id;
            RecipientId= recipient_id;
        }
    }
}
