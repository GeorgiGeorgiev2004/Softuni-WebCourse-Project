using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MentalDepths.Web.ViewModels.Web
{
    public class JobApplicationVM
    {
        public Guid Id { get; set; }

        [ForeignKey(nameof(Specialist))]
        public Guid SpecialistId { get; set; }

        public SpecialistVM Specialist { get; set; } = null!;

        [Required]
        public byte[]? CV { get; set; } = null!;
        [Required]
        public byte[]? ScannedDiploma { get; set; } = null!;
        [Required]
        public byte[] ?Certification { get; set; } = null!;
    }
}
