using AutoMapper;
using MentalDepths.Data;
using MentalDepths.Data.Models;
using Microsoft.AspNetCore.Routing.Patterns;
using Services.Test.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Test.UnitTests
{
    public class UnitTestBase
    {
        protected MentalDepthsDbContext context;

        [OneTimeSetUp]
        public void SetUpBase()
        {
            context = DatabaseMock.Instance;
            SeedDatabase();
        }
        public Admin Admin { get; set; }

        public Aplicant Aplicant { get; set; }

        public Apointment Apointment { get; set; }

        public List<ApplicationUser> ApplicationUsers { get; set; }

        public City City { get; set; }

        public Conversation Conversation { get; set; }

        public JobApplicationForm JobApplicationForm { get; set; }

        public Message Message { get; set; }

        public Note Note { get; set; }

        public Specialisation Specialisation { get; set; }

        public Specialist Specialist { get; set; }
        private void SeedDatabase()
        {
            Admin = new Admin()
            {
                Id = Guid.Parse("17ac6c30-fd65-4002-917d-753ca1d2a7a5"),
                Username = "admin",
                UserId = Guid.Parse("3df16939-8fe8-4012-8ce7-1a69f3f654ec")
            };
            context.Admins.Add(Admin);
            context.SaveChanges();
            Aplicant = new Aplicant()
            {
                Id = Guid.Parse("3b250a59-82af-49d4-9bb1-5fcb197de174"),
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/e/e7/Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006.jpg",
                Age = 22,
                Address = "Lihtenstein 12 2135",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed sed lorem laoreet, tempus lacus eu, auctor dui. Ut aliquet dictum porttitor. Nunc lobortis arcu sed tellus consequat scelerisque quis ut metus. Vestibulum quis metus malesuada, vestibulum enim et, feugiat felis. Cras imperdiet posuere nisi, quis luctus risus imperdiet semper. Pellentesque nulla est, aliquet a accumsan vitae, maximus sit amet justo. Nulla tempor, mi et placerat gravida, massa lorem rutrum odio, tristique sollicitudin lorem tellus sit amet sem. Cras vulputate nisl at enim efficitur facilisis. Etiam finibus pretium aliquam. Proin condimentum cursus purus ut euismod.",
                UserId = Guid.Parse("19f57060-46bb-422a-a6fe-fcad66933f25"),
                Specialisations = "specialisation 1, specialisation 2"
            };
            context.Aplicants.Add(Aplicant);
            context.SaveChanges();
            Apointment = new Apointment()
            {
                Id = Guid.Parse("ab65ae1f-cef0-4f16-a02d-18cc33d34134"),
                Address = MentalDepths.Common.Constatnts.Office.OfficeAddress,
                HasPassed = false,
                SpecialistId = Guid.Parse("812a4249-cf21-494e-9b6f-76fe5ab3aba3"),
                ApplicationUserId = Guid.Parse("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f"),
                DateAndTime = DateTime.Now
            };
            context.Apointments.Add(Apointment);
            context.SaveChanges();
            ApplicationUsers = new List<ApplicationUser>()
            {
                new ApplicationUser()
                {
                    Id=Guid.Parse("3df16939-8fe8-4012-8ce7-1a69f3f654ec"),
                    CreatedOn = DateTime.Now,
                    CityId = 1,
                    Email = "admin_admin@admin.admin",
                    FirstName = "Admin",
                    SecondName = "Admin",
                    LastName = "Admin",
                    PhoneNumber = "1234567890",
                    EmailConfirmed=true,
                    UserName = "BigBoss",
                    NormalizedEmail="ADMIN_ADMIN@ADMIN.ADMIN",
                    NormalizedUserName="BIGBOSS",
                    PhoneNumberConfirmed=true,
                    ConcurrencyStamp = "9108a430-af18-457a-b6aa-ee825d5abc5f",

                },
                 new ApplicationUser()
                {
                    Id=Guid.Parse("b7c79b57-ff1f-42fb-ab13-15e730e42957"),
                    CreatedOn = DateTime.Now,
                    CityId = 1,
                    Email = "specialist_specialist@spc.spc",
                    FirstName = "Specialist",
                    SecondName = "Specialist",
                    LastName = "Specialist",
                    PhoneNumber = "0987654321",
                    EmailConfirmed=true,
                    UserName = "Dr.Special",
                    NormalizedEmail="SPECIALIST_SPECIALIST@SPC.SPC",
                    NormalizedUserName="DR.SPECIAL",
                    PhoneNumberConfirmed=true,
                    ConcurrencyStamp = "58bb118a-87a3-4804-adac-98c971dd2373",
                },
                  new ApplicationUser()
                {

                    Id=Guid.Parse("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f"),
                    CreatedOn = DateTime.Now,
                    CityId = 1,
                    Email = "user_user@user.user",
                    FirstName = "User",
                    SecondName = "User",
                    LastName = "User",
                    PhoneNumber = "5498761230",
                    EmailConfirmed=true,
                    UserName = "Average_User",
                    NormalizedEmail="USER_USER@USER.USER",
                    NormalizedUserName="AVERAGE_USER",
                    PhoneNumberConfirmed=true,
                    ConcurrencyStamp = "ce2633f0-4440-486a-b05b-8f780aee182f",
                },
            };
            context.ApplicationUsers.AddRange(ApplicationUsers);
            City = new City()
            {
                Id = 999,
                Name = "TestCity"
            };
            context.Cities.Add(City);
            context.SaveChanges();
            Conversation = new Conversation()
            {
                Id=Guid.Parse("e746577e-37fa-45f6-b723-776d7f858673"),
                IsClosed = false,
                SpecialistId = Guid.Parse("812a4249-cf21-494e-9b6f-76fe5ab3aba3"),
                NoteId = Guid.Parse("95eb50b8-a714-4fbb-b19a-edcd6469aacb"),
                UserId=Guid.Parse("2b7ff5f6-3216-49e5-8ec8-8dc4e221615f")
            };
            context.Conversations.Add(Conversation);
            context.SaveChanges();
            JobApplicationForm = new JobApplicationForm()
            {
                Id = Guid.Parse("c66c791a-3ce2-4347-a9a8-482589035906"),
                AplicantId = Guid.Parse("3b250a59-82af-49d4-9bb1-5fcb197de174"),
                CV = File.ReadAllBytes("D:\\Softuni proekt\\Softuni-WebCourse-Project\\MentalDepths\\MentalDepths.Data\\Configurations\\images\\CV.jpg"),
                ScannedDiploma = File.ReadAllBytes("D:\\Softuni proekt\\Softuni-WebCourse-Project\\MentalDepths\\MentalDepths.Data\\Configurations\\images\\diploma.jpg"),
                Certification = File.ReadAllBytes("D:\\Softuni proekt\\Softuni-WebCourse-Project\\MentalDepths\\MentalDepths.Data\\Configurations\\images\\certification.jpg")
            };
            context.JobApplicationForms.Add(JobApplicationForm);
            context.SaveChanges();
            Message = new Message()
            {
                Id = 999,
                TypeOfUser=MentalDepths.Common.Enums.PatientOrSpecialist.Patient,
                TimeOfSend = DateTime.Now,
                ConversationId = Guid.Parse("e746577e-37fa-45f6-b723-776d7f858673"),
                Text = "Example message!"
            };
            context.Messages.Add(Message);
            context.SaveChanges();
            Note = new Note()
            {
                Id = Guid.Parse("95eb50b8-a714-4fbb-b19a-edcd6469aacb"),
                Message="Example note!",
                ConversationtId=Guid.Parse("e746577e-37fa-45f6-b723-776d7f858673")
            };
            context.Notes.Add(Note);
            context.SaveChanges();
            Specialisation = new Specialisation()
            {
                Id=999,
                Name = "Specialisation"
            };
            context.Specialisations.Add(Specialisation);
            context.SaveChanges();
            Specialist = new Specialist()
            {
                Id = Guid.Parse("812a4249-cf21-494e-9b6f-76fe5ab3aba3"),
                UserId = Guid.Parse("b7c79b57-ff1f-42fb-ab13-15e730e42957"),
                Address = "ul. Specialist bl. 7",
                Age=22,
                ImageURL = "https://fullform.blog/wp-content/uploads/2022/01/url.jpg",
                Description = "Example description",  
            };
            context.Specialists.Add(Specialist);

            context.SaveChanges();
        }

        [OneTimeTearDown]
        public void TearDownBase()
        {
            context.Dispose();
        }
    }
}
