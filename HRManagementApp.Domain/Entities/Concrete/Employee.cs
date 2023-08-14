using HRManagementApp.Domain.Entities.Abstract;
using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Domain.Entities.Concrete
{
    public class Employee: AppUser, IUserEntity
    {
        //Navigation Properties
        
        public byte[]? Picture { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string? NationalID { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public string? Job { get; set; }
        public string? Department { get; set; }
        public string? Address { get; set; }
        public decimal Salary { get; set; }
        public virtual Company? Company { get; set; }
        public Guid? CompanyID { get; set; }
        public virtual Shift? Shift { get; set; }
        public int? ShiftID { get; set; }
        public virtual List<Expense>? Expenses { get; set; }
        public virtual List<Leave>? Leaves { get; set; }
        public virtual List<AdvancePayment>? AdvancePayments { get; set; }
    }
}
