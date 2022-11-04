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
    public class MusicianConfiguration : IEntityTypeConfiguration<Musician>
    {
        public void Configure(EntityTypeBuilder<Musician> builder)
        {
            //Bu satırı yazmasakta Band de olduğu için çalışacak ama yazarsak hata vermeyecek
            builder.HasOne<Band>(m => m.Band)
                .WithMany(b => b.BandMembers)
                .HasForeignKey(m => m.BandId);

            //Çoka çok bağlantı
            //builder.HasMany<Band>(m => m.Bands)
            //    .WithMany(b => b.BandMembers);
        }
    }
}
