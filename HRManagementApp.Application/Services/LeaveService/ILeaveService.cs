using HRManagementApp.Application.DTOs.ExpenseDTOs;
using HRManagementApp.Application.DTOs.LeaveDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.LeaveService
{
    public interface ILeaveService:IBaseService<LeaveCreateDTO,LeaveUpdateDTO,LeaveListDTO,int>
    {
      
    }
}
