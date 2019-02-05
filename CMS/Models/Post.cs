using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMS.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        public Nullable<DateTime> UpdatedAt { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }

        [MaxLength(200)]
        [Required(ErrorMessage = "Post title must be informed")]
        public string PostTitle { get; set; }

        [MaxLength(60000)]
        [Required(ErrorMessage = "Post content must be filled")]
        public string PostContent { get; set; }

        [MaxLength(1000)]
        public string PostSummary { get; set; }

        [MaxLength(500)]
        public string PostSEO { get; set; }
    }
}