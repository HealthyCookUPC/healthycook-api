﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthyCook_Backend.Domain.Models
{
    public class ConsultasAyuda
    {
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "varchar(25)")]
        public string Username { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Description { get; set; }
    }
}
