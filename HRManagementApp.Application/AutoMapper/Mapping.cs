using AutoMapper;
using HRManagementApp.Application.DTOs.AdminDTOs;
using HRManagementApp.Application.DTOs.AdvancePaymentDTOs;
using HRManagementApp.Application.DTOs.AppRoleDTOs;
using HRManagementApp.Application.DTOs.CompanyDTOs;
using HRManagementApp.Application.DTOs.EmployeeDTOs;
using HRManagementApp.Application.DTOs.ExpenseDTOs;
using HRManagementApp.Application.DTOs.LeaveDTOs;
using HRManagementApp.Application.DTOs.PackageDTOs;
using HRManagementApp.Application.DTOs.ShiftDTOs;
using HRManagementApp.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.AutoMapper
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Admin, AdminDTO>().ReverseMap();
            CreateMap<Admin, AdminCreateDTO>().ReverseMap();
            CreateMap<Admin, AdminUpdateDTO>().ReverseMap();
            CreateMap<Admin, AdminListDTO>().ReverseMap();

            CreateMap<AdvancePayment, AdvancePaymentDTO>().ReverseMap();
            CreateMap<AdvancePayment, AdvancePaymentCreateDTO>().ReverseMap();
            CreateMap<AdvancePayment, AdvancePaymentUpdateDTO>().ReverseMap();
            CreateMap<AdvancePayment, AdvancePaymentListDTO>().ReverseMap();

            CreateMap<AppRole, AppRoleDTO>().ReverseMap();
            CreateMap<AppRole, AppRoleCreateDTO>().ReverseMap();
            CreateMap<AppRole, AppRoleUpdateDTO>().ReverseMap();
            CreateMap<AppRole, AppRoleListDTO>().ReverseMap();

            CreateMap<Company, CompanyDTO>().ReverseMap();
            CreateMap<Company, CompanyCreateDTO>().ReverseMap();
            CreateMap<Company, CompanyUpdateDTO>().ReverseMap();
            CreateMap<Company, CompanyListDTO>().ReverseMap();

            CreateMap<Employee, EmployeeDTO>().ReverseMap();
            CreateMap<Employee, EmployeeCreateDTO>().ReverseMap();
            CreateMap<Employee, EmployeeUpdateDTO>().ReverseMap();
            CreateMap<Employee, EmployeeListDTO>().ReverseMap();

            CreateMap<Expense, ExpenseDTO>().ReverseMap();
            CreateMap<Expense, ExpenseCreateDTO>().ReverseMap();
            CreateMap<Expense, ExpenseUpdateDTO>().ReverseMap();
            CreateMap<Expense, ExpenseListDTO>().ReverseMap();

            CreateMap<Leave, LeaveDTO>().ReverseMap();
            CreateMap<Leave, LeaveCreateDTO>().ReverseMap();
            CreateMap<Leave, LeaveUpdateDTO>().ReverseMap();
            CreateMap<Leave, LeaveListDTO>().ReverseMap();

            CreateMap<Package, PackageDTO>().ReverseMap();
            CreateMap<Package, PackageCreateDTO>().ReverseMap();
            CreateMap<Package, PackageUpdateDTO>().ReverseMap();
            CreateMap<Package, PackageListDTO>().ReverseMap();

            CreateMap<Shift, ShiftDTO>().ReverseMap();
            CreateMap<Shift, ShiftCreateDTO>().ReverseMap();
            CreateMap<Shift, ShiftUpdateDTO>().ReverseMap();
            CreateMap<Shift, ShiftListDTO>().ReverseMap();
        }
    }
}
