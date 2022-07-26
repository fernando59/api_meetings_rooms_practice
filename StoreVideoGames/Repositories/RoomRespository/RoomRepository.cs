using EFDataAccess;
using EFDataAccess.Models;

namespace StoreVideoGames.Repositories.RoomRespository
{
    public class RoomRepository : Repository<Room>, IRoomRepository
    {
        public RoomRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
