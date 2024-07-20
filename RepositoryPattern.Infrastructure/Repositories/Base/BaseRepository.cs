using RepositoryPattern.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace RepositoryPattern.Infrastructure.Repositories.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository()
        {
            _context = new AppDbContext() ?? throw new ArgumentNullException(nameof(_context));
            _dbSet = _context.Set<T>();
        }

        public bool Add(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _dbSet.Add(entity);
            return SaveChanges();
        }

        public bool Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _dbSet.Remove(entity);
            return SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            if (expression == null)
                throw new ArgumentNullException(nameof(expression));

            return _dbSet.FirstOrDefault(expression);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            if (expression == null)
                throw new ArgumentNullException(nameof(expression));

            return _dbSet.Where(expression).AsNoTracking().ToList();
        }

        public T Get(Guid id)
        {
            return _dbSet.Find(id);
        }

        public bool Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            _dbSet.Update(entity);
            return SaveChanges();
        }

        private bool SaveChanges()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (DbUpdateException ex)
            {

                throw new Exception("Database update error occurred.", ex);
            }
            catch (Exception ex)
            {

                throw new Exception("An unexpected error occurred.", ex);
            }
        }
    }
}
