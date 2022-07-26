using EFDataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreVideoGames.DTOs.RoomDTOs;
using StoreVideoGames.Manager;
using StoreVideoGames.Manager.RoomM;

namespace StoreVideoGames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomManager _roomManager;

        public RoomController(IRoomManager roomManager )
        {
            _roomManager = roomManager;
        }
        [HttpGet]
        public async Task<ActionResult> GetRooms()
        {
            ManagerResult<Room> managerResult = await _roomManager.GetAsync();
            managerResult.Message = "Get data Successfully";
            return Ok(managerResult);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom(CreateRoomDTO createRoomDTO)
        {
            ManagerResult<Room> managerResult = await _roomManager.AddAsync(createRoomDTO);

            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }

            return Ok(managerResult);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRoom(int id, CreateRoomDTO createRoomDTO)
        {
            ManagerResult<Room> managerResult = await _roomManager.UpdateAsync(id, createRoomDTO);

            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }

            return Ok(managerResult);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            ManagerResult<Room> managerResult = await _roomManager.DeleteAsync(id);
            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }
            managerResult.Message = "Delete Successfully";
            return Ok(managerResult);
        }

    }
}
