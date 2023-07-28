namespace MentalDepths.Services.Web
{
    using MentalDepths.Data;
    using MentalDepths.Data.Models;
    using MentalDepths.Services.Web.Interfaces;
    using MentalDepths.Web.Infrastructure.Extensions;
    using MentalDepths.Web.ViewModels.Web;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    public class JobApplicatipnService : IJobApplicatipnService
    {
        private MentalDepthsDbContext context;
        public JobApplicatipnService(MentalDepthsDbContext context)
        {
            this.context = context;
        }

        public async Task<JobApplicationVM> CreateAJobApplication(SpecialistVM model, JobApplicationFileVM jobApplication)
        {
            FileManipulator fm = new FileManipulator();
            return new JobApplicationVM() 
            {
                Id=Guid.NewGuid(),
                Specialist = new SpecialistVM
                {
                    ImageURL= model.ImageURL,
                    Address= model.Address,
                    Specialisations= model.Specialisations,
                    Age= model.Age,
                    ApplicationUser = model.ApplicationUser,
                    UserId=model.UserId,
                    Description=model.Description
                },
                CV=fm.ConvertToByteArray(jobApplication.CVPath),
                ScannedDiploma=fm.ConvertToByteArray(jobApplication.DiplomaPath),
                Certification=fm.ConvertToByteArray(jobApplication.CertificatePath),
            };
        }

        public async Task<SpecialistVM> CreateASpecialist(CreateASpecialistVM model)
        {
            SpecialistVM specialist = new SpecialistVM()
            {
                Id=Guid.NewGuid(),
                ApplicationUser = context.ApplicationUsers.FirstAsync(s=>s.Id==model.UserId).Result,
                UserId = model.UserId,
                ImageURL = model.ImageURL,
                Age = model.Age,
                Address = model.Address,
                Description = model.Description,
                Specialisations= model.Specialisations.Split(new char[]{',','.' },StringSplitOptions.RemoveEmptyEntries).ToList(),
            };
            specialist.ApplicationUser.PhoneNumber= model.PhoneNumber;
            return specialist;
        }
    }
}
