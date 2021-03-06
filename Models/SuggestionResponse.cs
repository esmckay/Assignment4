﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class SuggestionResponse
    {
        public string? suggName { get; set; } = "N/A";
        [Required]
        public string suggRest { get; set; }
        public string? suggDish { get; set; } = "N/A";

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Invalid Phone Number")]
        public string? suggPhone { get; set; } = "N/A";
    }
}
