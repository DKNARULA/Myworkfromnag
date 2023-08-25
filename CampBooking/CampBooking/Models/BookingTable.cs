using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CampBooking.Models
{
    public class BookingTable
    {
        
        public int Id { get; set; }
        public int BookRefId { get; set; }
        public int campid { get; set; }
        public string campName { get; set; }
        public int noofpeople { get; set; }
        [DataType(DataType.Date)]
        public DateTime checkInDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime checkOutDate { get; set; }
        public string billAddress { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public int pinCode { get; set; }
        public long mobile { get; set; }
        public int amount { get; set; }

        [ForeignKey("campDetailsId")]
        public virtual campDetails CampDetails { get; set; }

    }
}
