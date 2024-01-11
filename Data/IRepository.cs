using Entity.Models;
using System.Linq.Expressions;

namespace Data
{
    public interface IRepository
    {
        IQueryable<Country> FindAsync(Expression<Func<Country, bool>> expression);
    }
}
