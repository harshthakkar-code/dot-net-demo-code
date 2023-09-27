namespace WebApplication1.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public GenderModel Gender { get; set; } = new GenderModel();

        public IEnumerable<HobbyModel> Hobbies { get; set; } = new List<HobbyModel>();
    }
}
