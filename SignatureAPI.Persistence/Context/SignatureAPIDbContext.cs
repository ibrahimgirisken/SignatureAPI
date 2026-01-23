using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SignatureAPI.Domain.Entities.Common;
using SignatureAPI.Domain.Entities.Company;
using SignatureAPI.Domain.Entities.CompanyComponent;
using SignatureAPI.Domain.Entities.Identity;


namespace SignatureAPI.Persistence.Context
{
    public class SignatureAPIDbContext: IdentityDbContext<AppUser,IdentityRole<Guid>,Guid>
    {
        public SignatureAPIDbContext(DbContextOptions<SignatureAPIDbContext> options) : base(options) { }

        public DbSet<Company> Companies{ get; set; }
        public DbSet<CompanyComponent> CompanyComponents{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            const int keyLen = 191;
            const int loginProviderLen = 64;
            const int providerKeyLen = 128;
            const int tokenNameLen = 128;
            const int normLen = 128;

            modelBuilder.Entity<IdentityRole<Guid>>(entity =>
            {
                entity.Property(r => r.Id).HasMaxLength(keyLen);
                entity.Property(r => r.Name).HasMaxLength(normLen);
                entity.Property(r => r.NormalizedName).HasMaxLength(normLen);
            });

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.Property(u => u.Id).HasMaxLength(keyLen);
                entity.Property(u => u.UserName).HasMaxLength(normLen);
                entity.Property(u => u.NormalizedUserName).HasMaxLength(normLen);
                entity.Property(u => u.Email).HasMaxLength(normLen);
                entity.Property(u => u.NormalizedEmail).HasMaxLength(normLen);
            });

            modelBuilder.Entity<IdentityUserLogin<Guid>>(entity =>
            {
                entity.Property(l => l.LoginProvider).HasMaxLength(loginProviderLen);
                entity.Property(l => l.ProviderKey).HasMaxLength(providerKeyLen);
                entity.Property(l => l.UserId).HasMaxLength(keyLen);
                entity.Property(l => l.ProviderDisplayName).HasMaxLength(normLen);
            });

            modelBuilder.Entity<IdentityUserToken<Guid>>(entity =>
            {
                entity.Property(t => t.LoginProvider).HasMaxLength(loginProviderLen);
                entity.Property(t => t.Name).HasMaxLength(tokenNameLen);
                entity.Property(t => t.UserId).HasMaxLength(keyLen);
            });

            modelBuilder.Entity<IdentityUserClaim<Guid>>(entity =>
            {
                entity.Property(c => c.UserId).HasMaxLength(keyLen);
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>(entity =>
            {
                entity.Property(r => r.UserId).HasMaxLength(keyLen);
                entity.Property(r => r.RoleId).HasMaxLength(keyLen);
            });

            modelBuilder.Entity<IdentityRoleClaim<Guid>>(entity =>
            {
                entity.Property(r => r.RoleId).HasMaxLength(keyLen);
            });

            modelBuilder.Entity<Company>()
                .HasMany(c=>c.CompanyComponents)
                .WithOne(s => s.Company)
                .HasForeignKey(s=>s.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CompanyComponent>()
                .HasOne(c=>c.Company)
                .WithMany(Company => Company.CompanyComponents)
                .HasForeignKey(c => c.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas=ChangeTracker
                .Entries<BaseEntity>();

            foreach (var data in datas)
            {
                if (data.State == EntityState.Added)
                    data.Entity.CreatedDate = DateTime.UtcNow;

                if (data.State == EntityState.Modified)
                    data.Entity.UpdatedDate = DateTime.UtcNow;
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
