namespace MentalDepths.Services.Web.Repositories
{
    using MentalDepths.Services.Web.Repositories.Interfaces;
    using System.Collections.Generic;

    public class UserManagerRepository : IUserManagerRepository
    {
        private Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public Dictionary<string, string> Dictionary => dictionary;

        public void AddToDictionary(string key,string value)
        {
            dictionary.Add(key, value);
        }

        public void RemoveFromDictionary(string key)
        {
            dictionary.Remove(key);
        }
    }
}
