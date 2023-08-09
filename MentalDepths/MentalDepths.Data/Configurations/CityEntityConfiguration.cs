namespace MentalDepths.Data.Configurations
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;

    using MentalDepths.Data.Models;
    public class CityEntityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder
                .HasMany(c=>c.ApplicationUsers)
                .WithOne(au => au.City)
                .HasForeignKey(c=>c.CityId)
                .OnDelete(DeleteBehavior.Restrict);

           
        }

        public ICollection<City> GenerateCities() 
        {
            List<City> cities = new List<City>();

            City c = new City()
            {
                Id = 1,
                Name = ""
            };
            cities.Add(c);

            c = new City() 
            {
                Id = 2,
                Name = "Blagoevgrad"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 3,
                Name ="Burgas"
            };
            cities.Add(c);

            c = new City()
            {
                Id=4,
                Name = "Dobrich"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 5,
                Name = "Gabrovo"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 6,
                Name = "Haskovo"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 7,
                Name = "Kardzhali"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 8,
                Name = "Kyustendil"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 9,
                Name = "Lovech"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 10,
                Name = "Montana"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 11,
                Name = "Pazardzhik"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 12,
                Name = "Pernik"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 13,
                Name = "Pleven"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 14,
                Name = "Razgrad"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 15,
                Name = "Ruse"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 16,
                Name = "Shumen"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 17,
                Name = "Silistra"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 18,
                Name = "Sliven"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 19,
                Name = "Smolyan"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 20,
                Name = "Sofia City"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 21,
                Name = "Sofia (province)"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 22,
                Name = "Stara Zagora"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 23,
                Name = "Targovishte"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 24,
                Name = "Varna"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 25,
                Name = "Veliko Tarnovo"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 26,
                Name = "Vidin"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 27,
                Name = "Vratsa"
            };
            cities.Add(c);

            c = new City()
            {
                Id = 28,
                Name = "Yambol"
            };
            cities.Add(c);
            return cities;
        }
    } 
}
