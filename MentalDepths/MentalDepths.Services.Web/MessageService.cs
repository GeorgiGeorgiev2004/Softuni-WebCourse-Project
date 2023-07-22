using MentalDepths.Common.Enums;
using MentalDepths.Data;
using MentalDepths.Data.Models;
using MentalDepths.Services.Web.Interfaces;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace MentalDepths.Services.Web
{
    public class MessageService : IMessageService
    {
        private readonly ISpecialistService specialistService;
        private readonly IConversationService conversationService;
        private MentalDepthsDbContext context;
        public MessageService(ISpecialistService specialistService,MentalDepthsDbContext dbcontext, IConversationService cvs)
        {

            this.specialistService = specialistService;
            this.context = dbcontext;
            this.conversationService = cvs;
        }

        public async Task<Message> CreateMessage(string message, PatientOrSpecialist typeOfUser,Guid conversationId)
        {
            return new Message()
            {
                Text = message,
                TimeOfSend= DateTime.UtcNow,
                TypeOfUser = typeOfUser,
                ConversationId=conversationId
            };
        }

        public async Task SaveMessage(Guid userId, string message,Guid conversationId)
        {
            var applicationUser = context.ApplicationUsers.FirstOrDefaultAsync(s => s.Id == userId).Result;
            var conversation = conversationService.GetConversationById(conversationId).Result;
            PatientOrSpecialist pos = PatientOrSpecialist.Patient;
            if (specialistService.IsThereASpecialistWithThisUserId(userId).Result) 
            {
                pos = PatientOrSpecialist.Specialist;
            }
            var mess = this.CreateMessage(message, pos,conversationId).Result;
            var convo = context.Conversations.FirstAsync(c => c.Id == conversationId).Result;
            convo.Messages.Add(mess);

            context.Messages.Add(mess);
            context.SaveChanges();
        }
    }
}