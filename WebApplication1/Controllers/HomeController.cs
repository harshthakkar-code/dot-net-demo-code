using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using Newtonsoft;
using Newtonsoft.Json;
using System.Text.Json;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(getJson getJson)
        {
            string jsonString = getJson.JSONString;
            jsonString = JsonDocument.Parse(jsonString).RootElement.GetProperty("form").ToString();
            if (!string.IsNullOrEmpty(jsonString))
            {
                List<form> frm = JsonConvert.DeserializeObject<List<form>>(jsonString);
                ViewBag.jsonData = frm;
            }
            //ViewBag.jsonData = jsonString;
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}