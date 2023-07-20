using MentalDepths.Common.Enums;
using MentalDepths.Data;
using MentalDepths.Data.Models;
using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalDepths.Services.Web
{
    public class ConversationService : IConversationService
    {
        private MentalDepthsDbContext context;
        public ConversationService(MentalDepthsDbContext dbctx)
        {
            this.context = dbctx;
        }
        public async Task<ICollection<ConversationVM>> GetAllConversationsForUser(Guid userId)
        {
            var user = await context.ApplicationUsers.FirstAsync(s => s.Id == userId);
            Guid id = user.Id;
            Specialist? sp = context.Specialists.FirstOrDefaultAsync(s => s.UserId == userId).Result;
            if (sp!=null)
            {
                return await context.Conversations.Where(c => c.SpecialistId == sp.Id).Select(c => new ConversationVM()
                {
                    Id = c.Id,
                    UserId = user.Id,
                    User = c.User,
                    Specialist = c.Specialist,
                    SpecialistId = c.SpecialistId,
                    Note = new NoteVm()
                    {
                        Id = context.Notes.FirstOrDefault(n => n.ConversationtId == c.Id).Id,
                        Note = context.Notes.FirstOrDefault(n => n.ConversationtId == c.Id).Message,
                    }
                }).ToListAsync();
            }
            return await context.Conversations.Where(c => c.UserId == user.Id).Select(c=>new ConversationVM() 
            {
                Id = c.Id,
                UserId = user.Id,
                User=c.User,
                Specialist = c.Specialist,
                SpecialistId = c.SpecialistId,
                Note = new NoteVm()
                {
                    Id = context.Notes.FirstOrDefault(n => n.ConversationtId == c.Id).Id,
                    Note = context.Notes.FirstOrDefault(n => n.ConversationtId == c.Id).Message,
                }
            }).ToListAsync();
        }
        public async Task<ConversationVM> GenerateNewConversation(Guid IdSpecialist, Guid IdUser)
        {
            return new ConversationVM()
            {
                SpecialistId = IdSpecialist,
                UserId = IdUser,
                Specialist = await context.Specialists.FirstAsync(s => s.Id == IdSpecialist),
                User = await context.ApplicationUsers.FirstAsync(u => u.Id == IdUser)
            };
        }

        public async Task SaveConversation(ConversationVM conversation)
        {
            var note = new Note()
            {
                Id = Guid.NewGuid(),
                Message = "This patient has no note yet!"
            };
            var convo = new Conversation()
            {
                UserId = conversation.UserId,
                User = conversation.User,
                SpecialistId = conversation.SpecialistId,
                Specialist = conversation.Specialist,
                Note = note
            };

            context.Conversations.Add(convo);
            context.Notes.Add(note);
            context.SaveChanges();
        }
    }
}
