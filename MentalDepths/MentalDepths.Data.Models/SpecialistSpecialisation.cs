using System.ComponentModel.DataAnnotations.Schema;

namespace MentalDepths.Data.Models
{
    public class SpecialistSpecialisation
    {
        public Guid SpecialistId { get; set; }
        [ForeignKey(nameof(SpecialistId))]
        public Specialist Specialist { get; set; } = null!;

        public int SpecialisationId { get; set; }
        [ForeignKey(nameof(SpecialisationId))]
        public Specialisation Specialisation { get; set; } = null!;
    }
}
