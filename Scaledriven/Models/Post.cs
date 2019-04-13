using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scaledriven.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string PostId { get; set; }

        [Timestamp]
        public Byte[] CreateTime { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

    }
}
