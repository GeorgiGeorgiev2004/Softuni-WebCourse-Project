namespace MentalDepths.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using MentalDepths.Data.Models;
    public class SpecialistSpecialisationEntityConfiguration : IEntityTypeConfiguration<SpecialistSpecialisation>
    {
        public void Configure(EntityTypeBuilder<SpecialistSpecialisation> builder)
        {
            builder
                .HasKey(ss => new { ss.SpecialistId, ss.SpecialisationId });
            builder.HasOne(ss=>ss.Specialist)
                .WithMany(s=>s.Specialisations)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(ss => ss.Specialisation)
              .WithMany(s => s.Specialists)
              .OnDelete(DeleteBehavior.Restrict);
        }
        public List<SpecialistSpecialisation> GenerateSpecialistSpecialisation()
        {

            List<SpecialistSpecialisation> list = new List<SpecialistSpecialisation>();
            SpecialistSpecialisation ss = new SpecialistSpecialisation()
            {
                SpecialistId = Guid.Parse("33713803-661e-4fad-a041-cf526fbc83e4"),
                SpecialisationId = 8
            };
            list.Add(ss);

            ss = new SpecialistSpecialisation()
            {
                SpecialistId = Guid.Parse("33713803-661e-4fad-a041-cf526fbc83e4"),
                SpecialisationId = 4
            };
            list.Add(ss);

            ss = new SpecialistSpecialisation()
            {
                SpecialistId = Guid.Parse("550184af-0284-4a1c-bc3e-223cb9198e62"),
                SpecialisationId = 13
            };
            list.Add(ss);

            ss = new SpecialistSpecialisation()
            {
                SpecialistId = Guid.Parse("550184af-0284-4a1c-bc3e-223cb9198e62"),
                SpecialisationId = 6
            };
            list.Add(ss);

            ss = new SpecialistSpecialisation()
            {
                SpecialistId = Guid.Parse("550184af-0284-4a1c-bc3e-223cb9198e62"),
                SpecialisationId = 3
            };
            list.Add(ss);


            return list;
        }
    }
}
