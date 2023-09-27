namespace WebApplication1.Models
{
    public class UsersHobbiesModel
    {
        public int Id { get; set; }

        public UserModel User { get; set; } = new UserModel();

        public HobbyModel Hobby { get; set; } = new HobbyModel();
    }
}
