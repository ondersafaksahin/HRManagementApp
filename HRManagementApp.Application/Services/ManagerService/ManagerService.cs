using AutoMapper;
using HRManagementApp.Application.DTOs.EmployeeDTOs;
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
        UserManager<Manager> _userManager;
        IMapper _mapper;

        public ManagerService(UserManager<Manager> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task Create(ManagerCreateDTO managerCreateDTO)
        {
            var manager = _mapper.Map<Manager>(managerCreateDTO);
            await _userManager.CreateAsync(manager);
            await _userManager.AddToRoleAsync(manager, "Manager");
        }

        public async Task Delete(Guid id)
        {
            await _userManager.DeleteAsync(await _userManager.FindByIdAsync(id.ToString()));
        }

        public async Task<List<ManagerListDTO>> List()
        {
            var managerList = await _userManager.GetUsersInRoleAsync("Manager");
            return _mapper.Map<List<ManagerListDTO>>(managerList);
        }

        public async Task Update(ManagerUpdateDTO managerUpdateDTO)
        {
            await _userManager.UpdateAsync(_mapper.Map<Manager>(managerUpdateDTO));
        }
    }
}
