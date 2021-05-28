using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DonateBlood.Models;
using DonateBlood.Services.ServiceInterface;

namespace DonateBlood.Services.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private  AplicationDbContext _context;

        public Repository(AplicationDbContext context)
        {
           _context = context;


        }



        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }


        public IEnumerable<T> Find(Expression<System.Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
    }


}
