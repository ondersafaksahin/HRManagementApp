using AutoMapper;
using HRManagementApp.Application.DTOs.LeaveDTOs;
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

        public Task Create(LeaveCreateDTO leaveCreateDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LeaveListDTO>> List()
        {
            throw new NotImplementedException();
        }

        public Task Update(LeaveUpdateDTO leaveUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }
}
