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
        public ICollection<JobApplicationForm> GenerateJobApplicationForm() 
        {
            List<JobApplicationForm> jobApplicationForms = new List<JobApplicationForm>();

            JobApplicationForm jobApplicationForm = new JobApplicationForm() 
            {
                Id=Guid.Parse(""),

            };
            jobApplicationForms.Add(jobApplicationForm);

            return jobApplicationForms;
        }
    }
}
