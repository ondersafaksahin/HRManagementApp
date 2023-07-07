using HRManagementApp.Application.DTOs.AdminDTOs;
using HRManagementApp.Application.DTOs.AppRoleDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.AppRoleService
{
    public interface IAppRoleService
    {
        Task Create(AppRoleCreateDTO appRoleCreateDTO);
        Task Update(AppRoleUpdateDTO appRoleUpdateDTO);
        Task Delete(Guid id);
    }
}
