using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.AppUserDTOs
{
    public class RegisterDTO
    {
        public string UserName { get; set; }
        public string? NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string? NormalizedEmail { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Guid CompanyID { get; set; }
        public Status Status { get; set; }
    }
}
