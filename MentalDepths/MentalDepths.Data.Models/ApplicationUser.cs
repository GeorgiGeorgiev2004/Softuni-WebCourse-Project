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
            Id = Guid.NewGuid();
            CreatedOn = DateTime.Now;
            IsDeleted = false;
            Apointments = new HashSet<Apointment>();
            Prescriptions = new HashSet<Prescription>();
            EmailConfirmed = false;
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

        [RegularExpression(Common.ModelRegulations.Email.Regex)]
        public override string Email { get => base.Email; set => base.Email = value; }

        [ProtectedPersonalData]
        [Range (minvalue,maxvalue)]
        public int CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public City City { get; set; } = null!;

        public ICollection<Apointment> Apointments { get; set; }

        public ICollection<Prescription> Prescriptions { get; set; }
    }
}
