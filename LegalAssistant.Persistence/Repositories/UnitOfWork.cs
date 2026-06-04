using LegalAssistant.Application.Interfaces;
using LegalAssistant.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Persistence.Repositories
{
    public sealed class UnitOfWork
        : IUnitOfWork
    {
        private readonly AppDbContext _db;

        public UnitOfWork(
            AppDbContext db)
        {
            _db = db;
        }

        public async Task<int> SaveChangesAsync(
            CancellationToken ct)
        {
            return await _db.SaveChangesAsync(ct);
        }
    }
}
