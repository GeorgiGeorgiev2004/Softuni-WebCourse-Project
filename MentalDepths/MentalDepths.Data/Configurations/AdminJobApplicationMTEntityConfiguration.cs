using MentalDepths.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalDepths.Data.Configurations
{
    public class AdminJobApplicationMTEntityConfiguration : IEntityTypeConfiguration<AdminJobApplicationMT>
    {
        public void Configure(EntityTypeBuilder<AdminJobApplicationMT> builder)
        {
            builder
               .HasKey(aja => new { aja.AdminId, aja.JobApplicationId });
        }
    }
}
