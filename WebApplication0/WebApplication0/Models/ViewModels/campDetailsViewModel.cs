﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication0.Models.ViewModels
{
    public class campDetailsViewModel
    {
        public int id { get; set; }
        public string campName { get; set; }
        public int capacity { get; set; }
        public int price { get; set; }
        public string desc { get; set; }
        public string image { get; set; }
    }
}