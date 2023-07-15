using HRManagementApp.Application.DTOs.AppUserDTOs;
using HRManagementApp.Application.DTOs.CompanyDTOs;
using HRManagementApp.Domain.Entities.Abstract;
using HRManagementApp.Domain.Entities.Concrete;
using Microsoft.AspNetCore.Http.Features.Authentication;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.AppUserService
{
    public interface IAppUserService
    {
        Task<SignInResult> Login(LoginDTO loginDTO);
        Task<IdentityResult> Register(RegisterDTO registerDTO);
        Task ForgotPassword(ForgotPasswordDTO forgotPasswordDTO);
        Task<string> ChangePassword(ChangePasswordDTO changePasswordDTO);
        Task AddToRole(AppUserDTO appUserDTO,string role);
        Task<List<AppUserListDTO>>List();
        Task LogOut();
        Task<AppUserDTO> GetByUsername(string email);
        Task<AppUserDTO> GetByID(Guid id);
    }
}
