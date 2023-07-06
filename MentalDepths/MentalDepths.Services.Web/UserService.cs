namespace MentalDepths.Services.Web
{
    using System.Threading.Tasks;
    using System.Linq;

    using MentalDepths.Data;
    using MentalDepths.Data.Models;
    using MentalDepths.Services.Web.Interfaces;
    using MentalDepths.Web.ViewModels.Web;
    using Microsoft.EntityFrameworkCore;

    public class UserService : IUserService
    {
        private readonly MentalDepthsDbContext context;
        public UserService(MentalDepthsDbContext context)
        {
            this.context = context;
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

        public ApplicationUser CreateUser(ApplicationUserVMAccountManagement auam)
        {
            return new ApplicationUser();
        }
    }
}
