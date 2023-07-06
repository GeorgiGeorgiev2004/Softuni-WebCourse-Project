namespace MentalDepths.Web.ViewModels.Web
{

    using System.ComponentModel.DataAnnotations;
    
    using static Common.ModelRegulations.ApplicationUser;
    public class ApplicationUserVMAccountManagement
    {

        [Required]
        [StringLength(NamesMaxLenght, MinimumLength = NamesMinLenght)]
        public string FirstName { get; set; } = null!;

        public string? SecondName { get; set; }

        [Required]
        [StringLength(NamesMaxLenght, MinimumLength = NamesMinLenght)]
        public string LastName { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        public int CityId { get; set; }
        public ICollection<CitiesVM> Cities { get; set; } = new HashSet<CitiesVM>();

    }
}
