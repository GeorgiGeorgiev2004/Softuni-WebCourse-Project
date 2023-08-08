using MentalDepths.Services.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Test.UnitTests
{
    [TestFixture]
    public class ApointmnetTest:UnitTestBase
    {
        private ApointmentService apointmentService;
        [SetUp]
        public void SetUp()
        {
            apointmentService = new ApointmentService(context);
        }

    }
}
