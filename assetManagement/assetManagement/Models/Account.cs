﻿ using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace assetManagement.Models
{
    [Table("TB_M_Account")]
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string Password { get; set; }
        public Employee Employee { get; set; }
    }
}
