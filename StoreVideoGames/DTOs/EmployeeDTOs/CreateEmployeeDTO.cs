using System.ComponentModel.DataAnnotations;

namespace StoreVideoGames.DTOs.EmployeeDTOs
{
    public class CreateEmployeeDTO
    {
        public string name { get; set; }

        [StringLength(300)]
        public string description { get; set; }
        public int capacity { get; set; }
        public bool isEnable { get; set; } = false;
    }
}
