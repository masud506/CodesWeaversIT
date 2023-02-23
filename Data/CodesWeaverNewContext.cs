using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodesWeaverNew.Models;
using CodesWeaverNew.Models;

namespace CodesWeaverNew.Data
{
    public class CodesWeaverNewContext : DbContext
    {
        public CodesWeaverNewContext (DbContextOptions<CodesWeaverNewContext> options)
            : base(options)
        {
        }

        public DbSet<CodesWeaverNew.Models.Sliders> Sliders { get; set; }

        public DbSet<CodesWeaverNew.Models.About> About { get; set; }

        public DbSet<CodesWeaverNew.Models.Portfolio> Portfolio { get; set; }

        public DbSet<CodesWeaverNew.Models.Testimonials> Testimonials { get; set; }

        public DbSet<CodesWeaverNew.Models.Team> Team { get; set; }

        public DbSet<CodesWeaverNew.Models.Clients> Clients { get; set; }

        public DbSet<CodesWeaverNew.Models.Service> Service { get; set; }



     
    }
}
