using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.LeaveDTOs
{
    public class LeaveDTO
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Status Status { get; set; }
        public string RequestText { get; set; }
        public string AnswerText { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public virtual Employee Employee { get; set; }
        public Guid EmployeeID { get; set; }
    }
}
