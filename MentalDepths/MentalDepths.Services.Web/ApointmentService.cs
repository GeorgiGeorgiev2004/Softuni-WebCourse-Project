using MentalDepths.Common.Enums;
using MentalDepths.Data;
using MentalDepths.Data.Models;
using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using static MentalDepths.Common.ModelRegulations;
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
            return new BookApointementVM()
            {
                SpecialistId = IdSpecialist,
                UserId = IdUser,
                Specialist = await context.Specialists.FirstAsync(s => s.Id == IdSpecialist),
                User = await context.ApplicationUsers.FirstAsync(u => u.Id == IdUser)
            };
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
                Address = s.Address,
                Date=s.DateAndTime,
                ImageURLSpecialist = specialist.ImageURL,
                Note = new NoteVm() 
                {
                    Id= context.Notes.FirstOrDefault(n => n.ApointmentId == s.Id).Id,
                    Note = context.Notes.FirstOrDefault(n => n.ApointmentId == s.Id).Message,
                }
            }).ToListAsync();
        }
        public async Task SaveApointment(BookApointementVM bavm)
        {
            Apointment? ap = context.Apointments
                .FirstOrDefaultAsync(a => a.ApplicationUserId == bavm.UserId && a.SpecialistId == bavm.SpecialistId).Result;
            if (ap == null)
            {
                var note = new Note()
                {
                    Id = Guid.NewGuid(),
                    Message = "This patient has no note yet!"
                };
                var apointement = new Apointment()
                {
                    ApplicationUserId = bavm.UserId,
                    ApplicationUser = bavm.User,
                    SpecialistId = bavm.SpecialistId,
                    Specialist = bavm.Specialist,
                    DateAndTime = bavm.Date,
                    Address = AddressesEnum.Office.ToString(),
                    Note = note
                };

                context.Apointments.Add(apointement);
                context.Notes.Add(note);
                context.SaveChanges();
            }

        }
    }
}
