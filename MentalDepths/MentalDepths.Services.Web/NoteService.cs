using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;

namespace MentalDepths.Services.Web
{
    public class NoteService : INoteService
    {
        public async Task<NoteVm> GenerateNewNote()
        {
            return new NoteVm()
            {
                Id = string.Empty,
                Note = string.Empty,
            };
        }
    }
}
