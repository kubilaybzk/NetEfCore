using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Contracts
{

    /*
     Burası bizim contracts interface değerimiz eğer bir sınıf bu base değerleri kabul ediyorsa bu değerlere sahip olmak zorunda
        
      
     */


    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        /* Burada trackChanges kullanma sebebimiz yapılan 
            değişiklikleri her zaman izlemek zorunda kalmayalım
                performansı optimize edebilelim  */

        IQueryable<T> FindByCondition(bool trackChanges,Expression<Func<T,bool>> expression);

        /* Burada trackChanges kullanma sebebimiz yapılan
                değişiklikleri her zaman izlemek zorunda 
                    kalmayalım performansı optimize edebilelim  */

        void Update(T entity);

        void Delete(T entity);

        void Create(T entity);




    }
}
