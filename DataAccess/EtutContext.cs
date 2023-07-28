using Etut.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Etut.DataAccess
{
    public class EtutContext:DbContext
    {
        public DbSet<Entities.Etut> Etuts { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Branch> Branches { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-AIRQGAV;Initial Catalog=EtutDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Etut>()
                .Property(e => e.Date)
                .HasConversion(
                    v => new DateTime(v.Year, v.Month, v.Day), // DateOnly türünden DateTime'e dönüşüm
                    v => new DateOnly(v.Year, v.Month, v.Day) // DateTime'ten DateOnly'e dönüşüm
                );
        }
    }
}
