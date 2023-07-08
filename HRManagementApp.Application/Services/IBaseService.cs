using HRManagementApp.Application.DTOs.AdminDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementApp.Application.Services
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="C">CreateDTO class to use</typeparam>
    /// <typeparam name="U">UpdateDTO class to use</typeparam>
    /// <typeparam name="L">ListDTO class to use</typeparam>
    /// <typeparam name="I">ID type of the entity</typeparam>
    public interface IBaseService<C,U,L,I>
    {
        Task Create(C createDTO);
        Task Update(U updateDTO);
        Task<List<L>> List();
        Task Delete(I id);
        
    }
}
