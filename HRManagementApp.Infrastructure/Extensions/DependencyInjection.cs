using HRManagementApp.Domain.IRepositories;
using HRManagementApp.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Infrastructure.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
        {
            services.AddScoped<IAdvancePaymentRepository, AdvancePaymentRepository>();;
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IExpenseRepository, ExpenseRepository>();
            services.AddScoped<ILeaveRepository, LeaveRepository>();
            services.AddScoped<IPackageRepository, PackageRepository>();
            services.AddScoped<IShiftRepository, ShiftRepository>();
            return services;
        }
    }
}
