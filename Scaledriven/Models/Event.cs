using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scaledriven.Models
{

    public enum EventType
    {
        Public,
        Private,
        Group,
        Community
    }

    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string EventId { get; set; }

        public Category Category { get; set; }

        public int AttendantCount { get; set; }

        public string Description { get; set; }
    }
}
