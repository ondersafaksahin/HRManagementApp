using AutoMapper;
using HRManagementApp.Application.DTOs.ShiftDTOs;
using HRManagementApp.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services.ShiftService
{
    public class ShiftService : IShiftService
    {
        IShiftRepository _shiftRepository;
        IMapper _mapper;
        public ShiftService(IShiftRepository shiftRepository,IMapper mapper)
        {
            _shiftRepository = shiftRepository;
            _mapper = mapper;
        }

        public Task Create(ShiftCreateDTO shiftCreateDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ShiftListDTO>> List()
        {
            throw new NotImplementedException();
        }

        public Task Update(ShiftUpdateDTO shiftUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }
}
