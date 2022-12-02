using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EC1GroupProject.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public AccountModel account { get; set; }
        public float amount { get; set; }
        public DateTime Date { get; set; }
    }
}