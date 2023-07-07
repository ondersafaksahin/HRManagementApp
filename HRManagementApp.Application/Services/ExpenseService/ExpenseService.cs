using AutoMapper;
using HRManagementApp.Application.DTOs.ExpenseDTOs;
using HRManagementApp.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.ExpenseService
{
    public class ExpenseService : IExpenseService
    {
        IExpenseRepository _expenseRepository;
        IMapper _mapper;
        public ExpenseService(IExpenseRepository expenseRepository,IMapper mapper)
        {
            _expenseRepository = expenseRepository;
            _mapper = mapper;
        }

        public Task Create(ExpenseCreateDTO expenseCreateDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(ExpenseUpdateDTO expenseUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }
}
