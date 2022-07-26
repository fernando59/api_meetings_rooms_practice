using EFDataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreVideoGames.DTOs.EmployeeDTOs;
using StoreVideoGames.Manager;
using StoreVideoGames.Manager.EmployeeM;

namespace StoreVideoGames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeManager _employeeManager;

        public EmployeeController(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
            ManagerResult<Employee> managerResult = await _employeeManager.GetAsync();
            managerResult.Message = "Get data Successfully";
            return Ok(managerResult);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeDTO createEmployeeDTO)
        {
            ManagerResult<Employee> managerResult = await _employeeManager.AddAsync(createEmployeeDTO);

            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }

            return Ok(managerResult);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee(int id, CreateEmployeeDTO createEmployeeDTO)
        {
            ManagerResult<Employee> managerResult = await _employeeManager.UpdateAsync(id, createEmployeeDTO);

            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }

            return Ok(managerResult);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            ManagerResult<Employee> managerResult = await _employeeManager.DeleteAsync(id);
            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }
            managerResult.Message = "Delete Successfully";
            return Ok(managerResult);
        }

    }
}
