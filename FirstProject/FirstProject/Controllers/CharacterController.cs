using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class CharacterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
