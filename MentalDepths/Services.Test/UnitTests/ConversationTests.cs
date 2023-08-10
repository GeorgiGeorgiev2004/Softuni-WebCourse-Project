using MentalDepths.Services.Web;
using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Test.UnitTests
{
    [TestFixture]
    public class ConversationTests:UnitTestBase
    {
        private ConversationService conversationService;
        private NoteService noteService;

        [SetUp]
        public void SetUp()
        {
            noteService = new NoteService(context);
            conversationService = new ConversationService(context,noteService);
        }

        [Test]
        public void GetApointmentById_Works()
        {
            var conversationId = Guid.Parse("e746577e-37fa-45f6-b723-776d7f858673");

            var conversation = context.Conversations.FirstOrDefault(a => a.Id == conversationId);

            var ServiceConversation = conversationService.GetConversationById(conversationId).Result;

            Assert.That(conversation.UserId, Is.EqualTo(ServiceConversation.UserId));
            Assert.That(conversation.SpecialistId, Is.EqualTo(ServiceConversation.SpecialistId));
        }

        [Test]
        public void GenerateNewConversation_Works()
        {
            var specialistId = Guid.Parse("812a4249-cf21-494e-9b6f-76fe5ab3aba3");
            var patientId = Guid.Parse("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f");

            var ConversationVM = conversationService.GenerateNewConversation(specialistId, patientId).Result;

            Assert.That(ConversationVM.SpecialistId, Is.EqualTo(specialistId));
            Assert.That(ConversationVM.UserId, Is.EqualTo(patientId));
            Assert.That(ConversationVM.Id, Is.Not.EqualTo(null));
            Assert.That(ConversationVM.IsClosed, Is.EqualTo(false));
        }

        [Test]
        public void GetAllConversationsForUser_Works()
        {
            var userId = Guid.Parse("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f");
            var conversationId = Guid.Parse("e746577e-37fa-45f6-b723-776d7f858673");

            var apointment = context.Conversations.FirstOrDefault(a => a.Id == conversationId);

            var ConversationVMList = conversationService.GetAllConversationsForUser(userId).Result.ToList();

            Assert.That(ConversationVMList[0].Id, Is.EqualTo(apointment.Id));
        }
        [Test]
        public void SaveConversationDoesNotSaveExistingConversations_Works()
        {
            var specialistId = Guid.Parse("812a4249-cf21-494e-9b6f-76fe5ab3aba3");
            var patientId = Guid.Parse("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f");
            ConversationVM cvm = new ConversationVM()
            {
                Id = Guid.Parse("b0a1c8ad-c84a-4c43-b358-c77a6de5743a"),
                SpecialistId = specialistId,
                UserId = patientId,
                IsClosed = false,
            };

            conversationService.SaveConversation(cvm);
            Assert.That(context.Conversations.Count(), Is.EqualTo(1));
        }
        [Test]
        public void SaveConversationSavesNonExistentConversations_Works()
        {
            var specialistId = Guid.Parse("812a4249-cf21-494e-9b6f-76fe5ab3aba3");
            var adminId = Guid.Parse("3df16939-8fe8-4012-8ce7-1a69f3f654ec");
            ConversationVM cvm = new ConversationVM()
            {
                Id = Guid.Parse("b0a1c8ad-c84a-4c43-b358-c77a6de5743a"),
                SpecialistId = specialistId,
                UserId = adminId,
                IsClosed = false,
            };

            conversationService.SaveConversation(cvm);
            Assert.That(context.Conversations.Count(), Is.EqualTo(2));
        }
        [Test]
        public void MarkChatAsDeleted_Works()
        {
            var conversationId = Guid.Parse("e746577e-37fa-45f6-b723-776d7f858673");

            conversationService.MarkChatAsDeleted(conversationId);
            var conversation = conversationService.GetConversationById(conversationId).Result;
            Assert.That(conversation.IsClosed, Is.EqualTo(true));
        }
        [Test]
        public void MarkChatAsReturned_Works()
        {
            var conversationId = Guid.Parse("e746577e-37fa-45f6-b723-776d7f858673");

            conversationService.MarkChatAsDeleted(conversationId);
            
            conversationService.MarkChatAsReturned(conversationId);
            var conversation = conversationService.GetConversationById(conversationId).Result;
            Assert.That(conversation.IsClosed, Is.EqualTo(false));
        }

        [Test]
        public void IsThereAConversationBetween_Works()
        {
            var user1 = Guid.Parse("812a4249-cf21-494e-9b6f-76fe5ab3aba3");
            var user2 = Guid.Parse("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f");

            bool result = conversationService.IsThereAConversationBetween(user1, user2).Result;
            Assert.That(result, Is.EqualTo(true));
        }
        [Test]
        public void IsThereAConversationBetween_Breaks()
        {
            var user1 = Guid.Parse("812a4249-cf21-494e-9b6f-76fe5ab3aba3");
            var user2 = Guid.Parse("3df16939-8fe8-4012-8ce7-1a69f3f654ec");

            bool result = conversationService.IsThereAConversationBetween(user1, user2).Result;
            Assert.That(result, Is.EqualTo(false));
        }
        [Test]
        public void GetConversationByParticipants_Works()
        {
            var user1 = Guid.Parse("812a4249-cf21-494e-9b6f-76fe5ab3aba3");
            var user2 = Guid.Parse("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f");

            var convo = conversationService.GetConversationByParticipants(user1, user2).Result;
            Assert.That(convo, Is.Not.EqualTo(null));
        }
        [Test]
        public void GetConversationByParticipants_Breaks()
        {
            var user1 = Guid.Parse("812a4249-cf21-494e-9b6f-76fe5ab3aba3");
            var user2 = Guid.Parse("3df16939-8fe8-4012-8ce7-1a69f3f654ec");

            Assert.ThrowsAsync<NullReferenceException>(async ()=> await conversationService.GetConversationByParticipants(user1, user2));
        }
    }
}
