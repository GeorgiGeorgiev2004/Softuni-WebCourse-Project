namespace MentalDepths.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using MentalDepths.Data.Models;
    public class JobApplicationFormEntityConfiguration : IEntityTypeConfiguration<JobApplicationForm>
    {
        public void Configure(EntityTypeBuilder<JobApplicationForm> builder)
        {
            builder
                .HasOne(jaf => jaf.Specialist)
                .WithOne(s => s.JobApplication)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
