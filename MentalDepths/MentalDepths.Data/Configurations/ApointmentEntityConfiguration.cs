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
                SpecialistId= Guid.Parse("550184af-0284-4a1c-bc3e-223cb9198e62"),
                Address = AddressesEnum.Office.ToString(),
                DateAndTime = new DateTime(2023, 8, 11, 9, 40, 00),
                HasPassed = false,
            };
            apointments.Add(apointment);
            return apointments;
        }
    }
}
