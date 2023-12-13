using Balay_Back_end.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Balay_Back_end.Data
{
    public class AppDbContext :IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<AboutImage> AboutImages { get; set; }
        public DbSet<AboutHistory> AboutHistories { get; set; }
        public DbSet<AboutIcon> AboutIcons { get; set; }
        public DbSet<AboutAccordion> AboutAccordions { get; set; }








        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<AboutImage>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<AboutIcon>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<AboutAccordion>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<AboutHistory>().HasQueryFilter(m => !m.SoftDeleted);


        }
    }
}
