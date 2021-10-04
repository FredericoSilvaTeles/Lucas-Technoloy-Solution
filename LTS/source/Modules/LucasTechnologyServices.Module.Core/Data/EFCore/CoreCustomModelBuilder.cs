using LucasTechnologyService.Infrastructure.Data;
using LucasTechnologyServices.Module.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Data.EFCore
{
    public class CoreCustomModelBuilder : ICustomModelBuilder
    {
        
        public void Build(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppSetting>().ToTable("Core_AppSetting");
            modelBuilder.Entity<User>()
                .ToTable("Core_Users");
            modelBuilder.Entity<Role>()
                .ToTable("Core_Roles");
            modelBuilder.Entity<Customer>()
                .ToTable("Core_Customers");

            modelBuilder.Entity<IdentityUserClaim<long>>(b =>
            {
                b.HasKey(uc => uc.Id);
                b.ToTable("Core_UserClaim");
            });

            modelBuilder.Entity<IdentityRoleClaim<long>>(b =>
            {
                b.HasKey(rc => rc.Id);
                b.ToTable("Core_RoleClaim");
            });

            modelBuilder.Entity<UserRole>(b =>
            {
                b.HasKey(ur => new { ur.UserId, ur.RoleId });
                b.HasOne(ur => ur.Role).WithMany(x => x.Users).HasForeignKey(r => r.RoleId);
                b.HasOne(ur => ur.User).WithMany(x => x.Roles).HasForeignKey(u => u.UserId);
                b.ToTable("Core_userRoles");
            });

            modelBuilder.Entity<IdentityUserLogin<long>>(b =>
            {
                b.ToTable("Core_UserLogin");
            });

            modelBuilder.Entity<IdentityUserToken<long>>(b =>
            {
                b.ToTable("Core_UserToken");
            });

            modelBuilder.Entity<Entity>(e =>
            {
                e.HasKey(x => x.Id);
                e.Property(x => x.EntityId);
            });

            modelBuilder.Entity<Address>(x =>
            {
                x.HasOne(d => d.District)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict);
                x.HasOne(d => d.StateOrProvince)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict);

                x.HasOne(d => d.StateOrProvince)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict);

                x.HasOne(d => d.Country)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Restrict);
            });


            CoreSeedData.SeedData(modelBuilder);
        }

       
    }
}
