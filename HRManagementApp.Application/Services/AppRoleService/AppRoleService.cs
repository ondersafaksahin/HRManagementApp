using AutoMapper;
using HRManagementApp.Application.DTOs.AppRoleDTOs;
using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.IRepositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.AppRoleService
{
    public class AppRoleService : IAppRoleService
    {
        RoleManager<AppRole> _roleManager;
        IMapper _mapper;

        public AppRoleService(RoleManager<AppRole> roleManager, IMapper mapper)
        {
            _mapper = mapper;
            _roleManager = roleManager;
        }
        public async Task Create(AppRoleCreateDTO appRoleCreateDTO)
        {
            await _roleManager.CreateAsync(_mapper.Map<AppRole>(appRoleCreateDTO));
        }

        public async Task Delete(Guid id)
        {
            await _roleManager.DeleteAsync(await _roleManager.FindByIdAsync(id.ToString()));
        }

        public async Task<List<AppRoleListDTO>> List()
        {
            return _mapper.Map<List<AppRoleListDTO>>(await _roleManager.Roles.ToListAsync());
        }

        public async Task Update(AppRoleUpdateDTO appRoleUpdateDTO)
        {
            await _roleManager.UpdateAsync(_mapper.Map<AppRole>(appRoleUpdateDTO));
        }
    }
}
