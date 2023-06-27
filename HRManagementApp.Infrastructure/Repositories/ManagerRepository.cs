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
    public class ManagerRepository : BaseRepository<Manager>, IManagerRepository
    {
        HRDBContext _database;
        DbSet<Manager> _managers;
        public ManagerRepository(HRDBContext database) : base(database)
        {
            _database = database;
            _managers = _database.Managers;
        }
    }
}
