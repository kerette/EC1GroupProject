using EC1GroupProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EC1GroupProject.Dtos
{
    public class AccountDto
    {
        [Key]
        public string AccountNumber { get; set; }
        public float Balance { get; set; }
        public string AccountType { get; set; }
        public int TRN { get; set; }
        public Customer customer { get; set; }
    }
}