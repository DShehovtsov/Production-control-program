
using PcpBl.Models;
using System.Data.Entity;

namespace PcpBl
{
    public class PcpContext : DbContext
    {
        public PcpContext() : base("PcpConnection") { }

        public DbSet<Bird> Birds { get; set; }
        public DbSet<EggLayingQualities> EggLayingQualities { get; set; }
        public DbSet<WorkShop> WorkShops { get; set; }

        public DbSet<ManagementHistory> ManagementHistories { get; set; }
    }
}
