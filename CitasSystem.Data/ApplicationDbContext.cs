using CitasSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CitasSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Citas> Citas { get; set; }
    }
}
