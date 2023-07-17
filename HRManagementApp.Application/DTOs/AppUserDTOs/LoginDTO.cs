using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.AppUserDTOs
{
    public class LoginDTO
    {
        public string? Email { get; set; }
        public string? NormalizedEmail { get; set; }
        public string? Password { get; set; }
    }
}
