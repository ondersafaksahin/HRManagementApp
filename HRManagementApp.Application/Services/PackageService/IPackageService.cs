using HRManagementApp.Application.DTOs.ExpenseDTOs;
using HRManagementApp.Application.DTOs.PackageDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.PackageService
{
    public interface IPackageService:IBaseService<PackageCreateDTO,PackageUpdateDTO,PackageListDTO,int>
    {
     
    }
}
