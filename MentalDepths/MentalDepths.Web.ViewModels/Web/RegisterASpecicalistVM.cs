using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static MentalDepths.Common.ModelRegulations.Specialist;
using MentalDepths.Data.Models;

namespace MentalDepths.Web.ViewModels.Web
{
    public class RegisterASpecicalistVM
    {
        [Key]
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

        public ICollection<SpecialisationVM> Specialisations { get; set; } = new HashSet<SpecialisationVM>();

        public ICollection<int> SpecialisationIDs { get; set; } = new HashSet<int>();

        public Guid UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } = null!;
    }
}
