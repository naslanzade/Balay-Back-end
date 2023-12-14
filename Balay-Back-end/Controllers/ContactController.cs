using Microsoft.AspNetCore.Mvc;

namespace Balay_Back_end.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
