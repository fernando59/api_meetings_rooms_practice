using EFDataAccess.Models;
using StoreVideoGames.DTOs.ReservationDTOs;

namespace StoreVideoGames.Manager.ReservationM
{
    public class ReservationManager : IReservationManager
    {
        public Task<ManagerResult<Reservation>> AddAsync(CreateReservationDTO createReservationDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ManagerResult<Reservation>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ManagerResult<Reservation>> GetAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ManagerResult<Reservation>> UpdateAsync(int id, CreateReservationDTO updateReservationDTO)
        {
            throw new NotImplementedException();
        }
    }
}
