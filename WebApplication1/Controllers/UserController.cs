using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            using (var context = new UserContext())
            {
                var users = context.User.Select(x => new UserViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Gender = x.Gender,
                    Hobbies = context.UsersHobbies.Select(y => new HobbyModel
                    {
                        Id = y.Id,
                        Hobby = y.Hobby.Hobby
                    }).ToList()
                }).ToList();

                return View(users);
            }
        }

        [HttpPost("create")]
        public async Task<ActionResult> Create([FromForm] CreateUserViewModel createUserViewModel)
        {
            Console.WriteLine(createUserViewModel.Name);
            Console.WriteLine(createUserViewModel.Gender);
            Console.WriteLine(string.Join(", ", createUserViewModel.Hobbies));

            //using (var context = new UserContext())
            //{
            //    var user = new UserModel
            //    {
            //        Name = createUserViewModel.Name,
            //        Gender = context.Gender.Where(x => x.Gender == createUserViewModel.Gender).First(),
            //    };
            //    var usersHobbies = createUserViewModel.Hobbies.Select(hobby => new UsersHobbiesModel
            //    {
            //        User = user,
            //        Hobby = context.Hobby.Where(x => x.Hobby == hobby).First()
            //    });

            //    await context.User.AddAsync(user);

            //    await context.UsersHobbies.AddRangeAsync(usersHobbies);

            //    await context.SaveChangesAsync();
            //}

            return Ok();
        }
    }
}
