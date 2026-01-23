using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SignatureAPI.Application.Repositories;
using SignatureAPI.Domain.Entities.Common;
using SignatureAPI.Persistence.Context;


namespace SignatureAPI.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        readonly SignatureAPIDbContext _context;

        public WriteRepository(SignatureAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();
        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry=await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> list)
        {
            await Table.AddRangeAsync(list);
            return true;
        }

        public bool Remove(T model)
        {
            EntityEntry<T> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            var data=await Table.FirstOrDefaultAsync(e => e.Id ==id);
            if (data == null)
                return false;
            Table.Remove(data);
            return true;
        }

        public bool RemoveRange(List<T> list)
        {
            Table.UpdateRange(list);
            return true;
        }

        public bool Update(T model)
        {
            var entry=_context.Entry(model);
            if(entry.State==EntityState.Detached)
                Table.Attach(model);
            entry.State = EntityState.Modified;
            return true;
        }
        public async Task<int> SaveAsync()
        {
            using(var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var result =await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return result;
                }
                catch
                {
                    await transaction.RollbackAsync();
                    throw;
                }
            }
        }
    }
}
