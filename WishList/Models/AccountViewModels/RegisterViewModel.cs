﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public String Email { get; set; }
        [Required]
        [StringLength(100)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public String ConfirmPassword { get; set; }

    }
}
