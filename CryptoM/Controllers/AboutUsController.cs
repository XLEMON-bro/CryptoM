using Microsoft.AspNetCore.Mvc;

namespace CryptoM.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
