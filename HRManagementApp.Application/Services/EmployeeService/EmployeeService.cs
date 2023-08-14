using AutoMapper;
using HRManagementApp.Application.DTOs.EmployeeDTOs;
using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.IRepositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        IMapper _mapper;
        UserManager<Employee> _userManager;

        public EmployeeService(IMapper mapper, UserManager<Employee> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task Create(EmployeeCreateDTO employeeCreateDTO)
        {
            var employee = _mapper.Map<Employee>(employeeCreateDTO);
            await _userManager.CreateAsync(employee);
            await _userManager.AddToRoleAsync(employee, "Employee");
        }

        public async Task Delete(Guid id)
        {
            await _userManager.DeleteAsync(await _userManager.FindByIdAsync(id.ToString()));
        }

        public async Task<List<EmployeeListDTO>> List()
        {
            var employeeList = await _userManager.GetUsersInRoleAsync("employee");
            return _mapper.Map<List<EmployeeListDTO>>(employeeList);
        }

        public async Task Update(EmployeeUpdateDTO employeeUpdateDTO)
        {
            await _userManager.UpdateAsync(_mapper.Map<Employee>(employeeUpdateDTO));
        }
    }
}
