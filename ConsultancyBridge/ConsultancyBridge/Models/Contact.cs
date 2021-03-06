﻿using System.ComponentModel.DataAnnotations;

namespace ConsultancyBridge.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
    }
}