using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApi.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentContent { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public Post Post { get; set; }
        public User User { get; set; }
    }
}