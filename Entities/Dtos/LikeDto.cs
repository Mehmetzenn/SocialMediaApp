namespace Entities.Dtos
{
    public class LikeDto
    {
        public int LikeId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime LikedDate { get; set; }
    }
}
