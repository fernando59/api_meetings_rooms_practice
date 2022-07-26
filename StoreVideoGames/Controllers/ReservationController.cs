using EFDataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreVideoGames.DTOs.ReservationDTOs;
using StoreVideoGames.Manager;
using StoreVideoGames.Manager.ReservationM;

namespace StoreVideoGames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationManager _reservationManager;

        public ReservationController(IReservationManager reservationManager)
        {
            _reservationManager = reservationManager;
        }
        [HttpGet]
        public async Task<ActionResult> GetReservations()
        {
            ManagerResult<Reservation> managerResult = await _reservationManager.GetAsync();
            managerResult.Message = "Get data Successfully";
            return Ok(managerResult);
        }

        [HttpPost]
        public async Task<IActionResult> CreateReservation(CreateReservationDTO createReservationDTO)
        {
            ManagerResult<Reservation> managerResult = await _reservationManager.AddAsync(createReservationDTO);

            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }

            return Ok(managerResult);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateReservation(int id, CreateReservationDTO createReservationDTO)
        {
            ManagerResult<Reservation> managerResult = await _reservationManager.UpdateAsync(id, createReservationDTO);

            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }

            return Ok(managerResult);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            ManagerResult<Reservation> managerResult = await _reservationManager.DeleteAsync(id);
            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }
            managerResult.Message = "Delete Successfully";
            return Ok(managerResult);
        }

    }
}
