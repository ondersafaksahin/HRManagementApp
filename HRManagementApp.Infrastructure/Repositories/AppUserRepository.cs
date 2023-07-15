using HRManagementApp.Domain.Entities.Abstract;
using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.IRepositories;
using HRManagementApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Infrastructure.Repositories
{
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRepository
    {
        HRDBContext _database;
        DbSet<AppUser> _appUsers;

        public AppUserRepository(HRDBContext database) : base(database)
        {
            _database = database;
            _appUsers = _database.Users;
        }

    }
}
