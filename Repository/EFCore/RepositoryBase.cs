using Microsoft.EntityFrameworkCore;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EFCore
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
        where T : class //Sadece Class olarak obje alabilecek.
    {

        //Burada şöyle bir mantık oluşturacağız.
            //Genel olarak eleman listeleme fonksiyonları
            //Genel olarak silme , ekleme güncelleme fonksiyonları olacak.


        //Öncelikle burada Db ile bağlantı kurabilmemiz için RepositoryContext yapımızı oluşturalım.

        protected readonly RepositoryContext _context;

        public  RepositoryBase(RepositoryContext context)
        {
                _context = context;
        }


        public void Create(T entity) => _context.Set<T>().Add(entity);

        public void Delete(T entity)=>_context.Set<T>().Remove(entity);

        public IQueryable<T> FindAll(bool trackChanges) => 
            !trackChanges ? _context.Set<T>().AsNoTracking() : _context.Set<T>();

        public IQueryable<T> FindByCondition(bool trackChanges, Expression<Func<T, bool>> expression)=>
             !trackChanges ? _context.Set<T>().Where(expression).AsNoTracking() : _context.Set<T>().Where(expression);


        public void Update(T entity) => _context.Set<T>().Update(entity);
    }
}
