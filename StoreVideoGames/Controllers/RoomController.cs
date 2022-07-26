using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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


    }
}
