using AutoMapper;
using HRManagementApp.Application.DTOs.AdminDTOs;
using HRManagementApp.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.AdminService
{
    public class AdminService : IAdminService
    {
        readonly IAdminRepository _adminRepository;
        readonly IMapper _mapper;

        public AdminService(IAdminRepository adminRepository,IMapper mapper)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }

        public Task Create(AdminCreateDTO adminCreateDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(AdminUpdateDTO adminUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }
}
