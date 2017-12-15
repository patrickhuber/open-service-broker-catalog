using Microsoft.EntityFrameworkCore;
using Osbc.Entities;

namespace Osbc.EntityFramework
{
    public interface IOsbcDbContext
    {
        DbSet<Broker> Brokers { get; set; }
    }
}