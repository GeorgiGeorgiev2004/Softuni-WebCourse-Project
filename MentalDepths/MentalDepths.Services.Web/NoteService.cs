using MentalDepths.Common.Enums;
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
                Message = "No note for this patient yet!"
            };
        }

        public async Task<NoteVm> GetNoteById(Guid id)
        {
            var note = await dbContext.Notes.FirstAsync(a => a.Id == id);
            return new NoteVm() 
            {
                Id = note.Id,
                Message=note.Message
            };
        }

        public async Task SaveChangesToNote(Guid id, NoteVm model)
        {
            var note = dbContext.Notes.FirstOrDefault(o => o.Id == id);
            note.Message=model.Message;
            await dbContext.SaveChangesAsync();
        }
    }
}
