namespace MentalDepths.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Models;
    using System.Reflection.Emit;

    public class MentalDepthsDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>,Guid>
    {
        public MentalDepthsDbContext(DbContextOptions<MentalDepthsDbContext> options)
            : base(options)
        {

        }
        public DbSet<Admin> Admins { get; set; } = null!;
        public DbSet<Apointment> Apointments { get; set; } = null!;
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<JobApplicationForm> JobApplicationForms { get; set; } = null!;
        public DbSet<Prescription> Prescriptions { get; set; } = null!;
        public DbSet<Specialisation> Specialisations { get; set; } = null!;
        public DbSet<Specialist> Specialists { get; set; } = null!;

        //<summary>
        //From here down is mapping tables
        //</summary>
        public DbSet<SpecialistSpecialisation> SpecialistsSpecialisations { get; set; } = null!;
        public DbSet<AdminJobApplicationMT> AdminJobApplicationMT { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<SpecialistSpecialisation>()
                .HasKey(ss => new { ss.SpecialistId, ss.SpecialisationId });

            builder.Entity<AdminJobApplicationMT>()
                .HasKey(aja => new { aja.AdminId, aja.JobApplicationId });

            builder.Entity<Apointment>()
               .HasKey(a => new { a.SpecialistId, a.ApplicationUserId });

            builder.Entity<Prescription>()
               .HasKey(p => new { p.SpecialistId, p.ApplicationUserId });

            base.OnModelCreating(builder);
        }
    }
}