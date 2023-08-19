using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.CompanyDTOs
{
    public class CompanyDTO
    {
        public Guid ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Status Status { get; set; }
        public byte[]? Logo { get; set; }
        public string CompanyName { get; set; }
        public string? Title { get; set; }
        public string? TaxNumber { get; set; }
        public string? TaxAdministration { get; set; }
        public string Email { get; set; }
        public int? EmployeeCount { get; set; }
        public int? YearOfFoundation { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }
        public string ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public virtual List<Employee>? Employees { get; set; }
        public virtual Employee? Manager { get; set; }
        public Guid ManagerID { get; set; }
        public virtual Package? Package { get; set; }
        public int? PackageID { get; set; }
        public virtual List<Shift> Shifts { get; set; }
    }
}
