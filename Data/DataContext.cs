using Microsoft.EntityFrameworkCore;
using todo_list_NetCoreWebAPI.Models;

namespace todo_list_NetCoreWebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Task> Tasks {get; set;}

    }
}