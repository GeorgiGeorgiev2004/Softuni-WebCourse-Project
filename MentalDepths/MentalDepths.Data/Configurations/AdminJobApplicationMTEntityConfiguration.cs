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
    }
}
