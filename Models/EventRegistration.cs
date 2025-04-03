﻿using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment3.Models
{
    public class EventRegistration
    {
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string EventCode { get; set; }

        [Required]
        [Range(1, 10)]
        public int Tickets { get; set; }
    }
}
