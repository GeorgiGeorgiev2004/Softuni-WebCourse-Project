using MentalDepths.Web.ViewModels.Web;

namespace MentalDepths.Services.Web.Interfaces
{
    public interface ISpecialistService
    {
        public Task<ICollection<SpecialistVM>> GetAllSpecialist();
    }
}