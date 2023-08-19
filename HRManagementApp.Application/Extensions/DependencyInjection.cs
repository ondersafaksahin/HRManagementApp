using HRManagementApp.Application.Services.AdminService;
using HRManagementApp.Application.Services.AdvancePaymentService;
using HRManagementApp.Application.Services.AppRoleService;
using HRManagementApp.Application.Services.AppUserService;
using HRManagementApp.Application.Services.CompanyService;
using HRManagementApp.Application.Services.EmployeeService;
using HRManagementApp.Application.Services.ExpenseService;
using HRManagementApp.Application.Services.LeaveService;
using HRManagementApp.Application.Services.PackageService;
using HRManagementApp.Application.Services.ShiftService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAdvancePaymentService, AdvancePaymentService>();
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IExpenseService, ExpenseService>();
            services.AddScoped<ILeaveService, LeaveService>();
            services.AddScoped<IPackageService, PackageService>();
            services.AddScoped<IShiftService, ShiftService>();

            return services;
        }
    }
}
