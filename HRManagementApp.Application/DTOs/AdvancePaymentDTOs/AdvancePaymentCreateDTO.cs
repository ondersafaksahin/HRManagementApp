using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.AdvancePaymentDTOs
{
    public class AdvancePaymentCreateDTO
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string RequestText { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }
        public decimal Amount { get; set; }
        public char Currency { get; set; }
        public int Maturity { get; set; }
        public virtual Employee Employee { get; set; }
        public Guid EmployeeID { get; set; }
    }
}
