using AutoMapper;
using HRManagementApp.Application.DTOs.ManagerDTOs;
using HRManagementApp.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.ManagerService
{
    public class ManagerService : IManagerService
    {
        IManagerRepository _managerRepository;
        IMapper _mapper;

        public ManagerService(IManagerRepository managerRepository, IMapper mapper)
        {
            _managerRepository = managerRepository;
            _mapper = mapper;
        }

        public Task Create(ManagerCreateDTO managerCreateDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ManagerListDTO>> List()
        {
            throw new NotImplementedException();
        }

        public Task Update(ManagerUpdateDTO managerUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }
}
