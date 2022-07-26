namespace StoreVideoGames.DTOs.ReservationDTOs
{
    public class CreateReservationDTO
    {
        public DateTime date { get; set; }


        public int roomId { get; set; }
        public int employeeId { get; set; }
    }
}
