using LucasTechnologyService.Infrastructure;
using LucasTechnologyServices.Module.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Data.EFCore
{
    public class LTS1DbCbContext : IdentityDbContext<User, Role, long, IdentityUserClaim<long>, UserRole, IdentityUserLogin<long>, IdentityRoleClaim<long>, IdentityUserToken<long>>
    {
        public LTS1DbCbContext(DbContextOptions options) : base(options)
        {

        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            ValidateEntities();
            return base.SaveChanges(acceptAllChangesOnSuccess);

        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            ValidateEntities();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Type> typeToRegisters = new List<Type>();
            foreach (var module in GlobalConfiguration.Modules)
            {
                typeToRegisters.AddRange(module.Assembly.DefinedTypes.Select(t => t.AsType()));
            }

            RegisterEntities(modelBuilder, typeToRegisters);
            RegisterConvertion(modelBuilder);
            base.OnModelCreating(modelBuilder);

            RegisterCustomMappings(modelBuilder, typeToRegisters);
        }

        private void RegisterCustomMappings(ModelBuilder modelBuilder, List<Type> typeToRegisters)
        {
            throw new NotImplementedException();
        }

        private void RegisterConvertion(ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }

        private void RegisterEntities(ModelBuilder modelBuilder, List<Type> typeToRegisters)
        {
            throw new NotImplementedException();
        }

        private void ValidateEntities()
        {
            throw new NotImplementedException();
        }
    }
}
