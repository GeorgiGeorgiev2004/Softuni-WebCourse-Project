using MentalDepths.Common.Enums;
using MentalDepths.Data;
using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.EntityFrameworkCore;
using Apointment = MentalDepths.Data.Models.Apointment;
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
            var bavm= new BookApointementVM()
            {
                SpecialistId = IdSpecialist,
                UserId = IdUser,
                Specialist = await context.Specialists.FirstAsync(s => s.Id == IdSpecialist),
                User = await context.ApplicationUsers.FirstAsync(u => u.Id == IdUser),
                Date = DateTime.Now,
                //default office location
                Address="ul. Boqna 6 vh.6"
            };
            bavm.Specialist.ApplicationUser = await context.ApplicationUsers.FirstAsync(a => a.Id == bavm.Specialist.UserId);
            return bavm;
        }

        public async Task<ICollection<BookApointementVM>> GetAllApointementsForSpecialist(Guid userId)
        {
            var specialist = await context.Specialists.FirstAsync(s => s.UserId == userId);
            return await context.Apointments.Where(s => s.SpecialistId == specialist.Id).Select(s => new BookApointementVM()
            {
                Id=s.Id,
                SpecialistId = s.SpecialistId,
                Specialist= specialist,
                UserId = s.ApplicationUserId,
                User = context.ApplicationUsers.FirstOrDefault(u=>u.Id==s.ApplicationUserId),
                Date=s.DateAndTime
            }).ToListAsync();
        }
        public async Task SaveApointment(BookApointementVM bavm)
        {
            Apointment? ap = context.Apointments
                .FirstOrDefaultAsync(a => a.ApplicationUserId == bavm.UserId && a.SpecialistId == bavm.SpecialistId).Result;
            if (ap == null)
            {
                var apointement = new Apointment()
                {
                    ApplicationUserId = bavm.UserId,
                    ApplicationUser = bavm.User,
                    SpecialistId = bavm.SpecialistId,
                    Specialist = bavm.Specialist,
                    DateAndTime = bavm.Date,
                    Address = bavm.Address,
                };

                context.Apointments.Add(apointement);
                context.SaveChanges();
            }
        }
    }
}
