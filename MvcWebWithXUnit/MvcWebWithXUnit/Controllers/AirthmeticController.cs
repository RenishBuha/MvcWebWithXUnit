using Microsoft.AspNetCore.Mvc;
using MvcWebWithXUnit.Models;
using MvcWebWithXUnit.Services;

namespace MvcWebWithXUnit.Controllers
{
    public class AirthmeticController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult Add(AirthmeticModel items)
        {
            var airService = new AirthmeticService();
            var result = airService.Addition(items.Number1, items.Number2);
            items.Result = result;
            return View(result);
        }

        [HttpPost]
        public ActionResult Subtract(AirthmeticModel items)
        {
            var airService = new AirthmeticService();
            var result = airService.Subtraction(items.Number1, items.Number2);
            items.Result = result;
            return View(result);
        }

        [HttpPost]
        public ActionResult Multiply(AirthmeticModel items)
        {
            var airService = new AirthmeticService();
            var result = airService.Multiplication(items.Number1, items.Number2);
            items.Result = result;
            return View(result);
        }

        [HttpPost]
        public ActionResult Divide(AirthmeticModel items)
        {
            var airService = new AirthmeticService();
            var result = airService.Division(items.Number1, items.Number2);
            items.Result = result;
            return View(result);
        }

    }
}
