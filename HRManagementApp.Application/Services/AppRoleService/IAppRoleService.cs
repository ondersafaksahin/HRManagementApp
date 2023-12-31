﻿using HRManagementApp.Application.DTOs.AdminDTOs;
using HRManagementApp.Application.DTOs.AppRoleDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.AppRoleService
{
    public interface IAppRoleService:IBaseService<AppRoleCreateDTO, AppRoleUpdateDTO, AppRoleListDTO, Guid>
    {
    }
}
