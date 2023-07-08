using HRManagementApp.Application.DTOs.AdvancePaymentDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.AdvancePaymentService
{
    public interface IAdvancePaymentService:IBaseService<AdvancePaymentCreateDTO, AdvancePaymentUpdateDTO, AdvancePaymentListDTO,int>
    {
    }
}
