using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.AppUserDTOs
{
    public class ChangePasswordDTO
    {
        public string? Email { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public string CurrentPassword { get; set; }
        public string NewPassword1 {get; set; }
        public string NewPassword2 {get; set; }
    }
}
