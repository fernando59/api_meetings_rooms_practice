using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccess.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [StringLength(130)]
        public string name { get; set; }

        [StringLength(80)]
        public string position  { get; set; }


    }
}
