using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthyCook_Backend.Domain.Models
{
    public class Comment
    {
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "varchar(25)")]
        public string Username { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string Message { get; set; }

        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
