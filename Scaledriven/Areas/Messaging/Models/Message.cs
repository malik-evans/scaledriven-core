using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scaledriven.Areas.Messaging.Models
{
    public class Message
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string MessageId { get; set; }
        
        [Required]
        [MaxLength(120)]
        public string Text { get; set; }
        
        [Required]
        public string SenderId { get; set; }
        
        public DateTime CreatedAt => DateTime.Now;
    }
}