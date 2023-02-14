using Microsoft.AspNetCore.Mvc;

namespace FPLSP.Controllers
{
    public class LoginController : Controller
    {
        [HttpPost]
        public IActionResult Index(string ale)
        {
            var xx = ale.ToLower();
            return View();
        }
    }
}
