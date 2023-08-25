using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication0.Models
{
    public class campDetails
    {
        public int id { get; set; }
        public string campName { get; set; }
        public int capacity { get; set; }
        public int price { get; set; }
        public string desc { get; set; }
        public string image { get; set; }
        public virtual ICollection<BookingTable> booking { get; set; }
    }
}