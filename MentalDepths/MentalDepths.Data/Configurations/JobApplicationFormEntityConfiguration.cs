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
    public class JobApplicationFormEntityConfiguration : IEntityTypeConfiguration<JobApplicationForm>
    {
        public void Configure(EntityTypeBuilder<JobApplicationForm> builder)
        {
            builder
                .HasOne(jaf => jaf.Specialist)
                .WithOne(s => s.JobApplication)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
