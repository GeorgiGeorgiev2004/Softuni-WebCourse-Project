using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace MentalDepths
{
    using Microsoft.EntityFrameworkCore;

    using Data;
    using MentalDepths.Services.Web.Interfaces;
    using MentalDepths.Services.Web;
    using Microsoft.AspNetCore.Identity.UI.Services;
    using MentalDepths.Services.Web.Repositories.Interfaces;
    using MentalDepths.Services.Web.Repositories;
    using MentalDepths.Services.Web.SignalR.Chat;
    using MentalDepths.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<MentalDepthsDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<MentalDepths.Data.Models.ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
            })
                .AddRoles<IdentityRole<Guid>>()
                .AddEntityFrameworkStores<MentalDepthsDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IEmailSender, EmailSender>();
            builder.Services.AddScoped<ISpecialistService, SpecialistService>();
            builder.Services.AddScoped<IConversationService, ConversationService>();
            builder.Services.AddSingleton<IUserManagerRepository, UserManagerRepository>();
            builder.Services.AddScoped<IApointmentService, ApointmentService>();
            builder.Services.AddScoped<IMessageService, MessageService>();
            builder.Services.AddScoped<INoteService, NoteService>();
            builder.Services.AddScoped<IJobApplicatipnService, JobApplicationService>();
            builder.Services.AddScoped<IAdminService, AdminService>();
            builder.Services.AddScoped<ISpecialisationService, SpecialisationService>();
            builder.Services.AddSignalR();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.MapHub<ChatHub>("/chatHub");

            using (var scope = app.Services.CreateScope())
            {
                var rm = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<Guid>>>();

                var roles = new[] { "Admin", "Specialist", "User" };
                foreach (var role in roles)
                {
                    if (!await rm.RoleExistsAsync(role))
                    {
                        await rm.CreateAsync(new IdentityRole<Guid>(role));
                    }
                }
            }
            using (var scope = app.Services.CreateScope())
            {
                var um = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var user = await um.FindByEmailAsync("gogo_5a@abv.bg");
                if (user!=null&&um.IsInRoleAsync(user, "Admin").Result==false)
                {
                   var idk = await um.AddToRoleAsync(user, "Admin");
                }
                var spec1 = await um.FindByEmailAsync("Kolio_Zemev@gmail.com");
                if (spec1 != null && um.IsInRoleAsync(spec1, "Specialist").Result == false)
                {
                    var idk = await um.AddToRoleAsync(spec1, "Specialist");
                }
                var spec2 = await um.FindByEmailAsync("Ivan.Ivanov234@gmail.com");
                if (spec2 != null && um.IsInRoleAsync(spec2, "Specialist").Result == false)
                {
                    var idk = await um.AddToRoleAsync(spec2, "Specialist");
                }
            }
            app.Run();
        }
    }
}