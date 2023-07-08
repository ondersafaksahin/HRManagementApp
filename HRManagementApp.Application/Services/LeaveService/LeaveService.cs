using AutoMapper;
using HRManagementApp.Application.DTOs.LeaveDTOs;
using HRManagementApp.Domain.Entities.Concrete;
using HRManagementApp.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.LeaveService
{
    public class LeaveService : ILeaveService
    {
        ILeaveRepository _leaveRepository;
        IMapper _mapper;

        public LeaveService(ILeaveRepository leaveRepository,IMapper mapper)
        {
            _leaveRepository = leaveRepository;
            _mapper = mapper;
        }

        public async Task Create(LeaveCreateDTO leaveCreateDTO)
        {
            await _leaveRepository.Add(_mapper.Map<Leave>(leaveCreateDTO));
        }

        public async Task Delete(int id)
        {
            await _leaveRepository.Delete(await _leaveRepository.GetBy(x => x.ID == id));
        }

        public async Task<List<LeaveListDTO>> List()
        {
            return _mapper.Map<List<LeaveListDTO>>(await _leaveRepository.GetAll());
        }

        public async Task Update(LeaveUpdateDTO leaveUpdateDTO)
        {
            await _leaveRepository.Update(_mapper.Map<Leave>(leaveUpdateDTO));
        }
    }
}
