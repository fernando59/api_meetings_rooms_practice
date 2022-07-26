using EFDataAccess.Models;
using StoreVideoGames.DTOs.EmployeeDTOs;

namespace StoreVideoGames.Manager.EmployeeM
{
    public class EmployeeManager : IEmployeeManager
    {
        public Task<ManagerResult<Employee>> AddAsync(CreateEmployeeDTO createEmployeeDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ManagerResult<Employee>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ManagerResult<Employee>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ManagerResult<Employee>> UpdateAsync(int id, CreateEmployeeDTO updateEmployeeDTO)
        {
            throw new NotImplementedException();
        }
    }
}
