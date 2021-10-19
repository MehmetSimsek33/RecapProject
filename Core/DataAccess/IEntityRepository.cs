using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //filtre vermeyedebilirsin
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        //filtre zorunlu Linq filtreleri yazmamıza olanak saglar
        T Get(Expression<Func<T, bool>> filter);
        void add(T entity);
        void delete(T entity);
        void update(T entity);
    }
}
