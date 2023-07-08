namespace MentalDepths.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static MentalDepths.Common.ModelRegulations;
    public class JobApplicationForm
    {
        public JobApplicationForm()
        {
            Admins = new HashSet<AdminJobApplicationMT>();
            Id= Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        public ICollection<AdminJobApplicationMT> Admins { get; set; }

        [ForeignKey(nameof(Specialist))]
        public Guid SpecialistId { get; set; }
        
        public Specialist Specialist { get; set; } = null!;

        [Required]
        public byte[] CV { get; set; } = null!;
        [Required]
        public byte[] ScannedDiploma{ get; set; } = null!;
        [Required]
        public byte[] Certification { get; set; } = null!;
    }
}
