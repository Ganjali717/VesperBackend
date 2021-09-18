using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vesper_Backend.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Clients> Client { get; set; }
        public DbSet<About> Aboutus { get; set; }
        public DbSet<Counts> Count { get; set; }
        public DbSet<Services> Service { get; set; }
        public DbSet<MoreServices> MoreService { get; set; }
        public DbSet<Features> Feature { get; set; }
        public DbSet<Testimonials> Testimonial { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioSlider> PortfolioSliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Team> Teams { get; set; }

        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Heroes> Hero { get; set; }
    }
}
