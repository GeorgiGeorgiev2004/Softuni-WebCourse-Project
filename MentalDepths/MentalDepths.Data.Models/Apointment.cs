
namespace MentalDepths.Data.Models
{
    using MentalDepths.Common.Enums;
    using Microsoft.Extensions.DependencyInjection;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static MentalDepths.Common.ModelRegulations.Apointment;

    public class Apointment
    {
        public Apointment()
        {
            Id=Guid.NewGuid();
            IsConfirmed = false;
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

        [Required]
        public DateTime DateAndTime { get; set; }
        [Required]
        [StringLength(AddressMaxLenght,MinimumLength =AddressMinLenght)]
        public string Address { get; set; }

        [Required]
        public bool IsConfirmed { get; set; }
    }
}
