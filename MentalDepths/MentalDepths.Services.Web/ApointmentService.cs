using MentalDepths.Data;
using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;

namespace MentalDepths.Services.Web
{
    public class ApointmentService : IApointmentService
    {
        private MentalDepthsDbContext context;
        public ApointmentService(MentalDepthsDbContext dbctx)
        {
                this.context = dbctx;
        }
        public async Task<BookApointementVM> GenerateNewApointement(Guid IdSpecialist, Guid IdUser)
        {
            return new BookApointementVM() 
            {
                SpecialistId = IdSpecialist,
                UserId=IdUser,
                Specialist = await context.Specialists.FirstAsync(s => s.Id == IdSpecialist),
                User = await context.ApplicationUsers.FirstAsync(u => u.Id == IdUser)
            };
        }

        public async Task<ICollection<BookApointementVM>> GetAllApointementsForSpecialist(Guid specialistId)
        {
            return await context.Apointments.Where(s=>s.SpecialistId==specialistId).Select(s => new BookApointementVM() 
            {
                SpecialistId = s.SpecialistId,
                UserId = s.ApplicationUserId
            }).ToListAsync();
        }
    }
}
