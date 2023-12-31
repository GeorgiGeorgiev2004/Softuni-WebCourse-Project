﻿using MentalDepths.Common.Enums;
using MentalDepths.Data;
using MentalDepths.Data.Models;
using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace MentalDepths.Services.Web
{
    public class ConversationService : IConversationService
    {
        private MentalDepthsDbContext context;
        private INoteService noteService;
        public ConversationService(MentalDepthsDbContext dbctx, INoteService noteService)
        {
            this.context = dbctx;
            this.noteService = noteService;
        }
        public async Task<ICollection<ConversationVM>> GetAllConversationsForUser(Guid userId)
        {
            var user = await context.ApplicationUsers.FirstAsync(s => s.Id == userId);
            Specialist? sp = context.Specialists.FirstOrDefaultAsync(s => s.UserId == userId).Result;
            if (sp != null)
            {
                sp.ApplicationUser = await context.ApplicationUsers.FirstOrDefaultAsync(s => s.Id == userId);
                return await context.Conversations.Where(c => c.SpecialistId == sp.Id).Select(c => new ConversationVM()
                {
                    Id = c.Id,
                    UserId = c.UserId,
                    User = c.User,
                    Specialist = c.Specialist,
                    SpecialistId = c.SpecialistId,
                    SpecialistName = c.Specialist.ApplicationUser.UserName,
                    Note = new NoteVm()
                    {
                        Id = context.Notes.FirstOrDefault(n => n.ConversationtId == c.Id).Id,
                        Message = context.Notes.FirstOrDefault(n => n.ConversationtId == c.Id).Message
                    },
                    IsClosed=c.IsClosed
                }).ToListAsync();
            }
            return await context.Conversations.Where(c => c.UserId == user.Id).Select(c => new ConversationVM()
            {
                Id = c.Id,
                UserId = user.Id,
                User = context.ApplicationUsers.FirstOrDefault(s => s.Id == c.UserId),
                Specialist = context.Specialists.FirstOrDefault(s => s.Id == c.SpecialistId),
                SpecialistId = c.SpecialistId,
                SpecialistName = c.Specialist.ApplicationUser.UserName,
                Note = new NoteVm()
                {
                    Id = context.Notes.FirstOrDefault(n => n.ConversationtId == c.Id).Id,
                    Message = context.Notes.FirstOrDefault(n => n.ConversationtId == c.Id).Message
                },
                IsClosed = c.IsClosed
            }).ToListAsync();
        }
        public async Task<ConversationVM> GenerateNewConversation(Guid IdSpecialist, Guid IdUser)
        {
            Conversation? conv = context.Conversations.FirstOrDefaultAsync(c => c.UserId == IdUser && c.SpecialistId == IdSpecialist).Result;
            if (conv != null)
            {
                var n = new ConversationVM()
                {
                    Id = conv.Id,
                    UserId = conv.UserId,
                    SpecialistId = conv.SpecialistId,
                    Specialist = await context.Specialists.FirstAsync(s => s.Id == IdSpecialist),
                    User = await context.ApplicationUsers.FirstAsync(u => u.Id == IdUser),
                    Messages = context.Messages.Where(m => m.ConversationId == conv.Id).ToHashSet(),
                    IsClosed= conv.IsClosed,
                };
                n.Specialist.ApplicationUser = context.ApplicationUsers.FirstOrDefaultAsync(s => s.Id == IdUser).Result;
                n.SpecialistName = n.Specialist.ApplicationUser.UserName;
                return n;
            }
            else return new ConversationVM()
            {
                SpecialistId = IdSpecialist,
                UserId = IdUser,
                Specialist = await context.Specialists.FirstAsync(s => s.Id == IdSpecialist),
                User = await context.ApplicationUsers.FirstAsync(u => u.Id == IdUser),
                Messages = new HashSet<Message>(),
                IsClosed = false
            };
        }

        public async Task SaveConversation(ConversationVM conversation)
        {
            Conversation? conv = context.Conversations
                .FirstOrDefaultAsync(a => a.UserId == conversation.UserId && a.SpecialistId == conversation.SpecialistId).Result;
            if (conv == null)
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
                    Note = note,
                    IsClosed = false,
                    Messages = conversation.Messages,
                };

                await context.Conversations.AddAsync(convo);
                await context.Notes.AddAsync(note);
                await context.SaveChangesAsync();
            }

        }

        public async Task<ConversationVM> GetConversationById(Guid id)
        {
            Conversation? conversation = context.Conversations.FirstOrDefaultAsync(s => s.Id == id).Result;
            conversation.Specialist = context.Specialists.FirstOrDefaultAsync(s => s.Id == conversation.SpecialistId).Result;
            conversation.User = context.ApplicationUsers.FirstOrDefaultAsync(a => a.Id == conversation.UserId).Result;
            conversation.Note = context.Notes.FirstOrDefaultAsync(n => n.ConversationtId == id).Result;
            conversation.Messages = context.Messages.Where(m => m.ConversationId == id).ToHashSet();
            ConversationVM conv = new ConversationVM()
            {
                Id = conversation.Id,
                User = conversation.User,
                UserId = conversation.UserId,
                Specialist = conversation.Specialist,
                SpecialistId = conversation.SpecialistId,
                Note = noteService.GetNoteById(conversation.Note.Id).Result,
                Messages = conversation.Messages,
                IsClosed=conversation.IsClosed
            };
            return conv;
        }

        public async Task MarkChatAsDeleted(Guid id)
        {
            var conversation = context.Conversations.FirstOrDefaultAsync(c => c.Id == id).Result;
            conversation.IsClosed = true;
            await context.SaveChangesAsync();
        }

        public async Task MarkChatAsReturned(Guid Id)
        {
            var conversation = context.Conversations.FirstOrDefaultAsync(c => c.Id == Id).Result;
            conversation.IsClosed = false;
            await context.SaveChangesAsync();
        }

        public async Task<bool> IsThereAConversationBetween(Guid SpecialistId, Guid userId)
        {
            var c = context.Conversations.FirstOrDefaultAsync(c => c.UserId == userId && c.SpecialistId == SpecialistId).Result;
            if (c == null) return false;
            else return true;
        }

        public async Task<ConversationVM> GetConversationByParticipants(Guid SpecialistId, Guid userId)
        {
            var c = context.Conversations.FirstOrDefaultAsync(c => c.UserId == userId && c.SpecialistId == SpecialistId).Result;
            return new ConversationVM()
            {
                Id = c.Id,
                SpecialistId = SpecialistId,
                UserId = userId,
                IsClosed=c.IsClosed,
                Specialist= await context.Specialists.FirstAsync(s=>s.Id==c.SpecialistId),
                User = await context.ApplicationUsers.FirstAsync(s => s.Id == c.UserId),
            };
        }
    }
}
