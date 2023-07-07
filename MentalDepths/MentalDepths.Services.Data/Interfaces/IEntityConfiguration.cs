using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalDepths.Services.Data.Interfaces
{
    public interface IEntityConfiguration
    {
        public string GenerateUsername(string firstname, string lastname);
    }
}
