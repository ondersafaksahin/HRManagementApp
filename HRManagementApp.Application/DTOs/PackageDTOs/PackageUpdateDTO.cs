using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.PackageDTOs
{
    public class PackageUpdateDTO
    {
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Status Status { get; set; }
        public int DurationDays { get; set; }
        public DateTime? TakedownDate { get; set; }
        public int? UserCount { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
    }
}
