﻿using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MentalDepths.Controllers
{
    public class ConversationController : BaseController
    {
        private IConversationService conversationService;
        private INoteService noteService;
        public ConversationController(IConversationService cvs, INoteService noteService)
        {
            conversationService = cvs;
            this.noteService = noteService;
        }
        public async Task<IActionResult> MyConversations(Guid id)
        {
            var convos = conversationService.GetAllConversationsForUser(id).Result;
            return View(convos);
        }
        public async Task<IActionResult> Chat(Guid SpecialistId, Guid UserId)
        {
            var conversation = conversationService.GenerateNewConversation(SpecialistId, UserId).Result;
            if (conversation.SpecialistName ==null)
            {
                await conversationService.SaveConversation(conversation); 
                var id = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                return RedirectToAction("MyConversations", new { id });
            }
            if (conversation.IsClosed == true)
            {
                await conversationService.MarkChatAsReturned(conversation.Id);
            }
            return View(conversation);
        }
        [HttpGet]
        public async Task<IActionResult> Note(Guid NoteId)
        {
            var note = noteService.GetNoteById(NoteId).Result;
            return View(note);
        }
        [HttpPost]
        public async Task<IActionResult> Note(Guid NoteId, NoteVm model)
        {
            await noteService.SaveChangesToNote(NoteId, model);
            var id = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return RedirectToAction("MyConversations", "Conversation", new { id });
        }
        public IActionResult Delete(Guid Id)
        {
            var conversation = conversationService.GetConversationById(Id).Result;
            return View(conversation);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(ConversationVM cvm)
        {
            await conversationService.MarkChatAsDeleted(cvm.Id);
            var ID = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            return RedirectToAction("MyApointments", "Apointment", new { ID });
        }
    }
}
