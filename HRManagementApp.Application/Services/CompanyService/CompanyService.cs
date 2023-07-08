using AutoMapper;
using HRManagementApp.Application.DTOs.CompanyDTOs;
using HRManagementApp.Domain.Entities.Concrete;
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

        public async Task Create(CompanyCreateDTO companyCreateDTO)
        {
            await _companyRepository.Add(_mapper.Map<Company>(companyCreateDTO));
        }

        public async Task Delete(Guid id)
        {
            await _companyRepository.Delete(await _companyRepository.GetBy(x => x.ID == id));
        }

        public async Task<List<CompanyListDTO>> List()
        {
            return _mapper.Map<List<CompanyListDTO>>(await _companyRepository.GetAll());
        }

        public async Task Update(CompanyUpdateDTO companyUpdateDTO)
        {
            await _companyRepository.Update(_mapper.Map<Company>(companyUpdateDTO));
        }
    }
}
