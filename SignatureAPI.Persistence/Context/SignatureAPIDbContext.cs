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

            modelBuilder.Entity<SignatureAsset>()
                .HasOne(a=>a.Signature)
                .WithMany(s=>s.SignatureAssets)
                .HasForeignKey(a => a.SignatureId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SignatureLink>()
                .HasOne(l => l.Signature)
                .WithMany(s => s.SignatureLinks)
                .HasForeignKey(l => l.SignatureId)
                .OnDelete(DeleteBehavior.Cascade);

          
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
