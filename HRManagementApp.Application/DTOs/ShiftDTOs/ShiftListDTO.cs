using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.ShiftDTOs
{
    public class ShiftListDTO
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Status Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public virtual Company Company { get; set; }
    }
}
