using MentalDepths.Data;

namespace MentalDepths.Services.Web
{
    using Microsoft.EntityFrameworkCore;

    using MentalDepths.Services.Web.Interfaces;
    using MentalDepths.Web.ViewModels.Web;
	using System;
	using MentalDepths.Data.Models;
    using System.Runtime.CompilerServices;

    public class SpecialistService : ISpecialistService
    {
        private MentalDepthsDbContext context;
        public SpecialistService(MentalDepthsDbContext Context)
        {
            context = Context;
        }

		public async Task<SpecialistVM> FindSpecialistById(Guid id)
		{
			Specialist specialist = context.Specialists.FirstOrDefaultAsync(s=>s.Id==id).Result;
            SpecialistVM spec= new SpecialistVM 
            { 
                Id = specialist.Id,
                Address = specialist.Address,
                Description = specialist.Description,
				Specialisations = specialist.Specialisations.Select(s => s.Specialisation.Name).ToList(),
                ApplicationUser = await context.Users.FirstAsync(s=>s.Id==specialist.UserId),
                Age = specialist.Age,
                ImageURL = specialist.ImageURL,
			};
            return spec;
		}

        public async Task<ICollection<SpecialistVM>> GetAllSpecialist()
        {
            return await context.Specialists.Select(s => new SpecialistVM
            {
                Id = s.Id,
                Address = s.Address,
                Age = s.Age,
                Description = s.Description,
                ImageURL = s.ImageURL,
                Specialisations = s.Specialisations.Select(s=>s.Specialisation.Name).ToList(),
                ApplicationUser = s.ApplicationUser
            }).ToListAsync();
        }
    }
}