namespace MentalDepths.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Common.ModelRegulations.City;
    public class City
    {
        public City()
        {
            ApplicationUsers = new HashSet<ApplicationUser>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NamesMaxLenght, MinimumLength = NamesMinLenght)]
        public string Name { get; set; } = null!;

        public ICollection<ApplicationUser> ApplicationUsers{ get; set; }
    }
}
