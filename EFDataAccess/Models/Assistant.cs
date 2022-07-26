using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccess.Models
{
    public class Assistant
    {
        public int ID { get; set; }

        public bool isAttend { get; set; } = true;

        public int ReservationId { get; set; }
        public virtual Reservation Reservation{ get; set; }
    }
}
