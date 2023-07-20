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
    public class Program
    {
        public static void Main(string[] args)
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
                .AddEntityFrameworkStores<MentalDepthsDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IEmailSender, EmailSender>();
            builder.Services.AddScoped<ISpecialistService, SpecialistService>();
            builder.Services.AddScoped<IConversationService, ConversationService>();
            builder.Services.AddSingleton<IUserManagerRepository, UserManagerRepository>();
            builder.Services.AddScoped<IChatLogs, ChatLogs>();
            builder.Services.AddScoped<IApointmentService, ApointmentService>();
            builder.Services.AddScoped<INoteService, NoteService>();
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

            app.Run();
        }
    }
}