using HRManagementApp.Domain.Entities.Abstract;
using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Domain.Entities.Concrete
{
    public class Leave : IBaseEntity, IEntity<int>,IApprovable
    {
        //IEntity Interface
        public int ID { get; set; }


        //IBaseEntity Interface
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Status Status { get; set; }


        //IApprovable Interface
        public string RequestText { get; set; }
        public string AnswerText { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }


        //Extra Properties
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }


        //Navigation Properties
        public Employee Employee { get; set; }
        public Guid EmployeeID { get; set; }
    }
}
