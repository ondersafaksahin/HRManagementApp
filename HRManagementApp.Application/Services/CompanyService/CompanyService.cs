using AutoMapper;
using HRManagementApp.Application.DTOs.CompanyDTOs;
using HRManagementApp.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.CompanyService
{
    public class CompanyService : ICompanyService
    {
        ICompanyRepository _companyRepository;
        IMapper _mapper;

        public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public Task Create(CompanyCreateDTO companyCreateDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CompanyListDTO>> List()
        {
            throw new NotImplementedException();
        }

        public Task Update(CompanyUpdateDTO companyUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }
}
