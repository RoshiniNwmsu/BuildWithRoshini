using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace RoshiniPortfolio.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Feedback> Feedbacks { get; set; }
    }
}