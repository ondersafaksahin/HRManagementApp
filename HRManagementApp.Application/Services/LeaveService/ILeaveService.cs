using HRManagementApp.Application.DTOs.ExpenseDTOs;
using HRManagementApp.Application.DTOs.LeaveDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.LeaveService
{
    public interface ILeaveService
    {
        Task Create(LeaveCreateDTO leaveCreateDTO);
        Task Update(LeaveUpdateDTO leaveUpdateDTO);
        Task Delete(int id);
    }
}
