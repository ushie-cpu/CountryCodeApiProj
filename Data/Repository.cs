using Entity.Models;
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

        public IQueryable<Country> FindAsync(Expression<Func<Country, bool>> expression) =>
            context.Set().Where(expression);
           
    }
}
