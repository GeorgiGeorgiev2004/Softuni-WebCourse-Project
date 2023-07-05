namespace MentalDepths.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    using static Common.ModelRegulations.Prescription;
    public class Prescription
    {
        public Prescription()
        {
             IsAOneTimePrescription = false;
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ApplicationUserId { get; set; }
        [ForeignKey(nameof(ApplicationUserId))]
        public ApplicationUser ApplicationUser { get; set; } = null!;

        [Required]
        public Guid SpecialistId { get; set; }
        [ForeignKey(nameof(SpecialistId))]
        public Specialist Specialist { get; set; } = null!;

        [StringLength(MedicationMaxName, MinimumLength = MedicationMinName)]
        [Required]
        public string MedicationName { get; set; } = null!;

        [Required]
        [StringLength(MedicationMaxDescription, MinimumLength = MedicationMinDescription)]
        public string MedicationDescription { get; set;} = null!;

        [Required]
        public DateTime IssueDate { get; set; } 

        [Required]
        public bool IsAOneTimePrescription { get; set; }
    }
}
