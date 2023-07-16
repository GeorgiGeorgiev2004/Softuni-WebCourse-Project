using MentalDepths.Web.ViewModels.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalDepths.Services.Web.Interfaces
{
    public interface IApointmentService
    {
        public Task<BookApointementVM> GenerateNewApointement();
    }
}
