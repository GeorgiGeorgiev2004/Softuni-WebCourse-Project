using MentalDepths.Services.Web;
using MentalDepths.Web.ViewModels.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Test.UnitTests
{
    [TestFixture]
    public class NoteTests:UnitTestBase
    {
        private NoteService noteService;

        [SetUp]
        public void SetUp() 
        {
            noteService = new NoteService(context);
        }
        [Test]
        public void GenerateNewNote_Works() 
        {
            var note = noteService.GenerateNewNote();

            Assert.IsNotNull(note);
        }
        [Test]
        public void GetNoteBtId_Works()
        {
            var id = Guid.Parse("95eb50b8-a714-4fbb-b19a-edcd6469aacb");
            var note = noteService.GetNoteById(id);
            Assert.IsNotNull(note);
        }
        [Test]
        public void GetNoteBtId_Breaks()
        {
            var id = Guid.Parse("9664aafc-5f84-48fb-89fe-c8c20d802c45");
            Assert.ThrowsAsync<InvalidOperationException>(async () => await noteService.GetNoteById(id));
        }
        [Test]
        public void SaveChangesToNote_Works()
        {
            NoteVm model = new NoteVm()
            {
                Id = Guid.Parse("53daf8af-665b-46ac-965f-9d1641b984c8"),
                Message = "Eddited Note"
            };
            var id = Guid.Parse("95eb50b8-a714-4fbb-b19a-edcd6469aacb");
            noteService.SaveChangesToNote(id,model);
            var EditedNote=noteService.GetNoteById(id).Result;

            Assert.That(EditedNote.Message, Is.EqualTo(model.Message));
            Assert.That(EditedNote.Id, Is.Not.EqualTo(model.Id));
        }
    }
}
