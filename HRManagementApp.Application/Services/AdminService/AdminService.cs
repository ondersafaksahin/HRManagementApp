using AutoMapper;
using HRManagementApp.Application.DTOs.AdminDTOs;
using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.IRepositories;
using Microsoft.AspNetCore.Identity;
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
        readonly UserManager<AppUser> _userManager;

        public AdminService(IAdminRepository adminRepository,IMapper mapper,UserManager<AppUser> userManager)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task Create(AdminCreateDTO adminCreateDTO)
        {
            Admin admin = _mapper.Map<Admin>(adminCreateDTO);
            await _adminRepository.Add(admin);
        }

        public async Task Delete(Guid id)
        {
            await _adminRepository.Delete(await _adminRepository.GetBy(x => x.ID == id));
        }

        public async Task<List<AdminListDTO>> List()
        {
            List<Admin> adminList = await _adminRepository.GetAll();

            return _mapper.Map<List<AdminListDTO>>(adminList);
        }

        public async Task Update(AdminUpdateDTO adminUpdateDTO)
        {
            await _adminRepository.Update(_mapper.Map<Admin>(adminUpdateDTO));
        }
    }
}
