using MentalDepths.Services.Web;
using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace MentalDepths.Controllers
{
    public class ConversationController : Controller
    {
        private IConversationService conversationService;
        private INoteService noteService;
        public ConversationController(IConversationService cvs, INoteService noteService)
        {
            conversationService = cvs;
            this.noteService = noteService;

        }
        public IActionResult MyConversations(Guid id)
        {
            var convos = conversationService.GetAllConversationsForUser(id).Result;
            return View(convos);
        }
        public IActionResult Chat(Guid SpecialistId, Guid UserId)
        {
            var conversation = conversationService.GenerateNewConversation(SpecialistId, UserId).Result;
            conversationService.SaveConversation(conversation);
            return View(conversation);
        }
        [HttpGet]
        public async Task<IActionResult> Note(Guid NoteId)
        {
            var note = noteService.GetNoteFromApointment(NoteId).Result;
            return View(note);
        }
        [HttpPost]
        public async Task<IActionResult> Note(Guid NoteId, NoteVm model)
        {
            await noteService.SaveChangesToNote(NoteId, model);
            return RedirectToAction("Index", "Home");
        }

    }
}
