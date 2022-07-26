using EFDataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreVideoGames.DTOs.TitleDTOs;
using StoreVideoGames.Manager;
using StoreVideoGames.Manager.TitleM;

namespace StoreVideoGames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitleController : ControllerBase
    {
        private readonly ITitleManager _titleManager;

        public TitleController(ITitleManager titleManager)
        {
            _titleManager = titleManager;
        }



        [HttpGet]
        public async Task<ActionResult> GetTitles()
        {
            ManagerResult<Title> managerResult = await _titleManager.GetAsync();
            managerResult.Message = "Get data Successfully";
            return Ok(managerResult);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTitle(CreateTitleDTO createTitleDTO)
        {
            ManagerResult<Title> managerResult = await _titleManager.AddAsync(createTitleDTO);

            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }

            return Ok(managerResult);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTitle(int id, CreateTitleDTO createTitleDTO)
        {
            ManagerResult<Title> managerResult = await _titleManager.UpdateAsync(id, createTitleDTO);

            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }

            return Ok(managerResult);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            ManagerResult<Title> managerResult = await _titleManager.DeleteAsync(id);
            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }
            managerResult.Message = "Delete Successfully";
            return Ok(managerResult);
        }
    }
}
