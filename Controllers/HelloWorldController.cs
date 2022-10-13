using FirstMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMvcApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel
            {
                Name = "Stevie",
                Age = 3
            };

            return View(doggo);
        }

        public string Hello()
        {
            return "Who's there?";
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
