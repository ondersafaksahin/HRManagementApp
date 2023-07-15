using HRManagementApp.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Domain.Entities.Abstract
{
    public interface IUserEntity: IBaseEntity,IEntity<Guid>
    {
        public byte[]? Picture { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? BirthPlace { get; set; }
        public string? NationalID { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public Company? Company { get; set; }
        public Guid? CompanyID { get; set; }
        public string? Job { get; set; }
        public string? Department { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public decimal Salary { get; set; }
    }
}
