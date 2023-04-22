using Entities.Models;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EFCore
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(RepositoryContext context) : base(context)
        {

        }

        public void CreateOneBook(Book book) => Update(book);

        public void DeleteOneBook(Book book) => Delete(book);

        public IQueryable<Book> GetAllBooks(bool trackChanges)=> FindAll(trackChanges).OrderBy(b=>b.Title);

        public IQueryable<Book> GetOneBookById(bool trackChanges, int id) => FindByCondition(trackChanges, b => b.Id.Equals(id));

        public void UpdateOneBook(Book book) => Update(book);
    }
}
