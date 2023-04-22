using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EFCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, Title = "Araba Sevdası", Price = 112 },
                new Book { Id = 2, Title = "Uçurtma Avcısı", Price = 432 },
                new Book { Id = 3, Title = "Ezel", Price = 212 }
                );
        }
    }
}
