using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccess.Models
{
    public class Reservation
    {
        public int ID { get; set; }

        public DateTime date { get; set; }


        //Foreign Keys

        public int RoomId { get; set; }
        public int EmployeeId{ get; set; }


        public virtual Room Room{ get; set; }
        public virtual Employee Employee{ get; set; }

    }
}
