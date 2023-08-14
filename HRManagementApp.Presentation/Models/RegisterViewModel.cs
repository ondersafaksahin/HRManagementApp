using HRManagementApp.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace HRManagementApp.Presentation.Models
{
    public class RegisterViewModel
    {
        public string Email { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
        public Guid CompanyID { get; set; }
    }
}
