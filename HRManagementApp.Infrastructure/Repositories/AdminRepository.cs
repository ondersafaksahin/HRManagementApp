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
    public class AdminRepository : BaseRepository<Admin>, IAdminRepository
    {
        HRDBContext _database;
        DbSet<Admin> _admins;
        public AdminRepository(HRDBContext database) : base(database)
        {
            _database = database;
            _admins = _database.Admins;
        }
    }
}
