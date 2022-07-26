using EFDataAccess.Models;
using StoreVideoGames.DTOs.EmployeeDTOs;

namespace StoreVideoGames.Manager.EmployeeM
{
    public interface IEmployeeManager
    {
        Task<ManagerResult<Employee>> AddAsync(CreateEmployeeDTO createEmployeeDTO);
        Task<ManagerResult<Employee>> GetAsync();
        Task<ManagerResult<Employee>> UpdateAsync(int id, CreateEmployeeDTO updateEmployeeDTO);
        Task<ManagerResult<Employee>> DeleteAsync(int id);
    }
}
