using Microsoft.AspNetCore.Mvc;

namespace MentalDepths.Controllers
{
    public class ApointmentController : Controller
    {
        public IActionResult Book()
        {
            return View();
        }
    }
}
