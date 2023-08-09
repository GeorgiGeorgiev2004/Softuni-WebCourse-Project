namespace MentalDepths.Data
{
    using MentalDepths.Data.Configurations;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Models;
    using System.Reflection;

    public class MentalDepthsDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>,Guid>
    {
        private bool seed;
        public MentalDepthsDbContext(DbContextOptions<MentalDepthsDbContext> options, bool seed=true)
            : base(options)
        {
            if (Database.IsRelational())
            {
                Database.Migrate();
            }
            else
            {
                Database.EnsureCreated();
            }

            this.seed = seed;
        }
        public DbSet<Admin> Admins { get; set; } = null!;
        public DbSet<Apointment> Apointments { get; set; } = null!;
        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<JobApplicationForm> JobApplicationForms { get; set; } = null!;
        public DbSet<Prescription> Prescriptions { get; set; } = null!;
        public DbSet<Specialisation> Specialisations { get; set; } = null!;
        public DbSet<Specialist> Specialists { get; set; } = null!;
        public DbSet<Conversation> Conversations { get; set; } = null!;
        public DbSet<Message> Messages { get; set; } = null!;
        public DbSet<Note> Notes { get; set; } = null!;
        public DbSet<Aplicant> Aplicants { get; set; } = null!;
        //<summary>
        //From here down is mapping tables
        //</summary>
        public DbSet<SpecialistSpecialisation> SpecialistsSpecialisations { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(MentalDepthsDbContext)) ??
                                        Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(configAssembly);
            if (seed)
            {
                AdminEntityConfiguration AdminEC = new AdminEntityConfiguration();
                builder.Entity<Admin>().HasData(AdminEC.GenerateAdmin());

                AplicantEntityConfiguration AplicantEC = new AplicantEntityConfiguration();
                builder.Entity<Aplicant>().HasData(AplicantEC.GenerateAplicants());

                ApointmentEntityConfiguration ApointmentEC = new ApointmentEntityConfiguration();
                builder.Entity<Apointment>().HasData(ApointmentEC.GenerateApointment());

                ApplicationUserEntityConfiguration ApplicationUserEC = new ApplicationUserEntityConfiguration();
                builder.Entity<ApplicationUser>().HasData(ApplicationUserEC.GenerateApplicationUsers());

                CityEntityConfiguration CityEC = new CityEntityConfiguration();
                builder.Entity<City>().HasData(CityEC.GenerateCities());

                ConversationEntityConfiguration ConversationEC = new ConversationEntityConfiguration();
                builder.Entity<Conversation>().HasData(ConversationEC.GenerateConversation());

                JobApplicationFormEntityConfiguration JobApplicationFormEC = new JobApplicationFormEntityConfiguration();
                builder.Entity<JobApplicationForm>().HasData(JobApplicationFormEC.GenerateJobApplicationForm());

                MessageEntityConfiguration MessageEC = new MessageEntityConfiguration();
                builder.Entity<Message>().HasData(MessageEC.Conversation());
                
                NoteEntityConfiguration NoteEC = new NoteEntityConfiguration();
                builder.Entity<Aplicant>().HasData(NoteEC.GenerateNote());

                // WIP
                //PrescriptionEntityConfiguration PrescriptionEC = new PrescriptionEntityConfiguration();
                //builder.Entity<Aplicant>().HasData(PrescriptionEC.GeneratePrescription());

                SpecialisationEntityConfiguration SpecialisationEC = new SpecialisationEntityConfiguration();
                builder.Entity<Aplicant>().HasData(SpecialisationEC.GenerateSpecialisations());

                SpecialistEntityConfiguration SpecialistEC = new SpecialistEntityConfiguration();
                builder.Entity<Aplicant>().HasData(SpecialistEC.GenerateSpecialists());

                SpecialistSpecialisationEntityConfiguration SpecialistSpecialisationEC = new SpecialistSpecialisationEntityConfiguration();
                builder.Entity<Aplicant>().HasData(SpecialistSpecialisationEC.GenerateSpecialistSpecialisation());
            }
            base.OnModelCreating(builder);
        }
    }
}