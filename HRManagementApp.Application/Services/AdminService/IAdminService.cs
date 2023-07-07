﻿using HRManagementApp.Application.DTOs.AdminDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.AdminService
{
    public interface IAdminService
    {
        Task Create(AdminCreateDTO adminCreateDTO);
        Task Update(AdminUpdateDTO adminUpdateDTO);
        Task Delete(Guid id);
    }
}
