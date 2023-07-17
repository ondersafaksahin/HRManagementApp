using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.CompanyDTOs
{
    public class CompanyListDTO
    {
        public DateTime CreatedDate { get; set; }
        public Status Status { get; set; }
        public byte[]? Logo { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public int? EmployeeCount { get; set; }
        public int? YearOfFoundation { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }
        public string ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public int? PackageID { get; set; }
    }
}
