namespace MentalDepths.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.AspNetCore.Identity;

    using static Common.ModelRegulations.ApplicationUser;

    public class ApplicationUser:IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            CreatedOn = DateTime.UtcNow;
            IsDeleted = false;
        }
        [Required]
        [StringLength(NamesMaxLenght,MinimumLength =NamesMinLenght)]
        public string FirstName { get; set; } = null!;

        public string? SecondName { get; set; }

        [Required]
        [StringLength(NamesMaxLenght, MinimumLength = NamesMinLenght)]
        public string LastName { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime DeletedOn { get; set; }

        [ProtectedPersonalData]
        [Range (minvalue,maxvalue)]
        public int CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public City City { get; set; } = null!;
    }
}
