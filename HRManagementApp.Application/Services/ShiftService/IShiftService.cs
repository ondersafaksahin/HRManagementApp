using HRManagementApp.Application.DTOs.ExpenseDTOs;
using HRManagementApp.Application.DTOs.ShiftDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.ShiftService
{
    public interface IShiftService:IBaseService<ShiftCreateDTO,ShiftUpdateDTO,ShiftListDTO,int>
    {
    }
}
