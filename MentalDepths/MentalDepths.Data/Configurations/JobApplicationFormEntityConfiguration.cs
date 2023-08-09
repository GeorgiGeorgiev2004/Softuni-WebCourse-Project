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
                .HasOne(jaf => jaf.Aplicant)
                .WithOne(s => s.JobApplication)
                .OnDelete(DeleteBehavior.Cascade);
        }
        public List<JobApplicationForm> GenerateJobApplicationForm()
        {
            List<JobApplicationForm> jobApplicationForms = new List<JobApplicationForm>()
                {
                    new JobApplicationForm()
                    {
                        Id=Guid.Parse("2503c6c8-c74d-45e0-8f6a-ab475628445f"),
                        AplicantId=Guid.Parse("7bca8717-bead-4eff-934f-0eeb611c214b"),
                        CV=File.ReadAllBytes("D:\\Softuni proekt\\Softuni-WebCourse-Project\\MentalDepths\\MentalDepths.Data\\Configurations\\images\\CV.jpg"),
                        ScannedDiploma=File.ReadAllBytes("D:\\Softuni proekt\\Softuni-WebCourse-Project\\MentalDepths\\MentalDepths.Data\\Configurations\\images\\diploma.jpg"),
                        Certification=File.ReadAllBytes("D:\\Softuni proekt\\Softuni-WebCourse-Project\\MentalDepths\\MentalDepths.Data\\Configurations\\images\\certification.jpg")
                    },
                    new JobApplicationForm()
                    {
                        Id=Guid.Parse("6a9170ff-59af-47f3-ba1e-f1d5ffaeb0ab"),
                        AplicantId=Guid.Parse("b4e811e8-305e-405c-a758-cefdf2d2fb4e"),
                        CV=File.ReadAllBytes("D:\\Softuni proekt\\Softuni-WebCourse-Project\\MentalDepths\\MentalDepths.Data\\Configurations\\images\\catCV.jpg"),
                        ScannedDiploma=File.ReadAllBytes("D:\\Softuni proekt\\Softuni-WebCourse-Project\\MentalDepths\\MentalDepths.Data\\Configurations\\images\\HillDiploma.jpg"),
                        Certification=File.ReadAllBytes("D:\\Softuni proekt\\Softuni-WebCourse-Project\\MentalDepths\\MentalDepths.Data\\Configurations\\images\\catCertifications.jpg")
                    },
                };
            return jobApplicationForms;
        }
    }
}
