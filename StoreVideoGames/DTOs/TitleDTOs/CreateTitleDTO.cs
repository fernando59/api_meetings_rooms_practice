using System.ComponentModel.DataAnnotations;

namespace StoreVideoGames.DTOs.TitleDTOs
{
    public class CreateTitleDTO
    {

        [Required]
        public string name { get; set; }
        public string description { get; set; }
        public DateTime? releaseDate { get; set; }
        public bool released { get; set; } = true;
        public string developer { get; set; }
        public string platforms { get; set; }

    }
}
