using AutoMapper;
using HRManagementApp.Application.DTOs.AppUserDTOs;
using HRManagementApp.Presentation.Models;

namespace HRManagementApp.Presentation.AutoMapper
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<LoginDTO, LoginViewModel>().ReverseMap();
            CreateMap<RegisterDTO, RegisterViewModel>().ReverseMap();
        }
    }
}
