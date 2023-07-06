namespace MentalDepths.Services.Web.Interfaces
{
    using MentalDepths.Data.Models;
    using MentalDepths.Web.ViewModels.Web;
    public interface IUserService
    {
        ApplicationUser CreateUser(ApplicationUserVMAccountManagement auam);
        Task<ICollection<CitiesVM>> GetAllCities();
    }
}
