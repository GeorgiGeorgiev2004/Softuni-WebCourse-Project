using MentalDepths.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;

namespace Services.Test.Mocks
{
    public static class DatabaseMock
    {
        public static MentalDepthsDbContext Instance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<MentalDepthsDbContext>().UseInMemoryDatabase("MentalDepthsInMemoryDb" + DateTime.Now.ToString()).Options;

                return new MentalDepthsDbContext(dbContextOptions, false);
            }
        }
    }
}
