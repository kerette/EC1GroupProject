using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EC1GroupProject.Models
{
    public class Customer
    {
        [Key]
        public int TRN { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
    }
}