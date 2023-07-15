using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.AppUserDTOs
{
    public class ForgotPasswordDTO
    {
        public string? Email { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
