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
    public class LeaveRepository : BaseRepository<Leave>, ILeaveRepository
    {
        HRDBContext _database;
        DbSet<Leave> _leaves;
        public LeaveRepository(HRDBContext database) : base(database)
        {
            _database = database;
            _leaves = _database.Leaves;
        }
    }
}
