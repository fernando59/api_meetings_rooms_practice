using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccess.Models
{
    public class Room
    {

        public int ID { get; set; }
        [StringLength(80)]
        public string name { get; set; }

        [StringLength(300)]
        public string description { get; set; }
        public int capacity{ get; set; }
        public bool isEnable{ get; set; } = false;  
    }
}
