namespace MentalDepths.Web.ViewModels.Web
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using static MentalDepths.Common.ModelRegulations.Specialist;
    using MentalDepths.Data.Models;

    public class SpecialistVM
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(URLMaxLenght, MinimumLength = URLMaxLenght)]
        public string ImageURL { get; set; } = null!;

        [Required]
        [Range(MinAge, MaxAge)]
        public int Age { get; set; }

        [Required]
        [StringLength(AddressMaxLenght, MinimumLength = AddressMinLenght)]
        [ProtectedPersonalData]
        public string Address { get; set; } = null!;

        [StringLength(DescriptionMaxLenght, MinimumLength = DescriptionMinLenght)]
        public string Description { get; set; } = null!;

        public ICollection<string> Specialisations { get; set; }=new HashSet<string>();


        public ApplicationUser ApplicationUser { get; set; } = null!;
    }
}
