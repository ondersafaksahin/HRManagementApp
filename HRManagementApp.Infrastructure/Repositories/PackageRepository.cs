using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.IRepositories;
using HRManagementApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Infrastructure.Repositories
{
    public class PackageRepository : BaseRepository<Package>, IPackageRepository
    {
        HRDBContext _database;
        DbSet<Package> _packages;
        public PackageRepository(HRDBContext database) : base(database)
        {
            _database = database;
            _packages = _database.Packages;
        }
    }
}
