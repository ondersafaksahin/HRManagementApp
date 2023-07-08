using AutoMapper;
using HRManagementApp.Application.DTOs.AppRoleDTOs;
using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.AppRoleService
{
    public class AppRoleService : IAppRoleService
    {
        IAppRoleRepository _appRoleRepository;
        IMapper _mapper;

        public AppRoleService(IAppRoleRepository appRoleRepository, IMapper mapper)
        {
            _mapper = mapper;
            _appRoleRepository = appRoleRepository;
        }
        public async Task Create(AppRoleCreateDTO appRoleCreateDTO)
        {
            await _appRoleRepository.Add(_mapper.Map<AppRole>(appRoleCreateDTO));
        }

        public async Task Delete(Guid id)
        {
            await _appRoleRepository.Delete(await _appRoleRepository.GetBy(x => x.Id == id));
        }

        public async Task<List<AppRoleListDTO>> List()
        {
            return _mapper.Map<List<AppRoleListDTO>>(await _appRoleRepository.GetAll());
        }

        public async Task Update(AppRoleUpdateDTO appRoleUpdateDTO)
        {
            await _appRoleRepository.Update(_mapper.Map<AppRole>(appRoleUpdateDTO));
        }
    }
}
