using AutoMapper;
using HRManagementApp.Application.DTOs.ManagerDTOs;
using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.IRepositories;
using Microsoft.AspNetCore.Identity;
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

        public async Task Create(ManagerCreateDTO managerCreateDTO)
        {
            await _managerRepository.Add(_mapper.Map<Manager>(managerCreateDTO));
        }

        public async Task Delete(Guid id)
        {
            await _managerRepository.Delete(await _managerRepository.GetBy(x => x.ID == id));
        }

        public async Task<List<ManagerListDTO>> List()
        {
            return _mapper.Map<List<ManagerListDTO>>(await _managerRepository.GetAll());
        }

        public async Task Update(ManagerUpdateDTO managerUpdateDTO)
        {
            await _managerRepository.Update(_mapper.Map<Manager>(managerUpdateDTO));
        }
    }
}
