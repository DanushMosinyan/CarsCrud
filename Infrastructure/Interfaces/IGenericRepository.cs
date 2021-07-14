using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task Add(string query, object param);
        Task<T> GetById(string query, object param);
        Task<IEnumerable<T>> GetAll(string query);
        Task Delete(string query, object param);
        Task Update(string query, object param);
    }
}
