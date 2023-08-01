using MentalDepths.Web.ViewModels.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalDepths.Services.Web.Interfaces
{
    public interface ISpecialisationService
    {
        public Task AddSpecialisationToDB(SpecialisationVM model);
        public Task<ICollection<SpecialisationVM>> GetAllSpecialisations();
        public Task Delete(string name);
    }
}
