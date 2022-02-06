using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hahn.CarRental.Application.Contracts.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);

        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entity);

        T GetById(object id);

        IReadOnlyList<T> GetAll();

        Task<IReadOnlyList<T>> GetAllAsync();

        void Attach(T entity);

        void AttachRange(IEnumerable<T> entities);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);

        void Update(T entity);

        void UpdateRange(IEnumerable<T> entities);

        IQueryable<T> GetQuery();

    }
}
