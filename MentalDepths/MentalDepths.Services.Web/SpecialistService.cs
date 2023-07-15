﻿using MentalDepths.Data;

namespace MentalDepths.Services.Web
{
    using Microsoft.EntityFrameworkCore;

    using MentalDepths.Services.Web.Interfaces;
    using MentalDepths.Web.ViewModels.Web;
    public class SpecialistService : ISpecialistService
    {
        public readonly MentalDepthsDbContext context;
        public SpecialistService(MentalDepthsDbContext Context)
        {
            context = Context;
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