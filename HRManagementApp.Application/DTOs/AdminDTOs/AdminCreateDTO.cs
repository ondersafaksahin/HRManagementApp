using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.AdminDTOs
{
    public class AdminCreateDTO
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Email { get; set; }
    }
}
