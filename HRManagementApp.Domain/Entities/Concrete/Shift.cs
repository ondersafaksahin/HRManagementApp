using HRManagementApp.Domain.Entities.Abstract;
using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Domain.Entities.Concrete
{
    public class Shift : IBaseEntity, IEntity<int>
    {
        //IEntity Interface
        public int ID { get; set; }


        //IBaseEntity Interface
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Status Status { get; set; }


        //Extra Properties
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Description { get; set; }


        //Navigation Properties
        public virtual Company Company { get; set; }
        public Guid CompanyID { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}
