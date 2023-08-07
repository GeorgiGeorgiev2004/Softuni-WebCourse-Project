using MentalDepths.Data;

namespace MentalDepths.Services.Web
{
    using Microsoft.EntityFrameworkCore;

    using MentalDepths.Services.Web.Interfaces;
    using MentalDepths.Web.ViewModels.Web;
    using System;
    using MentalDepths.Data.Models;
    using System.Runtime.CompilerServices;
    using Microsoft.AspNetCore.Identity;

    public class SpecialistService : ISpecialistService
    {
        private MentalDepthsDbContext context;
        private UserManager<ApplicationUser> um;
        public SpecialistService(MentalDepthsDbContext Context, UserManager<ApplicationUser> um)
        {
            context = Context;
            this.um = um;
        }

        public async Task AsignApplicationUserToSpecialistOnLogIn(Guid userId)
        {
            Specialist? specialistWithUserId = context.Specialists.FirstOrDefaultAsync(x => x.UserId == userId).Result;
            if (specialistWithUserId != null && specialistWithUserId.ApplicationUser == null)
            {
                var UserWithId = context.ApplicationUsers.FirstOrDefaultAsync(u => u.Id == userId).Result;
                specialistWithUserId.ApplicationUser = UserWithId;

                context.SaveChanges();
            }
        }

        public async Task<SpecialistVM> FindSpecialistById(Guid id)
        {
            Specialist? specialist = context.Specialists.FirstOrDefaultAsync(s => s.Id == id).Result;
            SpecialistVM spec = new SpecialistVM
            {
                Id = specialist.Id,
                Address = specialist.Address,
                Description = specialist.Description,
                Specialisations = await context.SpecialistsSpecialisations.Where(ss=>ss.SpecialistId==specialist.Id).Select(s=>s.Specialisation.Name).ToListAsync(),
                ApplicationUser = await context.Users.FirstAsync(s => s.Id == specialist.UserId),
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
                Specialisations = s.Specialisations.Select(s => s.Specialisation.Name).ToList(),
                ApplicationUser = s.ApplicationUser
            }).ToListAsync();
        }

        public async Task<string> GetUsernameForspecialist(Guid userId)
        {
            return context.ApplicationUsers.FirstAsync(a => a.Id == userId).Result.UserName;
        }

        public async Task<bool> IsThereASpecialistWithThisUserId(Guid userId)
        {
            Specialist? spec = context.Specialists.FirstOrDefaultAsync(s => s.UserId == userId).Result;
            return spec != null;
        }

        public async Task SaveASpecialistToTheDb(RegisterASpecicalistVM specialistVM)
        {
            Specialist spc = new Specialist()
            {
                Id = specialistVM.Id,
                Address = specialistVM.Address,
                Age = specialistVM.Age,
                Description = specialistVM.Description,
                ImageURL = specialistVM.ImageURL,
                UserId = specialistVM.UserId
            };
            foreach (var specialty in specialistVM.SpecialisationIDs)
            {
                Specialisation s = await context.Specialisations.FirstAsync(s => s.Id == specialty);
                SpecialistSpecialisation ss = new SpecialistSpecialisation()
                {
                    SpecialisationId = s.Id,
                    SpecialistId = spc.Id
                };
                spc.Specialisations.Add(ss);
            };
            await um.AddToRoleAsync(context.ApplicationUsers.FirstAsync(a => a.Id == spc.UserId).Result, "Specialist");
            await context.Specialists.AddAsync(spc);
            await context.SaveChangesAsync();
        }
    }
}