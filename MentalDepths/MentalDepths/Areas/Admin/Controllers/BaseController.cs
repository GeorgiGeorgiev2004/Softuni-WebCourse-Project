﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MentalDepths.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
