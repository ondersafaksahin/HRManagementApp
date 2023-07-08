using AutoMapper;
using HRManagementApp.Application.DTOs.AppRoleDTOs;
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
        public Task Create(AppRoleCreateDTO appRoleCreateDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AppRoleListDTO>> List()
        {
            throw new NotImplementedException();
        }

        public Task Update(AppRoleUpdateDTO appRoleUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }
}
