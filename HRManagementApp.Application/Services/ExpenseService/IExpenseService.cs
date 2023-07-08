using HRManagementApp.Application.DTOs.AdminDTOs;
using HRManagementApp.Application.DTOs.ExpenseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.ExpenseService
{
    public interface IExpenseService:IBaseService<ExpenseCreateDTO,ExpenseUpdateDTO,ExpenseListDTO,int>
    {
    }
}
