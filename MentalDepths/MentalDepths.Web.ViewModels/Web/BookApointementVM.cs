using MentalDepths.Data.Models;

namespace MentalDepths.Web.ViewModels.Web
{
    public class BookApointementVM
    {
        public Guid SpecialistId { get; set; }
        public Specialist Specialist{ get; set; }
        public string ImageURLSpecialist { get; set; }

        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string ImageURLUser { get; set; }

        public string Address { get; set; }

        public DateTime Date { get; set; }
    }
}
