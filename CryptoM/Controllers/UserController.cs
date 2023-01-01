using Microsoft.AspNetCore.Mvc;

namespace CryptoM.Controllers
{
    public class UserController : Controller
    {
        //for login\ signup \ profile actions
        public IActionResult Index()
        {
            return View();
        }
    }
}
