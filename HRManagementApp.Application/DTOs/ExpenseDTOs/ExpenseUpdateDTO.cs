using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.DTOs.ExpenseDTOs
{
    public class ExpenseUpdateDTO
    {
        public DateTime? ModifiedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public Status Status { get; set; }
        public string AnswerText { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }
        public decimal Amount { get; set; }
        public char Currency { get; set; }
        public DateTime ExpenseDate { get; set; }
        public ExpenseType ExpenseType { get; set; }
    }
}
