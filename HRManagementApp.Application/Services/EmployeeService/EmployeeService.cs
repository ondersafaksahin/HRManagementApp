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
        IEmployeeRepository _employeRepository;
        IMapper _mapper;
        UserManager<AppUser> _userManager;

        public EmployeeService(IEmployeeRepository employeRepository, IMapper mapper, UserManager<AppUser> userManager)
        {
            _employeRepository = employeRepository;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task Create(EmployeeCreateDTO employeeCreateDTO)
        {
           await _employeRepository.Add(_mapper.Map<Employee>(employeeCreateDTO));
        }

        public async Task Delete(Guid id)
        {
            await _employeRepository.Delete(await _employeRepository.GetBy(x => x.ID == id));
        }

        public async Task<List<EmployeeListDTO>> List()
        {
            return _mapper.Map<List<EmployeeListDTO>>(await _employeRepository.GetAll());
        }

        public async Task Update(EmployeeUpdateDTO employeeUpdateDTO)
        {
            await _employeRepository.Update(_mapper.Map<Employee>(employeeUpdateDTO));
        }
    }
}
