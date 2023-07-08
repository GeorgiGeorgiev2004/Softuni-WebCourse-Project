namespace MentalDepths.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using MentalDepths.Data.Models;
    public class SpecialisationEntityConfiguration : IEntityTypeConfiguration<Specialisation>
    {
        public void Configure(EntityTypeBuilder<Specialisation> builder)
        {
            builder
                .HasMany(s => s.Specialists)
                .WithOne(s => s.Specialisation)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasData(GenerateSpecialisations());
        }
        public List<Specialisation> GenerateSpecialisations()
        {
            List<Specialisation> specialisations = new List<Specialisation>();
            Specialisation spec = new Specialisation() 
            {
                Id = 1,
                Name="Psychiatrist"
            };
            specialisations.Add(spec);

            spec = new Specialisation()
            {
                Id = 2,
                Name = "Adolescent psycology"
            };
            specialisations.Add(spec);

            spec = new Specialisation()
            {
                Id = 3,
                Name = "Prepubescent psycology"
            };
            specialisations.Add(spec);

            spec = new Specialisation()
            {
                Id = 4,
                Name = "Post-war trauma"
            };
            specialisations.Add(spec);

            spec = new Specialisation()
            {
                Id = 5,
                Name = "Abnormal psychology"
            };
            specialisations.Add(spec);

            spec = new Specialisation()
            {
                Id = 6,
                Name = "Biological psychology"
            };
            specialisations.Add(spec);

            spec = new Specialisation()
            {
                Id = 7,
                Name = "Cognitive psychology "
            };
            specialisations.Add(spec);

            spec = new Specialisation()
            {
                Id = 8,
                Name = "Developmental psychology"
            };
            specialisations.Add(spec);

            spec = new Specialisation()
            {
                Id = 9,
                Name = "Forensic psychology"
            };
            specialisations.Add(spec);

            spec = new Specialisation()
            {
                Id = 10,
                Name = "Counselling psychology"
            };
            specialisations.Add(spec);

            spec = new Specialisation()
            {
                Id = 11,
                Name = "Industrial-organizational psychology"
            };
            specialisations.Add(spec);

            spec = new Specialisation()
            {
                Id = 12,
                Name = "Forensic psychology"
            };
            specialisations.Add(spec);

            spec = new Specialisation()
            {
                Id = 13,
                Name = "Personality psychology"
            };
            specialisations.Add(spec);

            spec = new Specialisation()
            {
                Id = 14,
                Name = "Social psychology"
            };
            specialisations.Add(spec);

            return specialisations;
        }

    }
}
