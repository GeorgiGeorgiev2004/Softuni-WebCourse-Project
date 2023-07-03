namespace MentalDepths.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static MentalDepths.Common.ModelRegulations;
    public class JobApplicationForm
    {
        public JobApplicationForm()
        {
            Specialisations = new HashSet<Specialisation>();
            Admins = new HashSet<AdminJobApplicationMT>();
        }
        public Guid Id { get; set; }

        public ICollection<AdminJobApplicationMT> Admins { get; set; }

        public Guid SpecialistId { get; set; }

        [ForeignKey(nameof(SpecialistId))]
        public Specialist Specialist { get; set; } = null!;

        public ICollection<Specialisation> Specialisations { get; set; }

        [Required]
        public byte[] CV { get; set; } = null!;
        [Required]
        public byte[] ScannedDiploma{ get; set; } = null!;
        [Required]
        public byte[] Certification { get; set; } = null!;
    }
}
