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
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.AppUserService
{
    public class AppUserService : IAppUserService
    {
        IMapper _mapper;
        UserManager<AppUser> _userManager;
        SignInManager<AppUser> _signInManager;
        ICompanyRepository _companyRepository;
        PasswordHasher<AppUser> _passwordHasher;
        PasswordValidator<AppUser> _passwordValidator;

        public AppUserService(IMapper mapper, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ICompanyRepository companyRepository, PasswordHasher<AppUser> passwordHasher, PasswordValidator<AppUser> passwordValidator)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _companyRepository = companyRepository;
            _passwordHasher = passwordHasher;
        }

        public async Task AddToRole(AppUserDTO appUserDTO, string role)
        {
            await _userManager.AddToRoleAsync(_mapper.Map<AppUser>(appUserDTO), role);
        }

        public async Task<IdentityResult> ChangePassword(ChangePasswordDTO changePasswordDTO)
        {
            var appUser = await _userManager.FindByEmailAsync(changePasswordDTO.Email);
            var result = _userManager.PasswordHasher.VerifyHashedPassword(appUser, appUser.PasswordHash, changePasswordDTO.CurrentPassword);

            if (result==PasswordVerificationResult.Success && changePasswordDTO.NewPassword1==changePasswordDTO.NewPassword2)
            {
                return await _userManager.ChangePasswordAsync(appUser, changePasswordDTO.CurrentPassword, changePasswordDTO.NewPassword1);
            }
            return IdentityResult.Failed(new IdentityError { Description = "Please check your input" });
        }

        public Task ForgotPassword(ForgotPasswordDTO forgotPasswordDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<AppUserDTO> GetByID(Guid id)
        {
            return _mapper.Map<AppUserDTO>(await _userManager.FindByIdAsync(id.ToString())); 
        }

        public async Task<AppUserDTO> GetByUsername(string email)
        {
            return _mapper.Map<AppUserDTO>(await _userManager.FindByEmailAsync(email));
        }

        public async Task<List<AppUserListDTO>> List()
        {
            return _mapper.Map<List<AppUserListDTO>>(await _userManager.Users.ToListAsync());
        }

        public async Task<SignInResult> Login(LoginDTO loginDTO)
        {
            return await _signInManager.PasswordSignInAsync(loginDTO.Email, loginDTO.Password, true,false);
        }

        public async Task LogOut()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<string> MailGenerator(string userIdentifier,string domainExtension)
        {
            return await Task.FromResult(string.Concat(userIdentifier,'@',domainExtension));
        }

        public async Task<string> PasswordGenerator()
        {
            Random random = new Random();
            string password = "";
            const string uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowercaseLetters = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            for (int i = 0; i < 3; i++)
            {
                password += uppercaseLetters[random.Next(uppercaseLetters.Length)];
                password += lowercaseLetters[random.Next(lowercaseLetters.Length)];
                password += digits[random.Next(digits.Length)];
            }
            char[] result = password.ToCharArray();
            int n = result.Length;

            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                char temp = result[i];
                result[i] = result[j];
                result[j] = temp;
            }

            return await Task.FromResult(string.Concat(result));
        }

        public async Task<IdentityResult> Register(RegisterDTO registerDTO)
        {
            IdentityResult result;
            var user = (Employee)_mapper.Map<AppUser>(registerDTO);
            user.CreatedBy = registerDTO.UserName;
            user.CreatedDate = DateTime.Now;
            user.UserName = registerDTO.Email;
            user.NormalizedEmail = registerDTO.Email.ToUpper();
            user.NormalizedUserName = user.NormalizedEmail;

            if (registerDTO.Password1 != registerDTO.Password2)
            {
                result = IdentityResult.Failed(new IdentityError { Description = "Passwords do not match" });
                return result; 
            }

            user.Company = await _companyRepository.GetBy(x => x.ID == registerDTO.CompanyID);
            result = await _userManager.CreateAsync(user, registerDTO.Password1);
            await _userManager.AddToRoleAsync(user, "Employee");
            await _signInManager.SignInAsync(user, true);
            return result;
        }
    }
}
