﻿using MentalDepths.Common.Enums;
using MentalDepths.Data;
using MentalDepths.Data.Models;
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
            var bavm = new BookApointementVM()
            {
                SpecialistId = IdSpecialist,
                UserId = IdUser,
                Specialist = await context.Specialists.FirstAsync(s => s.Id == IdSpecialist),
                User = await context.ApplicationUsers.FirstAsync(u => u.Id == IdUser),
                Date = DateTime.Now,
                //default office location
                Address = Common.Constatnts.Office.OfficeAddress
            };
            bavm.Specialist.ApplicationUser = await context.ApplicationUsers.FirstAsync(a => a.Id == bavm.Specialist.UserId);
            return bavm;
        }
        public async Task<ICollection<BookApointementVM>> GetAllApointementsForUser(Guid userId)
        {
            var user = await context.ApplicationUsers.FirstAsync(s => s.Id == userId);
            Specialist? sp = context.Specialists.FirstOrDefaultAsync(s => s.UserId == userId).Result;
            if (sp != null)
            {
                sp.ApplicationUser = await context.ApplicationUsers.FirstOrDefaultAsync(s => s.Id == userId);
                return await context.Apointments.Where(c => c.SpecialistId == sp.Id&&c.HasPassed==false).Select(c => new BookApointementVM()
                {
                    Id = c.Id,
                    UserId = c.ApplicationUserId,
                    User = c.ApplicationUser,
                    Specialist = c.Specialist,
                    SpecialistId = c.SpecialistId,
                    Address= c.Address,
                    Date = c.DateAndTime,
                    
                }).ToListAsync();
            }
            return await context.Apointments.Where(c => c.ApplicationUserId == user.Id && c.HasPassed == false).Select(c => new BookApointementVM()
            {
                Id = c.Id,
                UserId = user.Id,
                User = context.ApplicationUsers.FirstOrDefault(s => s.Id == c.ApplicationUserId),
                Specialist= context.Specialists.FirstOrDefault(s => s.Id == c.SpecialistId),
                SpecialistId = c.SpecialistId,
                Address = c.Address,
                Date= c.DateAndTime,
            }).ToListAsync();
        }
        public async Task SaveApointment(BookApointementVM bavm)
        {
            Apointment? ap = context.Apointments
                .FirstOrDefaultAsync(a => a.ApplicationUserId == bavm.UserId && a.SpecialistId == bavm.SpecialistId &&a.DateAndTime==bavm.Date).Result;
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
