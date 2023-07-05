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
    public class SpecialistSpecialisationEntityConfiguration : IEntityTypeConfiguration<SpecialistSpecialisation>
    {
        public void Configure(EntityTypeBuilder<SpecialistSpecialisation> builder)
        {
            builder
                .HasKey(ss => new { ss.SpecialistId, ss.SpecialisationId });
        }
    }
}
