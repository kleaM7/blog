﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_Klea.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name ="Username")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //[Display(Name ="Remember me?")]
        //public bool RememberMe { get; set;
        //}
        public string ReturnURL { get; set; }

        public LoginModel()
        {

        }
    }
}