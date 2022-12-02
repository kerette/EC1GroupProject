using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EC1GroupProject.Dtos
{
    public class PaymentDto
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public AccountDto account { get; set; }
        public float amount { get; set; }
        public DateTime Date { get; set; }
    }
}