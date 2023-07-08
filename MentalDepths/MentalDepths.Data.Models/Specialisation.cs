namespace MentalDepths.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static Common.ModelRegulations.Specialisation;
    public class Specialisation
    {
        public Specialisation()
        {
            Specialists = new HashSet<SpecialistSpecialisation>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(NamesMaxLenght, MinimumLength = NamesMinLenght)]
        public string Name { get; set; } = null!;
        public ICollection<SpecialistSpecialisation> Specialists { get; set; }
    }
}
