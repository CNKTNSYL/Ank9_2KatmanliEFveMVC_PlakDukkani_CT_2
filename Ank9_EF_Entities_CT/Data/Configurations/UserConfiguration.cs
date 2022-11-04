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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(c => c.Id)
                .UseIdentityColumn(1000, 1)
                .IsRequired();

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(c => c.Password)
                .IsRequired()
                .HasColumnType("NCHAR(8)")
                .IsFixedLength(true);

            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Name).IsUnique();
        }
    }
}
