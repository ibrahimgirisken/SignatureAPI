using Microsoft.EntityFrameworkCore;
using SignatureAPI.Application.Repositories;
using SignatureAPI.Domain.Entities.Common;
using SignatureAPI.Persistence.Context;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SignatureAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly SignatureAPIDbContext _context;

        public ReadRepository(SignatureAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query=Table.AsQueryable();
            if (!tracking)
                return Table.AsNoTracking();
            return query;
        }

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();

            return await query.FirstOrDefaultAsync(e=>e.Id==Guid.Parse(id));
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query=Table.Where(method);
            if (!tracking)
                query = Table.AsNoTracking();
                return query;
        }
    }
}
