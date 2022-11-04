using Ank9_EF_Entities_CT.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank9_EF_Entities_CT.Data.Configurations
{
    public class BandConfiguration : IEntityTypeConfiguration<Band>
    {
        public void Configure(EntityTypeBuilder<Band> builder)
        {
            builder.HasMany<Musician>(b => b.BandMembers)
                .WithOne(m => m.Band)
                .HasForeignKey(m => m.BandId);
        }
    }
}
