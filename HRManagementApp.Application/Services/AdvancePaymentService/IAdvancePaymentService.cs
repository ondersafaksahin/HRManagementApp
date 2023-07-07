using HRManagementApp.Application.DTOs.AdvancePaymentDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.AdvancePaymentService
{
    public interface IAdvancePaymentService
    {
        Task Create(AdvancePaymentCreateDTO aPaymentServiceCreateDTO);
        Task Update(AdvancePaymentUpdateDTO aPaymentServiceUpdateDTO);
        Task Delete(int id);
    }
}
