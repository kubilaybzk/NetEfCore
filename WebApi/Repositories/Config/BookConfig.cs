
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Models;

namespace WebApplication1.Repositories.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Title = "Araba Sevdası", Price = 112 },
                new Book { Id = 2, Title = "Uçurtma Avcısı", Price =432 },
                new Book { Id = 3, Title = "Ezel", Price = 212 }
                );
        }
    }
}
