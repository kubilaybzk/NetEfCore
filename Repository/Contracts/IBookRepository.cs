using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{
    public interface IBookRepository :IRepositoryBase<Book>
    {
        void CreateOneBook(Book book);
        void DeleteOneBook(Book book);
        void UpdateOneBook(Book book);

        IQueryable<Book> GetAllBooks(bool trackChanges);

        Book GetOneBookById(bool trackChanges,int id);


    }
}
