namespace StoreVideoGames.DTOs.RoomDTOs
{
    public class CreateRoomDTO
    {
        public string name { get; set; }

        public string description { get; set; }
        public int capacity { get; set; }
        public bool isEnable { get; set; } 
    }
}
