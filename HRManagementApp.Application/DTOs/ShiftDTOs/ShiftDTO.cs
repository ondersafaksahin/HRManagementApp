using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.ShiftDTOs
{
    public class ShiftDTO
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Status Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Description { get; set; }
        public virtual Company Company { get; set; }
        public Guid CompanyID { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
