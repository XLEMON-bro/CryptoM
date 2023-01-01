using Microsoft.AspNetCore.Mvc;

namespace CryptoM.Controllers
{
    public class CryptoController : Controller
    {
        //for api actions \ crypto list
        public IActionResult Index()
        {
            return View();
        }
    }
}
