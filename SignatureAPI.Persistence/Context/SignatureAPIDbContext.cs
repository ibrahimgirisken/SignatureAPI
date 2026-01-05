using Microsoft.EntityFrameworkCore;
using SignatureAPI.Domain.Entities.Common;
using SignatureAPI.Domain.Entities.Company;
using SignatureAPI.Domain.Entities.Signature;
using SignatureAPI.Domain.Entities.Signature.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Persistence.Context
{
    public class SignatureAPIDbContext:DbContext
    {
        public SignatureAPIDbContext(DbContextOptions<SignatureAPIDbContext> options):base(options)
        {}
        public DbSet<Company> Companies{ get; set; }
        public DbSet<Signature> Signatures { get; set; }
        public DbSet<SignatureAsset> SignatureAssets { get; set; }
        public DbSet<SignatureLink> SignatureLinks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>()
                .HasOne(c=>c.Signature)
                .WithOne(s => s.Company)
                .HasForeignKey<Signature>(s=>s.CompanyId);

            modelBuilder.Entity<Signature>()
               .HasIndex(s => s.CompanyId)
               .IsUnique();

            modelBuilder.Entity<Signature>()
                .HasMany(s=>s.SignatureAssets)
                .WithOne(sa => sa.Signature)
                .HasForeignKey(sa => sa.SignatureId);

            modelBuilder.Entity<Signature>()
                .HasMany(s=>s.SignatureLinks)
                .WithOne(sl=>sl.Signature)
                .HasForeignKey(sl => sl.SignatureId);

            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas=ChangeTracker
                .Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
