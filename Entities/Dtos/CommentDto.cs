namespace Entities.Dtos
{
    public class CommentDto
    {
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
