using System.Data.Entity;
using oopsAPI.Models;

namespace oopsAPI.DBA
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext() : base("ConnectionPub")
        {

        }

        public DbSet<Oops> Oops { get; set; }
    }
}
