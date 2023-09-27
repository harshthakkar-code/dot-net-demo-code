namespace WebApplication1.Models
{
    public class CreateUserViewModel
    {
        public string? Name { get; set; }

        public string? Gender { get; set; }

        public IEnumerable<string> Hobbies { get; set; } = new List<string>();
    }
}
