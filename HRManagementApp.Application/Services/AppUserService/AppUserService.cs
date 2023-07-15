using AutoMapper;
using HRManagementApp.Application.DTOs.AppUserDTOs;
using HRManagementApp.Application.DTOs.CompanyDTOs;
using HRManagementApp.Domain.Entities.Abstract;
using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.IRepositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.AppUserService
{
    public class AppUserService : IAppUserService
    {
        IAppUserRepository _appUserRepository;
        IMapper _mapper;
        UserManager<AppUser> _userManager;
        SignInManager<AppUser> _signInManager;
        IEmployeeRepository _employeeRepository;
        ICompanyRepository _companyRepository;

        public AppUserService(IAppUserRepository appUserRepository, IMapper mapper, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IEmployeeRepository employeeRepository, ICompanyRepository companyRepository)
        {
            _appUserRepository = appUserRepository;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _employeeRepository = employeeRepository;
            _companyRepository = companyRepository;
        }

        public async Task AddToRole(AppUserDTO appUserDTO, string role)
        {
            await _userManager.AddToRoleAsync(_mapper.Map<AppUser>(appUserDTO), role);
        }

        public async Task<string> ChangePassword(ChangePasswordDTO changePasswordDTO)
        {
            var appUser = await _appUserRepository.GetBy(x => x.Email == changePasswordDTO.Email);
            PasswordVerificationResult result = _userManager.PasswordHasher.VerifyHashedPassword(appUser, appUser.PasswordHash, changePasswordDTO.CurrentPassword);
            string answer;

            if (result==PasswordVerificationResult.Success && changePasswordDTO.NewPassword1==changePasswordDTO.NewPassword2)
            {
                answer = "Password has been successfully changed";
                await _userManager.ChangePasswordAsync(appUser, changePasswordDTO.CurrentPassword, changePasswordDTO.NewPassword1);
            }
            else
            {
                answer = "Password could not be changed. Please check your input";
            }
            return answer;
        }

        public Task ForgotPassword(ForgotPasswordDTO forgotPasswordDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<AppUserDTO> GetByID(Guid id)
        {
            return _mapper.Map<AppUserDTO>(await _appUserRepository.GetBy(x => x.Id == id)); 
        }

        public async Task<AppUserDTO> GetByUsername(string email)
        {
            return _mapper.Map<AppUserDTO>(await _appUserRepository.GetBy(x => x.Email==email));
        }

        public async Task<List<AppUserListDTO>> List()
        {
            return _mapper.Map<List<AppUserListDTO>>(await _appUserRepository.GetAll());
        }

        public async Task<SignInResult> Login(LoginDTO loginDTO)
        {
            return await _signInManager.PasswordSignInAsync(loginDTO.Email, loginDTO.PasswordHash, true,false);
        }

        public async Task LogOut()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<IdentityResult> Register(RegisterDTO registerDTO)
        {
            IdentityResult result;
            var user = _mapper.Map<AppUser>(registerDTO);
            user.CreatedBy = registerDTO.UserName;
            user.CreatedDate = DateTime.Now;
            user.UserName = registerDTO.Email;
            user.NormalizedEmail = registerDTO.Email.ToUpper();
            user.NormalizedUserName = user.NormalizedEmail;
            if (registerDTO.Password1 == registerDTO.Password2)
            {
                result = await _userManager.CreateAsync(user, registerDTO.Password1);
            }
            else 
            {
                result = IdentityResult.Failed();
            }
            if (result.Succeeded)
            {

                await _employeeRepository.Add(new Employee
                {
                    CompanyID = registerDTO.CompanyID,
                    CreatedDate = DateTime.Now,
                    ID = Guid.NewGuid(),
                    AppUser = await _appUserRepository.GetBy(x => x.Email == registerDTO.Email),
                    AppUserID = (await _appUserRepository.GetBy(x => x.Email == registerDTO.Email)).Id,
                    Company=await _companyRepository.GetBy(x=>x.ID==registerDTO.CompanyID)
                });
                await _signInManager.SignInAsync(user, true);
            }
            return result;
        }
    }
}
