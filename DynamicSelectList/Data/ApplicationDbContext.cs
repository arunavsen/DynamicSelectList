using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamicSelectList.Models;
using Microsoft.EntityFrameworkCore;

namespace DynamicSelectList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
