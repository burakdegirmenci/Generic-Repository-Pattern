using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Infrastructure.Repositories.Base;

public interface IBaseRepository<T> where T : class
{
    bool Add(T entity);
    bool Delete(T entity);
    bool Update(T entity);
    T Get(Expression<Func<T, bool>> expression);
    IEnumerable<T> GetAll(Expression<Func<T, bool>> expression);
    T Get(Guid id);
}
