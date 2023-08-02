namespace MentalDepths.Web.ViewModels.Web
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using static MentalDepths.Common.ModelRegulations.Specialist;
    using MentalDepths.Data.Models;
    public class CreateASpecialistVM
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(URLMaxLenght, MinimumLength = URLMinLenght)]
        public string ImageURL { get; set; } = null!;

        [Required]
        [Range(MinAge, MaxAge)]
        public int Age { get; set; }
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Cellphone numbers need to have 10 digits")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [StringLength(AddressMaxLenght, MinimumLength = AddressMinLenght)]
        [ProtectedPersonalData]
        public string Address { get; set; } = null!;

        [StringLength(DescriptionMaxLenght, MinimumLength = DescriptionMinLenght)]
        public string Description { get; set; } = null!;
        [Required]
        public string Specialisations { get; set; } = null!;

        public Guid UserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; } = null!;
    }
}
