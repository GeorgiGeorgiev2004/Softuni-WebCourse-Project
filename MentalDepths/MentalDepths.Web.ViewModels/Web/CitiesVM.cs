namespace MentalDepths.Web.ViewModels.Web
{
    using System.ComponentModel.DataAnnotations;

    using static MentalDepths.Common.ModelRegulations.City;
    public class CitiesVM
    {
        public int Id { get; set; }

        [Required]
        [StringLength(NamesMaxLenght, MinimumLength = NamesMinLenght)]
        public string Name { get; set; } = null!;
    }
}
