using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAPI.Persistence.Context
{
    public class SignatureAPIDbContextFactory : IDesignTimeDbContextFactory<SignatureAPIDbContext>
    {
        public SignatureAPIDbContext CreateDbContext(string[] args)
        {
            var cs = Configuration.ConnectionString;

            var optionsBuilder = new DbContextOptionsBuilder<SignatureAPIDbContext>();
            optionsBuilder.UseMySql(cs, ServerVersion.AutoDetect(cs));

            return new SignatureAPIDbContext(optionsBuilder.Options);
        }
    }
}
