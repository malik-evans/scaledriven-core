using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scaledriven.Models
{

    public class Post
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }


        [Required]
        [DisplayName("OwerId")]
        public string UserId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Content { get; set; }

    }
}
