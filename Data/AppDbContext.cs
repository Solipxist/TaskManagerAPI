using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Models;
using Task = TaskManagerAPI.Models.Task;

namespace TaskManagerAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
