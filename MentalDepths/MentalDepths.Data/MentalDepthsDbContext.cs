namespace MentalDepths.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Models;
    public class MentalDepthsDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>,Guid>
    {
        public MentalDepthsDbContext(DbContextOptions<MentalDepthsDbContext> options)
            : base(options)
        {

        }

    }
}