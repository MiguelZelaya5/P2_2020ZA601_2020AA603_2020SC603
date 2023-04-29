using Microsoft.AspNetCore.Mvc;

namespace Parcial_2_2023.Controllers
{
    public class CovidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
