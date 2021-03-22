using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Restaurants.Models;

namespace Restaurants.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Restaurants.Models.Restaurant> Restaurant { get; set; }
        public DbSet<Restaurants.Models.Employee> Employee { get; set; }
    }
}
