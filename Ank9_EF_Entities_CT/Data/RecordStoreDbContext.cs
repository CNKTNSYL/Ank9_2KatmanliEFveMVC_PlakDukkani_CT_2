using Ank9_EF_Entities_CT.Data.Configurations;
using Ank9_EF_Entities_CT.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Ank9_EF_Entities_CT.Data
{
    public class RecordStoreDbContext : DbContext
    {
        public RecordStoreDbContext(DbContextOptions<RecordStoreDbContext>options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
            modelBuilder.ApplyConfiguration<Band>(new BandConfiguration());
            modelBuilder.ApplyConfiguration<Musician>(new MusicianConfiguration());

            //modelBuilder.Entity<Musician>()
            //    .HasOne<Band>(m => m.Band)
            //    .WithMany(b => b.BandMembers)
            //    .HasForeignKey(m => m.BandId);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Musician> Musicians { get; set; }
    }
}
