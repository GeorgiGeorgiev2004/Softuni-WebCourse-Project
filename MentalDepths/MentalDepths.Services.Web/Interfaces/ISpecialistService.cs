using MentalDepths.Data.Models;
using MentalDepths.Web.ViewModels.Web;

namespace MentalDepths.Services.Web.Interfaces
{
    public interface ISpecialistService
    {
        public Task<ICollection<SpecialistVM>> GetAllSpecialist();

        public Task<SpecialistVM> FindSpecialistById(Guid id);

        public Task AsignApplicationUserToSpecialistOnLogIn(Guid userId);

        public Task<bool> IsThereASpecialistWithThisUserId(Guid userId);

        public Task<string> GetUsernameForspecialist(Guid userId);
    }
}