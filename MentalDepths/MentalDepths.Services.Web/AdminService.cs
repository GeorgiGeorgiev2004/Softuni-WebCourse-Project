using MentalDepths.Data;
using MentalDepths.Services.Web.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalDepths.Services.Web
{
    public class AdminService :IAdminService
    {
        private MentalDepthsDbContext context;
        public AdminService(MentalDepthsDbContext ctxt)
        {
              context = ctxt;
        }
    }
}
