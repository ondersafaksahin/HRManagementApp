using AutoMapper;
using HRManagementApp.Application.DTOs.ShiftDTOs;
using HRManagementApp.Domain.Entities.Concrete;
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

        public async Task Create(ShiftCreateDTO shiftCreateDTO)
        {
            await _shiftRepository.Add(_mapper.Map<Shift>(shiftCreateDTO));
        }

        public async Task Delete(int id)
        {
            await _shiftRepository.Delete(await _shiftRepository.GetBy(x => x.ID == id));
        }

        public async Task<List<ShiftListDTO>> List()
        {
            return _mapper.Map<List<ShiftListDTO>>(await _shiftRepository.GetAll());
        }

        public async Task Update(ShiftUpdateDTO shiftUpdateDTO)
        {
            await _shiftRepository.Update(_mapper.Map<Shift>(shiftUpdateDTO);
        }
    }
}
