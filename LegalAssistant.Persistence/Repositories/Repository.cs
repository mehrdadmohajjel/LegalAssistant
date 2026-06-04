using LegalAssistant.Application.Interfaces;
using LegalAssistant.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Persistence.Repositories
{
    public sealed class Repository<T>
        : IRepository<T>
        where T : class
    {
        private readonly AppDbContext _db;

        public Repository(
            AppDbContext db)
        {
            _db = db;
        }

        public async Task<T?> GetByIdAsync(
            object id,
            CancellationToken ct)
        {
            return await _db.Set<T>()
                .FindAsync([id], ct);
        }

        public async Task<List<T>> GetAllAsync(
            CancellationToken ct)
        {
            return await _db.Set<T>()
                .ToListAsync(ct);
        }

        public async Task AddAsync(
            T entity,
            CancellationToken ct)
        {
            await _db.Set<T>()
                .AddAsync(entity, ct);
        }

        public void Update(T entity)
        {
            _db.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
        }
    }
}
