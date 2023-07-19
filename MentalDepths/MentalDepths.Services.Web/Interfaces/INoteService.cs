﻿using MentalDepths.Web.ViewModels.Web;

namespace MentalDepths.Services.Web.Interfaces
{
    public interface INoteService
    {
        public Task<NoteVm> GenerateNewNote();
        public Task<NoteVm> GetNoteFromApointment(Guid id);
        public Task SaveChangesToNote(Guid id, NoteVm model);
    }
}
