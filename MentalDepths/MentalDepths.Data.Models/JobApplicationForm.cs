namespace MentalDepths.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static MentalDepths.Common.ModelRegulations;
    public class JobApplicationForm
    {
        public JobApplicationForm()
        {
            Id= Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Specialist))]
        public Guid AplicantId { get; set; }
        
        public Aplicant Aplicant { get; set; } = null!;

        [Required]
        public byte[]? CV { get; set; } = null!;
        [Required]
        public byte[]? ScannedDiploma{ get; set; } = null!;
        [Required]
        public byte[]? Certification { get; set; } = null!;
    }
}
