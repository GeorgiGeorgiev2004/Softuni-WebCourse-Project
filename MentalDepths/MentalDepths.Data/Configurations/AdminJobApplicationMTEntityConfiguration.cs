namespace MentalDepths.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using MentalDepths.Data.Models;
    public class AdminJobApplicationMTEntityConfiguration : IEntityTypeConfiguration<AdminJobApplicationMT>
    {
        public void Configure(EntityTypeBuilder<AdminJobApplicationMT> builder)
        {
            builder
               .HasKey(aja => new { aja.AdminId, aja.JobApplicationId });
        }
        public List<AdminJobApplicationMT> GenerateAdminJobApplications()
        {
            List<AdminJobApplicationMT> adminJobApplications = new List<AdminJobApplicationMT>();

            AdminJobApplicationMT aja = new AdminJobApplicationMT()
            {
                AdminId = Guid.Parse("d947f5ab-75ae-4ebe-9f26-9af2671d77ac")

            };

            adminJobApplications.Add(aja);

            aja = new AdminJobApplicationMT()
            {
                AdminId = Guid.Parse("d947f5ab-75ae-4ebe-9f26-9af2671d77ac"),
            };

            adminJobApplications.Add(aja);

            aja = new AdminJobApplicationMT()
            {
                AdminId = Guid.Parse("d947f5ab-75ae-4ebe-9f26-9af2671d77ac"),

            };

            adminJobApplications.Add(aja);
            return adminJobApplications;
        }
    }
}
