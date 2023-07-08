using HRManagementApp.Application.DTOs.AdminDTOs;
using HRManagementApp.Application.DTOs.CompanyDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.CompanyService
{
    public interface ICompanyService:IBaseService<CompanyCreateDTO,CompanyUpdateDTO,CompanyListDTO,Guid>
    {
    }
}
