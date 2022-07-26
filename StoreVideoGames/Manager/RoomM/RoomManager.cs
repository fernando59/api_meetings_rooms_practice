using EFDataAccess.Models;
using StoreVideoGames.DTOs.RoomDTOs;

namespace StoreVideoGames.Manager.RoomM
{
    public class RoomManager : IRoomManager
    {
        public Task<ManagerResult<Room>> AddAsync(CreateRoomDTO createRoomDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ManagerResult<Room>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ManagerResult<Room>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ManagerResult<Room>> UpdateAsync(int id, CreateRoomDTO updateRoomDTO)
        {
            throw new NotImplementedException();
        }
    }
}
