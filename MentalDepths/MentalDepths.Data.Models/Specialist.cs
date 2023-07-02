namespace MentalDepths.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static MentalDepths.Common.ModelRegulations.Specialist;
    public class Specialist
    {
        public Specialist()
        {
            Id = Guid.NewGuid();
            Specialisations = new HashSet<SpecialistSpecialisation>();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(URLMaxLenght,MinimumLength =URLMaxLenght)]
        public string ImageURL { get; set; }

        [Required]
        [Range(MinAge,MaxAge)]
        public int Age { get; set; }

        [Required]
        [StringLength(AddressMaxLenght, MinimumLength = AddressMinLenght)]
        [ProtectedPersonalData]
        public string Address { get; set; }

        [StringLength(DescriptionMaxLenght, MinimumLength = DescriptionMinLenght)]
        public string Description { get; set; }

        public ICollection<SpecialistSpecialisation> Specialisations { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
