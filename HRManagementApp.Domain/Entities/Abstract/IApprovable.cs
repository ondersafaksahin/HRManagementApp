using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Domain.Entities.Abstract
{
    public interface IApprovable
    {
        public string RequestText { get; set; }
        public string AnswerText { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }
    }
}
