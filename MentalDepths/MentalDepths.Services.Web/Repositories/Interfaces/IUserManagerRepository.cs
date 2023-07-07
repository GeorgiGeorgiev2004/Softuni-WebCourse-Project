using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalDepths.Services.Web.Repositories.Interfaces
{
    public interface IUserManagerRepository
    {
        Dictionary<string, string> Dictionary { get; }

        public void AddToDictionary(string key, string value);

        public void RemoveFromDictionary(string key);
    }
}
