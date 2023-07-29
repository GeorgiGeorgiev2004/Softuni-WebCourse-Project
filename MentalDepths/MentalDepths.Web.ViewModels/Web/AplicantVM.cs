using MentalDepths.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using static MentalDepths.Common.ModelRegulations.Specialist;

namespace MentalDepths.Web.ViewModels.Web
{
    public class AplicantVM
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

        public string Specialisations { get; set; }


        [ForeignKey(nameof(JobApplication))]
        public Guid JobApplicationId { get; set; }

        public JobApplicationForm JobApplication { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser ApplicationUser { get; set; } = null!;
    }
}
