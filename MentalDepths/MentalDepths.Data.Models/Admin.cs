namespace MentalDepths.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static Common.ModelRegulations.Admin;
    public class Admin
    {
        public Admin()
        {
            Id= Guid.NewGuid();
            JobApplications = new HashSet<AdminJobApplicationMT>();
        }
        public Guid Id { get; set; }

        public string Username { get; set; } = null!;

        [Required]
        public Guid UserId { get; set; }

        [Required]
        [ForeignKey(nameof(UserId))]
        public ApplicationUser ApplicationUser { get; set; } = null!;

        public ICollection<AdminJobApplicationMT> JobApplications { get; set; }
    }
}
