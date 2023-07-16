using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.IRepositories;
using HRManagementApp.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Infrastructure.Extensions
{
    public static class SeedData
    {
        private const string AdminEmail = "admin@hrmanagementapp.com";
        private const string AdminPassword = "Asd123.";
        private const string AdminID = "0031c609-4d45-4c50-bbee-278e9dd5ed73";
        private const string AdminRoleID = "6ee57077-8be1-4991-850d-fcb5a6960473";

        public static void Seed(ModelBuilder builder,HRDBContext database)
        {

            //Seed Roles
            List<AppRole> roles = new List<AppRole>
            {
                new AppRole
                {
                    Id = Guid.Parse(AdminRoleID),
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Status = Domain.Enums.Status.Active
                },
                new AppRole
                {
                    Id = Guid.NewGuid(),
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    Name = "Manager",
                    NormalizedName = "MANAGER",
                    Status = Domain.Enums.Status.Active
                },
                new AppRole
                {
                    Id = Guid.NewGuid(),
                    CreatedBy = "Admin",
                    CreatedDate = DateTime.Now,
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE",
                    Status = Domain.Enums.Status.Active
                }
            };
            builder.Entity<AppRole>().HasData(roles);

            // Seed Admin
            AppUser user = new()
            {
                UserName = AdminEmail,
                NormalizedEmail = AdminEmail.ToUpper(),
                Email = AdminEmail,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                NormalizedUserName = AdminEmail.ToUpper(),
                Id = Guid.Parse(AdminID),
                Status = Domain.Enums.Status.Active
            };
            user.PasswordHash = new PasswordHasher<AppUser>().HashPassword(user, AdminPassword);
            Admin admin = new()
            {
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                AppUserID = Guid.Parse(AdminID),
                ID = Guid.NewGuid(),
                FirstName = "Önder Şafak",
                LastName = "Şahin",
                Status = Domain.Enums.Status.Active,
            };
            builder.Entity<AppUser>().HasData(user);
            builder.Entity<Admin>().HasData(admin);
            database.UserRoles.AddAsync(new IdentityUserRole<Guid> { RoleId = Guid.Parse(AdminRoleID), UserId = Guid.Parse(AdminID) });
        }
    }
}
