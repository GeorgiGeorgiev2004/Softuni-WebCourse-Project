using MentalDepths.Web.ViewModels.Web;

namespace MentalDepths.Services.Web.Interfaces
{
    public interface IApointmentService
    {
        public Task<BookApointementVM> GenerateNewApointement(Guid IdSpecialist, Guid IdUser);
        public Task<ICollection<BookApointementVM>> GetAllApointementsForUser(Guid userId);

        public Task SaveApointment(BookApointementVM model);
    }
}
