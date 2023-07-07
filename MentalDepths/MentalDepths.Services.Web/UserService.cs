namespace MentalDepths.Services.Web
{
    using System.Threading.Tasks;
    using System.Linq;
    using System;

    using MentalDepths.Data;
    using MentalDepths.Data.Models;
    using MentalDepths.Services.Web.Interfaces;
    using MentalDepths.Web.ViewModels.Web;
    using Microsoft.EntityFrameworkCore;

    using Repositories;
    using MentalDepths.Services.Web.Repositories.Interfaces;

    public class UserService : IUserService
    {
        private readonly MentalDepthsDbContext context;
        private readonly IUserManagerRepository repo;
        public UserService(MentalDepthsDbContext context, IUserManagerRepository repo)
        {
            this.context = context;
            this.repo = repo;
        }

        public string GenerateConfiramtionCode()
        {
            return new string(Enumerable.Repeat(Common.ModelRegulations.CodeSender.chars, Common.ModelRegulations.CodeSender.Lenght)
                .Select(s => s[Common.ModelRegulations.CodeSender.Random.Next(s.Length)]).ToArray());
        }

        public async Task<ICollection<CitiesVM>> GetAllCities()
        {
            List<CitiesVM> list = await context.Cities.Select(c => new CitiesVM
            {
                Id = c.Id,
                Name = c.Name
            }).ToListAsync();
            return list;
        }

        public void AddConfiramtionCodeToDic(string id, string code)
        {
            ApplicationUser? au = context.ApplicationUsers.FirstOrDefaultAsync(a => a.Id == Guid.Parse(id)).Result;
            if (au != null)
            {
                repo.AddToDictionary(id, code);
            }
        }

        public string GetConfiramtionCodeFromId(string id)
        {
            ApplicationUser? au = context.ApplicationUsers.FirstOrDefaultAsync(a => a.Id == Guid.Parse(id)).Result;
            return repo.Dictionary[au.Id.ToString()];

        }

        public void SetEmailConfirmationToTrue(string id)
        {
            ApplicationUser? au = context.ApplicationUsers.FirstOrDefaultAsync(a => a.Id == Guid.Parse(id)).Result;
            au.EmailConfirmed=true;
            context.SaveChanges();
        }

        public void DisposeOfConfirmedCodes(string id)
        {
            repo.RemoveFromDictionary(id);
        }

        public bool EmailIsConfirmed(string id)
        {
            ApplicationUser? au = context.ApplicationUsers.FirstOrDefaultAsync(a => a.Id == Guid.Parse(id)).Result;
            return au.EmailConfirmed;
        }
    }
}
