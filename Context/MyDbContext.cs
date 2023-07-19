
using Microsoft.EntityFrameworkCore;

namespace BlazorApi.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> opt) : base(opt)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Student> Students {get;set;}
        public DbSet<Teacher> Teachers {get; set;}
    }
}
