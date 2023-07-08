using AutoMapper;
using HRManagementApp.Application.DTOs.PackageDTOs;
using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.PackageService
{
    public class PackageService : IPackageService
    {
        IPackageRepository _packageRepository;
        IMapper _mapper;
        public PackageService(IPackageRepository packageRepository, IMapper mapper)
        {
            _packageRepository = packageRepository;
            _mapper = mapper;
        }

        public async Task Create(PackageCreateDTO packageCreateDTO)
        {
            await _packageRepository.Add(_mapper.Map<Package>(packageCreateDTO));
        }

        public async Task Delete(int id)
        {
            await _packageRepository.Delete(await _packageRepository.GetBy(x => x.ID == id));
        }

        public async Task<List<PackageListDTO>> List()
        {
            return _mapper.Map<List<PackageListDTO>>(await _packageRepository.GetAll());
        }

        public async Task Update(PackageUpdateDTO packageUpdateDTO)
        {
            await _packageRepository.Update(_mapper.Map<Package>(packageUpdateDTO));
        }
    }
}
