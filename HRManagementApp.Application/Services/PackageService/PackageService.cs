using AutoMapper;
using HRManagementApp.Application.DTOs.PackageDTOs;
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

        public Task Create(PackageCreateDTO packageCreateDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PackageListDTO>> List()
        {
            throw new NotImplementedException();
        }

        public Task Update(PackageUpdateDTO packageUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }
}
