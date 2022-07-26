using EFDataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreVideoGames.DTOs.AssistantDTOs;
using StoreVideoGames.Manager;
using StoreVideoGames.Manager.AssistantM;

namespace StoreVideoGames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssistantController : ControllerBase
    {
        private readonly IAssistantManager _assistantManager;

        public AssistantController(IAssistantManager assistantManager)
        {
            _assistantManager = assistantManager;
        }
        [HttpGet]
        public async Task<ActionResult> GetAssistants()
        {
            ManagerResult<Assistant> managerResult = await _assistantManager.GetAsync();
            managerResult.Message = "Get data Successfully";
            return Ok(managerResult);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAssistant(CreateAssistantDTO createAssistantDTO)
        {
            ManagerResult<Assistant> managerResult = await _assistantManager.AddAsync(createAssistantDTO);

            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }

            return Ok(managerResult);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAssistant(int id, CreateAssistantDTO createAssistantDTO)
        {
            ManagerResult<Assistant> managerResult = await _assistantManager.UpdateAsync(id, createAssistantDTO);

            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }

            return Ok(managerResult);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            ManagerResult<Assistant> managerResult = await _assistantManager.DeleteAsync(id);
            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }
            managerResult.Message = "Delete Successfully";
            return Ok(managerResult);
        }


    }
}
