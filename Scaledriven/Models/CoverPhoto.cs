using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scaledriven.Models
{

    public class CoverPhoto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CoverId { get; set; }

        /// <summary>
        /// Direct URL for the person's cover photo image
        /// </summary>
        public byte[] Source { get; set; }
    }
}
