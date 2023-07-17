using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.AppRoleDTOs
{
    public class AppRoleCreateDTO
    {
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    }
}
