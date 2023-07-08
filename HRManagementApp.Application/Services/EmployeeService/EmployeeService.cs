using AutoMapper;
using HRManagementApp.Application.DTOs.EmployeeDTOs;
using HRManagementApp.Domain.IRepositories;
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

        public EmployeeService(IEmployeeRepository employeRepository, IMapper mapper)
        {
            _employeRepository = employeRepository;
            _mapper = mapper;
        }

        public Task Create(EmployeeCreateDTO employeeCreateDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<EmployeeListDTO>> List()
        {
            throw new NotImplementedException();
        }

        public Task Update(EmployeeUpdateDTO employeeUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }
}
