using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<int> Post(string query, object param);
        Task<T> Get(string query, object param);
        Task<IEnumerable<T>> Get(string query);
        Task Delete(string query, object param);
        Task Put(string query, object param);
    }
}
