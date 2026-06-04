using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Application.Interfaces
{
    public interface IRepository<T>
       where T : class
    {
        Task<T?> GetByIdAsync(
            object id,
            CancellationToken cancellationToken);

        Task<List<T>> GetAllAsync(
            CancellationToken cancellationToken);

        Task AddAsync(
            T entity,
            CancellationToken cancellationToken);

        void Update(T entity);

        void Delete(T entity);
    }
}
