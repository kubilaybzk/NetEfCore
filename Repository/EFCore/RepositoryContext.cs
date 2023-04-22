using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.EFCore.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EFCore
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig());
        }

    }
}
