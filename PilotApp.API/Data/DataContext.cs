using Microsoft.EntityFrameworkCore;
using pilotapp.api.Models;

namespace pilotapp.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Value> Values { get; set; }
    }
}