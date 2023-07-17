using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.ManagerDTOs
{
    public class ManagerDTO
    {
        public Guid ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Status Status { get; set; }
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
        public string? PhoneNumber { get; set; }
        public decimal Salary { get; set; }
        public Guid AppUserID { get; set; }
        public virtual Company? Company { get; set; }
        public Guid? CompanyID { get; set; }
        public virtual List<Expense>? Expenses { get; set; }
        public virtual List<Leave>? Leaves { get; set; }
        public virtual List<AdvancePayment>? AdvancePayments { get; set; }
        public virtual Shift? Shift { get; set; }
        public int? ShiftID { get; set; }
    }
}
