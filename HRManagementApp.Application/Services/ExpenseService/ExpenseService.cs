using AutoMapper;
using HRManagementApp.Application.DTOs.ExpenseDTOs;
using HRManagementApp.Domain.Entities.Concrete;
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

        public async Task Create(ExpenseCreateDTO expenseCreateDTO)
        {
            await _expenseRepository.Add(_mapper.Map<Expense>(expenseCreateDTO));
        }

        public async Task Delete(int id)
        {
            await _expenseRepository.Delete(await _expenseRepository.GetBy(x => x.ID == id));
        }

        public async Task<List<ExpenseListDTO>> List()
        {
            return _mapper.Map<List<ExpenseListDTO>>(await _expenseRepository.GetAll());
        }

        public async Task Update(ExpenseUpdateDTO expenseUpdateDTO)
        {
            await _expenseRepository.Update(_mapper.Map<Expense>(expenseUpdateDTO));
        }
    }
}
