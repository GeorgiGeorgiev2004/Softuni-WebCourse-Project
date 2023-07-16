using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;

namespace MentalDepths.Services.Web
{
    public class ApointmentService : IApointmentService
    {
        public async Task<BookApointementVM> GenerateNewApointement()
        {
            return new BookApointementVM();
        }
    }
}
