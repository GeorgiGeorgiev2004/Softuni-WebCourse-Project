namespace MentalDepths.Services.Web.Interfaces
{
    using MentalDepths.Data.Models;
    using MentalDepths.Web.ViewModels.Web;
    public interface IUserService
    {
        public Task<ICollection<CitiesVM>> GetAllCities();

        public string GenerateConfiramtionCode();

        public void AddConfiramtionCodeToDic(string id, string code);

        public string GetConfiramtionCodeFromId(string id);

        public void SetEmailConfirmationToTrue(string id);

        public void DisposeOfConfirmedCodes(string userId);

        public bool EmailIsConfirmed(string userId);
    }
}
