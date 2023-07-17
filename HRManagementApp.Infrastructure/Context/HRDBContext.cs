using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Infrastructure.Mapping;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HRManagementApp.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Infrastructure.Context
{
    public class HRDBContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public HRDBContext(DbContextOptions<HRDBContext> options) : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<AdvancePayment> AdvancePayments { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Leave> Leaves { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Manager> Managers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AdminMapping());
            builder.ApplyConfiguration(new AdvancePaymentMapping());
            builder.ApplyConfiguration(new CompanyMapping());
            builder.ApplyConfiguration(new EmployeeMapping());
            builder.ApplyConfiguration(new ExpenseMapping());
            builder.ApplyConfiguration(new LeaveMapping());
            builder.ApplyConfiguration(new ManagerMapping());
            builder.ApplyConfiguration(new PackageMapping());
            builder.ApplyConfiguration(new ShiftMapping());
            builder.Seed(this);
            base.OnModelCreating(builder);
        }
    }
}
