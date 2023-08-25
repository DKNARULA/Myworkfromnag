using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{

    public class Event
    {
        [Key]
        [Required]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
       
        public int StartTime { get; set; }
        [Required]
        public string Type { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public string OtherDetails { get; set; }
        public string Invite { get; set; }

        public string Userid { get; set; }

    }
}
