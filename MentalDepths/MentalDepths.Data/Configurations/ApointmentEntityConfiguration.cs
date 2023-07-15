namespace MentalDepths.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;

    using MentalDepths.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using static Common.Enums.AddressesEnum;
    using MentalDepths.Common.Enums;

    public class ApointmentEntityConfiguration : IEntityTypeConfiguration<Apointment>
    {
        public void Configure(EntityTypeBuilder<Apointment> builder)
        {
            builder
                .HasOne(a => a.ApplicationUser)
                .WithMany(au => au.Apointments)
                .HasForeignKey(a => a.ApplicationUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.Specialist)
                .WithMany(au => au.Apointments)
                .HasForeignKey(a => a.SpecialistId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(GenerateApointment());
        }
        public List<Apointment> GenerateApointment()
        {
            var apointments = new List<Apointment>();
            var apointment = new Apointment
            {
                Id = Guid.Parse("247a7f62-3cfb-4d10-94b5-b94bb5a32e57"),
                ApplicationUserId= Guid.Parse("010d67b6-964d-4248-9c9a-ad83215eaa4a"),
                SpecialistId= Guid.Parse("33713803-661e-4fad-a041-cf526fbc83e4"),
                Address = AddressesEnum.Office.ToString(),
                DateAndTime = DateTime.Now.AddDays(3)
            };
            apointments.Add(apointment);
            return apointments;
        }
    }
}
