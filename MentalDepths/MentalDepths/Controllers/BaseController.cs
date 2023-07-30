using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MentalDepths.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {

    }
}
