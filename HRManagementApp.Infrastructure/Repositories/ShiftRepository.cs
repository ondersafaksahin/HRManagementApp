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
    public class ShiftRepository : BaseRepository<Shift>, IShiftRepository
    {
        HRDBContext _database;
        DbSet<Shift> _shifts;
        public ShiftRepository(HRDBContext database) : base(database)
        {
            _database = database;
            _shifts = _database.Shifts;
        }
    }
}
