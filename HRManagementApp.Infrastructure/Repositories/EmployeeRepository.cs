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
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        HRDBContext _database;
        DbSet<Employee> _employees;
        public EmployeeRepository(HRDBContext database) : base(database)
        {
            _database = database;
            _employees = _database.Employees;
        }
    }
}
