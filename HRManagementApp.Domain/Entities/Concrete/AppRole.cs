using HRManagementApp.Domain.Entities.Abstract;
using HRManagementApp.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Domain.Entities.Concrete
{
    public class AppRole : IdentityRole<Guid>, IBaseEntity
    {
        //IBaseEntity Interface
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Status Status { get; set; }
    }
}
