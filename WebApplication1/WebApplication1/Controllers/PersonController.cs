using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonController : Controller
    {
        public static List<PersonModel> listOfPerson = new();
        public IActionResult Index()
        {
            return View(listOfPerson);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PersonModel p)
        {
            p.Id = Guid.NewGuid().ToString();
            listOfPerson.Add(p);
            return RedirectToAction("Index");
        }
    }
}
