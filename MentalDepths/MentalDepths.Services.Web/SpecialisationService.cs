using MentalDepths.Data;
using MentalDepths.Data.Models;
using MentalDepths.Services.Web.Interfaces;
using MentalDepths.Web.ViewModels.Web;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalDepths.Services.Web
{
    public class SpecialisationService : ISpecialisationService
    {
        private MentalDepthsDbContext context;
        public SpecialisationService(MentalDepthsDbContext mddc)
        {
            context=mddc;
        }
        public async Task AddSpecialisationToDB(SpecialisationVM model)
        {
            var specialisation = await context.Specialisations.FirstOrDefaultAsync(s=>s.Name==model.Name);
            if (specialisation != null)
            {
                return;
            }
            else 
            {
                Specialisation spc = new Specialisation() {Name=model.Name };
                await context.Specialisations.AddAsync(spc);
                await context.SaveChangesAsync();
            }
        }

        public async Task Delete(string name)
        {
            var specialisation = await context.Specialisations.FirstOrDefaultAsync(s=>s.Name==name);
            context.Specialisations.Remove(specialisation);
            await context.SaveChangesAsync();
        }

        public async Task<ICollection<SpecialisationVM>> GetAllSpecialisations()
        {
            return await context.Specialisations.Select(s => new SpecialisationVM() 
            {
                Id = s.Id,
                Name=s.Name
            }).ToListAsync();
        }
    }
}
