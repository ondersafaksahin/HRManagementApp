using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.AppUserDTOs
{
    public class AppUserListDTO
    {
        public Guid Id { get; set; } = default!;
        public string? Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public Status Status { get; set; }
        public AppRole? Role { get; set; }
        public Company? Company { get; set; }
    }
}
