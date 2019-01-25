using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMS.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }
        
        public DateTime? DeletedAt { get; set; }

        [Required(ErrorMessage = "Description must be informed")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Slug must be informed")]
        public string Slug { get; set; }
    }
}