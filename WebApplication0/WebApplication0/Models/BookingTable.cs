﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication0.Models
{
    public class BookingTable
    {
            public int id { get; set; }
            public string campName { get; set; }
            public int noofpeople { get; set; }
            public DateTime checkInDate { get; set; }
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