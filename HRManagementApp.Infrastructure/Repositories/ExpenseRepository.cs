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
    public class ExpenseRepository : BaseRepository<Expense>, IExpenseRepository
    {
        HRDBContext _database;
        DbSet<Expense> _expenses;
        public ExpenseRepository(HRDBContext database) : base(database)
        {
            _database = database;
            _expenses = _database.Expenses;
        }
    }
}
