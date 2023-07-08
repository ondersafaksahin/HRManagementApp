using HRManagementApp.Application.DTOs.ExpenseDTOs;
using HRManagementApp.Application.DTOs.ManagerDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.ManagerService
{
    public interface IManagerService:IBaseService<ManagerCreateDTO,ManagerUpdateDTO,ManagerListDTO,Guid>
    {
    }
}
