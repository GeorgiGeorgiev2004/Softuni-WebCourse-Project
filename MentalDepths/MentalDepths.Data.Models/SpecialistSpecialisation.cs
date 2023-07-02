using System.ComponentModel.DataAnnotations.Schema;

namespace MentalDepths.Data.Models
{
    public class SpecialistSpecialisation
    {
        public Guid SpecialistId { get; set; }
        [ForeignKey(nameof(SpecialistId))]
        public Specialist Specialist { get; set; }

        public int SpecialisationId { get; set; }
        [ForeignKey(nameof(SpecialisationId))]
        public Specialisations Specialisation { get; set; }
    }
}
