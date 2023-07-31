using MentalDepths.Web.ViewModels.Web;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace MentalDepths.Services.Web.Interfaces
{
    public interface IAdminService
    {
        public Task<AplicantVM> FindAplicantById(Guid aplicantId);
    }
}
