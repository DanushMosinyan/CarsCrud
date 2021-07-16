using System.Data;
using System.Threading.Tasks;
using Infrastructure.Interfaces;
using Dapper;
using System.Collections.Generic;

namespace Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly IDbConnection _dbConnection;

        public GenericRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<int> Add(string query, object param = null)
        {
            return await _dbConnection.QuerySingleAsync<int>(query, param);
        }

        public async Task Delete(string query, object param = null)
        {
            await _dbConnection.ExecuteAsync(query, param);
        }

        public async Task<IEnumerable<T>> GetAll(string query)
        {
            var result = await _dbConnection.QueryAsync<T>(query);
            return result;
        }

        public async Task<T> GetById(string query, object param = null)
        {
            var result = await _dbConnection.QuerySingleAsync<T>(query, param);
            return result;
        }

        public async Task Put(string query, object param = null)
        {
            await _dbConnection.ExecuteAsync(query, param);
        }
    }
}
