using System.ComponentModel.DataAnnotations;

namespace StoreVideoGames.DTOs.EmployeeDTOs
{
    public class CreateEmployeeDTO
    {
        public string name { get; set; }

        [StringLength(300)]
        public string position{ get; set; }
    }
}
