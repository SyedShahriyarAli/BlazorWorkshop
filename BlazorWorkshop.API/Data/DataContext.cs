using BlazorWorkshop.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWorkshop.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
