using HRManagementApp.Domain.Entities.Abstract;
using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Domain.Entities.Concrete
{
    public class Admin : IBaseEntity, IEntity<Guid>
    {
        //IEntity Interface
        public Guid ID { get; set; }


        //IBaseEntity Interface
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = "Admin";
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Status Status { get; set; }


        //Extra Properties
        public byte[]? Picture { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }


        //Navigation Properties
        public Guid AppUserID { get; set; }
    }
}
