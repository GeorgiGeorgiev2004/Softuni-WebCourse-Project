namespace MentalDepths.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    public class AdminJobApplicationMT
    {
        public Guid AdminId { get; set; }

        [ForeignKey(nameof(AdminId))]
        public Admin Admin { get; set; }= null!;

        public Guid JobApplicationId { get; set; }

        [ForeignKey(nameof(JobApplicationId))]
        public JobApplicationForm JobApplicationForm { get; set; } = null!;
    }
}
