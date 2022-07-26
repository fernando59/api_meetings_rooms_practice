using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

    }
}
