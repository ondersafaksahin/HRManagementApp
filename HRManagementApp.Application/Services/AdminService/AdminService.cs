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
        readonly IMapper _mapper;
        readonly UserManager<AppUser> _userManager;

        public AdminService(IMapper mapper, UserManager<AppUser> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task Create(AdminCreateDTO adminCreateDTO)
        {
            Admin admin = _mapper.Map<Admin>(adminCreateDTO);
            var result = await _userManager.CreateAsync(admin);
            await _userManager.AddToRoleAsync(admin, "Admin");
        }

        public async Task Delete(Guid id)
        {
            await _userManager.DeleteAsync(await _userManager.FindByIdAsync(id.ToString()));
        }

        public async Task<List<AdminListDTO>> List()
        {
            IList<AppUser> adminList = await _userManager.GetUsersInRoleAsync("Admin");

            return _mapper.Map<List<AdminListDTO>>(adminList);
        }

        public async Task Update(AdminUpdateDTO adminUpdateDTO)
        {
            await _userManager.UpdateAsync(_mapper.Map<Admin>(adminUpdateDTO));
        }
    }
}
