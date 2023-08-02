using MentalDepths.Data;
using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalDepths.Services.Web
{
    public class AdminService : IAdminService
    {
        private MentalDepthsDbContext context;
        private ISpecialisationService specialisationService;
        public AdminService(MentalDepthsDbContext ctxt,ISpecialisationService spc)
        {
              context = ctxt;
            specialisationService = spc;
        }

        public async Task<AplicantVM> FindAplicantById(Guid aplicantId)
        {
            var ap = await context.Aplicants.FirstOrDefaultAsync(a => a.Id == aplicantId);
            return new AplicantVM()
            {
                Address=ap.Address,
                Id=ap.Id,
                Age=ap.Age,
                ApplicationUser=await context.ApplicationUsers.FirstOrDefaultAsync(a=>a.Id==ap.UserId),
                UserId=ap.UserId,
                Description=ap.Description,
                ImageURL=ap.ImageURL,
                JobApplicationId=ap.JobApplicationId,
                Specialisations=ap.Specialisations,
            };
        }

        public async Task<RegisterASpecicalistVM> TurnAplicantToSpecialist(AplicantVM aplicant)
        {
            return new RegisterASpecicalistVM() 
            {
                Id=Guid.NewGuid(),
                ImageURL=aplicant.ImageURL,
                Age = aplicant.Age,
                Address=aplicant.Address,
                Description=aplicant.Description,
                Specialisations=specialisationService.GetAllSpecialisations().Result,
                UserId=aplicant.UserId,
                ApplicationUser = await context.ApplicationUsers.FirstOrDefaultAsync(a=>a.Id==aplicant.UserId)
            };
        }
    }
}
