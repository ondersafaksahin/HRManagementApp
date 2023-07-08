using HRManagementApp.Application.DTOs.CompanyDTOs;
using HRManagementApp.Application.DTOs.EmployeeDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.EmployeeService
{
    public interface IEmployeeService:IBaseService<EmployeeCreateDTO,EmployeeUpdateDTO,EmployeeListDTO,Guid>
    {
    }
}
