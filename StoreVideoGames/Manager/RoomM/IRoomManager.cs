using EFDataAccess.Models;
using StoreVideoGames.DTOs.RoomDTOs;

namespace StoreVideoGames.Manager.RoomM
{
    public interface IRoomManager
    {
        Task<ManagerResult<Room>> AddAsync(CreateRoomDTO createRoomDTO);
        Task<ManagerResult<Room>> GetAsync();
        Task<ManagerResult<Room>> UpdateAsync(int id, CreateRoomDTO updateRoomDTO);
        Task<ManagerResult<Room>> DeleteAsync(int id);
    }
}
