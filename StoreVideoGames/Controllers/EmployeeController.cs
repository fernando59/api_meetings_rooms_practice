using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

    }
}
