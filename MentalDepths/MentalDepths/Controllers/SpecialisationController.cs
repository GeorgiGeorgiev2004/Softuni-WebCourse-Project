using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MentalDepths.Controllers
{
    [Authorize(Roles ="Admin")]
    public class SpecialisationController : BaseController
    {
        private ISpecialisationService sps;
        public SpecialisationController(ISpecialisationService sps)
        {
                this.sps = sps;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(SpecialisationVM model)
        {
            await sps.AddSpecialisationToDB(model);
            return RedirectToAction("All") ;
        }
        [HttpGet]
        public IActionResult All()
        {
            var specialisations =sps.GetAllSpecialisations().Result;
            return View(specialisations);
        }
        public async Task<IActionResult> Delete(string name)
        {
            await sps.Delete(name);
            return RedirectToAction("All");
        }
    }
}
