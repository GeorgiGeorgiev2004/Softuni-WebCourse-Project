using MentalDepths.Services.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalDepths.Services.Data
{
    public class EntityConfiguration : IEntityConfiguration
    {
        public string GenerateUsername(string firstname,string lastname)
        {
            return $"{firstname}_{lastname}";
        }
    }
}
