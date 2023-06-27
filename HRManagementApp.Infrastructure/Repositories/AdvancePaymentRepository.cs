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
    public class AdvancePaymentRepository : BaseRepository<AdvancePayment>, IAdvancePaymentRepository
    {
        HRDBContext _database;
        DbSet<AdvancePayment> _advancePayments;
        public AdvancePaymentRepository(HRDBContext database) : base(database)
        {
            _database = database;
            _advancePayments = _database.AdvancePayments;
        }
    }
}