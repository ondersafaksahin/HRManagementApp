﻿using HRManagementApp.Domain.Entities.Concrete;
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

        public static void Seed(this ModelBuilder builder,HRDBContext database)
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
            Admin user = new Admin()
            {
                UserName = AdminEmail,
                NormalizedEmail = AdminEmail.ToUpper(),
                Email = AdminEmail,
                CreatedBy = "Admin",
                CreatedDate = DateTime.Now,
                NormalizedUserName = AdminEmail.ToUpper(),
                Id = Guid.Parse(AdminID),
                Status = Domain.Enums.Status.Active,
            };
            user.PasswordHash = new PasswordHasher<Admin>().HashPassword(user, AdminPassword);
            builder.Entity<Admin>().HasData(user);
            builder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid> { RoleId = Guid.Parse(AdminRoleID), UserId = Guid.Parse(AdminID) });

            //Seed Packages

            Package standart = new Package() { CreatedBy = "Admin", ID = 1, Currency = "$", Price = 10, DurationDays = 30, PackageName = "Standart", Status = Domain.Enums.Status.Active, ReleaseDate = DateTime.Now };
            Package business = new Package() { CreatedBy = "Admin", ID = 2, Currency = "$", Price = 20, DurationDays = 30, PackageName = "Business", Status = Domain.Enums.Status.Active, ReleaseDate = DateTime.Now };
            Package premium = new Package() { CreatedBy = "Admin", ID = 3, Currency = "$", Price = 30, DurationDays = 30, PackageName = "Premium", Status = Domain.Enums.Status.Active, ReleaseDate = DateTime.Now };
            var packages = new List<Package>() { standart, business, premium };
            builder.Entity<Package>().HasData(packages);
        }
    }
}
