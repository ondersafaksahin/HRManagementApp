using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.AppRoleDTOs
{
    public class AppRoleListDTO
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Status Status { get; set; }
    }
}
