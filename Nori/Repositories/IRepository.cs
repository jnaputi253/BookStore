using System.Linq;

namespace Nori.Repositories
{
    public interface IRepository<out TModel> where TModel : class
    {
        IQueryable<TModel> GetAll();
    }
}
