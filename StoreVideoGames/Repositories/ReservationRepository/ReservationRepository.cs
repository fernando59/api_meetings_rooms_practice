using EFDataAccess;
using EFDataAccess.Models;

namespace StoreVideoGames.Repositories.ReservationRepository
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        public ReservationRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
