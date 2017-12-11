using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AGCProject.Models;

namespace AGCProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<DriveCard>().ToTable("DriveCard");
            builder.Entity<SpacerCard>().ToTable("SpacerCard");
            builder.Entity<Operator>().ToTable("Operator");
        }

        public DbSet<AGCProject.Models.DriveCard> DriveCards { get; set; }
        public DbSet<AGCProject.Models.SpacerCard> SpacerCards { get; set; }
        public DbSet<AGCProject.Models.Operator> Operators { get; set; }
    }
}
