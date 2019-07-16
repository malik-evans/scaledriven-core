using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scaledriven.Areas.Association.Models
{

    public enum StatementAttitude
    {
        Good,
        Loud,
        /// <summary>
        /// Aggressive
        /// </summary>
        Arg,
        Humble
    }

    public class Statement
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        [Required]
        public string MessengerId { get; set; }

        [Required]
        public StatementAttitude Attitude { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
