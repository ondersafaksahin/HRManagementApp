using AutoMapper;
using HRManagementApp.Application.DTOs.AdvancePaymentDTOs;
using HRManagementApp.Domain.Entities.Concrete;
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

        public async Task Create(AdvancePaymentCreateDTO createDTO)
        {
            AdvancePayment advancePayment = _mapper.Map<AdvancePayment>(createDTO);
            await _advancePaymentRepository.Add(advancePayment);
        }

        public async Task Delete(int id)
        {
            await _advancePaymentRepository.Delete(await _advancePaymentRepository.GetBy(x => x.ID == id));
        }

        public async Task<List<AdvancePaymentListDTO>> List()
        {
            return _mapper.Map<List<AdvancePaymentListDTO>>(await _advancePaymentRepository.GetAll());
        }

        public async Task Update(AdvancePaymentUpdateDTO updateDTO)
        {
            await _advancePaymentRepository.Update(_mapper.Map<AdvancePayment>(updateDTO));
        }
    }
}
