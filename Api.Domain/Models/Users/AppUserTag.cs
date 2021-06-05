namespace Api.Domain.Models.Users
{
    public class AppUserTag
    {
        public AppUserTag(int id, int userId, int tagId)
        {
            Id = id;
            UserId = userId;
            TagId = tagId;
        }

        public int Id { get; private set; }
        public int UserId { get; private set; }
        public int TagId { get; private set; }
    }
}
