using MentalDepths.Data;
using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.EntityFrameworkCore;

namespace MentalDepths.Services.Web
{
    public class NoteService : INoteService
    {
        private MentalDepthsDbContext dbContext;
        public NoteService(MentalDepthsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<NoteVm> GenerateNewNote()
        {
            return new NoteVm()
            {
                Id = Guid.NewGuid(),
                Note = "This patient has no note yet!",
            };
        }

        public async Task<NoteVm> GetNoteFromApointment(Guid id)
        {
            var note = await dbContext.Notes.FirstAsync(a => a.ApointmentId == id);
            return new NoteVm()
            {
                Id = note.Id,
                Note = note.Message
            };
        }

        public async Task SaveChangesToNote(Guid id, NoteVm model)
        {
            var notePlaceholder = this.GetNoteFromApointment(id).Result;
            var note = dbContext.Notes.FirstOrDefault(o => o.Id == notePlaceholder.Id);
            note.Message = model.Note;

            await dbContext.SaveChangesAsync();
        }
    }
}
