using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.AdminDTOs
{
    public class AdminListDTO
    {
        public byte[]? Picture { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public Status Status { get; set; }
        public Guid AppUserID { get; set; }
    }
}
