using Microsoft.EntityFrameworkCore;
using vega.Core.Models;
using vega.Models;

namespace vega.Persistance
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options)
        {

        }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}
