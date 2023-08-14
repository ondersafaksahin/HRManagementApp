using HRManagementApp.Domain.Entities.Abstract;
using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Domain.Entities.Concrete
{
    public class Admin : AppUser
    {
        public byte[]? Picture { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
