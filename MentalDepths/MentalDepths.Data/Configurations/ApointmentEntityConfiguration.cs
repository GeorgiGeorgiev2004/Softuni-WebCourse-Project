namespace MentalDepths.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;

    using MentalDepths.Data.Models;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

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

            builder
                .HasData(GenerateApointment());
        }
        public Apointment[] GenerateApointment()
        {
            var apointments = new List<Apointment>();
            var apointment = new Apointment
            {

            };
            apointments.Add(apointment);
            apointment = new Apointment
            {

            };
            apointments.Add(apointment);
            apointment = new Apointment
            {

            };
            apointments.Add(apointment);
            apointment = new Apointment
            {

            };
            apointments.Add(apointment);
            return apointments.ToArray();       
        }
    }
}
