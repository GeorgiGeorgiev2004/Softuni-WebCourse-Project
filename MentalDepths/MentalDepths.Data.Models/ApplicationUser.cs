namespace MentalDepths.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Microsoft.AspNetCore.Identity;

    using static Common.ModelRegulations.ApplicationUser;
    using static MentalDepths.Common.ModelRegulations;

    public class ApplicationUser:IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            CreatedOn = DateTime.UtcNow;
            IsDeleted = false;
            Apointments = new HashSet<Apointment>();
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

        public ICollection<Apointment> Apointments { get; set; }
    }
}
