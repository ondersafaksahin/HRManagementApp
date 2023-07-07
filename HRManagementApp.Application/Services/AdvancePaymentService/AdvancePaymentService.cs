using AutoMapper;
using HRManagementApp.Application.DTOs.AdvancePaymentDTOs;
using HRManagementApp.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.AdvancePaymentService
{
    public class AdvancePaymentService : IAdvancePaymentService
    {
        IAdvancePaymentRepository _advancePaymentRepository;
        IMapper _mapper;

        public AdvancePaymentService(IAdvancePaymentRepository advancePaymentRepository,IMapper mapper)
        {
            _mapper = mapper;
            _advancePaymentRepository = advancePaymentRepository;
        }

        public Task Create(AdvancePaymentCreateDTO aPaymentServiceCreateDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(AdvancePaymentUpdateDTO aPaymentServiceUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }
}
