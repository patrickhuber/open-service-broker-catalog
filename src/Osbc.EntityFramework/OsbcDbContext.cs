using Microsoft.EntityFrameworkCore;
using Osbc.Entities;

namespace Osbc.EntityFramework
{
    public class OsbcDbContext : DbContext, IOsbcDbContext
    {
        public DbSet<Broker> Brokers { get; set; }
    }
}
