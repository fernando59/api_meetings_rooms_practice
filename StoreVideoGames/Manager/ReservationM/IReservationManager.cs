using EFDataAccess.Models;
using StoreVideoGames.DTOs.ReservationDTOs;

namespace StoreVideoGames.Manager.ReservationM
{
    public interface IReservationManager
    {
        Task<ManagerResult<Reservation>> AddAsync(CreateReservationDTO createReservationDTO);
        Task<ManagerResult<Reservation>> GetAsync();
        Task<ManagerResult<Reservation>> UpdateAsync(int id, CreateReservationDTO updateReservationDTO);
        Task<ManagerResult<Reservation>> DeleteAsync(int id);
    }
}
