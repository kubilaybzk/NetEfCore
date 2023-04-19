
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using WebApplication1.Repositories.Config;

namespace WebApi.Repositories
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions option):base(option) {
        
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig());
        }

    }   
}
