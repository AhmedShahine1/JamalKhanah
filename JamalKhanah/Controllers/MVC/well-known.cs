using Microsoft.AspNetCore.Mvc;

namespace JamalKhanah.Controllers.MVC
{
    public class well_known : Controller
    {
        public IActionResult pki_validation()
        {
            return View("pki-validation");
        }
    }
}
