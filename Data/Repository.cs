using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Data
{
    public class Repository : IRepository
    {
        private readonly AppDBContext context;

        public Repository(AppDBContext context)
        {
            this.context = context;
        }

        public IQueryable<Country> FindAsync(Expression<Func<Country, bool>> expression, bool trackChanges = false) => 
            trackChanges ?
                  context.Set<Country>().Where(expression) :
                  context.Set<Country>().Where(expression).AsNoTracking();
    }
}
