using Microsoft.AspNetCore.Mvc;

namespace PaymentIntegration.Controllers
{
    public class Donate : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
