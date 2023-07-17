using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.EmployeeDTOs
{
    public class EmployeeListDTO
    {
        public DateTime CreatedDate { get; set; }
        public Status Status { get; set; }
        public byte[]? Picture { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public string? Job { get; set; }
        public string? Department { get; set; }
        public string? PhoneNumber { get; set; }
        public decimal Salary { get; set; }
        public Guid AppUserID { get; set; }
        public Guid? CompanyID { get; set; }
    }
}
